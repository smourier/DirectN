using System.Text;

namespace System.Runtime.InteropServices
{
    public static class InteropRuntime
    {
        public static Encoding StringEncoding { get; set; }

        private static readonly byte[] _mask;

        static InteropRuntime()
        {
            _mask = new byte[8];
            var mask = 1;
            for (int i = 0; i < 8; i++)
            {
                _mask[i] = (byte)mask;
                mask *= 2;
            }
        }

        // "The ordering of data declared as bit fields is from low to high bit"
        // https://docs.microsoft.com/en-us/cpp/cpp/cpp-bit-fields?view=vs-2017
        // Note we don't do any check because calling code is supposed to be generated.

        public static sbyte GetSByte(byte[] bytes, int offset, int count) => (sbyte)GetByte(bytes, offset, count);
        public static byte GetByte(byte[] bytes, int offset, int count)
        {
            byte b = 0;
            for (int i = 0; i < count; i++)
            {
                var bitIndex = i + offset;
                var index = bytes.Length - 1 - bitIndex / 8;
                var mask = bitIndex % 8;
                var data = (byte)(bytes[index] & _mask[mask]);
                b |= data;
            }
            return b;
        }

        public static char GetChar(byte[] bytes, int offset, int count) => (char)GetInt16(bytes, offset, count);
        public static short GetInt16(byte[] bytes, int offset, int count) => (short)GetUInt16(bytes, offset, count);
        public static ushort GetUInt16(byte[] bytes, int offset, int count)
        {
            ushort ui = 0;
            for (int i = 0; i < count; i++)
            {
                var bitIndex = i + offset;
                var index = bytes.Length - 1 - bitIndex / 8;
                var mask = bitIndex % 8;
                var data = (byte)(bytes[index] & _mask[mask]);
                ui |= (ushort)(short)(data << (8 * (i / 8)));
            }
            return ui;
        }

        public static bool GetBoolean32(byte[] bytes, int offset, int count) => GetUInt32(bytes, offset, count) != 0;
        public static int GetInt32(byte[] bytes, int offset, int count) => (int)GetUInt32(bytes, offset, count);
        public static uint GetUInt32(byte[] bytes, int offset, int count)
        {
            uint ui = 0;
            for (int i = 0; i < count; i++)
            {
                var bitIndex = i + offset;
                var index = bytes.Length - 1 - bitIndex / 8;
                var mask = bitIndex % 8;
                var data = (byte)(bytes[index] & _mask[mask]);
                ui |= (uint)data << (8 * (i / 8));
            }
            return ui;
        }

        public static long GetInt64(byte[] bytes, int offset, int count) => (int)GetUInt64(bytes, offset, count);
        public static ulong GetUInt64(byte[] bytes, int offset, int count)
        {
            ulong ul = 0;
            for (int i = 0; i < count; i++)
            {
                var bitIndex = i + offset;
                var index = bytes.Length - 1 - bitIndex / 8;
                var mask = bitIndex % 8;
                var data = (byte)(bytes[index] & _mask[mask]);
                ul |= (ulong)data << (8 * (i / 8));
            }
            return ul;
        }

        public static float GetSingle(byte[] bytes, int offset, int count) => BitConverter.ToSingle(GetByteArray(bytes, offset, count), 0);
        public static double GetDouble(byte[] bytes, int offset, int count) => BitConverter.ToDouble(GetByteArray(bytes, offset, count), 0);

        public static string GetString(byte[] bytes, int offset, int count, UnmanagedType type)
        {
            var bits = GetByteArray(bytes, offset, count);
            if (type == UnmanagedType.LPStr)
            {
                var enc = StringEncoding ?? Encoding.Default;
                return enc.GetString(bits);
            }

            return Encoding.Unicode.GetString(bits);
        }

        public static byte[] GetByteArray(byte[] bytes, int offset, int count)
        {
            var size = count / 8;
            if ((count % 8) != 0)
            {
                size++;
            }

            var buffer = new byte[size];
            for (int i = 0; i < count; i++)
            {
                var bitIndex = i + offset;
                var index = bytes.Length - 1 - bitIndex / 8;
                var mask = bitIndex % 8;
                var data = (byte)(bytes[index] & _mask[mask]);
                buffer[8 * (i / 8)] |= data;
            }
            return buffer;
        }

        private static void CheckAlignement(int offset, int count)
        {
            if ((offset % 8) != 0)
                throw new ArgumentException(null, nameof(offset));

            if ((count % 8) != 0)
                throw new ArgumentException(null, nameof(offset));
        }

        public static T[] GetArray<T>(byte[] bytes, int offset, int count)
        {
            CheckAlignement(offset, count);
            if (!typeof(T).IsValueType)
                throw new ArgumentException(null, nameof(T));

            var elementSize = Marshal.SizeOf<T>();
            var arrayLength = count / 8 / elementSize;
            var array = new T[arrayLength];
            var arrayPtr = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
            Marshal.Copy(bytes, offset / 8, arrayPtr, arrayLength);
            return array;
        }

        public static T Get<T>(byte[] bytes, int offset, int count)
        {
            if (typeof(T) == typeof(string))
            {
                CheckAlignement(offset, count);
                return (T)(object)Encoding.Default.GetString(bytes, 0, count / 8);
            }

            if (!typeof(T).IsValueType)
                throw new ArgumentException(null, nameof(T));

            var size = Marshal.SizeOf<T>();
            var buffer = new byte[size];
            for (int i = 0; i < count; i++)
            {
                var bitIndex = i + offset;
                var index = bytes.Length - 1 - bitIndex / 8;
                var mask = bitIndex % 8;
                var data = (byte)(bytes[index] & _mask[mask]);
                buffer[8 * (i / 8)] |= data;
            }

            var ghc = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                return (T)Marshal.PtrToStructure(ghc.AddrOfPinnedObject(), typeof(T));
            }
            finally
            {
                ghc.Free();
            }
        }
    }
}
