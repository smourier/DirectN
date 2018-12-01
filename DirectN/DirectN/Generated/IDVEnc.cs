// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(15415,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d18e17a0-aacb-11d0-afb0-00aa00b67a42"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDVEnc
    {
        [PreserveSig]
        HRESULT get_IFormatResolution(/* [annotation][out] _Out_ */ out int VideoFormat, /* [annotation][out] _Out_ */ out int DVFormat, /* [annotation][out] _Out_ */ out int Resolution, /* [in] */ byte fDVInfo, /* [annotation][out] _Out_ */ out DVINFO sDVInfo);
        
        [PreserveSig]
        HRESULT put_IFormatResolution(/* [in] */ int VideoFormat, /* [in] */ int DVFormat, /* [in] */ int Resolution, /* [in] */ byte fDVInfo, /* [annotation][in] _In_ */ ref DVINFO sDVInfo);
    }
}
