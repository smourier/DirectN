// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1109,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DTEXTURE = DirectN.IDirect3DTexture;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [Guid("2cdcd9e0-25a0-11cf-a31a-00aa00b93356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DTexture
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3DDevice __unnamed_0, LPDIRECTDRAWSURFACE __unnamed_1);
        
        [PreserveSig]
        HRESULT GetHandle(IDirect3DDevice __unnamed_0, ref uint __unnamed_1);
        
        [PreserveSig]
        HRESULT PaletteChanged(uint __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT Load(LPDIRECT3DTEXTURE __unnamed_0);
        
        [PreserveSig]
        HRESULT Unload();
    }
}
