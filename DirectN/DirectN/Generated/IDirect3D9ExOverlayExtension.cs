// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(207,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("187aeb13-aaf5-4c59-876d-e059088c0df8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D9ExOverlayExtension
    {
        [PreserveSig]
        HRESULT CheckDeviceOverlayType(uint Adapter, _D3DDEVTYPE DevType, uint OverlayWidth, uint OverlayHeight, _D3DFORMAT OverlayFormat, ref D3DDISPLAYMODEEX pDisplayMode, D3DDISPLAYROTATION DisplayRotation, ref _D3DOVERLAYCAPS pOverlayCaps);
    }
}
