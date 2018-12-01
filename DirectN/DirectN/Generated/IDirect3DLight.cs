// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(954,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4417c142-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DLight
    {
        [PreserveSig]
        HRESULT Initialize(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetLight(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetLight(IntPtr __unnamed_0);
    }
}
