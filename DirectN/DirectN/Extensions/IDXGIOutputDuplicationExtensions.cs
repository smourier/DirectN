using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class IDXGIOutputDuplicationExtensions
    {
        public static DXGI_OUTDUPL_DESC GetDesc(this IComObject<IDXGIOutputDuplication> output) => GetDesc(output?.Object);
        public static DXGI_OUTDUPL_DESC GetDesc(this IDXGIOutputDuplication duplication)
        {
            if (duplication == null)
                throw new ArgumentNullException(nameof(duplication));

            duplication.GetDesc(out var desc);
            return desc;
        }

        public static tagRECT[] GetFrameDirtyRects(this IComObject<IDXGIOutputDuplication> output) => GetFrameDirtyRects(output?.Object);
        public static tagRECT[] GetFrameDirtyRects(this IDXGIOutputDuplication duplication)
        {
            if (duplication == null)
                throw new ArgumentNullException(nameof(duplication));

            var hr = duplication.GetFrameDirtyRects(0, IntPtr.Zero, out var size);
            if (size == 0)
            {
                hr.ThrowOnError(); // won't throw if no error
                return Array.Empty<tagRECT>();
            }

            var rects = new List<tagRECT>();
            using (var mem = new ComMemory(size))
            {
                var rectSize = Marshal.SizeOf<tagRECT>();
                var curSize = 0;
                duplication.GetFrameDirtyRects(size, mem.Pointer, out size).ThrowOnError();
                do
                {
                    rects.Add(Marshal.PtrToStructure<tagRECT>(mem.Pointer + curSize));
                    curSize += rectSize;
                }
                while (curSize < size);
            }
            return rects.ToArray();
        }
    }
}
