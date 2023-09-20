// generated from <Windows SDK Path>\um\windows.ui.xaml.media.dxinterop.h
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
