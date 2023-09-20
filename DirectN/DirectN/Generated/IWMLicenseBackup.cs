// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("05e5ac9f-3fb6-4508-bb43-a4067ba1ebe8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMLicenseBackup
    {
        [PreserveSig]
        HRESULT BackupLicenses(/* [in] */ uint dwFlags, /* [in] */ IWMStatusCallback pCallback);
        
        [PreserveSig]
        HRESULT CancelLicenseBackup();
    }
}
