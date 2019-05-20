// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(15313,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("05e5ac9f-3fb6-4508-bb43-a4067ba1ebe8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMLicenseBackup
    {
        [PreserveSig]
        HRESULT BackupLicenses(/* [in] */ uint dwFlags, /* [in] */ IWMStatusCallback pCallback);
        
        [PreserveSig]
        HRESULT CancelLicenseBackup();
    }
}
