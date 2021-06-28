// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(16513,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d0e04c47-25b8-4369-925a-362a01d95444"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMPEG2StreamIdMap
    {
        [PreserveSig]
        HRESULT MapStreamId(/* [in] */ uint ulStreamId, /* [in] */ uint MediaSampleContent, /* [in] */ uint ulSubstreamFilterValue, /* [in] */ int iDataOffset);
        
        [PreserveSig]
        HRESULT UnmapStreamId(/* [in] */ int culStreamId, /* [annotation][in] _In_reads_(culStreamId) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pulStreamId);
        
        [PreserveSig]
        HRESULT EnumStreamIdMap(/* [annotation][out] _Out_ */ out IEnumStreamIdMap ppIEnumStreamIdMap);
    }
}
