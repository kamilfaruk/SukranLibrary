/* Coder by KFY */
using System;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Collections.Generic;
using SukranLibrary.Models;
using System.Runtime.InteropServices;
using SukranLibrary.Components;
using SukranLibrary.Tools;
using System.Security.Principal;
using System.Security.AccessControl;
using System.Threading;
using SukranLibrary.Database;
using SukranLibrary.Forms.SubForms;

namespace SukranLibrary.Forms
{
    public partial class MainForm : Form
    {
        //https://coolors.co/1d2227-2f343a-40454c-345b6d-109ad0-935053-e65a5a-2d7344-19a03c      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public bool NotificationOpenControl = false;
        public DateTime NotificationOpenControlStartDate;
        public MainForm()
        {
            try
            {
                InitializeComponent();
                SetStartup(false);
                LoginForm _loginForm = new LoginForm();
                _loginForm.ShowDialog();
                if (_loginForm.Logined)
                {
                    GetUserMenu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.MainForm -> ", _ex);
            }
        }
        private void SetStartup(bool _set)
        {
            try
            {
                using (var _registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    if (_set)
                    {
                        if (_registryKey.GetValue("SukranLibrary") == null)
                        {
                            _registryKey.SetValue("SukranLibrary", Application.ExecutablePath.ToString());
                        }
                    }
                    else
                    {
                        if (_registryKey.GetValue("SukranLibrary") != null)
                        {
                            _registryKey.DeleteValue("SukranLibrary");
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.SetStartup -> ", _ex);
            }
        }
        private void GetUserMenu()
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    User _user = _dbManager.GetUser(Constants.CurrentUserId);
                    Logout_Btn.Text = _user.Name + " " + _user.Surname;
                    this.Menu_Pnl.Controls.Clear();
                    this.Menu_Pnl.Controls.Add(this.Shift_Table);
                    this.Menu_Pnl.Controls.Add(this.Logout_Btn);
                    this.Menu_Pnl.Controls.Add(this.SlideMenu_Btn);
                    if (_user.Authority == "KULLANICI")
                    {
                        this.Book_Pbx.Location = new Point(0, 98);
                        this.Book_Btn.Location = new Point(0, 98);
                        this.Author_Pbx.Location = new Point(0, 155);
                        this.Author_Btn.Location = new Point(0, 155);
                        this.Filter_Pbx.Location = new Point(0, 212);
                        this.Filter_Btn.Location = new Point(0, 212);
                        this.TechnicalSupport_Pbx.Location = new Point(0, 268);
                        this.TechnicalSupport_Btn.Location = new Point(0, 268);
                        //
                        this.Menu_Pnl.Controls.Add(this.Book_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Book_Btn);
                        this.Menu_Pnl.Controls.Add(this.Author_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Author_Btn);
                        this.Menu_Pnl.Controls.Add(this.Filter_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Filter_Btn);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Pbx);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Btn);
                    }
                    else if (_user.Authority == "YÖNETİCİ")
                    {
                        this.Book_Pbx.Location = new Point(0, 98);
                        this.Book_Btn.Location = new Point(0, 98);
                        this.Author_Pbx.Location = new Point(0, 155);
                        this.Author_Btn.Location = new Point(0, 155);
                        this.Filter_Pbx.Location = new Point(0, 212);
                        this.Filter_Btn.Location = new Point(0, 212);
                        this.Settings_Pbx.Location = new Point(0, 268);
                        this.Settings_Btn.Location = new Point(0, 268);
                        this.TechnicalSupport_Pbx.Location = new Point(0, 325);
                        this.TechnicalSupport_Btn.Location = new Point(0, 325);
                        //
                        this.Menu_Pnl.Controls.Add(this.Book_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Book_Btn);
                        this.Menu_Pnl.Controls.Add(this.Author_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Author_Btn);
                        this.Menu_Pnl.Controls.Add(this.Filter_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Filter_Btn);
                        this.Menu_Pnl.Controls.Add(this.Settings_Pbx);
                        this.Menu_Pnl.Controls.Add(this.Settings_Btn);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Pbx);
                        this.Menu_Pnl.Controls.Add(this.TechnicalSupport_Btn);
                    }
                    else
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Ne yazıkki giriş yapmış olduğunuz kullanıcıya ait yetkilendirmelerde hata mevcut. Lütfen farklı bir kullanıcı hesabı ile giriş yapmayı deneyiniz.";
                            string _title = "KULLANICI YETKİ HATASI";
                            _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                            Environment.Exit(0);
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.GetUserMenu -> ", _ex);
            }
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    ShowIcon = false;
                    Main_NotifiyIcon.Visible = true;
                    Main_NotifiyIcon.ShowBalloonTip(700);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.MainForm_Resize -> ", _ex);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                OpenFormInPanel(new LogoForm());
                Main_NotifiyIcon.BalloonTipText = "Uygulama Arka Plana Alındı";
                Main_NotifiyIcon.BalloonTipTitle = "Şükranın Kütüphanesi";
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.MainForm_Load -> ", _ex);
            }
        }
        private void Main_NotifiyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Main_NotifiyIcon.Visible = false;
                WindowState = FormWindowState.Normal;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Main_NotifiyIcon_MouseDoubleClick -> ", _ex);
            }
        }

        #region Title Buttons
        private void Title_Pnl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Title_Pnl_MouseDown -> ", _ex);
            }
        }
        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Minimize_Btn_Click -> ", _ex);
            }
        }
        private void Restart_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Şükranın Kütüphanesini yeniden başlatmak istediğinize emin misiniz?";
                    string _title = "RESET ONAYI";
                    DialogResult _ans = _msgBox.Show(_message, _title, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Restart_Btn_Click -> ", _ex);
            }
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Şükranın Kütüphanesinden çıkış yapmak istediğinize emin misiniz?";
                    string _title = "KAPATMA ONAYI";
                    DialogResult _ans = _msgBox.Show(_message, _title, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        Application.Exit();
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Restart_Btn_Click -> ", _ex);
            }
        }
        #endregion

        #region Menu Buttons
        private void SlideMenu_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Menu_Pnl.Width == 172)
                {
                    this.CollapseMenu_Tmr.Start();
                    this.SlideMenu_Btn.Image = Properties.Resources.Menu2_Image;
                }
                else if (Menu_Pnl.Width == 55)
                {
                    this.ExpandMenu_Tmr.Start();
                    this.SlideMenu_Btn.Image = Properties.Resources.Menu_Image;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.SlideMenu_Btn_Click -> ", _ex);
            }
        }
        private void ButtonsBackColorTransparent()
        {
            try
            {
                Book_Btn.BackColor = Color.Transparent;
                Author_Btn.BackColor = Color.Transparent;
                Filter_Btn.BackColor = Color.Transparent;
                Settings_Btn.BackColor = Color.Transparent;
                TechnicalSupport_Btn.BackColor = Color.Transparent;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.ButtonsBackColorTransparent -> ", _ex);
            }
        }
        private void OpenFormInPanel(object _form)
        {
            try
            {
                if (this.FormContainer_Pnl.Controls.Count > 0)
                    this.FormContainer_Pnl.Controls.RemoveAt(0);
                Form _currentForm = _form as Form;
                _currentForm.TopLevel = false;
                _currentForm.FormBorderStyle = FormBorderStyle.None;
                _currentForm.Dock = DockStyle.Fill;
                this.FormContainer_Pnl.Controls.Add(_currentForm);
                this.FormContainer_Pnl.Tag = _currentForm;
                _currentForm.Show();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.OpenFormInPanel -> ", _ex);
            }
        }
        private void ShowLogoFormWhenClosingForms(object sender, FormClosedEventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                OpenFormInPanel(new LogoForm());
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.ShowLogoFormWhenClosingForms -> ", _ex);
            }
        }
        private void Book_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                Book_Btn.BackColor = Color.FromArgb(47, 52, 58);
                BookForm _form = new BookForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Book_Btn_Click -> ", _ex);
            }
        }
        private void Author_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                Author_Btn.BackColor = Color.FromArgb(47, 52, 58);
                AuthorForm _form = new AuthorForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Author_Btn_Click -> ", _ex);
            }
        }
        private void Filter_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                Filter_Btn.BackColor = Color.FromArgb(47, 52, 58);
                FilterForm _form = new FilterForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Filter_Btn_Click -> ", _ex);
            }
        }
        private void Settings_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                Settings_Btn.BackColor = Color.FromArgb(47, 52, 58);
                SettingsForm _form = new SettingsForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Settings_Btn_Click -> ", _ex);
            }
        }
        private void TechnicalSupport_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsBackColorTransparent();
                TechnicalSupport_Btn.BackColor = Color.FromArgb(47, 52, 58);
                TechnicalSupportForm _form = new TechnicalSupportForm();
                _form.FormClosed += new FormClosedEventHandler(ShowLogoFormWhenClosingForms);
                OpenFormInPanel(_form);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.TechnicalSupport_Btn_Click -> ", _ex);
            }
        }
        private void Notification_TglBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Constants.NotificationOpen = Notification_TglBtn.Checked;
                if (Constants.NotificationOpen)
                {
                    NotificationOpenControl = false;
                }
                else
                {
                    NotificationOpenControlStartDate = DateTime.Now;
                    NotificationOpenControl = true;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Shift_TglBtn_CheckedChanged -> ", _ex);
            }
        }
        private void Logout_Btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Hide();
                Constants.CurrentUserId = 0;
                LoginForm _loginForm = new LoginForm();
                _loginForm.ShowDialog();
                _loginForm.TopMost = true;
                if (_loginForm.Logined)
                {
                    this.Show();
                    GetUserMenu();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.Logout_Pbx_Click -> ", _ex);
            }
        }
        #endregion

        #region Timer Ticks
        private void DateTime_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                Date_Lbl.Text = DateTime.Now.ToLongDateString();
                Hour_Lbl.Text = DateTime.Now.ToString("HH:mm:ss");
                if (NotificationOpenControl)
                {
                    TimeSpan _notificationClosedTimespan = DateTime.Now - NotificationOpenControlStartDate;
                    if (_notificationClosedTimespan.TotalSeconds > 60)
                    {
                        DateTime_Tmr.Stop();
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Bildirim gönderim sisteminiz uzun süredir kapalı. Şimdi tekrar açmak ister misiniz?";
                            string _title = "BİLDİRİM UYARISI";
                            DialogResult _ans = _msgBox.Show(_message, _title, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                            if (_ans == DialogResult.Yes)
                            {
                                Notification_TglBtn.Checked = true;
                            }
                            else
                            {
                                NotificationOpenControlStartDate = DateTime.Now;
                            }
                        }
                        DateTime_Tmr.Start();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.DateTime_Tmr_Tick -> ", _ex);
            }
        }
        private void ExpandMenu_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Menu_Pnl.Width >= 172)
                {
                    this.ExpandMenu_Tmr.Stop();
                }
                else
                {
                    Menu_Pnl.Width = Menu_Pnl.Width + 9;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.ExpandMenu_Tmr_Tick -> ", _ex);
            }
        }
        private void CollapseMenu_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Menu_Pnl.Width <= 55)
                {
                    this.CollapseMenu_Tmr.Stop();
                }
                else
                {
                    Menu_Pnl.Width = Menu_Pnl.Width - 9;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MainForm.CollapseMenu_Tmr_Tick -> ", _ex);
            }
        }
        #endregion

        #region Invoke Functions
        delegate void SetSystemStatusPanelCallback(Control _control);
        private void SetSystemStatusPanel(Control _control)
        {
            if (this.SystemStatus_Pnl.InvokeRequired)
            {
                SetSystemStatusPanelCallback d = new SetSystemStatusPanelCallback(SetSystemStatusPanel);
                this.Invoke(d, new object[] { _control });
            }
            else
            {
                this.SystemStatus_Pnl.Controls.Clear();
                this.SystemStatus_Pnl.Controls.Add(_control);
            }
        }
        #endregion
    }
}
