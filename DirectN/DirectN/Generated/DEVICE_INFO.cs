// generated from <Windows SDK Path>\um\mfsharingengine.h
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
