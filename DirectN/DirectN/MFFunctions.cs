using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class MFFunctions
    {
        [DllImport("mfplat")]
        public static extern HRESULT MFTEnumEx(
            Guid guidCategory,
            MFT_ENUM_FLAG Flags,
            IntPtr pInputType,
            IntPtr pOutputType,
            out IntPtr pppMFTActivate,
            out int pnumMFTActivate);

        public static IReadOnlyList<ComObject<IMFActivate>> MFTEnumEx(Guid categoryId, MFT_ENUM_FLAG flags, MFT_REGISTER_TYPE_INFO? inputType = null, MFT_REGISTER_TYPE_INFO? outputType = null)
        {
            using (var input = inputType.StructureToMemory())
            {
                using (var output = outputType.StructureToMemory())
                {
                    MFTEnumEx(categoryId, flags, input.Pointer, output.Pointer, out var ptr, out int count).ThrowOnError();
                    var list = new List<ComObject<IMFActivate>>();
                    try
                    {
                        for (int i = 0; i < count; i++)
                        {
                            var activatePtr = Marshal.ReadIntPtr(ptr, i * IntPtr.Size);
                            var activate = (IMFActivate)Marshal.GetObjectForIUnknown(activatePtr);
                            list.Add(new ComObject<IMFActivate>(activate));
                        }
                    }
                    finally
                    {
                        if (ptr != IntPtr.Zero)
                        {
                            Marshal.FreeCoTaskMem(ptr);
                        }
                    }
                    return list;
                }
            }
        }
    }
}
