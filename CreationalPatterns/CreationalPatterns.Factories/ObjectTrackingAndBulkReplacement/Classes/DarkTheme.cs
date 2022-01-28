using ObjectTrackingAndBulkReplacement.Interfaces;

namespace ObjectTrackingAndBulkReplacement.Classes
{
    public class DarkTheme : ITheme
    {
        public string TextColor => "white";

        public string BgrColor => "dark gray";
    }
}
