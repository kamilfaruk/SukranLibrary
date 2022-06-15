using SukranLibrary.Controls;
using System.Drawing;
using System.Windows.Forms;
namespace SukranLibrary.Forms.SubForms
{
    partial class FilterForm
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
            this.Main_Table = new TableLayoutPanel();
            this.Close_Btn = new Button();
            this.BookFilter_Btn = new Button();
            this.Main_BookFilterControl = new BookFilterControl();
            this.QuotationFilter_Btn = new Button();
            this.Main_QuotationFilterControl = new QuotationFilterControl();
            this.Main_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Table
            // 
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 3;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Main_Table.RowCount = 3;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 33));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 7));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Close_Btn, 0, 0);
            this.Main_Table.Controls.Add(this.BookFilter_Btn, 1, 0);
            this.Main_Table.SetRowSpan(this.BookFilter_Btn, 2);
            this.Main_Table.Controls.Add(this.QuotationFilter_Btn, 2, 0);
            this.Main_Table.SetRowSpan(this.QuotationFilter_Btn, 2);
            this.Main_Table.Controls.Add(this.Main_BookFilterControl, 0, 2);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Location = new System.Drawing.Point(0, 0);
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.Size = new System.Drawing.Size(800, 450);
            this.Main_Table.TabIndex = 0;
            // 
            // Close_Btn
            // 
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Close_Btn.FlatStyle = FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.Close_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Close_Btn.Location = new System.Drawing.Point(0, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(25, 25);
            this.Close_Btn.Image = ((System.Drawing.Image)(Properties.Resources.Close_Image));
            this.Close_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            //
            //BookFilter_Btn
            //
            this.BookFilter_Btn.Dock = DockStyle.Fill;
            this.BookFilter_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.BookFilter_Btn.FlatAppearance.BorderSize = 1;
            this.BookFilter_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.BookFilter_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.BookFilter_Btn.FlatStyle = FlatStyle.Flat;
            this.BookFilter_Btn.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            this.BookFilter_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.BookFilter_Btn.Location = new Point(53, 966);
            this.BookFilter_Btn.Name = "BookFilter_Btn";
            this.BookFilter_Btn.Padding = new Padding(5, 0, 0, 0);
            this.BookFilter_Btn.Size = new Size(244, 64);
            this.BookFilter_Btn.TabIndex = 11;
            this.BookFilter_Btn.Text = "KİTAP FİLTRELE";
            this.BookFilter_Btn.UseVisualStyleBackColor = true;
            this.BookFilter_Btn.Click += BookFilter_Btn_Click;
            //
            //Main_BookFilterControl
            //
            this.Main_Table.SetColumnSpan(Main_BookFilterControl, 3);
            this.Main_BookFilterControl.Dock = DockStyle.Fill;
            this.Main_BookFilterControl.Name = "Main_BookFilterControl";
            //
            //QuotationFilter_Btn
            //
            this.QuotationFilter_Btn.Dock = DockStyle.Fill;
            this.QuotationFilter_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.QuotationFilter_Btn.FlatAppearance.BorderSize = 1;
            this.QuotationFilter_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.QuotationFilter_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.QuotationFilter_Btn.FlatStyle = FlatStyle.Flat;
            this.QuotationFilter_Btn.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            this.QuotationFilter_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.QuotationFilter_Btn.Location = new Point(53, 966);
            this.QuotationFilter_Btn.Name = "QuotationFilter_Btn";
            this.QuotationFilter_Btn.Padding = new Padding(5, 0, 0, 0);
            this.QuotationFilter_Btn.Size = new Size(244, 64);
            this.QuotationFilter_Btn.TabIndex = 11;
            this.QuotationFilter_Btn.Text = "ALINTI FİLTRELE";
            this.QuotationFilter_Btn.UseVisualStyleBackColor = true;
            this.QuotationFilter_Btn.Click += QuotationFilter_Btn_Click;
            //
            //Main_QuotationFilterControl
            //
            this.Main_Table.SetColumnSpan(Main_QuotationFilterControl, 3);
            this.Main_QuotationFilterControl.Dock = DockStyle.Fill;
            this.Main_QuotationFilterControl.Name = "Main_QuotationFilterControl";
            // 
            //FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(47, 52, 58);
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(Main_Table);
            this.Text = "FilterForm";
            this.Name = "FilterForm";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Button Close_Btn;
        private Button BookFilter_Btn;
        private BookFilterControl Main_BookFilterControl;
        private Button QuotationFilter_Btn;
        private QuotationFilterControl Main_QuotationFilterControl;
    }
}