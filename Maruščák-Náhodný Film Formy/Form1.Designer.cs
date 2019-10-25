namespace Maruščák_Náhodný_Film_Formy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.untickButtonTV = new System.Windows.Forms.Button();
            this.untickButtonMovie = new System.Windows.Forms.Button();
            this.tvShowCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.movieCheckBox = new System.Windows.Forms.CheckBox();
            this.tvShowCheckBox = new System.Windows.Forms.CheckBox();
            this.movieCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.appSummaryLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.showImage = new System.Windows.Forms.PictureBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.tmdbLinkLabel = new System.Windows.Forms.LinkLabel();
            this.genresLabel = new System.Windows.Forms.Label();
            this.poularityLabel = new System.Windows.Forms.Label();
            this.voteAverageLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.moreOnlabel = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showImage)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.AutoSize = true;
            this.showButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.showButton.FlatAppearance.BorderSize = 2;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.showButton.Location = new System.Drawing.Point(60, 345);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(140, 46);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show me!";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.DimGray;
            this.controlPanel.Controls.Add(this.untickButtonTV);
            this.controlPanel.Controls.Add(this.untickButtonMovie);
            this.controlPanel.Controls.Add(this.tvShowCheckListBox);
            this.controlPanel.Controls.Add(this.movieCheckBox);
            this.controlPanel.Controls.Add(this.tvShowCheckBox);
            this.controlPanel.Controls.Add(this.movieCheckListBox);
            this.controlPanel.Controls.Add(this.showButton);
            this.controlPanel.Location = new System.Drawing.Point(0, 50);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(260, 405);
            this.controlPanel.TabIndex = 2;
            this.controlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPanel_Paint);
            // 
            // untickButtonTV
            // 
            this.untickButtonTV.AutoSize = true;
            this.untickButtonTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.untickButtonTV.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.untickButtonTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.untickButtonTV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untickButtonTV.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.untickButtonTV.Location = new System.Drawing.Point(158, 314);
            this.untickButtonTV.Name = "untickButtonTV";
            this.untickButtonTV.Size = new System.Drawing.Size(90, 27);
            this.untickButtonTV.TabIndex = 8;
            this.untickButtonTV.Text = "Untick all";
            this.untickButtonTV.UseVisualStyleBackColor = false;
            this.untickButtonTV.Click += new System.EventHandler(this.untickButtonTV_Click);
            // 
            // untickButtonMovie
            // 
            this.untickButtonMovie.AutoSize = true;
            this.untickButtonMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.untickButtonMovie.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.untickButtonMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.untickButtonMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untickButtonMovie.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.untickButtonMovie.Location = new System.Drawing.Point(10, 314);
            this.untickButtonMovie.Name = "untickButtonMovie";
            this.untickButtonMovie.Size = new System.Drawing.Size(90, 27);
            this.untickButtonMovie.TabIndex = 7;
            this.untickButtonMovie.Text = "Untick all";
            this.untickButtonMovie.UseVisualStyleBackColor = false;
            this.untickButtonMovie.Click += new System.EventHandler(this.untickButtonMovie_Click);
            // 
            // tvShowCheckListBox
            // 
            this.tvShowCheckListBox.BackColor = System.Drawing.Color.DimGray;
            this.tvShowCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvShowCheckListBox.CheckOnClick = true;
            this.tvShowCheckListBox.ForeColor = System.Drawing.Color.White;
            this.tvShowCheckListBox.FormattingEnabled = true;
            this.tvShowCheckListBox.Location = new System.Drawing.Point(139, 29);
            this.tvShowCheckListBox.Name = "tvShowCheckListBox";
            this.tvShowCheckListBox.Size = new System.Drawing.Size(118, 285);
            this.tvShowCheckListBox.TabIndex = 6;
            this.tvShowCheckListBox.SelectedIndexChanged += new System.EventHandler(this.tvShowCheckListBox_SelectedIndexChanged);
            // 
            // movieCheckBox
            // 
            this.movieCheckBox.AutoSize = true;
            this.movieCheckBox.Checked = true;
            this.movieCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.movieCheckBox.ForeColor = System.Drawing.Color.White;
            this.movieCheckBox.Location = new System.Drawing.Point(12, 6);
            this.movieCheckBox.Name = "movieCheckBox";
            this.movieCheckBox.Size = new System.Drawing.Size(60, 17);
            this.movieCheckBox.TabIndex = 5;
            this.movieCheckBox.Text = "Movies";
            this.movieCheckBox.UseVisualStyleBackColor = true;
            this.movieCheckBox.CheckedChanged += new System.EventHandler(this.movieCheckBox_CheckedChanged);
            // 
            // tvShowCheckBox
            // 
            this.tvShowCheckBox.AutoSize = true;
            this.tvShowCheckBox.Checked = true;
            this.tvShowCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tvShowCheckBox.ForeColor = System.Drawing.Color.White;
            this.tvShowCheckBox.Location = new System.Drawing.Point(139, 6);
            this.tvShowCheckBox.Name = "tvShowCheckBox";
            this.tvShowCheckBox.Size = new System.Drawing.Size(75, 17);
            this.tvShowCheckBox.TabIndex = 4;
            this.tvShowCheckBox.Text = "TV Shows";
            this.tvShowCheckBox.UseVisualStyleBackColor = true;
            this.tvShowCheckBox.CheckedChanged += new System.EventHandler(this.tvShowCheckBox_CheckedChanged);
            // 
            // movieCheckListBox
            // 
            this.movieCheckListBox.BackColor = System.Drawing.Color.DimGray;
            this.movieCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieCheckListBox.CheckOnClick = true;
            this.movieCheckListBox.ForeColor = System.Drawing.Color.White;
            this.movieCheckListBox.FormattingEnabled = true;
            this.movieCheckListBox.Location = new System.Drawing.Point(12, 29);
            this.movieCheckListBox.Name = "movieCheckListBox";
            this.movieCheckListBox.Size = new System.Drawing.Size(131, 285);
            this.movieCheckListBox.TabIndex = 2;
            this.movieCheckListBox.SelectedIndexChanged += new System.EventHandler(this.movieCheckListBox_SelectedIndexChanged);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.topPanel.Controls.Add(this.appSummaryLabel);
            this.topPanel.Controls.Add(this.appNameLabel);
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(811, 50);
            this.topPanel.TabIndex = 3;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // appSummaryLabel
            // 
            this.appSummaryLabel.AutoSize = true;
            this.appSummaryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.appSummaryLabel.ForeColor = System.Drawing.Color.White;
            this.appSummaryLabel.Location = new System.Drawing.Point(10, 25);
            this.appSummaryLabel.Name = "appSummaryLabel";
            this.appSummaryLabel.Size = new System.Drawing.Size(260, 19);
            this.appSummaryLabel.TabIndex = 6;
            this.appSummaryLabel.Text = "If you want to know what to watch next!";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.White;
            this.appNameLabel.Location = new System.Drawing.Point(5, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(231, 30);
            this.appNameLabel.TabIndex = 5;
            this.appNameLabel.Text = "Random Movie Finder";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(736, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseMove);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(774, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exitButton_MouseMove);
            // 
            // showImage
            // 
            this.showImage.Location = new System.Drawing.Point(276, 56);
            this.showImage.Name = "showImage";
            this.showImage.Size = new System.Drawing.Size(134, 201);
            this.showImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showImage.TabIndex = 4;
            this.showImage.TabStop = false;
            this.showImage.Click += new System.EventHandler(this.showImage_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.yearLabel.Location = new System.Drawing.Point(276, 303);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(523, 23);
            this.yearLabel.TabIndex = 7;
            // 
            // titleLabel
            // 
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(416, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(383, 25);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionLabel.Location = new System.Drawing.Point(416, 79);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(383, 178);
            this.descriptionLabel.TabIndex = 9;
            // 
            // tmdbLinkLabel
            // 
            this.tmdbLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tmdbLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tmdbLinkLabel.Location = new System.Drawing.Point(348, 408);
            this.tmdbLinkLabel.Name = "tmdbLinkLabel";
            this.tmdbLinkLabel.Size = new System.Drawing.Size(450, 26);
            this.tmdbLinkLabel.TabIndex = 10;
            this.tmdbLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tmdbLinkLabel_LinkClicked);
            // 
            // genresLabel
            // 
            this.genresLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genresLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.genresLabel.Location = new System.Drawing.Point(276, 326);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(523, 23);
            this.genresLabel.TabIndex = 11;
            // 
            // poularityLabel
            // 
            this.poularityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poularityLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.poularityLabel.Location = new System.Drawing.Point(276, 349);
            this.poularityLabel.Name = "poularityLabel";
            this.poularityLabel.Size = new System.Drawing.Size(523, 23);
            this.poularityLabel.TabIndex = 12;
            // 
            // voteAverageLabel
            // 
            this.voteAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voteAverageLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.voteAverageLabel.Location = new System.Drawing.Point(276, 280);
            this.voteAverageLabel.Name = "voteAverageLabel";
            this.voteAverageLabel.Size = new System.Drawing.Size(523, 23);
            this.voteAverageLabel.TabIndex = 13;
            // 
            // typeLabel
            // 
            this.typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.typeLabel.Location = new System.Drawing.Point(276, 257);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(523, 23);
            this.typeLabel.TabIndex = 14;
            // 
            // moreOnlabel
            // 
            this.moreOnlabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.moreOnlabel.Location = new System.Drawing.Point(273, 409);
            this.moreOnlabel.Name = "moreOnlabel";
            this.moreOnlabel.Size = new System.Drawing.Size(70, 26);
            this.moreOnlabel.TabIndex = 15;
            this.moreOnlabel.Text = "More on:";
            this.moreOnlabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(810, 455);
            this.Controls.Add(this.moreOnlabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.voteAverageLabel);
            this.Controls.Add(this.poularityLabel);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.tmdbLinkLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.showImage);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Random Movie Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.CheckedListBox movieCheckListBox;
        private System.Windows.Forms.CheckBox movieCheckBox;
        private System.Windows.Forms.CheckBox tvShowCheckBox;
        private System.Windows.Forms.CheckedListBox tvShowCheckListBox;
        private System.Windows.Forms.PictureBox showImage;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label appSummaryLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.LinkLabel tmdbLinkLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label poularityLabel;
        private System.Windows.Forms.Label voteAverageLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label moreOnlabel;
        private System.Windows.Forms.Button untickButtonMovie;
        private System.Windows.Forms.Button untickButtonTV;
    }
}

