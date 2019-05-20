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
        HRESULT Lock(uint __unnamed_0, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_1, ref uint __unnamed_2);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT ProcessVertices(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2, LPDIRECT3DVERTEXBUFFER __unnamed_3, uint __unnamed_4, IDirect3DDevice3 __unnamed_5, uint __unnamed_6);
        
        [PreserveSig]
        HRESULT GetVertexBufferDesc(ref _D3DVERTEXBUFFERDESC __unnamed_0);
        
        [PreserveSig]
        HRESULT Optimize(IDirect3DDevice3 __unnamed_0, uint __unnamed_1);
    }
}
