// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcodecdsp.h(1806,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a7b2504b-e58a-47fb-958b-cac7165a057d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecStrings
    {
        [PreserveSig]
        HRESULT GetName(/* [in] */ ref _DMOMediaType pmt, /* [in] */ uint cchLength, /* [annotation][size_is][unique][out][in] _Out_writes_to_opt_(cchLength, *pcchLength) */ [MarshalAs(UnmanagedType.LPWStr)] string szName, /* [out] */ out uint pcchLength);
        
        [PreserveSig]
        HRESULT GetDescription(/* [in] */ ref _DMOMediaType pmt, /* [in] */ uint cchLength, /* [annotation][size_is][unique][out][in] _Out_writes_to_opt_(cchLength, *pcchLength) */ [MarshalAs(UnmanagedType.LPWStr)] string szDescription, /* [out] */ out uint pcchLength);
    }
}
