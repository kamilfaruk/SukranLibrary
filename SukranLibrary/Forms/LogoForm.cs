/* Coder by KFY */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace SukranLibrary.Forms
{
    public partial class LogoForm : Form
    {
        public LogoForm()
        {
            try
            {
                InitializeComponent();
                string _logoImagePath = Application.StartupPath.ToString() + "\\" + Constants.TempDirectory + "\\" + Constants.LogoFormImage;
                if (File.Exists(_logoImagePath))
                {
                    FileStream _stream = File.Open(_logoImagePath, FileMode.Open, FileAccess.Read);
                    Image _logoImage = Image.FromStream(_stream);
                    if (_logoImage == null)
                    {
                        _logoImage = Properties.Resources.Logo_Image;
                    }
                    _stream.Close();
                    this.Logo_Pbx.BackgroundImage = _logoImage;
                }
                else
                {
                    this.Logo_Pbx.BackgroundImage = Properties.Resources.Logo_Image;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("LogoForm.LogoForm -> ", _ex);
            }
        }
    }
}
