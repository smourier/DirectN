// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d.h(1150,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DTEXTURE2 = DirectN.IDirect3DTexture2;

namespace DirectN
{
    [ComImport, Guid("93281502-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DTexture2
    {
        [PreserveSig]
        HRESULT GetHandle(IDirect3DDevice2 unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT PaletteChanged(uint unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT Load(LPDIRECT3DTEXTURE2 unnamed__0);
    }
}
