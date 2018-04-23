using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DevExpress.LookAndFeel;
using System.Windows.Forms;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]

    public class LookAndFeelSettingsHelper : Component
    {

        public LookAndFeelSettingsHelper()
        {
            RestoreSettings();
            Application.ApplicationExit += Application_ApplicationExit;
        }

        // Fields...
        private string _FileName;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string FileName
        {
            get { return string.IsNullOrEmpty(_FileName)? "LookAndFeelSettings.save" : _FileName; }
            set
            {
                _FileName = value;
            }
        }
        

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            SaveSettings();
        }


        private void SaveSettings()
        {
            Save(FileName);
        }

        private void RestoreSettings()
        {
            Load(FileName);
        }
        public static void Save(string fileName)
        {
            FileStream stream;
            LookAndFeelSettings settings;
            BinaryFormatter formatter;

            settings = new LookAndFeelSettings();
            settings.SkinName = UserLookAndFeel.Default.SkinName;
            settings.Style = UserLookAndFeel.Default.Style;
            settings.UseWindowsXPTheme = UserLookAndFeel.Default.UseWindowsXPTheme;

            using (stream = new FileStream(fileName, FileMode.Create))
            {
                formatter = new BinaryFormatter();
                formatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
                formatter.Serialize(stream, settings);
            }
        }

        public static void Load(string fileName)
        {
            if (File.Exists(fileName))
                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
                    LookAndFeelSettings settings = formatter.Deserialize(stream) as LookAndFeelSettings;
                    if (settings != null)
                    {
                        UserLookAndFeel.Default.UseWindowsXPTheme = settings.UseWindowsXPTheme;
                        UserLookAndFeel.Default.Style = settings.Style;
                        UserLookAndFeel.Default.SkinName = settings.SkinName;
                    }
                }
        }
    }
}
