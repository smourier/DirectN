// generated from <Windows SDK Path>\um\d3d.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4417c144-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
