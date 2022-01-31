using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace CopyThroughSerialization.Classes
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);

            object copy = formatter.Deserialize(stream);
            stream.Close();
            return (T) copy;
        }

        public static T DeepCopyXml<T>(this T self)
        {
            using MemoryStream stream = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stream, self);
            stream.Position = 0;

            return (T)serializer.Deserialize(stream);
        }
    }
}
