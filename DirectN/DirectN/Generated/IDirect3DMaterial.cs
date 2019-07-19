// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(991,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4417c144-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DMaterial
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3D unnamed__0);
        
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL unnamed__0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL unnamed__0);
        
        [PreserveSig]
        HRESULT GetHandle(IDirect3DDevice unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT Reserve();
        
        [PreserveSig]
        HRESULT Unreserve();
    }
}
