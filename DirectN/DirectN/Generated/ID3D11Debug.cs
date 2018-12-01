// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11sdklayers.h(147,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("79cf2233-7536-4948-9d36-1e4692dc5760"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Debug
    {
        [PreserveSig]
        HRESULT SetFeatureMask(uint Mask);
        
        [PreserveSig]
        uint GetFeatureMask();
        
        [PreserveSig]
        HRESULT SetPresentPerRenderOpDelay(uint Milliseconds);
        
        [PreserveSig]
        uint GetPresentPerRenderOpDelay();
        
        [PreserveSig]
        HRESULT SetSwapChain(/* optional(IDXGISwapChain) */ IntPtr pSwapChain);
        
        [PreserveSig]
        HRESULT GetSwapChain(/* [annotation] _Out_ */ out IntPtr ppSwapChain);
        
        [PreserveSig]
        HRESULT ValidateContext(/* [annotation] _In_ */ ID3D11DeviceContext pContext);
        
        [PreserveSig]
        HRESULT ReportLiveDeviceObjects(D3D11_RLDO_FLAGS Flags);
        
        [PreserveSig]
        HRESULT ValidateContextForDispatch(/* [annotation] _In_ */ ID3D11DeviceContext pContext);
    }
}
