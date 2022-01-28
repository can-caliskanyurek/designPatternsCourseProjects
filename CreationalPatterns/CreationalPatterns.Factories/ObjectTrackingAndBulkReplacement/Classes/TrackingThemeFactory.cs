using ObjectTrackingAndBulkReplacement.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectTrackingAndBulkReplacement.Classes
{
    public class TrackingThemeFactory
    {
        private readonly List<WeakReference<ITheme>> themes = new();
        public ITheme CreateTheme(bool dark)
        {
            ITheme theme = dark ? new DarkTheme() : new LightTheme();
            themes.Add(new WeakReference<ITheme>(theme));
            return theme;
        }

        public string Info
        {
            get {    
                StringBuilder sb = new StringBuilder();

                foreach (WeakReference<ITheme> reference in themes)
                {
                    if (reference.TryGetTarget(out ITheme theme))
                    {
                        bool dark = theme is DarkTheme;
                        sb.Append(dark ? "Dark" : "Light").AppendLine(" theme");
                    }
                }

                return sb.ToString();
            }
        }
    }
}
