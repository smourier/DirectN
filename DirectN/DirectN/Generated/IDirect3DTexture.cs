// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1109,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2cdcd9e0-25a0-11cf-a31a-00aa00b93356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DTexture
    {
        [PreserveSig]
        HRESULT Initialize(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetHandle(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT PaletteChanged(uint __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT Load(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Unload();
    }
}
