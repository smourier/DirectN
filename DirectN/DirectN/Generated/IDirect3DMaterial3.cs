// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1071,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ca9c46f4-d3c5-11d1-b75a-00600852b312"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DMaterial3
    {
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL __unnamed_0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL __unnamed_0);
        
        [PreserveSig]
        HRESULT GetHandle(ref IDirect3DDevice3 __unnamed_0, ref uint __unnamed_1);
    }
}
