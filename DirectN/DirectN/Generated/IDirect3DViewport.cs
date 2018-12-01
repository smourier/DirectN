// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1188,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4417c146-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DViewport
    {
        [PreserveSig]
        HRESULT Initialize(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT TransformVertices(uint __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT LightElements(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SetBackground(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetBackground(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SetBackgroundDepth(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetBackgroundDepth(ref IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT Clear(uint __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT AddLight(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteLight(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT NextLight(IntPtr __unnamed_0, ref IntPtr __unnamed_1, uint __unnamed_2);
    }
}
