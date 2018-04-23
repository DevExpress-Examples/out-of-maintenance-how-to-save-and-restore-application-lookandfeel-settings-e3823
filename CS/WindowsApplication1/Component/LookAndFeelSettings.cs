using System;
using System.Collections.Generic;
using DevExpress.LookAndFeel;

namespace WindowsApplication1
{
    [Serializable]
    public class LookAndFeelSettings
    {
        public string SkinName;
        public LookAndFeelStyle Style;
        public bool UseWindowsXPTheme;

        public LookAndFeelSettings()
        {

        }
    }
}
