﻿namespace Metroshoesmaagementsystem
{
    partial class Monthly_expense
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Monthname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemsquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemsprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monthname,
            this.Itemname,
            this.Itemsquantity,
            this.Itemsprice,
            this.Totalamount});
            this.dataGridView1.Location = new System.Drawing.Point(85, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 184);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Monthname
            // 
            this.Monthname.HeaderText = "Month name";
            this.Monthname.Name = "Monthname";
            // 
            // Itemname
            // 
            this.Itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Itemname.HeaderText = "Item name";
            this.Itemname.Name = "Itemname";
            // 
            // Itemsquantity
            // 
            this.Itemsquantity.HeaderText = "Items Quantity";
            this.Itemsquantity.Name = "Itemsquantity";
            // 
            // Itemsprice
            // 
            this.Itemsprice.HeaderText = "Items price";
            this.Itemsprice.Name = "Itemsprice";
            // 
            // Totalamount
            // 
            this.Totalamount.HeaderText = "Total amount";
            this.Totalamount.Name = "Totalamount";
            // 
            // Monthly_expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Monthly_expense";
            this.Text = "Monthly Expense";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monthname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemsquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemsprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalamount;
    }
}