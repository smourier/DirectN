// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\windows.ui.xaml.media.dxinterop.h(950,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d5a2f60c-37b2-44a2-937b-8d8eb9726821"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISwapChainPanelNative2 : ISwapChainPanelNative
    {
        // ISwapChainPanelNative
        [PreserveSig]
        new HRESULT SetSwapChain(/* [annotation][in] _In_ */ IDXGISwapChain swapChain);
        
        // ISwapChainPanelNative2
        [PreserveSig]
        HRESULT SetSwapChainHandle(/* [annotation][in] _In_ */ IntPtr swapChainHandle);
    }
}
