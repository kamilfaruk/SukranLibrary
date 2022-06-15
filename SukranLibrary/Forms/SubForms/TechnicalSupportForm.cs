/* Coder by KFY */
using System;
using SukranLibrary.Tools;
using System.Windows.Forms;
using SukranLibrary.Components;
using SukranLibrary.Components.Notification;

namespace SukranLibrary.Forms.SubForms
{
    public partial class TechnicalSupportForm : Form
    {
        public TechnicalSupportForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("TechnicalSupportForm.TechnicalSupportForm -> ", _ex);
            }
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("TechnicalSupportForm.Close_Btn_Click -> ", _ex);
            }
        }
        private void Send_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (NotificationManager _notificationManager = new NotificationManager())
                {
                    string _message = Message_Txt.Text;
                    string _subject = Subject_Txt.Texts;
                    if (_message != "" && _subject != "")
                    {
                        using (GMail _gmail = new GMail())
                        {

                            if (_gmail.SendMail(Constants.TechnicSupportMail, Constants.TechnicSupportPassword, "kamilfarukyel94@gmail.com", _subject, _message))
                            {
                                _notificationManager.Notification_NonController("Destek talebiniz iletildi.", NotificationType.Success);
                            }
                            else
                            {
                                _notificationManager.Notification_NonController("Destek talebiniz iletilemedi.", NotificationType.Error);
                            }
                        }
                        Info_Lbl.Visible = true;
                    }
                    else
                    {
                        _notificationManager.Notification_NonController("Lütfen tüm alanları doldurunuz.", NotificationType.Info);
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("TechnicalSupportForm.Send_Btn_Click -> ", _ex);
            }
        }
    }
}
