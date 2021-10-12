// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(3092,9)
using System;
using System.Runtime.InteropServices;
using DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY = DirectN.DISPLAYCONFIG_OUTPUT_TECHNOLOGY;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
        public DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS flags;
        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
        public ushort edidManufactureId;
        public ushort edidProductCodeId;
        public uint connectorInstance;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string monitorFriendlyDeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string monitorDevicePath;
    }
}
