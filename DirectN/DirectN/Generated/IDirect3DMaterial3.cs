// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d.h(1071,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ca9c46f4-d3c5-11d1-b75a-00600852b312"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DMaterial3
    {
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL unnamed__0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL unnamed__0);
        
        [PreserveSig]
        HRESULT GetHandle(IDirect3DDevice3 unnamed__0, ref uint unnamed__1);
    }
}
