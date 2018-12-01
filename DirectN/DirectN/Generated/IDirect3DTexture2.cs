// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1150,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("93281502-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DTexture2
    {
        [PreserveSig]
        HRESULT GetHandle(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT PaletteChanged(uint __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT Load(IntPtr __unnamed_0);
    }
}
