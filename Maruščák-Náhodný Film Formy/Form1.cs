using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Search;

namespace Maruščák_Náhodný_Film_Formy
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public TMDbClient Client = new TMDbClient("abb68381179384b4688f488ee4c32bf1"); // Pls no steal..., Kappa pro key jsem jim musel dat adresu tak jsem si dal nejakou random z USA
        public MovieManager Manager;
        public BinaryFormatter bf;

        public Form1()
        {
            bf = new BinaryFormatter();
            try
            {
                using (FileStream fsRead = new FileStream("data.bin", FileMode.Open))
                {
                    Manager = (MovieManager)bf.Deserialize(fsRead);
                }
            }
            catch
            {
                Manager = new MovieManager();
                foreach (var genre in Client.GetMovieGenresAsync().Result)
                {
                    Manager.MovieGenres.Add(new Genres(genre.Id, genre.Name));
                }
                foreach (var genre in Client.GetTvGenresAsync().Result)
                {
                    Manager.TVShowGenres.Add(new Genres(genre.Id, genre.Name));
                }
                for (int i = 0; i < 15; i++)
                {
                    var movieCollection = Client.GetMovieTopRatedListAsync("EN", i).Result;
                    var tvCollection = Client.GetTvShowTopRatedAsync(i,"EN").Result;
                    foreach (var movie in movieCollection.Results)
                    {
                        CreateMovieToManager(movie);
                    }

                    foreach (var tvShow in tvCollection.Results)
                    {
                        CreateTvShowToManager(tvShow);
                    }
                }
                for (int i = 0; i < 15; i++)
                {
                    var movieCollection = Client.GetMoviePopularListAsync("EN", i).Result;
                    var tvCollection = Client.GetTvShowPopularAsync(i, "EN").Result;
                    foreach (var movie in movieCollection.Results)
                    {
                        CreateMovieToManager(movie);
                    }

                    foreach (var tvShow in tvCollection.Results)
                    {
                        CreateTvShowToManager(tvShow);
                    }
                }

                using (FileStream fs = new FileStream("data.bin", FileMode.Create))
                {
                    bf.Serialize(fs, Manager);
                    fs.Flush();
                }
            }
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 2, 2)); // Zaoblí okraje
            
            foreach (var genre in Manager.MovieGenres)
            {
                movieCheckListBox.Items.Add(genre.Name, CheckState.Checked);
            }

            foreach (var genre in Manager.TVShowGenres)
            {
                tvShowCheckListBox.Items.Add(genre.Name, CheckState.Checked);
            }

            appNameLabel.MouseDown += topPanel_MouseDown;
            appSummaryLabel.MouseDown += topPanel_MouseDown;

            titleLabel.BorderStyle = BorderStyle.None;
            descriptionLabel.BorderStyle = BorderStyle.None;
            yearLabel.BorderStyle = BorderStyle.None;
            genresLabel.BorderStyle = BorderStyle.None;
            voteAverageLabel.BorderStyle = BorderStyle.None;
            poularityLabel.BorderStyle = BorderStyle.None;
            typeLabel.BorderStyle = BorderStyle.None;
            tmdbLinkLabel.BorderStyle = BorderStyle.None;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
        
        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Drag formy
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private Random rnd = new Random();
        private Movie SearchedMovie;
        private TVShow SearchedTvShow;
        private int lastMovieID;
        private int lastTVShowID;
        private void showButton_Click(object sender, EventArgs e) // poster width = 672; poster height = 1009
        {
            SearchedMovie = null;
            SearchedTvShow = null;
            if (tvShowCheckBox.Checked && movieCheckBox.Checked)
            {
                var allowedTVShows = IncludeTVShowsWithAnyOfGenres();
                var allowedMovies = IncludeMoviesWithAnyOfGenres();
                int showOrMovie = rnd.Next(allowedMovies.Count + allowedTVShows.Count);
                if (showOrMovie >= allowedMovies.Count)
                {
                    if (allowedTVShows.Count != 0)
                    {
                        moreOnlabel.Visible = true;
                        do
                        {
                            SearchedTvShow = allowedTVShows[rnd.Next(allowedTVShows.Count)];
                        } while (allowedTVShows.Count != 1 && SearchedTvShow.ID == lastTVShowID);
                        lastTVShowID = SearchedTvShow.ID;
                    }
                }
                else
                {
                    if (allowedMovies.Count != 0)
                    {
                        moreOnlabel.Visible = true;
                        do
                        {
                            SearchedMovie = allowedMovies[rnd.Next(allowedMovies.Count)];
                        } while (allowedMovies.Count != 1 && SearchedMovie.ID == lastMovieID);
                        lastMovieID = SearchedMovie.ID;
                    }
                }
            }
            else if (tvShowCheckBox.Checked)
            {
                var allowedTVShows = IncludeTVShowsWithAnyOfGenres();
                if (allowedTVShows.Count != 0)
                {
                    moreOnlabel.Visible = true;
                    do
                    {
                        SearchedTvShow = allowedTVShows[rnd.Next(allowedTVShows.Count)];
                    } while (allowedTVShows.Count != 1 && SearchedTvShow.ID == lastTVShowID);
                    lastTVShowID = SearchedTvShow.ID;
                }
            }
            else if(movieCheckBox.Checked)
            {
                var allowedMovies = IncludeMoviesWithAnyOfGenres();
                if (allowedMovies.Count != 0)
                {
                    moreOnlabel.Visible = true;
                    do
                    {
                        SearchedMovie = allowedMovies[rnd.Next(allowedMovies.Count)];
                    } while (allowedMovies.Count != 1 && SearchedMovie.ID == lastMovieID);
                    lastMovieID = SearchedMovie.ID;
                }
            }

            if (SearchedMovie != null)
            {
                typeLabel.Text = "Movie";

                Thread newThread = new Thread(() => LoadImage($"https://image.tmdb.org/t/p/original{SearchedMovie.PosterPath}"));
                newThread.Start();

                titleLabel.Text = SearchedMovie.Title;
                descriptionLabel.Text = SearchedMovie.Description;
                yearLabel.Text = $"Release Date: {SearchedMovie.ReleaseDate.Value.ToShortDateString()}";

                genresLabel.Text = "Genres:";
                foreach (var genre in SearchedMovie.Genres)
                {
                    genresLabel.Text += $" {genre.Name},";
                }
                genresLabel.Text = genresLabel.Text.Remove(genresLabel.Text.Length - 1);

                voteAverageLabel.Text = $"Average rating: {SearchedMovie.VoteAverage.ToString()}/10";
                poularityLabel.Text = $"Popularity level: {SearchedMovie.Popularity.ToString()}";

                tmdbLinkLabel.Tag = $"https://www.themoviedb.org/movie/{SearchedMovie.ID}";
                tmdbLinkLabel.Text = tmdbLinkLabel.Tag.ToString();
            }
            else if (SearchedTvShow != null)
            {
                typeLabel.Text = "TV Show";

                Thread newThread = new Thread(() => LoadImage($"https://image.tmdb.org/t/p/original{SearchedTvShow.PosterPath}"));
                newThread.Start();

                titleLabel.Text = SearchedTvShow.Title;
                descriptionLabel.Text = SearchedTvShow.Description;
                yearLabel.Text = $"Release Date: {SearchedTvShow.ReleaseDate.Value.ToShortDateString()}";

                genresLabel.Text = "Genres:";
                foreach (var genre in SearchedTvShow.Genres)
                {
                    genresLabel.Text += $" {genre.Name},";
                }
                genresLabel.Text = genresLabel.Text.Remove(genresLabel.Text.Length - 1);

                voteAverageLabel.Text = $"Average rating: {SearchedTvShow.VoteAverage.ToString()}/10";
                poularityLabel.Text = $"Popularity level: {SearchedTvShow.Popularity.ToString()}";

                tmdbLinkLabel.Tag = $"https://www.themoviedb.org/tv/{SearchedTvShow.ID}";
                tmdbLinkLabel.Text = tmdbLinkLabel.Tag.ToString();
            }
        }

        public Movie CreateMovieToManager(SearchMovie item)
        {
            Genres[] newGenres = new Genres[item.GenreIds.Count];
            for (var k = 0; k < item.GenreIds.Count; k++)
            {
                var id = item.GenreIds[k];
                newGenres[k] = new Genres(id, Manager.MovieGenres.FirstOrDefault(x => x.ID == id)?.Name);
            }

            var moreInfo = Client.GetMovieAsync(item.Id).Result;
            Manager.Movies.Add(new Movie(item.Id, item.Title, item.Overview, item.ReleaseDate, item.Popularity, item.PosterPath, item.VoteAverage, newGenres, moreInfo.Homepage,moreInfo.Budget,moreInfo.Revenue));
            return Manager.Movies.Last();
        }

        public TVShow CreateTvShowToManager(SearchTv item)
        {
            Genres[] newGenres = new Genres[item.GenreIds.Count];
            for (var k = 0; k < item.GenreIds.Count; k++)
            {
                var id = item.GenreIds[k];
                newGenres[k] = new Genres(id, Manager.TVShowGenres.FirstOrDefault(x => x.ID == id)?.Name);
            }

            var moreInfo = Client.GetTvShowAsync(item.Id).Result;
            Manager.TVShows.Add(new TVShow(item.Id, item.Name, item.Overview, item.FirstAirDate, item.Popularity, item.PosterPath, item.VoteAverage, newGenres, moreInfo.Homepage));
            return Manager.TVShows.Last();
        }

        public List<Movie> IncludeMoviesWithAnyOfGenres()
        {
            List<Movie> allowedMovies = new List<Movie>();
            List<string> allowedGenres = new List<string>();
            foreach (var item in movieCheckListBox.CheckedItems)
            {
                allowedGenres.Add(item.ToString());
            }
            foreach (var movie in Manager.Movies)
            {
                string[] movieGenres = new string[movie.Genres.Length];
                for (var i = 0; i < movie.Genres.Length; i++)
                {
                    movieGenres[i] = movie.Genres[i].Name;
                }

                foreach (var genre in allowedGenres)
                {
                    if (movieGenres.Contains(genre))
                    {
                        allowedMovies.Add(movie);
                        break;
                    }
                }
            }

            return allowedMovies;
        }
        public List<TVShow> IncludeTVShowsWithAnyOfGenres()
        {
            List<TVShow> allowedTvShows = new List<TVShow>();
            List<string> allowedGenres = new List<string>();
            foreach (var item in tvShowCheckListBox.CheckedItems)
            {
                allowedGenres.Add(item.ToString());
            }
            foreach (var tvShow in Manager.TVShows)
            {
                string[] tvShowGenres = new string[tvShow.Genres.Length];
                for (var i = 0; i < tvShow.Genres.Length; i++)
                {
                    tvShowGenres[i] = tvShow.Genres[i].Name;
                }

                foreach (var genre in allowedGenres)
                {
                    if (tvShowGenres.Contains(genre))
                    {
                        allowedTvShows.Add(tvShow);
                        break;
                    }
                }
            }
            
            return allowedTvShows;
        }

        public void LoadImage(string link)
        {
            try
            {
                if (!string.IsNullOrEmpty(link))
                    showImage.Load(link);
            }
            catch
            {
                showImage.Image = null;
            }
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minimizeButton_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void tvShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tvShowCheckBox.Checked)
            {
                tvShowCheckListBox.Show();
            }
            else
            {
                tvShowCheckListBox.Hide();
            }
        }

        private void movieCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (movieCheckBox.Checked)
            {
                movieCheckListBox.Show();
            }
            else
            {
                movieCheckListBox.Hide();
            }
        }

        private void movieCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tvShowCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showImage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void tmdbLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(tmdbLinkLabel.Text);
        }

        private bool movieTicked = true;
        private bool tvTicked = true;
        private void untickButtonMovie_Click(object sender, EventArgs e)
        {
            if (movieTicked)
            {
                for (int i = 0;i < movieCheckListBox.Items.Count;i++)
                {
                    movieCheckListBox.SetItemCheckState(i,CheckState.Unchecked);
                }

                movieTicked = false;
                untickButtonMovie.Text = "Tick all";
            }
            else
            {
                for (int i = 0; i < movieCheckListBox.Items.Count; i++)
                {
                    movieCheckListBox.SetItemCheckState(i, CheckState.Checked);
                }

                movieTicked = true;
                untickButtonMovie.Text = "Untick all";
            }
        }

        private void untickButtonTV_Click(object sender, EventArgs e)
        {
            if (tvTicked)
            {
                for (int i = 0; i < tvShowCheckListBox.Items.Count; i++)
                {
                    tvShowCheckListBox.SetItemCheckState(i, CheckState.Unchecked);
                }

                tvTicked = false;
                untickButtonTV.Text = "Tick all";
            }
            else
            {
                for (int i = 0; i < tvShowCheckListBox.Items.Count; i++)
                {
                    tvShowCheckListBox.SetItemCheckState(i, CheckState.Checked);
                }

                tvTicked = true;
                untickButtonTV.Text = "Untick all";
            }
        }
    }
    [Serializable]
    public class MovieManager
    {
        public List<Movie> Movies = new List<Movie>();
        public List<TVShow> TVShows = new List<TVShow>();
        public List<Genres> MovieGenres = new List<Genres>();
        public List<Genres> TVShowGenres = new List<Genres>();
    }
    [Serializable]
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Popularity { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string PosterPath { get; set; }
        public double VoteAverage { get; set; }
        public Genres[] Genres { get; set; }
        public string Homepage { get; set; }
        public long Budget { get; set; }
        public long Revenue { get; set; }
        public Movie(int id,string title,string description, DateTime? releaseDate,double popularity,string posterPath,double voteAverage,Genres[] genres,string homepage,long budget,long revenue)
        {
            Title = title;
            Description = description;
            ReleaseDate = releaseDate;
            PosterPath = posterPath;
            VoteAverage = voteAverage;
            Genres = genres;
            ID = id;
            Popularity = popularity;
            Homepage = homepage;
            Budget = budget;
            Revenue = revenue;
        }
    }
    [Serializable]
    public class TVShow
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Popularity { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string PosterPath { get; set; }
        public double VoteAverage { get; set; }
        public Genres[] Genres { get; set; }
        public string Homepage { get; set; }
        public TVShow(int id,string title, string description, DateTime? releaseDate,double popularity, string posterPath, double voteAverage,Genres[] genres,string homepage)
        {
            Title = title;
            Description = description;
            ReleaseDate = releaseDate;
            PosterPath = posterPath;
            VoteAverage = voteAverage;
            Genres = genres;
            ID = id;
            Popularity = popularity;
            Homepage = homepage;
        }
    }
    [Serializable]
    public class Genres
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Genres(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
