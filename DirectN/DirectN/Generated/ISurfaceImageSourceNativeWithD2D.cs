// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\windows.ui.xaml.media.dxinterop.h(678,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("54298223-41e1-4a41-9c08-02e8256864a1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISurfaceImageSourceNativeWithD2D
    {
        [PreserveSig]
        HRESULT SetDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object device);
        
        [PreserveSig]
        HRESULT BeginDraw(/* [annotation][in] _In_ */ ref tagRECT updateRect, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* [annotation][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object updateObject, /* [annotation][out] _Out_ */ out tagPOINT offset);
        
        [PreserveSig]
        HRESULT EndDraw();
        
        [PreserveSig]
        HRESULT SuspendDraw();
        
        [PreserveSig]
        HRESULT ResumeDraw();
    }
}
