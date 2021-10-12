// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d.h(394,1)
using System;
using System.Runtime.InteropServices;
using LPD3DMATRIX = DirectN._D3DMATRIX;
using LPDIRECT3DEXECUTEBUFFER = DirectN.IDirect3DExecuteBuffer;
using LPDIRECT3DTEXTURE = DirectN.IDirect3DTexture;
using LPDIRECT3DVIEWPORT = DirectN.IDirect3DViewport;

namespace DirectN
{
    [ComImport, Guid("a37624ab-8d5f-4650-9d3e-9eae3d9bc670"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3D unnamed__0, [MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__1, ref _D3DDeviceDesc unnamed__2);
        
        [PreserveSig]
        HRESULT GetCaps(ref _D3DDeviceDesc unnamed__0, ref _D3DDeviceDesc unnamed__1);
        
        [PreserveSig]
        HRESULT SwapTextureHandles(LPDIRECT3DTEXTURE unnamed__0, LPDIRECT3DTEXTURE unnamed__1);
        
        [PreserveSig]
        HRESULT CreateExecuteBuffer(ref _D3DExecuteBufferDesc unnamed__0, out LPDIRECT3DEXECUTEBUFFER unnamed__1, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__2);
        
        [PreserveSig]
        HRESULT GetStats(ref _D3DSTATS unnamed__0);
        
        [PreserveSig]
        HRESULT Execute(LPDIRECT3DEXECUTEBUFFER unnamed__0, LPDIRECT3DVIEWPORT unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT AddViewport(LPDIRECT3DVIEWPORT unnamed__0);
        
        [PreserveSig]
        HRESULT DeleteViewport(LPDIRECT3DVIEWPORT unnamed__0);
        
        [PreserveSig]
        HRESULT NextViewport(LPDIRECT3DVIEWPORT unnamed__0, out LPDIRECT3DVIEWPORT unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT Pick(LPDIRECT3DEXECUTEBUFFER unnamed__0, LPDIRECT3DVIEWPORT unnamed__1, uint unnamed__2, ref _D3DRECT unnamed__3);
        
        [PreserveSig]
        HRESULT GetPickRecords(ref uint unnamed__0, ref _D3DPICKRECORD unnamed__1);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT CreateMatrix(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT SetMatrix(uint unnamed__0, ref LPD3DMATRIX unnamed__1);
        
        [PreserveSig]
        HRESULT GetMatrix(uint unnamed__0, ref _D3DMATRIX unnamed__1);
        
        [PreserveSig]
        HRESULT DeleteMatrix(uint unnamed__0);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(out IDirect3D unnamed__0);
    }
}
