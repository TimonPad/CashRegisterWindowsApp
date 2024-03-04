
namespace UI_Reporting_software
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Total_sales_text = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Most_Sold_Items_text = new System.Windows.Forms.Label();
            this.Most_Sold_Items_grid = new System.Windows.Forms.DataGridView();
            this.Total_sales_grid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Start_date = new System.Windows.Forms.DateTimePicker();
            this.End_date = new System.Windows.Forms.DateTimePicker();
            this.Load_reports = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Most_Sold_Items_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_sales_grid)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Total_sales_text, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Total_sales_grid, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27778F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.72222F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 216);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Total_sales_text
            // 
            this.Total_sales_text.AutoSize = true;
            this.Total_sales_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Total_sales_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_sales_text.Location = new System.Drawing.Point(3, 0);
            this.Total_sales_text.Name = "Total_sales_text";
            this.Total_sales_text.Size = new System.Drawing.Size(382, 32);
            this.Total_sales_text.TabIndex = 0;
            this.Total_sales_text.Text = "Total Sales";
            this.Total_sales_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Most_Sold_Items_text, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Most_Sold_Items_grid, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27778F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.72222F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(388, 216);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Most_Sold_Items_text
            // 
            this.Most_Sold_Items_text.AutoSize = true;
            this.Most_Sold_Items_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Most_Sold_Items_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Most_Sold_Items_text.Location = new System.Drawing.Point(3, 0);
            this.Most_Sold_Items_text.Name = "Most_Sold_Items_text";
            this.Most_Sold_Items_text.Size = new System.Drawing.Size(382, 32);
            this.Most_Sold_Items_text.TabIndex = 0;
            this.Most_Sold_Items_text.Text = "Top 10 most sold items";
            this.Most_Sold_Items_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Most_Sold_Items_grid
            // 
            this.Most_Sold_Items_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Most_Sold_Items_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Most_Sold_Items_grid.Location = new System.Drawing.Point(3, 35);
            this.Most_Sold_Items_grid.Name = "Most_Sold_Items_grid";
            this.Most_Sold_Items_grid.Size = new System.Drawing.Size(382, 178);
            this.Most_Sold_Items_grid.TabIndex = 1;
            // 
            // Total_sales_grid
            // 
            this.Total_sales_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Total_sales_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Total_sales_grid.Location = new System.Drawing.Point(3, 35);
            this.Total_sales_grid.Name = "Total_sales_grid";
            this.Total_sales_grid.Size = new System.Drawing.Size(382, 178);
            this.Total_sales_grid.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Start_date, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.End_date, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Load_reports, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // Start_date
            // 
            this.Start_date.Dock = System.Windows.Forms.DockStyle.Top;
            this.Start_date.Location = new System.Drawing.Point(3, 3);
            this.Start_date.Name = "Start_date";
            this.Start_date.Size = new System.Drawing.Size(388, 20);
            this.Start_date.TabIndex = 0;
            // 
            // End_date
            // 
            this.End_date.Dock = System.Windows.Forms.DockStyle.Top;
            this.End_date.Location = new System.Drawing.Point(3, 150);
            this.End_date.Name = "End_date";
            this.End_date.Size = new System.Drawing.Size(388, 20);
            this.End_date.TabIndex = 1;
            // 
            // Load_reports
            // 
            this.Load_reports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Load_reports.Location = new System.Drawing.Point(3, 418);
            this.Load_reports.Name = "Load_reports";
            this.Load_reports.Size = new System.Drawing.Size(388, 23);
            this.Load_reports.TabIndex = 2;
            this.Load_reports.Text = "Load";
            this.Load_reports.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Most_Sold_Items_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_sales_grid)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label Most_Sold_Items_text;
        private System.Windows.Forms.DataGridView Most_Sold_Items_grid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Total_sales_text;
        private System.Windows.Forms.DataGridView Total_sales_grid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker Start_date;
        private System.Windows.Forms.DateTimePicker End_date;
        private System.Windows.Forms.Button Load_reports;
    }
}

