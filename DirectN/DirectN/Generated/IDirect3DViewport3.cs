// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1326,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b0ab3b61-33d7-11d1-a981-00c04fd7b174"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DViewport3 : IDirect3DViewport2
    {
        // IDirect3DViewport
        [PreserveSig]
        new HRESULT Initialize(IntPtr __unnamed_0);
        
        [PreserveSig]
        new HRESULT GetViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        new HRESULT SetViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        new HRESULT TransformVertices(uint __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        new HRESULT LightElements(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        new HRESULT SetBackground(uint __unnamed_0);
        
        [PreserveSig]
        new HRESULT GetBackground(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        new HRESULT SetBackgroundDepth(IntPtr __unnamed_0);
        
        [PreserveSig]
        new HRESULT GetBackgroundDepth(ref IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        new HRESULT Clear(uint __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        new HRESULT AddLight(IntPtr __unnamed_0);
        
        [PreserveSig]
        new HRESULT DeleteLight(IntPtr __unnamed_0);
        
        [PreserveSig]
        new HRESULT NextLight(IntPtr __unnamed_0, ref IntPtr __unnamed_1, uint __unnamed_2);
        
        // IDirect3DViewport2
        [PreserveSig]
        new HRESULT GetViewport2(IntPtr __unnamed_0);
        
        [PreserveSig]
        new HRESULT SetViewport2(IntPtr __unnamed_0);
        
        // IDirect3DViewport3
        [PreserveSig]
        HRESULT SetBackgroundDepth2(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetBackgroundDepth2(ref IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT Clear2(uint __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, uint __unnamed_3, float __unnamed_4, uint __unnamed_5);
    }
}
