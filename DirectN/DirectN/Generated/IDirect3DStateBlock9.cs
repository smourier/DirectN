// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b07c4fe5-310d-4ba8-a23c-4f0f206f218b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DStateBlock9
    {
        [PreserveSig]
        HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT Capture();
        
        [PreserveSig]
        HRESULT Apply();
    }
}
