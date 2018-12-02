// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_4.h(107,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("94d99bdb-f1f8-4ab0-b236-7da0170edab1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGISwapChain3
    {
        [PreserveSig]
        uint GetCurrentBackBufferIndex();
        
        [PreserveSig]
        HRESULT CheckColorSpaceSupport(/* [annotation][in] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace, /* [annotation][out] _Out_ */ out uint pColorSpaceSupport);
        
        [PreserveSig]
        HRESULT SetColorSpace1(/* [annotation][in] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        HRESULT ResizeBuffers1(/* [annotation][in] _In_ */ uint BufferCount, /* [annotation][in] _In_ */ uint Width, /* [annotation][in] _In_ */ uint Height, /* [annotation][in] _In_ */ DXGI_FORMAT Format, /* [annotation][in] _In_ */ uint SwapChainFlags, /* [annotation][in] _In_reads_(BufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pCreationNodeMask, /* [annotation][in] _In_reads_(BufferCount) */ [MarshalAs(UnmanagedType.IUnknown)] object ppPresentQueue);
    }
}
