using System;

namespace DirectN
{
    public class ColorProfileElement
    {
        public ColorProfileElement(int tag, byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            Tag = tag;
            Bytes = bytes;
            Type = bytes.Length >= 4 ? ColorProfile.Get4BytesString(BitConverter.ToInt32(bytes, 0)) : null;
        }

        public int Tag { get; }
        public string TagString => ColorProfile.Get4BytesStringBE(Tag);
        public string Type { get; }
        public byte[] Bytes { get; }

        public override string ToString()
        {
            var s = Conversions.ToHexa(BitConverter.GetBytes(Tag)) + " '" + TagString + "'";
            if (Type != null)
            {
                s += " (" + Type + ")";
            }
            return s;
        }
    }
}
