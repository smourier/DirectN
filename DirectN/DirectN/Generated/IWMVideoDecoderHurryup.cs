// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcodecdsp.h(1589,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("352bb3bd-2d4d-4323-9e71-dcdcfbd53ca6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMVideoDecoderHurryup
    {
        [PreserveSig]
        HRESULT SetHurryup(/* [in] */ int lHurryup);
        
        [PreserveSig]
        HRESULT GetHurryup(/* [out] */ out int plHurryup);
    }
}
