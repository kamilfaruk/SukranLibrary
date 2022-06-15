using SukranLibrary.Components;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace SukranLibrary.Forms
{
    partial class MainForm
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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            //
            this.Main_Pnl = new Panel();
            this.Title_Pnl = new Panel();
            this.FormTitle_Pbx = new PictureBox();
            this.FormTitle_Lbl = new Label();
            this.Minimize_Btn = new Button();
            this.Restart_Btn = new Button();
            this.Close_Btn = new Button();
            this.FormContainer_Pnl = new Panel();
            this.Menu_Pnl = new Panel();
            this.SlideMenu_Btn = new PictureBox();
            this.Book_Pbx = new PictureBox();
            this.Book_Btn = new Button();
            this.Author_Pbx = new PictureBox();
            this.Author_Btn = new Button();
            this.Filter_Pbx = new PictureBox();
            this.Filter_Btn = new Button();
            this.Settings_Pbx = new PictureBox();
            this.Settings_Btn = new Button();
            this.TechnicalSupport_Pbx = new PictureBox();
            this.TechnicalSupport_Btn = new Button();
            this.Shift_Table = new TableLayoutPanel();
            this.Notification_TglBtn = new Custom_ToggleButton();
            this.Notification_Lbl = new Label();
            this.Logout_Btn = new Button();
            this.Overview_Tbl = new TableLayoutPanel();
            this.SystemStatus_Pnl = new Panel();
            this.Date_Lbl = new Label();
            this.Hour_Lbl = new Label();
            this.ExpandMenu_Tmr = new Timer(this.components);
            this.CollapseMenu_Tmr = new Timer(this.components);
            this.DateTime_Tmr = new Timer(this.components);
            this.Main_NotifiyIcon = new NotifyIcon(this.components);
            //
            this.Main_Pnl.SuspendLayout();
            this.Shift_Table.SuspendLayout();
            this.Overview_Tbl.SuspendLayout();
            this.SystemStatus_Pnl.SuspendLayout();
            this.Menu_Pnl.SuspendLayout();
            ((ISupportInitialize)(this.SlideMenu_Btn)).BeginInit();
            ((ISupportInitialize)(this.TechnicalSupport_Pbx)).BeginInit();
            ((ISupportInitialize)(this.Settings_Pbx)).BeginInit();
            ((ISupportInitialize)(this.Filter_Pbx)).BeginInit();
            ((ISupportInitialize)(this.Author_Pbx)).BeginInit();
            ((ISupportInitialize)(this.Book_Pbx)).BeginInit();
            this.Title_Pnl.SuspendLayout();
            ((ISupportInitialize)(this.FormTitle_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Pnl
            // 
            this.Main_Pnl.BackColor = Color.FromArgb(64, 69, 76);
            this.Main_Pnl.Controls.Add(this.FormContainer_Pnl);
            this.Main_Pnl.Controls.Add(this.Overview_Tbl);
            this.Main_Pnl.Controls.Add(this.Menu_Pnl);
            this.Main_Pnl.Controls.Add(this.Title_Pnl);
            this.Main_Pnl.Dock = DockStyle.Fill;
            this.Main_Pnl.Location = new Point(0, 0);
            this.Main_Pnl.Margin = new Padding(4);
            this.Main_Pnl.Name = "Main_Pnl";
            this.Main_Pnl.Size = new Size(1467, 738);
            this.Main_Pnl.TabIndex = 0;
            #region Title_Pnl
            // 
            // Title_Pnl
            // 
            this.Title_Pnl.BackColor = Color.FromArgb(202, 43, 77);
            this.Title_Pnl.Controls.Add(this.FormTitle_Pbx);
            this.Title_Pnl.Controls.Add(this.FormTitle_Lbl);
            this.Title_Pnl.Controls.Add(this.Minimize_Btn);
            this.Title_Pnl.Controls.Add(this.Restart_Btn);
            this.Title_Pnl.Controls.Add(this.Close_Btn);
            this.Title_Pnl.Dock = DockStyle.Top;
            this.Title_Pnl.Location = new Point(0, 0);
            this.Title_Pnl.Margin = new Padding(4);
            this.Title_Pnl.Name = "Title_Pnl";
            this.Title_Pnl.Size = new Size(1467, 53);
            this.Title_Pnl.TabIndex = 1;
            this.Title_Pnl.MouseDown += new MouseEventHandler(this.Title_Pnl_MouseDown);
            // 
            // FormTitle_Pbx
            // 
            this.FormTitle_Pbx.Image = Properties.Resources.SukranLibrary_Image;
            this.FormTitle_Pbx.Location = new Point(12, 11);
            this.FormTitle_Pbx.Margin = new Padding(4);
            this.FormTitle_Pbx.Name = "FormTitle_Pbx";
            this.FormTitle_Pbx.Size = new Size(37, 34);
            this.FormTitle_Pbx.SizeMode = PictureBoxSizeMode.Zoom;
            this.FormTitle_Pbx.TabIndex = 5;
            this.FormTitle_Pbx.TabStop = false;
            // 
            // FormTitle_Lbl
            // 
            this.FormTitle_Lbl.AutoSize = true;
            this.FormTitle_Lbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle_Lbl.ForeColor = Color.White;
            this.FormTitle_Lbl.Location = new Point(50, 18);
            this.FormTitle_Lbl.Margin = new Padding(4, 0, 4, 0);
            this.FormTitle_Lbl.Name = "FormTitle_Lbl";
            this.FormTitle_Lbl.Size = new Size(107, 20);
            this.FormTitle_Lbl.TabIndex = 4;
            this.FormTitle_Lbl.Text = "SÜKRANIN KÜTÜPHANESİ";
            // 
            // Minimize_Btn
            // 
            this.Minimize_Btn.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.Minimize_Btn.Cursor = Cursors.Hand;
            this.Minimize_Btn.FlatAppearance.BorderSize = 0;
            this.Minimize_Btn.FlatStyle = FlatStyle.Flat;
            this.Minimize_Btn.Image = Properties.Resources.Minimize_Image;
            this.Minimize_Btn.Location = new Point(1334, 0);
            this.Minimize_Btn.Margin = new Padding(4);
            this.Minimize_Btn.Name = "Minimize_Btn";
            this.Minimize_Btn.Size = new Size(57, 53);
            this.Minimize_Btn.TabIndex = 2;
            this.Minimize_Btn.UseVisualStyleBackColor = true;
            this.Minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            // 
            // Close_Btn
            // 
            this.Close_Btn.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.Close_Btn.Cursor = Cursors.Hand;
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatStyle = FlatStyle.Flat;
            this.Close_Btn.Image = Properties.Resources.Close_Image;
            this.Close_Btn.Location = new Point(1391, 0);
            this.Close_Btn.Margin = new Padding(4);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new Size(57, 53);
            this.Close_Btn.TabIndex = 2;
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Restart_Btn
            // 
            this.Restart_Btn.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.Restart_Btn.Cursor = Cursors.Hand;
            this.Restart_Btn.FlatAppearance.BorderSize = 0;
            this.Restart_Btn.FlatStyle = FlatStyle.Flat;
            this.Restart_Btn.Image = Properties.Resources.Restart_Image;
            this.Restart_Btn.Location = new Point(1277, 0);
            this.Restart_Btn.Margin = new Padding(4);
            this.Restart_Btn.Name = "Restart_Btn";
            this.Restart_Btn.Size = new Size(57, 53);
            this.Restart_Btn.TabIndex = 2;
            this.Restart_Btn.UseVisualStyleBackColor = true;
            this.Restart_Btn.Click += new System.EventHandler(this.Restart_Btn_Click);
            #endregion
            // 
            // FormContainer_Pnl
            // 
            this.FormContainer_Pnl.BackColor = Color.FromArgb(64, 69, 76);
            this.FormContainer_Pnl.Dock = DockStyle.Fill;
            this.FormContainer_Pnl.Location = new Point(307, 53);
            this.FormContainer_Pnl.Margin = new Padding(4);
            this.FormContainer_Pnl.Name = "FormContainer_Pnl";
            this.FormContainer_Pnl.Size = new Size(1160, 562);
            this.FormContainer_Pnl.TabIndex = 6;
            #region Menu_Pnl
            // 
            // Menu_Pnl
            // 
            this.Menu_Pnl.BackColor = Color.FromArgb(29, 34, 39);
            this.Menu_Pnl.Controls.Add(this.SlideMenu_Btn);
            this.Menu_Pnl.Controls.Add(this.Shift_Table);
            this.Menu_Pnl.Controls.Add(this.Logout_Btn);
            this.Menu_Pnl.Dock = DockStyle.Left;
            this.Menu_Pnl.Location = new Point(0, 53);
            this.Menu_Pnl.Margin = new Padding(4);
            this.Menu_Pnl.Name = "Menu_Pnl";
            this.Menu_Pnl.Size = new Size(230, 685);
            this.Menu_Pnl.TabIndex = 2;
            // 
            // SlideMenu_Btn
            // 
            this.SlideMenu_Btn.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.SlideMenu_Btn.Cursor = Cursors.Hand;
            this.SlideMenu_Btn.Image = Properties.Resources.Menu_Image;
            this.SlideMenu_Btn.Location = new Point(164, 2);
            this.SlideMenu_Btn.Margin = new Padding(4);
            this.SlideMenu_Btn.Name = "SlideMenu_Btn";
            this.SlideMenu_Btn.Size = new Size(57, 46);
            this.SlideMenu_Btn.SizeMode = PictureBoxSizeMode.CenterImage;
            this.SlideMenu_Btn.TabIndex = 12;
            this.SlideMenu_Btn.TabStop = false;
            this.SlideMenu_Btn.Click += new System.EventHandler(this.SlideMenu_Btn_Click);
            /*
             * 98
             * 155
             * 212
             * 268
             * 325
             * 382
             */
            // 
            // Book_Pbx
            // 
            this.Book_Pbx.BackColor = Color.FromArgb(202, 43, 77);
            this.Book_Pbx.Location = new Point(0, 98);
            this.Book_Pbx.Margin = new Padding(4);
            this.Book_Pbx.Name = "Book_Pbx";
            this.Book_Pbx.Size = new Size(3, 49);
            this.Book_Pbx.TabIndex = 1;
            this.Book_Pbx.TabStop = false;
            // 
            // Book_Btn
            // 
            this.Book_Btn.Cursor = Cursors.Default;
            this.Book_Btn.FlatAppearance.BorderSize = 0;
            this.Book_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 69, 76);
            this.Book_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 45, 53);
            this.Book_Btn.FlatStyle = FlatStyle.Flat;
            this.Book_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Book_Btn.ForeColor = Color.Silver;
            this.Book_Btn.Image = Properties.Resources.Book_Image;
            this.Book_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Book_Btn.Location = new Point(0, 98);
            this.Book_Btn.Margin = new Padding(4);
            this.Book_Btn.Name = "Book_Btn";
            this.Book_Btn.Size = new Size(307, 49);
            this.Book_Btn.TabIndex = 0;
            this.Book_Btn.Text = "Kitaplar";
            this.Book_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Book_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.Book_Btn.UseVisualStyleBackColor = true;
            this.Book_Btn.Click += new System.EventHandler(this.Book_Btn_Click);
            // 
            // Author_Pbx
            // 
            this.Author_Pbx.BackColor = Color.FromArgb(202, 43, 77);
            this.Author_Pbx.Location = new Point(0, 155);
            this.Author_Pbx.Margin = new Padding(4);
            this.Author_Pbx.Name = "Author_Pbx";
            this.Author_Pbx.Size = new Size(3, 49);
            this.Author_Pbx.TabIndex = 3;
            this.Author_Pbx.TabStop = false;
            // 
            // Author_Btn
            // 
            this.Author_Btn.Cursor = Cursors.Default;
            this.Author_Btn.FlatAppearance.BorderSize = 0;
            this.Author_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 69, 76);
            this.Author_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 45, 53);
            this.Author_Btn.FlatStyle = FlatStyle.Flat;
            this.Author_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Author_Btn.ForeColor = Color.Silver;
            this.Author_Btn.Image = Properties.Resources.Author_Image;
            this.Author_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Author_Btn.Location = new Point(0, 155);
            this.Author_Btn.Margin = new Padding(4);
            this.Author_Btn.Name = "Author_Btn";
            this.Author_Btn.Size = new Size(307, 49);
            this.Author_Btn.TabIndex = 2;
            this.Author_Btn.Text = "Yazarlar";
            this.Author_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.Author_Btn.UseVisualStyleBackColor = true;
            this.Author_Btn.Click += new System.EventHandler(this.Author_Btn_Click);
            // 
            // Filter_Pbx
            // 
            this.Filter_Pbx.BackColor = Color.FromArgb(202, 43, 77);
            this.Filter_Pbx.Location = new Point(0, 212);
            this.Filter_Pbx.Margin = new Padding(4);
            this.Filter_Pbx.Name = "Filter_Pbx";
            this.Filter_Pbx.Size = new Size(3, 49);
            this.Filter_Pbx.TabIndex = 5;
            this.Filter_Pbx.TabStop = false;
            // 
            // Filter_Btn
            // 
            this.Filter_Btn.Cursor = Cursors.Default;
            this.Filter_Btn.FlatAppearance.BorderSize = 0;
            this.Filter_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 69, 76);
            this.Filter_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 45, 53);
            this.Filter_Btn.FlatStyle = FlatStyle.Flat;
            this.Filter_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Filter_Btn.ForeColor = Color.Silver;
            this.Filter_Btn.Image = Properties.Resources.Filter_Image;
            this.Filter_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Filter_Btn.Location = new Point(0, 212);
            this.Filter_Btn.Margin = new Padding(4);
            this.Filter_Btn.Name = "Filter_Btn";
            this.Filter_Btn.Size = new Size(307, 49);
            this.Filter_Btn.TabIndex = 4;
            this.Filter_Btn.Text = "Filtrele";
            this.Filter_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.Filter_Btn.UseVisualStyleBackColor = true;
            this.Filter_Btn.Click += new System.EventHandler(this.Filter_Btn_Click);
            // 
            // Settings_Pbx
            // 
            this.Settings_Pbx.BackColor = Color.FromArgb(202, 43, 77);
            this.Settings_Pbx.Location = new Point(0, 268);
            this.Settings_Pbx.Margin = new Padding(4);
            this.Settings_Pbx.Name = "Settings_Pbx";
            this.Settings_Pbx.Size = new Size(3, 49);
            this.Settings_Pbx.TabIndex = 7;
            this.Settings_Pbx.TabStop = false;
            // 
            // Settings_Btn
            // 
            this.Settings_Btn.Cursor = Cursors.Default;
            this.Settings_Btn.FlatAppearance.BorderSize = 0;
            this.Settings_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 69, 76);
            this.Settings_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 45, 53);
            this.Settings_Btn.FlatStyle = FlatStyle.Flat;
            this.Settings_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Btn.ForeColor = Color.Silver;
            this.Settings_Btn.Image = Properties.Resources.Settings_Image;
            this.Settings_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Settings_Btn.Location = new Point(0, 268);
            this.Settings_Btn.Margin = new Padding(4);
            this.Settings_Btn.Name = "Settings_Btn";
            this.Settings_Btn.Size = new Size(307, 49);
            this.Settings_Btn.TabIndex = 6;
            this.Settings_Btn.Text = "Ayarlar";
            this.Settings_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.Settings_Btn.UseVisualStyleBackColor = true;
            this.Settings_Btn.Click += new System.EventHandler(this.Settings_Btn_Click);
            // 
            // TechnicalSupport_Pbx
            // 
            this.TechnicalSupport_Pbx.BackColor = Color.FromArgb(202, 43, 77);
            this.TechnicalSupport_Pbx.Location = new Point(0, 325);
            this.TechnicalSupport_Pbx.Margin = new Padding(4);
            this.TechnicalSupport_Pbx.Name = "TechnicalSupport_Pbx";
            this.TechnicalSupport_Pbx.Size = new Size(3, 49);
            this.TechnicalSupport_Pbx.TabIndex = 9;
            this.TechnicalSupport_Pbx.TabStop = false;
            // 
            // TechnicalSupport_Btn
            // 
            this.TechnicalSupport_Btn.Cursor = Cursors.Default;
            this.TechnicalSupport_Btn.FlatAppearance.BorderSize = 0;
            this.TechnicalSupport_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 69, 76);
            this.TechnicalSupport_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 45, 53);
            this.TechnicalSupport_Btn.FlatStyle = FlatStyle.Flat;
            this.TechnicalSupport_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.TechnicalSupport_Btn.ForeColor = Color.Silver;
            this.TechnicalSupport_Btn.Image = Properties.Resources.TechnicalSupport_Image;
            this.TechnicalSupport_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.TechnicalSupport_Btn.Location = new Point(0, 325);
            this.TechnicalSupport_Btn.Margin = new Padding(4);
            this.TechnicalSupport_Btn.Name = "TechnicalSupport_Btn";
            this.TechnicalSupport_Btn.Size = new Size(307, 49);
            this.TechnicalSupport_Btn.TabIndex = 8;
            this.TechnicalSupport_Btn.Text = "Teknik Destek";
            this.TechnicalSupport_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.TechnicalSupport_Btn.UseVisualStyleBackColor = true;
            this.TechnicalSupport_Btn.Click += new System.EventHandler(this.TechnicalSupport_Btn_Click);
            //
            //Shift_Table 
            //
            this.Shift_Table.Name = "Shift_Table";
            this.Shift_Table.BackColor = Color.Transparent;
            this.Shift_Table.ColumnCount = 2;
            this.Shift_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78));
            this.Shift_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Shift_Table.RowCount = 2;
            this.Shift_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Shift_Table.Controls.Add(this.Notification_TglBtn, 0, 0);
            this.Shift_Table.Controls.Add(this.Notification_Lbl, 1, 0);
            this.Shift_Table.Size = new Size(307, 38);
            this.Shift_Table.Location = new Point(0, 590);
            this.Shift_Table.Margin = new Padding(4);
            this.Shift_Table.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            //
            //Notification_TglBtn
            //
            this.Notification_TglBtn.Dock = DockStyle.Fill;
            this.Notification_TglBtn.OnBackColor = Color.FromArgb(132, 141, 154);
            this.Notification_TglBtn.OffBackColor = Color.FromArgb(110, 120, 135);
            this.Notification_TglBtn.OnToggleColor = Color.FromArgb(70, 131, 65);
            this.Notification_TglBtn.OffToggleColor = Color.FromArgb(202, 43, 77);
            this.Notification_TglBtn.Checked = true;
            this.Notification_TglBtn.CheckedChanged += Notification_TglBtn_CheckedChanged;
            //
            //Notification_Lbl
            //
            this.Notification_Lbl.Dock = DockStyle.Fill;
            this.Notification_Lbl.BackColor = Color.Transparent;
            this.Notification_Lbl.Name = "Notification_Lbl";
            this.Notification_Lbl.Text = "Bildirim Gösterimi";
            this.Notification_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notification_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
            this.Notification_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Logout_Btn
            // 
            this.Logout_Btn.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.Logout_Btn.Cursor = Cursors.Hand;
            this.Logout_Btn.Cursor = Cursors.Default;
            this.Logout_Btn.FlatAppearance.BorderSize = 0;
            this.Logout_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 69, 76);
            this.Logout_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 45, 53);
            this.Logout_Btn.FlatStyle = FlatStyle.Flat;
            this.Logout_Btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Btn.ForeColor = Color.Silver;
            this.Logout_Btn.Image = Properties.Resources.Logout_Image;
            this.Logout_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Logout_Btn.Location = new Point(0, 628);
            this.Logout_Btn.Margin = new Padding(4);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.Size = new Size(307, 49);
            this.Logout_Btn.TabIndex = 13;
            this.Logout_Btn.Text = "---";
            this.Logout_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.Logout_Btn.UseVisualStyleBackColor = true;
            this.Logout_Btn.Click += Logout_Btn_Click;
            #endregion
            #region Overview_Tbl
            // 
            // Overview_Tbl
            // 
            this.Overview_Tbl.BackColor = Color.FromArgb(55, 61, 69);
            this.Overview_Tbl.ColumnCount = 2;
            this.Overview_Tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Overview_Tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300));
            this.Overview_Tbl.RowCount = 2;
            this.Overview_Tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.Overview_Tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.Overview_Tbl.Controls.Add(this.SystemStatus_Pnl, 0, 0);
            this.Overview_Tbl.SetRowSpan(this.SystemStatus_Pnl, 2);
            this.Overview_Tbl.Controls.Add(this.Hour_Lbl, 4, 0);
            this.Overview_Tbl.Controls.Add(this.Date_Lbl, 4, 1);
            this.Overview_Tbl.Dock = DockStyle.Bottom;
            this.Overview_Tbl.Location = new Point(307, 615);
            this.Overview_Tbl.Margin = new Padding(4);
            this.Overview_Tbl.Name = "Overview_Tbl";
            this.Overview_Tbl.Size = new Size(1160, 123);
            this.Overview_Tbl.TabIndex = 5;
            //
            //SystemStatus_Pnl
            //
            this.SystemStatus_Pnl.Dock = DockStyle.Fill;
            this.SystemStatus_Pnl.AutoScroll = false;
            this.SystemStatus_Pnl.VerticalScroll.Enabled = false;
            this.SystemStatus_Pnl.VerticalScroll.Visible = false;
            this.SystemStatus_Pnl.HorizontalScroll.Visible = false;
            this.SystemStatus_Pnl.VerticalScroll.Maximum = 0;
            this.SystemStatus_Pnl.HorizontalScroll.Maximum = 0;
            this.SystemStatus_Pnl.AutoScroll = true;
            this.SystemStatus_Pnl.Text = "SystemStatus_Pnl";
            // 
            // Date_Lbl
            // 
            this.Date_Lbl.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.Date_Lbl.AutoSize = true;
            this.Date_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Date_Lbl.ForeColor = Color.White;
            this.Date_Lbl.Location = new Point(811, 87);
            this.Date_Lbl.Margin = new Padding(4, 0, 4, 0);
            this.Date_Lbl.Name = "Date_Lbl";
            this.Date_Lbl.Size = new Size(275, 25);
            this.Date_Lbl.TabIndex = 4;
            this.Date_Lbl.Text = "---";
            this.Date_Lbl.Dock = DockStyle.Fill;
            this.Date_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Hour_Lbl
            // 
            this.Hour_Lbl.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.Hour_Lbl.AutoSize = true;
            this.Hour_Lbl.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular);
            this.Hour_Lbl.ForeColor = Color.LightGray;
            this.Hour_Lbl.Location = new Point(816, 14);
            this.Hour_Lbl.Margin = new Padding(4, 0, 4, 0);
            this.Hour_Lbl.Name = "Hour_Lbl";
            this.Hour_Lbl.Size = new Size(259, 67);
            this.Hour_Lbl.TabIndex = 1;
            this.Hour_Lbl.Text = "---";
            this.Hour_Lbl.Dock = DockStyle.Fill;
            this.Hour_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            #endregion
            #region Timers
            // 
            // ExpandMenu_Tmr
            // 
            this.ExpandMenu_Tmr.Interval = 15;
            this.ExpandMenu_Tmr.Tick += new System.EventHandler(this.ExpandMenu_Tmr_Tick);
            // 
            // CollapseMenu_Tmr
            // 
            this.CollapseMenu_Tmr.Interval = 15;
            this.CollapseMenu_Tmr.Tick += new System.EventHandler(this.CollapseMenu_Tmr_Tick);
            // 
            // DateTime_Tmr
            // 
            this.DateTime_Tmr.Enabled = true;
            this.DateTime_Tmr.Tick += new System.EventHandler(this.DateTime_Tmr_Tick);
            #endregion
            // 
            //Main_NotifiyIcon
            // 
            this.Main_NotifiyIcon.Icon = Properties.Resources.SukranLibrary_Icon;
            this.Main_NotifiyIcon.Text = "ŞÜKRANIN KÜTÜPHANESİ";
            this.Main_NotifiyIcon.Visible = true;
            this.Main_NotifiyIcon.MouseDoubleClick += new MouseEventHandler(this.Main_NotifiyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1500, 800);
            this.Controls.Add(this.Main_Pnl);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.SukranLibrary_Icon;
            //this.TopMost = true;
            this.Margin = new Padding(4);
            this.MinimumSize = new Size(907, 615);
            this.Name = "MainForm";
            this.Text = "ŞÜKRANIN KÜTÜPHANESİ";
            this.Load += MainForm_Load;
            this.Resize += MainForm_Resize;
            this.Main_Pnl.ResumeLayout(false);
            this.Shift_Table.ResumeLayout(false);
            this.Overview_Tbl.ResumeLayout(false);
            this.Overview_Tbl.PerformLayout();
            this.SystemStatus_Pnl.ResumeLayout(false);
            this.SystemStatus_Pnl.PerformLayout();
            this.Menu_Pnl.ResumeLayout(false);
            //
            ((ISupportInitialize)(this.SlideMenu_Btn)).EndInit();
            ((ISupportInitialize)(this.TechnicalSupport_Pbx)).EndInit();
            ((ISupportInitialize)(this.Settings_Pbx)).EndInit();
            ((ISupportInitialize)(this.Filter_Pbx)).EndInit();
            ((ISupportInitialize)(this.Author_Pbx)).EndInit();
            ((ISupportInitialize)(this.Book_Pbx)).EndInit();
            this.Title_Pnl.ResumeLayout(false);
            this.Title_Pnl.PerformLayout();
            ((ISupportInitialize)(this.FormTitle_Pbx)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private Panel Main_Pnl;
        private Panel Title_Pnl;
        private PictureBox FormTitle_Pbx;
        private Label FormTitle_Lbl;
        private Button Minimize_Btn;
        private Button Restart_Btn;
        private Button Close_Btn;
        private Panel FormContainer_Pnl;
        private Panel Menu_Pnl;
        private PictureBox SlideMenu_Btn;
        private PictureBox Book_Pbx;
        private Button Book_Btn;
        private PictureBox Author_Pbx;
        private Button Author_Btn;
        private PictureBox Filter_Pbx;
        private Button Filter_Btn;
        private PictureBox Settings_Pbx;
        private Button Settings_Btn;
        private PictureBox TechnicalSupport_Pbx;
        private Button TechnicalSupport_Btn;
        private TableLayoutPanel Shift_Table;
        private Custom_ToggleButton Notification_TglBtn;
        private Label Notification_Lbl;
        private Button Logout_Btn;
        private TableLayoutPanel Overview_Tbl;
        private Panel SystemStatus_Pnl;
        private Label Date_Lbl;
        private Label Hour_Lbl;
        private Timer ExpandMenu_Tmr;
        private Timer CollapseMenu_Tmr;
        private Timer DateTime_Tmr;
        private NotifyIcon Main_NotifiyIcon;
    }
}