// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(394,1)
using System;
using System.Runtime.InteropServices;
using LPD3DMATRIX = DirectN._D3DMATRIX;
using LPDIRECT3DEXECUTEBUFFER = DirectN.IDirect3DExecuteBuffer;
using LPDIRECT3DTEXTURE = DirectN.IDirect3DTexture;
using LPDIRECT3DVIEWPORT = DirectN.IDirect3DViewport;

namespace DirectN
{
    [Guid("a37624ab-8d5f-4650-9d3e-9eae3d9bc670"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3D __unnamed_0, [MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_1, ref _D3DDeviceDesc __unnamed_2);
        
        [PreserveSig]
        HRESULT GetCaps(ref _D3DDeviceDesc __unnamed_0, ref _D3DDeviceDesc __unnamed_1);
        
        [PreserveSig]
        HRESULT SwapTextureHandles(LPDIRECT3DTEXTURE __unnamed_0, LPDIRECT3DTEXTURE __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateExecuteBuffer(ref _D3DExecuteBufferDesc __unnamed_0, out LPDIRECT3DEXECUTEBUFFER __unnamed_1, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_2);
        
        [PreserveSig]
        HRESULT GetStats(ref _D3DSTATS __unnamed_0);
        
        [PreserveSig]
        HRESULT Execute(LPDIRECT3DEXECUTEBUFFER __unnamed_0, LPDIRECT3DVIEWPORT __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT AddViewport(LPDIRECT3DVIEWPORT __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteViewport(LPDIRECT3DVIEWPORT __unnamed_0);
        
        [PreserveSig]
        HRESULT NextViewport(LPDIRECT3DVIEWPORT __unnamed_0, out LPDIRECT3DVIEWPORT __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT Pick(LPDIRECT3DEXECUTEBUFFER __unnamed_0, LPDIRECT3DVIEWPORT __unnamed_1, uint __unnamed_2, ref _D3DRECT __unnamed_3);
        
        [PreserveSig]
        HRESULT GetPickRecords(ref uint __unnamed_0, ref _D3DPICKRECORD __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateMatrix(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT SetMatrix(uint __unnamed_0, ref LPD3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT GetMatrix(uint __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT DeleteMatrix(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(out IDirect3D __unnamed_0);
    }
}
