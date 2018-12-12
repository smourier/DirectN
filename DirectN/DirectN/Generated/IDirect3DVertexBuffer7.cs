// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1449,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DVERTEXBUFFER7 = DirectN.IDirect3DVertexBuffer7;

namespace DirectN
{
    [Guid("f5049e7d-4861-11d2-a407-00a0c90629a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVertexBuffer7
    {
        [PreserveSig]
        HRESULT Lock(uint __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1, ref uint __unnamed_2);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT ProcessVertices(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2, LPDIRECT3DVERTEXBUFFER7 __unnamed_3, uint __unnamed_4, IDirect3DDevice7 __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT GetVertexBufferDesc(ref _D3DVERTEXBUFFERDESC __unnamed_0);
        
        [PreserveSig]
        HRESULT Optimize(IDirect3DDevice7 __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT ProcessVerticesStrided(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2, ref _D3DDRAWPRIMITIVESTRIDEDDATA __unnamed_3, uint __unnamed_4, IDirect3DDevice7 __unnamed_5, uint __unnamed_6);
    }
}
