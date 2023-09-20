// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d18e17a0-aacb-11d0-afb0-00aa00b67a42"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDVEnc
    {
        [PreserveSig]
        HRESULT get_IFormatResolution(/* [annotation][out] _Out_ */ out int VideoFormat, /* [annotation][out] _Out_ */ out int DVFormat, /* [annotation][out] _Out_ */ out int Resolution, /* [in] */ byte fDVInfo, /* [annotation][out] _Out_ */ out DVINFO sDVInfo);
        
        [PreserveSig]
        HRESULT put_IFormatResolution(/* [in] */ int VideoFormat, /* [in] */ int DVFormat, /* [in] */ int Resolution, /* [in] */ byte fDVInfo, /* [annotation][in] _In_ */ ref DVINFO sDVInfo);
    }
}
