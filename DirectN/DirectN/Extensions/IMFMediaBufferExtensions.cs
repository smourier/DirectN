using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class IMFMediaBufferExtensions
    {
        public static IntPtr Lock(this IComObject<IMFMediaBuffer> obj) => Lock(obj.Object, out var max, out var current);
        public static IntPtr Lock(this IComObject<IMFMediaBuffer> obj, out uint maxLength, out uint currentLength) => Lock(obj?.Object, out maxLength, out currentLength);
        public static IntPtr Lock(this IMFMediaBuffer obj) => Lock(obj, out var max, out var current);
        public static IntPtr Lock(this IMFMediaBuffer obj, out uint maxLength, out uint currentLength)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            var p = Marshal.AllocHGlobal(8);
            try
            {
                obj.Lock(out var ptr, p, p + 4).ThrowOnError();
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
