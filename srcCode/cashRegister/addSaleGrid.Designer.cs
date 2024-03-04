
namespace cashRegister
{
    partial class addSaleGrid
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
            this.unitslabel = new System.Windows.Forms.Label();
            this.unitsBox = new System.Windows.Forms.TextBox();
            this.add_to_grid_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unitslabel
            // 
            this.unitslabel.AutoSize = true;
            this.unitslabel.Location = new System.Drawing.Point(12, 72);
            this.unitslabel.Name = "unitslabel";
            this.unitslabel.Size = new System.Drawing.Size(86, 13);
            this.unitslabel.TabIndex = 0;
            this.unitslabel.Text = "number of units:";
            // 
            // unitsBox
            // 
            this.unitsBox.Location = new System.Drawing.Point(129, 69);
            this.unitsBox.Name = "unitsBox";
            this.unitsBox.Size = new System.Drawing.Size(100, 20);
            this.unitsBox.TabIndex = 1;
            this.unitsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitsBox_KeyPress);
            // 
            // add_to_grid_btn
            // 
            this.add_to_grid_btn.Location = new System.Drawing.Point(197, 126);
            this.add_to_grid_btn.Name = "add_to_grid_btn";
            this.add_to_grid_btn.Size = new System.Drawing.Size(75, 23);
            this.add_to_grid_btn.TabIndex = 2;
            this.add_to_grid_btn.Text = "add";
            this.add_to_grid_btn.UseVisualStyleBackColor = true;
            this.add_to_grid_btn.Click += new System.EventHandler(this.add_to_grid_btn_Click);
            // 
            // addSaleGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.add_to_grid_btn);
            this.Controls.Add(this.unitsBox);
            this.Controls.Add(this.unitslabel);
            this.Name = "addSaleGrid";
            this.Text = "addSaleGrid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unitslabel;
        private System.Windows.Forms.TextBox unitsBox;
        private System.Windows.Forms.Button add_to_grid_btn;
    }
}