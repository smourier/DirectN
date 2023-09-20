// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e5b7ca9a-0f1c-4f66-9002-74ec50d8b304"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPlayerHook
    {
        [PreserveSig]
        HRESULT PreDecode();
    }
}
