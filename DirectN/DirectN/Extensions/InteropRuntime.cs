using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace System.Runtime.InteropServices
{
    public static class InteropRuntime
    {
        public static Encoding StringEncoding { get; set; }

        // Note we mostly do checks with debug.assert, since calling code is supposed to be generated.
        public static sbyte GetSByte(byte[] bytes, int offset, int count) => (sbyte)GetByte(bytes, offset, count);
        public static byte GetByte(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                return 0;

            if (count == 8)
                return bytes[offset / 8];

            byte b = 0;
            var bitIndex = 0;
            foreach (var bit in EnumerateBits(bytes, offset, count))
            {
                if (bit)
                {
                    b |= (byte)(1 << bitIndex);
                }
                bitIndex++;
            }
            return b;
        }

        public static char GetChar(byte[] bytes, int offset, int count) => (char)GetInt16(bytes, offset, count);
        public static short GetInt16(byte[] bytes, int offset, int count) => (short)GetUInt16(bytes, offset, count);
        public static ushort GetUInt16(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                return 0;

            if (count == 16)
                return BitConverter.ToUInt16(bytes, offset / 8);

            ushort ui = 0;
            var bitIndex = 0;
            foreach (var bit in EnumerateBits(bytes, offset, count))
            {
                if (bit)
                {
                    ui |= (ushort)(1 << bitIndex);
                }
                bitIndex++;
            }
            return ui;
        }

        public static bool GetBoolean(byte[] bytes, int offset, int count) => EnumerateBits(bytes, offset, count).Any(b => b);

        public static int GetInt32(byte[] bytes, int offset, int count) => (int)GetUInt32(bytes, offset, count);
        public static uint GetUInt32(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                return 0;

            if (count == 32)
                return BitConverter.ToUInt32(bytes, offset / 8);

            uint ui = 0;
            var bitIndex = 0;
            foreach (var bit in EnumerateBits(bytes, offset, count))
            {
                if (bit)
                {
                    ui |= 1U << bitIndex;
                }
                bitIndex++;
            }
            return ui;
        }

        public static long GetInt64(byte[] bytes, int offset, int count) => (int)GetUInt64(bytes, offset, count);
        public static ulong GetUInt64(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                return 0;

            if (count == 64)
                return BitConverter.ToUInt64(bytes, offset / 8);

            ulong ul = 0;
            var bitIndex = 0;
            foreach (var bit in EnumerateBits(bytes, offset, count))
            {
                if (bit)
                {
                    ul |= 1UL << bitIndex;
                }
                bitIndex++;
            }
            return ul;
        }

        public static float GetSingle(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                return 0;

            Debug.Assert(count == 32);
            return BitConverter.ToSingle(bytes, offset / 8);
        }

        public static double GetDouble(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                return 0;

            Debug.Assert(count == 64);
            return BitConverter.ToDouble(bytes, offset / 8);
        }

        public static string GetString(byte[] bytes, int offset, int count, UnmanagedType type)
        {
            if (bytes == null)
                return null;

            var bits = GetByteArray(bytes, offset, count);
            if (type == UnmanagedType.LPStr)
            {
                var enc = StringEncoding ?? Encoding.Default;
                return enc.GetString(bits);
            }

            return Encoding.Unicode.GetString(bits);
        }

        public static IEnumerable<bool> EnumerateBits(byte[] bytes, int offset, int count)
        {
            if (bytes == null)
                yield break;

            // The ordering of data declared as bit fields is from low to high bit
            // https://docs.microsoft.com/en-us/cpp/cpp/cpp-bit-fields
            var byteIndex = offset / 8;
            var bitIndex = offset % 8;
            var b = bytes[byteIndex];
            for (var i = 0; i < count; i++)
            {
                yield return (b & (1 << bitIndex)) != 0;
                if (i == count - 1)
                    break;

                bitIndex++;
                if (bitIndex > 7)
                {
                    bitIndex = 0;
                    byteIndex++;
                    b = bytes[byteIndex];
                }
            }
        }

        public static byte[] GetByteArray(byte[] bytes, int offset, int count)
        {
            Debug.Assert(count % 8 == 0);
            Debug.Assert(offset % 8 == 0);
            if (bytes == null)
                return null;

            var value = new byte[count / 8];
            Buffer.BlockCopy(bytes, offset / 8, value, 0, value.Length);
            return value;
        }

        public static T[] GetArray<T>(byte[] bytes, int offset, int count)
        {
            Debug.Assert((offset % 8) == 0);
            Debug.Assert((count % 8) == 0);
            if (bytes == null)
                return null;

            if (!typeof(T).IsValueType)
                throw new NotSupportedException();

            var elementSize = Marshal.SizeOf<T>();
            var arrayLength = count / 8 / elementSize;
            var array = new T[arrayLength];
            var arrayPtr = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
            Marshal.Copy(bytes, offset / 8, arrayPtr, arrayLength);
            return array;
        }

        public static T Get<T>(byte[] bytes, int offset, int count)
        {
            Debug.Assert((offset % 8) == 0);
            Debug.Assert((count % 8) == 0);
            if (bytes == null)
                return default;

            if (typeof(T) == typeof(string))
                return (T)(object)Encoding.Default.GetString(bytes, 0, count / 8);

            if (!typeof(T).IsValueType)
                throw new NotSupportedException();

            var size = Marshal.SizeOf<T>();
            var buffer = new byte[size];
            var bitIndex = 0;
            var byteIndex = 0;
            foreach (var bit in EnumerateBits(bytes, offset, count))
            {
                if (bit)
                {
                    buffer[byteIndex] |= (byte)(1 << bitIndex);
                }
                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
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

            var countMod = count % 8;
            var offsetMod = offset % 8;
            if (countMod == 0 && offsetMod == 0)
            {
                Buffer.BlockCopy(value, 0, bytes, offset / 8, count / 8);
                return;
            }

            var bitIndex = offsetMod;
            var byteIndex = offset / 8;
            foreach (var bit in EnumerateBits(value, 0, value.Length * 8))
            {
                if (bit)
                {
                    bytes[byteIndex] |= (byte)(1 << bitIndex);
                }
                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }
        }

        public static void SetArray<T>(T[] value, byte[] bytes, int offset, int count)
        {
            Debug.Assert((offset % 8) == 0);
            Debug.Assert((count % 8) == 0);
            if (value == null || value.Length == 0)
                return;

            if (!typeof(T).IsValueType)
                throw new ArgumentException(null, nameof(T));

            var valuePtr = Marshal.UnsafeAddrOfPinnedArrayElement(value, 0);
            Marshal.Copy(valuePtr, bytes, offset / 8, count / 8);
        }

        public static void Set<T>(T obj, byte[] bytes, int offset, int count)
        {
            Debug.Assert((offset % 8) == 0);
            Debug.Assert((count % 8) == 0);
            if (!typeof(T).IsValueType)
                throw new ArgumentException(null, nameof(T));

            var buffer = new byte[Marshal.SizeOf<T>()];
            var ptr = Marshal.AllocCoTaskMem(buffer.Length);
            try
            {
                Marshal.StructureToPtr(obj, ptr, false);
                Marshal.Copy(ptr, buffer, 0, buffer.Length);
                SetByteArray(buffer, bytes, offset, count);
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }
    }
}
