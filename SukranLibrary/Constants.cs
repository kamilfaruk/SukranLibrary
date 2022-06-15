﻿/* Coder by KFY */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SukranLibrary.Packets;
using SukranLibrary.Models;

namespace SukranLibrary
{
    class Constants
    {
        //Constants
        public static string TechnicSupportMail = "sukraninkutuphanesi@gmail.com";
        public static string TechnicSupportPassword = "Ky010919";
        public static string LogoFormMessage = "Kütüphane Takip Uygulaması"; //"Şükran ♥ Kamil"
        public static string LogoFormImage = "Logo_Image.png";

        //Paths
        public static string DB_ConnectionString = "SukranLibraryDB.sqlite";
        public static string TempDirectory = "Temp";
        public static string LogDirectory = @"Temp\Logs";
        public static string LogPath = @"Temp\Logs\SystemLog.txt";
        public static string MailAttechmentLogPath = @"Temp\Logs\Mail\SystemLog.txt";
        public static string MailTextLogPath = @"Temp\Logs\Mail\Mail.txt";
        public static string ConstantsJson = @"Temp\Constants.json";
        public static string LicenseLic = @"Temp\License.lic";
        //Current States
        public static int CurrentUserId = 0;
        public static bool NotificationOpen = true;
        public static void ExportConstantsJson()
        {
            try
            {
                JSonPacket _constantJson = new JSonPacket(@"{" +
                    @"""LogoFormMessage"":""" + LogoFormMessage +
                    @""",""LogoFormImage"":""" + LogoFormImage +
                    @""",""TechnicSupportMail"":""" + TechnicSupportMail +
                    @""",""TechnicSupportPassword"":""" + TechnicSupportPassword +
                    @""",""NotificationOpen"":""" + NotificationOpen.ToString() +
                    @"""}");
                JSonPacket.WriteJsonToFile(_constantJson, Application.StartupPath.ToString() + "\\" + ConstantsJson);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("Constants.RefreshJson -> ", _ex);
            }
        }
    }
}

