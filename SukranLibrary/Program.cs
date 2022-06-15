using SukranLibrary.Components;
using SukranLibrary.Database;
using SukranLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SukranLibrary
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Logger.Write("Uygulama Başlatıldı.");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using (WaitForm _waitForm = new WaitForm(InitializeProgram, "Program Başlatılıyor...", Properties.Resources.Initializing_Gif, 12F, ContentAlignment.BottomCenter))
                {
                    _waitForm.ShowDialog();
                }
                using (DBManager _dbManager = new DBManager())
                {
                    List<User> _userList = _dbManager.GetUserList();
                    if (_userList == null && _userList.Count == 0)
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Uygulamanın başlatılabilmesi için veri tabanında en az 1 adet kayıtlı kullanıcı bulunmalıdır. Lütfen uygulamayı kaldırıp tekrar kurunuz.";
                            string _header = "KULLANICI BULUNAMADI";
                            _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                            Environment.Exit(0);
                        }
                    }
                }
                Application.Run(new Forms.MainForm());
                Logger.Write("Uygulama Düzgün Kapatıldı.");
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Uygulama Kritik Bir Hata Nedeni İle Kapandı. Hata: ", _ex);
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Uygulama kritik bir hatadan dolayı kapatıldı.";
                    string _header = "KRİTİK HATA";
                    _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Error);
                }
            }
            finally
            {
                Logger.ExportLog();
            }
        }
        private static void InitializeProgram()
        {
            try
            {
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Program.ConnectOPCServer -> ", _ex);
            }
        }
    }
}
