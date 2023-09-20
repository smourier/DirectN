// generated from <Windows SDK Path>\um\windows.ui.xaml.media.dxinterop.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("43bebd4e-add5-4035-8f85-5608d08e9dc9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISwapChainBackgroundPanelNative
    {
        [PreserveSig]
        HRESULT SetSwapChain(/* [annotation][in] _In_ */ IDXGISwapChain swapChain);
    }
}
