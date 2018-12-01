// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(297,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bb223240-e72b-11d0-a9b4-00aa00c0993e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3D3
    {
        [PreserveSig]
        HRESULT EnumDevices(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateLight(ref IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateMaterial(ref IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateViewport(ref IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT FindDevice(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateDevice([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, IntPtr __unnamed_1, ref IntPtr __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT CreateVertexBuffer(IntPtr __unnamed_0, ref IntPtr __unnamed_1, uint __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT EnumZBufferFormats([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT EvictManagedTextures();
    }
}
