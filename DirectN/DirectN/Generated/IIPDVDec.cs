// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(15555,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b8e8bd60-0bfe-11d0-af91-00aa00b67a42"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IIPDVDec
    {
        [PreserveSig]
        HRESULT get_IPDisplay(/* [annotation][out] _Out_ */ out int displayPix);
        
        [PreserveSig]
        HRESULT put_IPDisplay(/* [in] */ int displayPix);
    }
}
