using System.Text;

namespace System.Runtime.InteropServices
{
    public static class InteropRuntime
    {
        public static Encoding StringEncoding { get; set; }

        private static readonly byte[] _mask = BuildMask();

        private static byte[] BuildMask()
        {
            var mask = new byte[8];
            var m = 1;
            for (int i = 0; i < 8; i++)
            {
                mask[i] = (byte)m;
                m *= 2;
            }
            return mask;
        }

        // "The ordering of data declared as bit fields is from low to high bit"
        // https://docs.microsoft.com/en-us/cpp/cpp/cpp-bit-fields?view=vs-2017
        // Note we don't do any check because calling code is supposed to be generated.

        public static sbyte GetSByte(byte[] bytes, int offset, int count) => (sbyte)GetByte(bytes, offset, count);
        public static byte GetByte(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

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
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

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

        public static bool GetBoolean(byte[] bytes, int offset, int count) => GetUInt32(bytes, offset, count) != 0;
        public static int GetInt32(byte[] bytes, int offset, int count) => (int)GetUInt32(bytes, offset, count);
        public static uint GetUInt32(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

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

        public static long GetInt64(byte[] bytes, int offset, int count) => (long)GetUInt64(bytes, offset, count);
        public static ulong GetUInt64(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

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
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

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

        private static void CheckByteAlignement(int offset, int count)
        {
            if ((offset % 8) != 0)
                throw new ArgumentException(null, nameof(offset));

            if ((count % 8) != 0)
                throw new ArgumentException(null, nameof(offset));
        }

        public static T[] GetArray<T>(byte[] bytes, int offset, int count)
        {
            CheckByteAlignement(offset, count);
            if (!typeof(T).IsValueType)
                throw new InvalidOperationException();

            var elementSize = Marshal.SizeOf<T>();
            var arrayLength = count / 8 / elementSize;
            var array = new T[arrayLength];
            var arrayPtr = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
            Marshal.Copy(bytes, offset / 8, arrayPtr, arrayLength);
            return array;
        }

        public static T Get<T>(byte[] bytes, int offset, int count)
        {
            if (!typeof(T).IsValueType)
                throw new InvalidOperationException();

            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

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

        public static void SetSByte(sbyte value, byte[] bytes, int offset, int count) => SetByteArray(new byte[] { (byte)value }, bytes, offset, count);
        public static void SetByte(byte value, byte[] bytes, int offset, int count) => SetByteArray(new byte[] { value }, bytes, offset, count);
        public static void SetChar(char value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetInt16(short value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetUInt16(ushort value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetBoolean(bool value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetInt32(int value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetUInt32(uint value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetInt64(long value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetUInt64(ulong value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetSingle(float value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);
        public static void SetDouble(double value, byte[] bytes, int offset, int count) => SetByteArray(BitConverter.GetBytes(value), bytes, offset, count);

        public static void SetString(string value, byte[] bytes, int offset, int count, UnmanagedType type)
        {
            if (value == null || value.Length == 0)
                return;

            byte[] valueBytes;
            if (type == UnmanagedType.LPStr)
            {
                var enc = StringEncoding ?? Encoding.Default;
                valueBytes = enc.GetBytes(value);
            }
            else
            {
                valueBytes = Encoding.UTF8.GetBytes(value);
            }

            SetByteArray(valueBytes, bytes, offset, count);
        }

        public static void SetByteArray(byte[] value, byte[] bytes, int offset, int count)
        {
            if (value == null || value.Length == 0)
                return;

            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            for (int i = 0; i < count; i++)
            {
                var bitIndex = i + offset;
                var index = bytes.Length - 1 - bitIndex / 8;
                var mask = bitIndex % 8;
                var data = (byte)(bytes[index] & _mask[mask]);

                bytes[8 * (i / 8)] |= data;
            }
        }

        public static void SetArray<T>(T[] value, byte[] bytes, int offset, int count)
        {
            if (value == null || value.Length == 0)
                return;

            CheckByteAlignement(offset, count);
            if (!typeof(T).IsValueType)
                throw new InvalidOperationException();

            var valuePtr = Marshal.UnsafeAddrOfPinnedArrayElement(value, 0);
            Marshal.Copy(valuePtr, bytes, offset / 8, count / 8);
        }

        public static void Set<T>(T input, byte[] bytes, int offset, int count)
        {
            if (!typeof(T).IsValueType)
                throw new InvalidOperationException();

            var buffer = new byte[Marshal.SizeOf<T>()];
            var ptr = Marshal.AllocCoTaskMem(buffer.Length);
            Marshal.StructureToPtr(input, ptr, false);
            Marshal.Copy(ptr, buffer, 0, buffer.Length);
            Marshal.FreeCoTaskMem(ptr);
            SetByteArray(buffer, bytes, offset, count);
        }
    }
}
