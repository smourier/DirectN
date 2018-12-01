// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1253,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("93281500-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DViewport2 : IDirect3DViewport
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
        HRESULT GetViewport2(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetViewport2(IntPtr __unnamed_0);
    }
}
