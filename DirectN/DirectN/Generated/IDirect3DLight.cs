// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(954,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4417c142-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DLight
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3D __unnamed_0);
        
        [PreserveSig]
        HRESULT SetLight(ref _D3DLIGHT __unnamed_0);
        
        [PreserveSig]
        HRESULT GetLight(ref _D3DLIGHT __unnamed_0);
    }
}
