
namespace UI_Product_maintenance_software
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Available_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Changeprice_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            this.Itemlistview = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAvailable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialogLoad = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Itemlistview, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Available_button, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Add_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Changeprice_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Save_button, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Load_button, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 393);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Available_button
            // 
            this.Available_button.Location = new System.Drawing.Point(319, 3);
            this.Available_button.Name = "Available_button";
            this.Available_button.Size = new System.Drawing.Size(152, 49);
            this.Available_button.TabIndex = 5;
            this.Available_button.Text = "Availability";
            this.Available_button.UseVisualStyleBackColor = true;
            this.Available_button.Click += new System.EventHandler(this.Available_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_button.Location = new System.Drawing.Point(3, 3);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(152, 49);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Changeprice_button
            // 
            this.Changeprice_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Changeprice_button.Location = new System.Drawing.Point(161, 3);
            this.Changeprice_button.Name = "Changeprice_button";
            this.Changeprice_button.Size = new System.Drawing.Size(152, 49);
            this.Changeprice_button.TabIndex = 1;
            this.Changeprice_button.Text = "Change price";
            this.Changeprice_button.UseVisualStyleBackColor = true;
            this.Changeprice_button.Click += new System.EventHandler(this.Changeprice_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(635, 3);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(156, 49);
            this.Save_button.TabIndex = 3;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_productlist_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(477, 3);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(152, 49);
            this.Load_button.TabIndex = 4;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Itemlistview
            // 
            this.Itemlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPrice,
            this.chAvailable});
            this.Itemlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Itemlistview.FullRowSelect = true;
            this.Itemlistview.GridLines = true;
            this.Itemlistview.HideSelection = false;
            this.Itemlistview.Location = new System.Drawing.Point(3, 3);
            this.Itemlistview.MultiSelect = false;
            this.Itemlistview.Name = "Itemlistview";
            this.Itemlistview.Size = new System.Drawing.Size(794, 384);
            this.Itemlistview.TabIndex = 2;
            this.Itemlistview.UseCompatibleStateImageBehavior = false;
            this.Itemlistview.View = System.Windows.Forms.View.Details;
            this.Itemlistview.SelectedIndexChanged += new System.EventHandler(this.Itemlist_view_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Product Name";
            this.chName.Width = 244;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 205;
            // 
            // chAvailable
            // 
            this.chAvailable.Text = "Availability";
            this.chAvailable.Width = 590;
            // 
            // openFileDialogLoad
            // 
            this.openFileDialogLoad.FileName = "openFileDialog1";
            this.openFileDialogLoad.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.openFileDialogLoad.Title = "Select database";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Changeprice_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ListView Itemlistview;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chAvailable;
        private System.Windows.Forms.Button Available_button;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoad;
    }
}

