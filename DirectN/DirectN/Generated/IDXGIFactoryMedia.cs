// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_3.h(1531,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("41e7d1f2-a591-4f7b-a2e5-fa9c843e1c12"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIFactoryMedia
    {
        [PreserveSig]
        HRESULT CreateSwapChainForCompositionSurfaceHandle(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, /* optional(HANDLE) */ IntPtr hSurface, /* [annotation][in] _In_ */ ref DXGI_SWAP_CHAIN_DESC1 pDesc, /* [annotation][in] _In_opt_ */ IDXGIOutput pRestrictToOutput, /* [annotation][out] _COM_Outptr_ */ out IDXGISwapChain1 ppSwapChain);
        
        [PreserveSig]
        HRESULT CreateDecodeSwapChainForCompositionSurfaceHandle(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, /* optional(HANDLE) */ IntPtr hSurface, /* [annotation][in] _In_ */ ref DXGI_DECODE_SWAP_CHAIN_DESC pDesc, /* [annotation][in] _In_ */ IDXGIResource pYuvDecodeBuffers, /* [annotation][in] _In_opt_ */ IDXGIOutput pRestrictToOutput, /* [annotation][out] _COM_Outptr_ */ out IDXGIDecodeSwapChain ppSwapChain);
    }
}
