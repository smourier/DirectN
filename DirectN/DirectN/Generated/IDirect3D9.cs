// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9.h(178,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("81bdcbca-64d4-426d-ae8d-ad0147f4275c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D9
    {
        [PreserveSig]
        HRESULT RegisterSoftwareDevice(IntPtr pInitializeFunction);
        
        [PreserveSig]
        uint GetAdapterCount();
        
        [PreserveSig]
        HRESULT GetAdapterIdentifier(uint Adapter, uint Flags, ref _D3DADAPTER_IDENTIFIER9 pIdentifier);
        
        [PreserveSig]
        uint GetAdapterModeCount(uint Adapter, _D3DFORMAT Format);
        
        [PreserveSig]
        HRESULT EnumAdapterModes(uint Adapter, _D3DFORMAT Format, uint Mode, ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        HRESULT GetAdapterDisplayMode(uint Adapter, ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        HRESULT CheckDeviceType(uint Adapter, _D3DDEVTYPE DevType, _D3DFORMAT AdapterFormat, _D3DFORMAT BackBufferFormat, bool bWindowed);
        
        [PreserveSig]
        HRESULT CheckDeviceFormat(uint Adapter, _D3DDEVTYPE DeviceType, _D3DFORMAT AdapterFormat, uint Usage, _D3DRESOURCETYPE RType, _D3DFORMAT CheckFormat);
        
        [PreserveSig]
        HRESULT CheckDeviceMultiSampleType(uint Adapter, _D3DDEVTYPE DeviceType, _D3DFORMAT SurfaceFormat, bool Windowed, _D3DMULTISAMPLE_TYPE MultiSampleType, ref uint pQualityLevels);
        
        [PreserveSig]
        HRESULT CheckDepthStencilMatch(uint Adapter, _D3DDEVTYPE DeviceType, _D3DFORMAT AdapterFormat, _D3DFORMAT RenderTargetFormat, _D3DFORMAT DepthStencilFormat);
        
        [PreserveSig]
        HRESULT CheckDeviceFormatConversion(uint Adapter, _D3DDEVTYPE DeviceType, _D3DFORMAT SourceFormat, _D3DFORMAT TargetFormat);
        
        [PreserveSig]
        HRESULT GetDeviceCaps(uint Adapter, _D3DDEVTYPE DeviceType, ref _D3DCAPS9 pCaps);
        
        [PreserveSig]
        IntPtr GetAdapterMonitor(uint Adapter);
        
        [PreserveSig]
        HRESULT CreateDevice(uint Adapter, _D3DDEVTYPE DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, ref _D3DPRESENT_PARAMETERS_ pPresentationParameters, out IDirect3DDevice9 ppReturnedDeviceInterface);
    }
}
