
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Most_Items_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Top_sales_grid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Total_sales_text = new System.Windows.Forms.Label();
            this.Total_sales_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allTimebtn = new System.Windows.Forms.RadioButton();
            this.lastMonthbtn = new System.Windows.Forms.RadioButton();
            this.lastWeekbtn = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top_sales_grid)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_sales_grid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 428);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Most_Items_text, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Top_sales_grid, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 217);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(388, 208);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Most_Items_text
            // 
            this.Most_Items_text.AutoSize = true;
            this.Most_Items_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Most_Items_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Most_Items_text.Location = new System.Drawing.Point(3, 0);
            this.Most_Items_text.Name = "Most_Items_text";
            this.Most_Items_text.Size = new System.Drawing.Size(382, 20);
            this.Most_Items_text.TabIndex = 1;
            this.Most_Items_text.Text = "Top 10 most sold items";
            this.Most_Items_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Most_Items_text.Click += new System.EventHandler(this.Most_Items_text_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 22);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Top_sales_grid
            // 
            this.Top_sales_grid.AllowUserToAddRows = false;
            this.Top_sales_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Top_sales_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Top_sales_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_sales_grid.Location = new System.Drawing.Point(3, 23);
            this.Top_sales_grid.Name = "Top_sales_grid";
            this.Top_sales_grid.RowHeadersWidth = 51;
            this.Top_sales_grid.Size = new System.Drawing.Size(382, 160);
            this.Top_sales_grid.TabIndex = 3;
            this.Top_sales_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Top_sales_grid_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Total_sales_text, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Total_sales_grid, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 208);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // Total_sales_text
            // 
            this.Total_sales_text.AutoSize = true;
            this.Total_sales_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Total_sales_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_sales_text.Location = new System.Drawing.Point(3, 0);
            this.Total_sales_text.Name = "Total_sales_text";
            this.Total_sales_text.Size = new System.Drawing.Size(382, 20);
            this.Total_sales_text.TabIndex = 0;
            this.Total_sales_text.Text = "Total Sales";
            this.Total_sales_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Total_sales_text.Click += new System.EventHandler(this.Total_sales_text_Click);
            // 
            // Total_sales_grid
            // 
            this.Total_sales_grid.AllowUserToAddRows = false;
            this.Total_sales_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Total_sales_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Total_sales_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Total_sales_grid.Location = new System.Drawing.Point(3, 23);
            this.Total_sales_grid.Name = "Total_sales_grid";
            this.Total_sales_grid.RowHeadersWidth = 51;
            this.Total_sales_grid.Size = new System.Drawing.Size(382, 160);
            this.Total_sales_grid.TabIndex = 1;
            this.Total_sales_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Total_sales_grid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total sales: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allTimebtn);
            this.groupBox1.Controls.Add(this.lastMonthbtn);
            this.groupBox1.Controls.Add(this.lastWeekbtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TimeLine";
            // 
            // allTimebtn
            // 
            this.allTimebtn.AutoSize = true;
            this.allTimebtn.Location = new System.Drawing.Point(53, 138);
            this.allTimebtn.Name = "allTimebtn";
            this.allTimebtn.Size = new System.Drawing.Size(59, 17);
            this.allTimebtn.TabIndex = 2;
            this.allTimebtn.TabStop = true;
            this.allTimebtn.Text = "All time";
            this.allTimebtn.UseVisualStyleBackColor = true;
            this.allTimebtn.CheckedChanged += new System.EventHandler(this.allTimebtn_CheckedChanged);
            // 
            // lastMonthbtn
            // 
            this.lastMonthbtn.AutoSize = true;
            this.lastMonthbtn.Location = new System.Drawing.Point(53, 85);
            this.lastMonthbtn.Name = "lastMonthbtn";
            this.lastMonthbtn.Size = new System.Drawing.Size(78, 17);
            this.lastMonthbtn.TabIndex = 1;
            this.lastMonthbtn.TabStop = true;
            this.lastMonthbtn.Text = "Last Month";
            this.lastMonthbtn.UseVisualStyleBackColor = true;
            this.lastMonthbtn.CheckedChanged += new System.EventHandler(this.lastMonth_CheckedChanged);
            // 
            // lastWeekbtn
            // 
            this.lastWeekbtn.AutoSize = true;
            this.lastWeekbtn.Location = new System.Drawing.Point(53, 26);
            this.lastWeekbtn.Name = "lastWeekbtn";
            this.lastWeekbtn.Size = new System.Drawing.Size(73, 17);
            this.lastWeekbtn.TabIndex = 0;
            this.lastWeekbtn.TabStop = true;
            this.lastWeekbtn.Text = "Last week";
            this.lastWeekbtn.UseVisualStyleBackColor = true;
            this.lastWeekbtn.CheckedChanged += new System.EventHandler(this.lastWeekbtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top_sales_grid)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_sales_grid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label Most_Items_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Top_sales_grid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Total_sales_text;
        private System.Windows.Forms.DataGridView Total_sales_grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton allTimebtn;
        private System.Windows.Forms.RadioButton lastMonthbtn;
        private System.Windows.Forms.RadioButton lastWeekbtn;
    }
}

