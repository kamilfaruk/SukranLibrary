using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using SukranLibrary.Components;
using System;

namespace SukranLibrary.Controls
{
    partial class QuotationCrudControl
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
            this.Quotation_Dgv = new Custom_DataGridView();
            this.Id = new DataGridViewTextBoxColumn();
            this.Page = new DataGridViewTextBoxColumn();
            this.Summary = new DataGridViewTextBoxColumn();
            this.Book = new DataGridViewTextBoxColumn();
            this.BookId = new DataGridViewTextBoxColumn();
            this.Manager_Table = new TableLayoutPanel();
            this.Page_Lbl = new Label();
            this.Page_Num = new NumericUpDown();
            this.Summary_Lbl = new Label();
            this.Summary_Txt = new Custom_TextBox();
            this.Save_Btn = new Button();
            this.Delete_Btn = new Button();
            this.Cancel_Btn = new Button();
            this.Main_Table.SuspendLayout();
            ((ISupportInitialize)(this.Quotation_Dgv)).BeginInit();
            this.Manager_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Quotation_Dgv, 0, 0);
            this.Main_Table.Controls.Add(this.Manager_Table, 1, 0);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            // Quotation_Dgv
            // 
            this.Quotation_Dgv.Dock = DockStyle.Fill;
            this.Quotation_Dgv.Name = "Quotation_Dgv";
            this.Quotation_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Page,
            this.Summary,
            this.Book,
            this.BookId});
            this.Quotation_Dgv.DoubleClick += new System.EventHandler(this.Quotation_Dgv_DoubleClick);
            // 
            //Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            //Book
            // 
            this.Book.DataPropertyName = "Book";
            this.Book.HeaderText = "KİTAP";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Visible = false;
            // 
            //BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "KİTAP NO";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            //
            //Manager_Table
            //
            this.Manager_Table.BackColor = Color.Transparent;
            this.Manager_Table.ColumnCount = 4;
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Manager_Table.RowCount = 4;
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Manager_Table.Controls.Add(this.Page_Lbl, 0, 0);
            this.Manager_Table.Controls.Add(this.Page_Num, 2, 0);
            this.Manager_Table.SetColumnSpan(this.Page_Num, 2);
            this.Manager_Table.Controls.Add(this.Summary_Lbl, 0, 1);
            this.Manager_Table.Controls.Add(this.Summary_Txt, 2, 1);
            this.Manager_Table.SetColumnSpan(this.Summary_Txt, 2);
            this.Manager_Table.Controls.Add(this.Save_Btn, 0, 2);
            this.Manager_Table.Controls.Add(this.Delete_Btn, 1, 2);
            this.Manager_Table.SetColumnSpan(this.Delete_Btn, 2);
            this.Manager_Table.Controls.Add(this.Cancel_Btn, 3, 2);
            this.Manager_Table.Dock = DockStyle.Fill;
            this.Manager_Table.Name = "Manager_Table";
            this.Manager_Table.TabIndex = 0;
            // 
            // Page_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Page_Lbl, 2);
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
            this.Page_Num.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Page_Num.BackColor = Color.FromArgb(64, 69, 76);
            this.Page_Num.ForeColor = Color.FromArgb(192, 192, 192);
            this.Page_Num.Minimum = 0;
            this.Page_Num.Maximum = 5000;
            // 
            //Summary_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Summary_Lbl, 2);
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
            //Save_Btn
            // 
            this.Save_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Save_Btn.FlatAppearance.BorderSize = 1;
            this.Save_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Save_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Save_Btn.Image = Properties.Resources.Save_Image;
            this.Save_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Save_Btn.Location = new Point(0, 512);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Save_Btn.Size = new Size(229, 45);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "KAYDET";
            this.Save_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Save_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            //Delete_Btn
            // 
            this.Delete_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Delete_Btn.FlatAppearance.BorderSize = 1;
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Delete_Btn.Image = Properties.Resources.Delete_Image;
            this.Delete_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Delete_Btn.Location = new Point(0, 512);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Delete_Btn.Size = new Size(229, 45);
            this.Delete_Btn.TabIndex = 5;
            this.Delete_Btn.Text = "SİL";
            this.Delete_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Delete_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            //Cancel_Btn
            // 
            this.Cancel_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Cancel_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Cancel_Btn.FlatAppearance.BorderSize = 1;
            this.Cancel_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Cancel_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Cancel_Btn.Image = Properties.Resources.Cancel_Image;
            this.Cancel_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Cancel_Btn.Location = new Point(0, 512);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Cancel_Btn.Size = new Size(229, 45);
            this.Cancel_Btn.TabIndex = 5;
            this.Cancel_Btn.Text = "İPTAL";
            this.Cancel_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Cancel_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            //QuotationCrudControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(800, 600);
            this.Load += QuotationCrudControl_Load;
            this.Controls.Add(this.Main_Table);
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Manager_Table.ResumeLayout(false);
            this.Manager_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quotation_Dgv)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Custom_DataGridView Quotation_Dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Page;
        private DataGridViewTextBoxColumn Summary;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn Book;
        private TableLayoutPanel Manager_Table;
        private Label Page_Lbl;
        private NumericUpDown Page_Num;
        private Label Summary_Lbl;
        private Custom_TextBox Summary_Txt;
        private Button Save_Btn;
        private Button Delete_Btn;
        private Button Cancel_Btn;
    }
}