// generated from <Windows SDK Path>\um\wingdi.h
using System.Runtime.InteropServices;
using DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY = DirectN.DISPLAYCONFIG_OUTPUT_TECHNOLOGY;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_TARGET_BASE_TYPE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY baseOutputTechnology;
    }
}
