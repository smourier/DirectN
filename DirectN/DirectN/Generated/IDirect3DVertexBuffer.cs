// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(1407,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DVERTEXBUFFER = DirectN.IDirect3DVertexBuffer;

namespace DirectN
{
    [Guid("7a503555-4a83-11d1-a5db-00a0c90367f8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVertexBuffer
    {
        [PreserveSig]
        HRESULT Lock(uint unnamed__0, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__1, ref uint unnamed__2);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT ProcessVertices(uint unnamed__0, uint unnamed__1, uint unnamed__2, LPDIRECT3DVERTEXBUFFER unnamed__3, uint unnamed__4, IDirect3DDevice3 unnamed__5, uint unnamed__6);
        
        [PreserveSig]
        HRESULT GetVertexBufferDesc(ref _D3DVERTEXBUFFERDESC unnamed__0);
        
        [PreserveSig]
        HRESULT Optimize(IDirect3DDevice3 unnamed__0, uint unnamed__1);
    }
}
