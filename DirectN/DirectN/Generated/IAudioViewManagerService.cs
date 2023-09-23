// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a7a7ef10-1f49-45e0-ad35-612057cc8f74"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioViewManagerService
    {
        [PreserveSig]
        HRESULT SetAudioStreamWindow(/* [in] */ IntPtr hwnd);
    }
}
