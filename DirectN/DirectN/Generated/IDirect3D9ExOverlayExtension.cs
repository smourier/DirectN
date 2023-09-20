// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("187aeb13-aaf5-4c59-876d-e059088c0df8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D9ExOverlayExtension
    {
        [PreserveSig]
        HRESULT CheckDeviceOverlayType(uint Adapter, _D3DDEVTYPE DevType, uint OverlayWidth, uint OverlayHeight, _D3DFORMAT OverlayFormat, ref D3DDISPLAYMODEEX pDisplayMode, D3DDISPLAYROTATION DisplayRotation, ref _D3DOVERLAYCAPS pOverlayCaps);
    }
}
