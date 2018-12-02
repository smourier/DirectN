// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(991,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4417c144-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DMaterial
    {
        [PreserveSig]
        HRESULT Initialize(ref IDirect3D __unnamed_0);
        
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL __unnamed_0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL __unnamed_0);
        
        [PreserveSig]
        HRESULT GetHandle(ref IDirect3DDevice __unnamed_0, ref uint __unnamed_1);
        
        [PreserveSig]
        HRESULT Reserve();
        
        [PreserveSig]
        HRESULT Unreserve();
    }
}
