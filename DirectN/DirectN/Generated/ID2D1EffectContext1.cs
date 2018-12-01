// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor_1.h(34,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The internal context handed to effect authors to create transforms from effects and any other operation tied to context which is not useful to the application facing API.
    /// </summary>
    [Guid("84ab595a-fc81-4546-bacd-e8ef4d8abe7a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1EffectContext1
    {
        [PreserveSig]
        HRESULT CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, /* _In_reads_(3) */ [MarshalAs(UnmanagedType.LPArray)] uint[] extents, /* _In_reads_(dataCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, uint dataCount, /* _In_reads_(2) */ [MarshalAs(UnmanagedType.LPArray)] uint[] strides, /* _COM_Outptr_ */ out ID2D1LookupTable3D lookupTable);
    }
}
