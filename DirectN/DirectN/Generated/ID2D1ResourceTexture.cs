// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(438,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("688d15c3-02b0-438d-b13a-d1b44c32c39a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ResourceTexture
    {
        [PreserveSig]
        HRESULT Update(/* _In_reads_opt_(dimensions) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] minimumExtents, /* _In_reads_opt_(dimensions) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] maximimumExtents, /* _In_reads_opt_(dimensions - 1) */ [MarshalAs(UnmanagedType.LPArray)] uint[] strides, int dimensions, /* _In_reads_(dataCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataCount);
    }
}
