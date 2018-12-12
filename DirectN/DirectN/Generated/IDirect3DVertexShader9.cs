// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(184,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("efc5557e-6265-4613-8a94-43857889eb36"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVertexShader9
    {
        [PreserveSig]
        HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT GetFunction([MarshalAs(UnmanagedType.IUnknown)] object __unnamed_0, ref uint pSizeOfData);
    }
}
