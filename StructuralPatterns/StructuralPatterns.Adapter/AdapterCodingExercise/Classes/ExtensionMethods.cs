using AdapterCodingExercise.Interfaces;

namespace AdapterCodingExercise.Classes
{
    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }
}
