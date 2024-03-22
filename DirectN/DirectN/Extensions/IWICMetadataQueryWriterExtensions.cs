using System;

namespace DirectN
{
    public static class IWICMetadataQueryWriterExtensions
    {
        public static void SetMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name, object value, PropertyType? type = null) => SetMetadataByName(writer?.Object, name, value, type);
        public static void SetMetadataByName(this IWICMetadataQueryWriter writer, string name, object value, PropertyType? type = null)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            using (var pv = new PropVariant(value, type))
            {
                writer.SetMetadataByName(name, pv.Detached).ThrowOnError();
            }
        }

        public static void SetMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name, PropVariant pv) => SetMetadataByName(writer?.Object, name, pv);
        public static void SetMetadataByName(this IWICMetadataQueryWriter writer, string name, PropVariant pv)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (pv == null)
                throw new ArgumentNullException(nameof(pv));

            writer.SetMetadataByName(name, pv.Detached).ThrowOnError();
        }

        public static void RemoveMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name) => RemoveMetadataByName(writer?.Object, name);
        public static void RemoveMetadataByName(this IWICMetadataQueryWriter writer, string name)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            writer.RemoveMetadataByName(name).ThrowOnError();
        }
    }
}
