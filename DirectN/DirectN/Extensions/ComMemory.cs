using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace DirectN
{
    public class ComMemory : IDisposable
    {
        private IntPtr _pointer;

        public ComMemory(object structure)
        {
            if (structure != null)
            {
                if (structure is byte[] bytes)
                {
                    Size = bytes.Length;
                    _pointer = Marshal.AllocCoTaskMem(Size);
                    Marshal.Copy(bytes, 0, _pointer, Size);
                }
                else if (structure is Array array)
                {
                    if (array.Rank != 1)
                        throw new ArgumentException(null, nameof(structure));

                    var elementType = array.GetType().GetElementType();
                    var elementSize = Marshal.SizeOf(elementType);
                    var length = array.GetLength(0);
                    Size = elementSize * length;
                    _pointer = Marshal.AllocCoTaskMem(Size);
                    for (var i = 0; i < length; i++)
                    {
                        Marshal.StructureToPtr(array.GetValue(i), _pointer + i * elementSize, false);
                    }
                }
                else if (structure is string str)
                {
                    Size = (str.Length + 1) * 2;
                    _pointer = Marshal.StringToCoTaskMemUni(str);
                }
                else
                {
                    Size = Marshal.SizeOf(structure);
                    _pointer = Marshal.AllocCoTaskMem(Size);
                    Marshal.StructureToPtr(structure, _pointer, false);
                }
            }
        }

        public ComMemory(uint size)
            : this((int)size)
        {
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

        public ComMemory(IntPtr pointer, int size)
        {
            Replace(pointer, size);
        }

        public int Size { get; protected set; }

        public IntPtr Pointer
        {
            get
            {
                var pointer = _pointer;
                if (pointer == IntPtr.Zero && Size != 0)
                    throw new ObjectDisposedException(nameof(Pointer));

                return pointer;
            }
        }

        public T ToStructure<T>() => Marshal.PtrToStructure<T>(Pointer);

        public byte[] ToArray()
        {
            var bytes = new byte[Size];
            Marshal.Copy(Pointer, bytes, 0, bytes.Length);
            return bytes;
        }

        public virtual void Replace(object structure)
        {
#if DEBUG
            if (Marshal.SizeOf(structure) != Size)
                throw new ArgumentException(null, nameof(structure));
#endif
            Marshal.StructureToPtr(structure, _pointer, false);
        }

        public void Replace(IntPtr pointer, uint size) => Replace(pointer, (int)size);
        public virtual void Replace(IntPtr pointer, int size)
        {
            _pointer = pointer;
            Size = size;
        }

        public static void Free(ref IntPtr ptr)
        {
            var p = Interlocked.Exchange(ref ptr, IntPtr.Zero);
            if (p == IntPtr.Zero)
                return;

            Marshal.FreeCoTaskMem(p);
        }

        public static IntPtr AllocAndCopy(object structure)
        {
            var size = Marshal.SizeOf(structure);
            var p = Marshal.AllocCoTaskMem(size);
            Marshal.StructureToPtr(structure, p, false);
            return p;
        }

        protected virtual void Dispose(bool disposing)
        {
            var pointer = Interlocked.Exchange(ref _pointer, IntPtr.Zero);
            if (pointer != IntPtr.Zero)
            {
                Marshal.FreeCoTaskMem(pointer);
            }
        }

        ~ComMemory() { Dispose(false); }
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
    }

    public class ComMemory<T> : ComMemory
    {
        public ComMemory(T structure)
            : base(structure)
        {
        }

        public T ToStructure() => Marshal.PtrToStructure<T>(Pointer);
    }
}
