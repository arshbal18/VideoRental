namespace VideoRental
{
    partial class VideoRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoRental));
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRented = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMovie
            // 
            this.btnMovie.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.Location = new System.Drawing.Point(52, 212);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(149, 53);
            this.btnMovie.TabIndex = 0;
            this.btnMovie.Text = "Movie";
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click_1);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(52, 153);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(149, 53);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click_1);
            // 
            // btnRented
            // 
            this.btnRented.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRented.Location = new System.Drawing.Point(52, 271);
            this.btnRented.Name = "btnRented";
            this.btnRented.Size = new System.Drawing.Size(149, 53);
            this.btnRented.TabIndex = 1;
            this.btnRented.Text = "Rented";
            this.btnRented.UseVisualStyleBackColor = true;
            this.btnRented.Click += new System.EventHandler(this.btnRented_Click_1);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltitle.Location = new System.Drawing.Point(310, 23);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(307, 46);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Video Rental System";
            // 
            // VideoRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 369);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnRented);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnMovie);
            this.Name = "VideoRental";
            this.Text = "VideoRental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRented;
        private System.Windows.Forms.Label lbltitle;
    }
}

