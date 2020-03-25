using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class IMFMediaBufferExtensions
    {
        public static IntPtr Lock(this ComObject<IMFMediaBuffer> input) => Lock(input?.Object, out _, out _);
        public static IntPtr Lock(this ComObject<IMFMediaBuffer> input, out uint maxLength, out uint currentLength) => Lock(input?.Object, out maxLength, out currentLength);
        public static IntPtr Lock(this IMFMediaBuffer input) => Lock(input, out _, out _);
        public static IntPtr Lock(this IMFMediaBuffer input, out uint maxLength, out uint currentLength)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var p = Marshal.AllocHGlobal(8);
            try
            {
                input.Lock(out var ptr, p, p + 4).ThrowOnError();
                maxLength = (uint)Marshal.ReadInt32(p);
                currentLength = (uint)Marshal.ReadInt32(p + 4);
                return ptr;
            }
            finally
            {
                Marshal.FreeHGlobal(p);
            }
        }
    }
}
