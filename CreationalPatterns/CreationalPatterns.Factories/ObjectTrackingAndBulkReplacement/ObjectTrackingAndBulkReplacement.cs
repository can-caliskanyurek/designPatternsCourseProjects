using ObjectTrackingAndBulkReplacement.Classes;
using ObjectTrackingAndBulkReplacement.Interfaces;
using System;

namespace ObjectTrackingAndBulkReplacement
{
    public class ObjectTrackingAndBulkReplacement
    {
        static void Main(string[] args)
        {
            TrackingThemeFactory factory = new TrackingThemeFactory();
            factory.CreateTheme(false);
            factory.CreateTheme(true);
            Console.WriteLine(factory.Info);

            ReplaceableThemeFactory factory2 = new ReplaceableThemeFactory();
            Ref<ITheme> magicTheme = factory2.CreateTheme(true);
            Console.WriteLine(magicTheme.Value.BgrColor);
            factory2.ReplaceTheme(false);
            Console.WriteLine(magicTheme.Value.BgrColor);
        }
    }
}
