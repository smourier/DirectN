using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("41e7d1f2-a591-4f7b-a2e5-fa9c843e1c12"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactoryMedia
    {
        [PreserveSig]
        HRESULT CreateSwapChainForCompositionSurfaceHandle(
            object pDevice,
            IntPtr hSurface,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        HRESULT CreateDecodeSwapChainForCompositionSurfaceHandle(
            object pDevice,
            IntPtr hSurface,
            ref DXGI_DECODE_SWAP_CHAIN_DESC pDesc,
            IDXGIResource pYuvDecodeBuffers,
            IDXGIOutput pRestrictToOutput,
            out IDXGIDecodeSwapChain ppSwapChain);
    }
}
