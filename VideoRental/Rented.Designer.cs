namespace VideoRental
{
    partial class Rented
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rented));
            this.lblRMID = new System.Windows.Forms.Label();
            this.lblCustIDFK = new System.Windows.Forms.Label();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.txtRMID = new System.Windows.Forms.TextBox();
            this.txtCustIDFK = new System.Windows.Forms.TextBox();
            this.txtDateRented = new System.Windows.Forms.TextBox();
            this.txtDateReturned = new System.Windows.Forms.TextBox();
            this.btnAddRented = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.RMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMovieIDFK = new System.Windows.Forms.Label();
            this.txtMovieIDFK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRMID
            // 
            this.lblRMID.AutoSize = true;
            this.lblRMID.Location = new System.Drawing.Point(28, 249);
            this.lblRMID.Name = "lblRMID";
            this.lblRMID.Size = new System.Drawing.Size(35, 13);
            this.lblRMID.TabIndex = 1;
            this.lblRMID.Text = "RMID";
            // 
            // lblCustIDFK
            // 
            this.lblCustIDFK.AutoSize = true;
            this.lblCustIDFK.Location = new System.Drawing.Point(203, 249);
            this.lblCustIDFK.Name = "lblCustIDFK";
            this.lblCustIDFK.Size = new System.Drawing.Size(52, 13);
            this.lblCustIDFK.TabIndex = 2;
            this.lblCustIDFK.Text = "CustIDFK";
            this.lblCustIDFK.Click += new System.EventHandler(this.lblCustomerId_Click);
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Location = new System.Drawing.Point(295, 249);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(68, 13);
            this.lblDateRented.TabIndex = 3;
            this.lblDateRented.Text = "Date Rented";
            this.lblDateRented.Click += new System.EventHandler(this.lblDateRented_Click);
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Location = new System.Drawing.Point(369, 249);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(77, 13);
            this.lblDateReturned.TabIndex = 4;
            this.lblDateReturned.Text = "Date Returned";
            this.lblDateReturned.Click += new System.EventHandler(this.lblDateReturned_Click);
            // 
            // txtRMID
            // 
            this.txtRMID.Location = new System.Drawing.Point(26, 265);
            this.txtRMID.Name = "txtRMID";
            this.txtRMID.Size = new System.Drawing.Size(71, 20);
            this.txtRMID.TabIndex = 5;
            this.txtRMID.TextChanged += new System.EventHandler(this.txtMoviesId_TextChanged);
            // 
            // txtCustIDFK
            // 
            this.txtCustIDFK.Location = new System.Drawing.Point(206, 265);
            this.txtCustIDFK.Name = "txtCustIDFK";
            this.txtCustIDFK.Size = new System.Drawing.Size(71, 20);
            this.txtCustIDFK.TabIndex = 6;
            // 
            // txtDateRented
            // 
            this.txtDateRented.Location = new System.Drawing.Point(288, 265);
            this.txtDateRented.Name = "txtDateRented";
            this.txtDateRented.Size = new System.Drawing.Size(75, 20);
            this.txtDateRented.TabIndex = 7;
            this.txtDateRented.TextChanged += new System.EventHandler(this.txtDateRented_TextChanged);
            // 
            // txtDateReturned
            // 
            this.txtDateReturned.Location = new System.Drawing.Point(372, 265);
            this.txtDateReturned.Name = "txtDateReturned";
            this.txtDateReturned.Size = new System.Drawing.Size(83, 20);
            this.txtDateReturned.TabIndex = 8;
            // 
            // btnAddRented
            // 
            this.btnAddRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRented.Location = new System.Drawing.Point(26, 169);
            this.btnAddRented.Name = "btnAddRented";
            this.btnAddRented.Size = new System.Drawing.Size(103, 45);
            this.btnAddRented.TabIndex = 9;
            this.btnAddRented.Text = "Add";
            this.btnAddRented.UseVisualStyleBackColor = true;
            this.btnAddRented.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(164, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 45);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(298, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 45);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RMID,
            this.MovieIDFK,
            this.CustIDFK,
            this.DateRented,
            this.DateReturned});
            this.listView1.Location = new System.Drawing.Point(26, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 132);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // RMID
            // 
            this.RMID.Text = "RMID";
            // 
            // MovieIDFK
            // 
            this.MovieIDFK.Text = "MovieIDFK";
            this.MovieIDFK.Width = 86;
            // 
            // CustIDFK
            // 
            this.CustIDFK.Text = "CustIDFK";
            // 
            // DateRented
            // 
            this.DateRented.Text = "DateRented";
            this.DateRented.Width = 99;
            // 
            // DateReturned
            // 
            this.DateReturned.Text = "DateReturned";
            this.DateReturned.Width = 101;
            // 
            // lblMovieIDFK
            // 
            this.lblMovieIDFK.AutoSize = true;
            this.lblMovieIDFK.Location = new System.Drawing.Point(104, 249);
            this.lblMovieIDFK.Name = "lblMovieIDFK";
            this.lblMovieIDFK.Size = new System.Drawing.Size(60, 13);
            this.lblMovieIDFK.TabIndex = 13;
            this.lblMovieIDFK.Text = "MovieIDFK";
            this.lblMovieIDFK.Click += new System.EventHandler(this.lblMovieIDFK_Click);
            // 
            // txtMovieIDFK
            // 
            this.txtMovieIDFK.Location = new System.Drawing.Point(107, 265);
            this.txtMovieIDFK.Name = "txtMovieIDFK";
            this.txtMovieIDFK.Size = new System.Drawing.Size(75, 20);
            this.txtMovieIDFK.TabIndex = 14;
            // 
            // Rented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMovieIDFK);
            this.Controls.Add(this.lblMovieIDFK);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddRented);
            this.Controls.Add(this.txtDateReturned);
            this.Controls.Add(this.txtDateRented);
            this.Controls.Add(this.txtCustIDFK);
            this.Controls.Add(this.txtRMID);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.lblDateRented);
            this.Controls.Add(this.lblCustIDFK);
            this.Controls.Add(this.lblRMID);
            this.Name = "Rented";
            this.Text = "Rented";
            this.Load += new System.EventHandler(this.Rented_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRMID;
        private System.Windows.Forms.Label lblCustIDFK;
        private System.Windows.Forms.Label lblDateRented;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.TextBox txtRMID;
        private System.Windows.Forms.TextBox txtCustIDFK;
        private System.Windows.Forms.TextBox txtDateRented;
        private System.Windows.Forms.TextBox txtDateReturned;
        private System.Windows.Forms.Button btnAddRented;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader RMID;
        private System.Windows.Forms.ColumnHeader MovieIDFK;
        private System.Windows.Forms.ColumnHeader CustIDFK;
        private System.Windows.Forms.ColumnHeader DateRented;
        private System.Windows.Forms.ColumnHeader DateReturned;
        private System.Windows.Forms.Label lblMovieIDFK;
        private System.Windows.Forms.TextBox txtMovieIDFK;
    }
}