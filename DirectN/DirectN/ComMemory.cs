using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace DirectN
{
    public sealed class ComMemory : IDisposable
    {
        private IntPtr _pointer;

        public ComMemory(object structure)
        {
            if (structure != null)
            {
                Size = Marshal.SizeOf(structure);
                _pointer = Marshal.AllocCoTaskMem(Size);
                Marshal.StructureToPtr(structure, _pointer, false);
            }
        }

        public ComMemory(int size)
        {
            Size = size;
            // note: we allow any size to keep consistent syntax all over
            if (size > 0)
            {
                _pointer = Marshal.AllocCoTaskMem(size);
            }
        }

        public int Size { get; }
        public IntPtr Pointer
        {
            get
            {
                var pointer = _pointer;
                if (pointer == IntPtr.Zero && Size != 0)
                    throw new ObjectDisposedException("Pointer");

                return pointer;
            }
        }

        public void Dispose()
        {
            var pointer = Interlocked.Exchange(ref _pointer, IntPtr.Zero);
            if (pointer != IntPtr.Zero)
            {
                Marshal.FreeCoTaskMem(pointer);
            }
        }
    }
}
