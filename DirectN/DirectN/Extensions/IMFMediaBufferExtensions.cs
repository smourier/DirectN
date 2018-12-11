using System;

namespace DirectN
{
    public static class IMFMediaBufferExtensions
    {
        public static IntPtr Lock(this ComObject<IMFMediaBuffer> obj) => Lock(obj.Object, out var max, out var current);
        public static IntPtr Lock(this ComObject<IMFMediaBuffer> obj, out uint maxLength, out uint currentLength) => Lock(obj?.Object, out maxLength, out currentLength);
        public static IntPtr Lock(this IMFMediaBuffer obj) => Lock(obj, out var max, out var current);
        public static IntPtr Lock(this IMFMediaBuffer obj, out uint maxLength, out uint currentLength)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.Lock(out var ptr, out maxLength, out currentLength);
            return ptr;
        }
    }
}
