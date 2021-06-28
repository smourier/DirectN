// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\windows.ui.xaml.media.dxinterop.h(808,5)
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
