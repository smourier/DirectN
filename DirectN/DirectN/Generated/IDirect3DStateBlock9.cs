// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(181,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b07c4fe5-310d-4ba8-a23c-4f0f206f218b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DStateBlock9
    {
        [PreserveSig]
        HRESULT GetDevice(IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT Capture();
        
        [PreserveSig]
        HRESULT Apply();
    }
}
