using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("eb533d5d-2db6-40f8-97a9-494692014f07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFDXGIDeviceManager
    {
        [PreserveSig]
        HRESULT CloseDeviceHandle(IntPtr hDevice);

        [PreserveSig]
        HRESULT GetVideoService(IntPtr hDevice, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppService);

        [PreserveSig]
        HRESULT LockDevice(IntPtr hDevice, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkDevice, bool fBlock);

        [PreserveSig]
        HRESULT OpenDeviceHandle(out IntPtr phDevice);

        [PreserveSig]
        HRESULT ResetDevice([MarshalAs(UnmanagedType.IUnknown)] object pUnkDevice, int resetToken);

        [PreserveSig]
        HRESULT TestDevice(IntPtr hDevice);

        [PreserveSig]
        HRESULT UnlockDevice(IntPtr hDevice, bool fSaveState);
    }
}
