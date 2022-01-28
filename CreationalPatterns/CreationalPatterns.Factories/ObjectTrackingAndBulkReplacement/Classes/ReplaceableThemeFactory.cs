using ObjectTrackingAndBulkReplacement.Interfaces;
using System;
using System.Collections.Generic;

namespace ObjectTrackingAndBulkReplacement.Classes
{
    public class ReplaceableThemeFactory
    {
        private readonly List<WeakReference<Ref<ITheme>>> themes = new();

        private ITheme CreateThemeImpl(bool dark)
        {
            return dark ? new DarkTheme() : new LightTheme();
        }

        public Ref<ITheme> CreateTheme(bool dark)
        {
            Ref<ITheme> reference = new Ref<ITheme>(CreateThemeImpl(dark));
            themes.Add(new(reference));
            return reference;
        }

        public void ReplaceTheme(bool dark)
        {
            foreach (WeakReference<Ref<ITheme>> weakReference in themes)
            {
                if (weakReference.TryGetTarget(out var reference))
                {
                    reference.Value = CreateThemeImpl(dark);
                }
            }
        }
    }
}
