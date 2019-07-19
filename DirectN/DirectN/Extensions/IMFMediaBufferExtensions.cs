using System;

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

            input.Lock(out var ptr, out maxLength, out currentLength).ThrowOnError();
            return ptr;
        }
    }
}
