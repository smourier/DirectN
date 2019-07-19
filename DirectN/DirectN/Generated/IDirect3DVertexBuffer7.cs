// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(1449,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DVERTEXBUFFER7 = DirectN.IDirect3DVertexBuffer7;

namespace DirectN
{
    [Guid("f5049e7d-4861-11d2-a407-00a0c90629a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVertexBuffer7
    {
        [PreserveSig]
        HRESULT Lock(uint unnamed__0, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__1, ref uint unnamed__2);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT ProcessVertices(uint unnamed__0, uint unnamed__1, uint unnamed__2, LPDIRECT3DVERTEXBUFFER7 unnamed__3, uint unnamed__4, IDirect3DDevice7 unnamed__5, uint unnamed__6);
        
        [PreserveSig]
        HRESULT GetVertexBufferDesc(ref _D3DVERTEXBUFFERDESC unnamed__0);
        
        [PreserveSig]
        HRESULT Optimize(IDirect3DDevice7 unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT ProcessVerticesStrided(uint unnamed__0, uint unnamed__1, uint unnamed__2, ref _D3DDRAWPRIMITIVESTRIDEDDATA unnamed__3, uint unnamed__4, IDirect3DDevice7 unnamed__5, uint unnamed__6);
    }
}
