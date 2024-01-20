using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Tracking_Factory
{
    internal class ReplaceableFactory
    {
        public List<WeakReference<Ref<ITheme>>> themes = new List<WeakReference<Ref<ITheme>>> ();
        private ITheme createThemeImpl(bool isDark)
        => isDark ? new DarkTheme() : new LightTheme();
        public Ref<ITheme> CreateTheme(bool isDark)
        {
            var refe = new Ref<ITheme>(createThemeImpl(isDark));
            themes.Add(new WeakReference<Ref<ITheme>>(refe));
            return refe;
        }
        public void Replace(bool isDark)
        {
            foreach (var theme in themes)
            {
                if(theme.TryGetTarget(out var thm))
                {
                    thm.val = createThemeImpl(isDark);
                }
            }
        }
    }
}
