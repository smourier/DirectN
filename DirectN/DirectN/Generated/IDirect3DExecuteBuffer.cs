// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(905,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4417c145-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DExecuteBuffer
    {
        [PreserveSig]
        HRESULT Initialize(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT Lock(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT SetExecuteData(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetExecuteData(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Validate(IntPtr __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3);
        
        [PreserveSig]
        HRESULT Optimize(uint __unnamed_0);
    }
}
