// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor.h(438,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("688d15c3-02b0-438d-b13a-d1b44c32c39a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ResourceTexture
    {
        [PreserveSig]
        HRESULT Update(/* _In_reads_opt_(dimensions) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] minimumExtents, /* _In_reads_opt_(dimensions) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] maximimumExtents, /* _In_reads_opt_(dimensions - 1) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] strides, uint dimensions, /* _In_reads_(dataCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, uint dataCount);
    }
}
