// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_4.h(554,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dc7dca35-2196-414d-9f53-617884032a60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIOutput4
    {
        [PreserveSig]
        HRESULT CheckOverlayColorSpaceSupport(/* [annotation][in] _In_ */ DXGI_FORMAT Format, /* [annotation][in] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, /* [annotation][out] _Out_ */ out uint pFlags);
    }
}
