using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public sealed class IntPtrBuffer : SafeBuffer
    {
        public IntPtrBuffer(IntPtr pointer, long byteLength)
            : base(false)
        {
            if (byteLength < 0)
                throw new ArgumentOutOfRangeException(nameof(byteLength));

            handle = pointer;
            Initialize((ulong)byteLength);
        }

        public IntPtrBuffer(int byteLength)
            : base(true)
        {
            if (byteLength < 0)
                throw new ArgumentOutOfRangeException(nameof(byteLength));

            if (byteLength > 0)
            {
                handle = Marshal.AllocHGlobal(byteLength);
                if (handle == IntPtr.Zero)
                    throw new OutOfMemoryException();
            }

            Owned = true;
            Initialize((ulong)byteLength);
        }

        public bool Owned { get; }

        protected override bool ReleaseHandle()
        {
            if (!Owned || handle == IntPtr.Zero)
                return true;

            Marshal.FreeHGlobal(handle);
            handle = IntPtr.Zero;
            return true;
        }
    }
}
