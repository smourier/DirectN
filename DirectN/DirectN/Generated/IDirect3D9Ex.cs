// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(204,1)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [Guid("02177241-69fc-400c-8ff1-93a44df6861d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D9Ex : IDirect3D9
    {
        // IDirect3D9
        [PreserveSig]
        new HRESULT RegisterSoftwareDevice([MarshalAs(UnmanagedType.IUnknown)] object pInitializeFunction);
        
        [PreserveSig]
        new uint GetAdapterCount();
        
        [PreserveSig]
        new HRESULT GetAdapterIdentifier(uint Adapter, uint Flags, ref _D3DADAPTER_IDENTIFIER9 pIdentifier);
        
        [PreserveSig]
        new uint GetAdapterModeCount(uint Adapter, _D3DFORMAT Format);
        
        [PreserveSig]
        new HRESULT EnumAdapterModes(uint Adapter, _D3DFORMAT Format, uint Mode, ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        new HRESULT GetAdapterDisplayMode(uint Adapter, ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        new HRESULT CheckDeviceType(uint Adapter, _D3DDEVTYPE DevType, _D3DFORMAT AdapterFormat, _D3DFORMAT BackBufferFormat, bool bWindowed);
        
        [PreserveSig]
        new HRESULT CheckDeviceFormat(uint Adapter, _D3DDEVTYPE DeviceType, _D3DFORMAT AdapterFormat, uint Usage, _D3DRESOURCETYPE RType, _D3DFORMAT CheckFormat);
        
        [PreserveSig]
        new HRESULT CheckDeviceMultiSampleType(uint Adapter, _D3DDEVTYPE DeviceType, _D3DFORMAT SurfaceFormat, bool Windowed, _D3DMULTISAMPLE_TYPE MultiSampleType, ref uint pQualityLevels);
        
        [PreserveSig]
        new HRESULT CheckDepthStencilMatch(uint Adapter, _D3DDEVTYPE DeviceType, _D3DFORMAT AdapterFormat, _D3DFORMAT RenderTargetFormat, _D3DFORMAT DepthStencilFormat);
        
        [PreserveSig]
        new HRESULT CheckDeviceFormatConversion(uint Adapter, _D3DDEVTYPE DeviceType, _D3DFORMAT SourceFormat, _D3DFORMAT TargetFormat);
        
        [PreserveSig]
        new HRESULT GetDeviceCaps(uint Adapter, _D3DDEVTYPE DeviceType, ref _D3DCAPS9 pCaps);
        
        [PreserveSig]
        new IntPtr GetAdapterMonitor(uint Adapter);
        
        [PreserveSig]
        new HRESULT CreateDevice(uint Adapter, _D3DDEVTYPE DeviceType, ref IntPtr hFocusWindow, uint BehaviorFlags, ref _D3DPRESENT_PARAMETERS_ pPresentationParameters, IDirect3DDevice9 ppReturnedDeviceInterface);
        
        // IDirect3D9Ex
        [PreserveSig]
        uint GetAdapterModeCountEx(uint Adapter, ref D3DDISPLAYMODEFILTER pFilter);
        
        [PreserveSig]
        HRESULT EnumAdapterModesEx(uint Adapter, ref D3DDISPLAYMODEFILTER pFilter, uint Mode, ref D3DDISPLAYMODEEX pMode);
        
        [PreserveSig]
        HRESULT GetAdapterDisplayModeEx(uint Adapter, ref D3DDISPLAYMODEEX pMode, ref D3DDISPLAYROTATION pRotation);
        
        [PreserveSig]
        HRESULT CreateDeviceEx(uint Adapter, _D3DDEVTYPE DeviceType, ref IntPtr hFocusWindow, uint BehaviorFlags, ref _D3DPRESENT_PARAMETERS_ pPresentationParameters, ref D3DDISPLAYMODEEX pFullscreenDisplayMode, IDirect3DDevice9Ex ppReturnedDeviceInterface);
        
        [PreserveSig]
        HRESULT GetAdapterLUID(uint Adapter, ref LUID pLUID);
    }
}
