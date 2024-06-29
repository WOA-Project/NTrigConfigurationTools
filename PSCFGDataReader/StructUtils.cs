using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;

namespace PSCFGDataReader
{
    public static class StructUtils
    {
        public static byte[] FromStructure<T>(this T str)
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];

            IntPtr ptr = IntPtr.Zero;
            try
            {
                ptr = Marshal.AllocHGlobal(size);
                Marshal.StructureToPtr(str, ptr, true);
                Marshal.Copy(ptr, arr, 0, size);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return arr;
        }

        public static T FromBinaryReader<T>(this BinaryReader reader)
        {
            // Read in a byte array
            byte[] bytes = reader.ReadBytes(Marshal.SizeOf(typeof(T)));

            // Pin the managed memory while, copy it out the data, then unpin it
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            T theStructure = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();

            return theStructure;
        }

        public static T Deserialize<T>(this Stream stream)
        {
            T str;
            XmlSerializer serializer = new(typeof(T));
            str = (T)serializer.Deserialize(stream);
            return str;
        }

        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            XmlSerializer xmlSerializer = new(typeof(T));

            using StringWriter stringWriter = new();
            using XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true });
            xmlSerializer.Serialize(xmlWriter, value);
            return stringWriter.ToString();
        }
    }
}
