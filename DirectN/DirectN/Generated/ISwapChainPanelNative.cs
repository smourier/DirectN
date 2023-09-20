// generated from <Windows SDK Path>\um\windows.ui.xaml.media.dxinterop.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f92f19d2-3ade-45a6-a20c-f6f1ea90554b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISwapChainPanelNative
    {
        [PreserveSig]
        HRESULT SetSwapChain(/* [annotation][in] _In_ */ IDXGISwapChain swapChain);
    }
}
