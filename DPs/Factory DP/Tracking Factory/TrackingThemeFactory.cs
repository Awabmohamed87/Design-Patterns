using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Tracking_Factory
{
    internal class TrackingThemeFactory
    {
        private readonly List<WeakReference<ITheme>> themes = new List<WeakReference<ITheme>>();
        public ITheme CreateTheme(bool isDark = false)
        {
            ITheme dt = isDark? new DarkTheme() : new LightTheme();
                themes.Add(new WeakReference<ITheme>(dt));
                return dt;
           
        }
        public string Info { get {
                var sb = new StringBuilder();
                foreach (var theme in themes)
                {
                    if(theme.TryGetTarget(out var them))
                    {
                        sb.Append(them is DarkTheme? "Dark ": "Light ").AppendLine("Theme");
                    }
                }
                return sb.ToString();
            } }
    }
}
