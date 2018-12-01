// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfsharingengine.h(114,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DEVICE_INFO
    {
        [MarshalAs(UnmanagedType.BStr)] 
        public string pFriendlyDeviceName;
        [MarshalAs(UnmanagedType.BStr)] 
        public string pUniqueDeviceName;
        [MarshalAs(UnmanagedType.BStr)] 
        public string pManufacturerName;
        [MarshalAs(UnmanagedType.BStr)] 
        public string pModelName;
        [MarshalAs(UnmanagedType.BStr)] 
        public string pIconURL;
    }
}
