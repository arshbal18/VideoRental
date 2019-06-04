namespace VideoRental
{
    partial class Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MovieID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Copies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblId = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRental_Cost = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRental_Cost = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(92, 192);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 44);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(279, 192);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 44);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(471, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieID,
            this.Rating,
            this.Title,
            this.Year,
            this.Rental_Cost,
            this.Copies,
            this.Plot,
            this.Genre});
            this.listView1.Location = new System.Drawing.Point(92, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 131);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MovieID
            // 
            this.MovieID.Text = "MovieId";
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.Text = "Rental_Cost";
            this.Rental_Cost.Width = 90;
            // 
            // Copies
            // 
            this.Copies.Text = "Copies";
            // 
            // Plot
            // 
            this.Plot.Text = "Plot";
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(89, 266);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(47, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "MovieID";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(178, 266);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating";
            this.lblRating.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(82, 282);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(72, 20);
            this.txtMovieId.TabIndex = 7;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(171, 282);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(73, 20);
            this.txtRating.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(276, 282);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(64, 20);
            this.txtTitle.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(369, 282);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(74, 20);
            this.txtYear.TabIndex = 10;
            // 
            // txtRental_Cost
            // 
            this.txtRental_Cost.Location = new System.Drawing.Point(467, 282);
            this.txtRental_Cost.Name = "txtRental_Cost";
            this.txtRental_Cost.Size = new System.Drawing.Size(79, 20);
            this.txtRental_Cost.TabIndex = 11;
            this.txtRental_Cost.TextChanged += new System.EventHandler(this.txtRentedMovies_TextChanged);
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(568, 282);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(73, 20);
            this.txtCopies.TabIndex = 12;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(662, 282);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(67, 20);
            this.txtPlot.TabIndex = 13;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(754, 282);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(73, 20);
            this.txtGenre.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(276, 263);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(366, 266);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "Year";
            // 
            // lblRental_Cost
            // 
            this.lblRental_Cost.AutoSize = true;
            this.lblRental_Cost.Location = new System.Drawing.Point(464, 263);
            this.lblRental_Cost.Name = "lblRental_Cost";
            this.lblRental_Cost.Size = new System.Drawing.Size(62, 13);
            this.lblRental_Cost.TabIndex = 17;
            this.lblRental_Cost.Text = "Rental Cost";
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(565, 263);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(39, 13);
            this.lblCopies.TabIndex = 18;
            this.lblCopies.Text = "Copies";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Location = new System.Drawing.Point(659, 263);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(25, 13);
            this.lblPlot.TabIndex = 19;
            this.lblPlot.Text = "Plot";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(751, 263);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 20;
            this.lblGenre.Text = "Genre";
            this.lblGenre.Click += new System.EventHandler(this.lblGenre_Click);
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPlot);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.lblRental_Cost);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtRental_Cost);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "Movie";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.Movie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MovieID;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Rental_Cost;
        private System.Windows.Forms.ColumnHeader Copies;
        private System.Windows.Forms.ColumnHeader Plot;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRental_Cost;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRental_Cost;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label lblGenre;
    }
}