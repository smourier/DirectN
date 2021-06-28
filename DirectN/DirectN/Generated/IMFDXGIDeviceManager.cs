// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(5969,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("eb533d5d-2db6-40f8-97a9-494692014f07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDXGIDeviceManager
    {
        [PreserveSig]
        HRESULT CloseDeviceHandle(/* [annotation] _In_ */ IntPtr hDevice);
        
        [PreserveSig]
        HRESULT GetVideoService(/* [annotation] _In_ */ IntPtr hDevice, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppService);
        
        [PreserveSig]
        HRESULT LockDevice(/* [annotation] _In_ */ IntPtr hDevice, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkDevice, /* [annotation] _In_ */ bool fBlock);
        
        [PreserveSig]
        HRESULT OpenDeviceHandle(/* [annotation] _Out_ */ out IntPtr phDevice);
        
        [PreserveSig]
        HRESULT ResetDevice(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkDevice, /* [annotation] _In_ */ uint resetToken);
        
        [PreserveSig]
        HRESULT TestDevice(/* [annotation] _In_ */ IntPtr hDevice);
        
        [PreserveSig]
        HRESULT UnlockDevice(/* [annotation] _In_ */ IntPtr hDevice, /* [annotation] _In_ */ bool fSaveState);
    }
}
