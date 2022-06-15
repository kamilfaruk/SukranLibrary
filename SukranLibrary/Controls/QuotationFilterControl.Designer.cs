using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using SukranLibrary.Components;
using System;
namespace SukranLibrary.Controls
{
    partial class QuotationFilterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Table = new TableLayoutPanel();
            this.Filter_Table = new TableLayoutPanel();
            this.Page_Lbl = new Label();
            this.Page_Num = new NumericUpDown();
            this.Page_Btn = new Button();
            this.Book_Lbl = new Label();
            this.Book_Cbx = new Custom_ComboBox();
            this.Book_Btn = new Button();
            this.Summary_Lbl = new Label();
            this.Summary_Txt = new Custom_TextBox();
            this.Summary_Btn = new Button();
            this.Quotation_Dgv = new Custom_DataGridView();
            this.Id = new DataGridViewTextBoxColumn();
            this.Page = new DataGridViewTextBoxColumn();
            this.Summary = new DataGridViewTextBoxColumn();
            this.Book = new DataGridViewTextBoxColumn();
            this.BookId = new DataGridViewTextBoxColumn();
            this.Main_Table.SuspendLayout();
            ((ISupportInitialize)(this.Quotation_Dgv)).BeginInit();
            this.Filter_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 1;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Filter_Table, 0, 0);
            this.Main_Table.Controls.Add(this.Quotation_Dgv, 0, 1);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            //
            //Filter_Table
            //
            this.Filter_Table.BackColor = Color.Transparent;
            this.Filter_Table.ColumnCount = 11;
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Filter_Table.RowCount = 1;
            this.Filter_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Filter_Table.Controls.Add(this.Book_Lbl, 1, 0);
            this.Filter_Table.Controls.Add(this.Book_Cbx, 2, 0);
            this.Filter_Table.Controls.Add(this.Book_Btn, 3, 0);
            this.Filter_Table.Controls.Add(this.Page_Lbl, 4, 0);
            this.Filter_Table.Controls.Add(this.Page_Num, 5, 0);
            this.Filter_Table.Controls.Add(this.Page_Btn, 6, 0);       
            this.Filter_Table.Controls.Add(this.Summary_Lbl, 7, 0);
            this.Filter_Table.Controls.Add(this.Summary_Txt, 8, 0);
            this.Filter_Table.Controls.Add(this.Summary_Btn, 9, 0);
            this.Filter_Table.Dock = DockStyle.Fill;
            this.Filter_Table.Name = "Filter_Table";
            this.Filter_Table.TabIndex = 0;
            // 
            // Book_Lbl
            // 
            this.Book_Lbl.Dock = DockStyle.Fill;
            this.Book_Lbl.BackColor = Color.Transparent;
            this.Book_Lbl.Name = "Book_Lbl";
            this.Book_Lbl.Text = "Kitap:";
            this.Book_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Book_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Book_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Book_Cbx
            // 
            this.Book_Cbx.Name = "Book_Cbx";
            this.Book_Cbx.Dock = DockStyle.Fill;
            this.Book_Cbx.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Book_Cbx.BackColor = Color.FromArgb(64, 69, 76);
            this.Book_Cbx.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //Book_Btn
            //
            this.Book_Btn.Dock = DockStyle.Fill;
            this.Book_Btn.Name = "Book_Btn";
            this.Book_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Book_Btn.FlatAppearance.BorderSize = 1;
            this.Book_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Book_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Book_Btn.BackgroundImage = Properties.Resources.Filter2_Image;
            this.Book_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            this.Book_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_Btn.UseVisualStyleBackColor = true;
            this.Book_Btn.Click += Book_Btn_Click;
            // 
            // Page_Lbl
            // 
            this.Page_Lbl.Dock = DockStyle.Fill;
            this.Page_Lbl.BackColor = Color.Transparent;
            this.Page_Lbl.Name = "Page_Lbl";
            this.Page_Lbl.Text = "Sayfa:";
            this.Page_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Page_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Page_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Page_Num
            // 
            this.Page_Num.Name = "Page_Num";
            this.Page_Num.Dock = DockStyle.Fill;
            this.Page_Num.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular);
            this.Page_Num.BackColor = Color.FromArgb(64, 69, 76);
            this.Page_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.Page_Num.Minimum = 0;
            this.Page_Num.Maximum = 5000;
            //
            //Page_Btn
            //
            this.Page_Btn.Dock = DockStyle.Fill;
            this.Page_Btn.Name = "Page_Btn";
            this.Page_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Page_Btn.FlatAppearance.BorderSize = 1;
            this.Page_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Page_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Page_Btn.BackgroundImage = Properties.Resources.Filter2_Image;
            this.Page_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            this.Page_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Page_Btn.UseVisualStyleBackColor = true;
            this.Page_Btn.Click += Page_Btn_Click;          
            // 
            // Summary_Lbl
            // 
            this.Summary_Lbl.Dock = DockStyle.Fill;
            this.Summary_Lbl.BackColor = Color.Transparent;
            this.Summary_Lbl.Name = "Summary_Lbl";
            this.Summary_Lbl.Text = "Alıntı Özeti:";
            this.Summary_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Summary_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Summary_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Summary_Txt
            // 
            this.Summary_Txt.Name = "Summary_Txt";
            this.Summary_Txt.Dock = DockStyle.Fill;
            this.Summary_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Summary_Txt.AutoSize = true;
            this.Summary_Txt.TextAlign = HorizontalAlignment.Left;
            this.Summary_Txt.BorderColor = Color.FromArgb(202, 43, 77);
            this.Summary_Txt.BorderFocusColor = Color.FromArgb(135, 29, 52);
            this.Summary_Txt.UnderlinedStyle = true;
            this.Summary_Txt.TabIndex = 0;
            this.Summary_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Summary_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //Summary_Btn
            //
            this.Summary_Btn.Dock = DockStyle.Fill;
            this.Summary_Btn.Name = "Summary_Btn";
            this.Summary_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Summary_Btn.FlatAppearance.BorderSize = 1;
            this.Summary_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Summary_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Summary_Btn.BackgroundImage = Properties.Resources.Filter2_Image;
            this.Summary_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            this.Summary_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Summary_Btn.UseVisualStyleBackColor = true;
            this.Summary_Btn.Click += Summary_Btn_Click;
            // 
            // Quotation_Dgv
            // 
            this.Quotation_Dgv.Dock = DockStyle.Fill;
            this.Quotation_Dgv.Name = "Quotation_Dgv";
            this.Quotation_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Book,
            this.Page,
            this.Summary,     
            this.BookId});
            // 
            //Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            //Book
            // 
            this.Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book.DataPropertyName = "Book";
            this.Book.HeaderText = "KİTAP";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            // 
            //Page
            // 
            this.Page.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Page.DataPropertyName = "Page";
            this.Page.HeaderText = "SAYFA";
            this.Page.Name = "Page";
            this.Page.ReadOnly = true;
            // 
            //Summary
            // 
            this.Summary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Summary.DataPropertyName = "Summary";
            this.Summary.HeaderText = "ALINTI ÖZETİ";
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            // 
            //BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "KİTAP NO";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            // 
            //QuotationFilterControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(800, 600);
            this.Load += QuotationFilterControl_Load;
            this.Controls.Add(this.Main_Table);
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Filter_Table.ResumeLayout(false);
            this.Filter_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quotation_Dgv)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private TableLayoutPanel Filter_Table;
        private Label Page_Lbl;
        private NumericUpDown Page_Num;
        private Button Page_Btn;
        private Label Summary_Lbl;
        private Custom_TextBox Summary_Txt;
        private Button Summary_Btn;
        private Label Book_Lbl;
        private Custom_ComboBox Book_Cbx;
        private Button Book_Btn;
        private Custom_DataGridView Quotation_Dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Page;
        private DataGridViewTextBoxColumn Summary;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn Book;
    }
}