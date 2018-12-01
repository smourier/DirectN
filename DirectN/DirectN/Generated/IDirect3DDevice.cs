// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(394,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a37624ab-8d5f-4650-9d3e-9eae3d9bc670"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice
    {
        [PreserveSig]
        HRESULT Initialize(IntPtr __unnamed_0, Guid __unnamed_1, IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT GetCaps(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SwapTextureHandles(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateExecuteBuffer(IntPtr __unnamed_0, ref IntPtr __unnamed_1, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_2);
        
        [PreserveSig]
        HRESULT GetStats(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Execute(IntPtr __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT AddViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT DeleteViewport(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT NextViewport(IntPtr __unnamed_0, ref IntPtr __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT Pick(IntPtr __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT GetPickRecords(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumTextureFormats(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT CreateMatrix(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetMatrix(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetMatrix(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT DeleteMatrix(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT GetDirect3D(ref IntPtr __unnamed_0);
    }
}
