// generated from <Windows SDK Path>\um\d3d.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("93281503-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DMaterial2
    {
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL unnamed__0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL unnamed__0);
        
        [PreserveSig]
        HRESULT GetHandle(IDirect3DDevice2 unnamed__0, ref uint unnamed__1);
    }
}
