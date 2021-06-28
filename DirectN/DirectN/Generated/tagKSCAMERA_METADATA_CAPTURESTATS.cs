// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(6260,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_METADATA_CAPTURESTATS
    {
        public tagKSCAMERA_METADATA_ITEMHEADER Header;
        public uint Flags;
        public uint Reserved;
        public ulong ExposureTime;
        public ulong ExposureCompensationFlags;
        public int ExposureCompensationValue;
        public uint IsoSpeed;
        public uint FocusState;
        public uint LensPosition;
        public uint WhiteBalance;
        public uint Flash;
        public uint FlashPower;
        public uint ZoomFactor;
        public ulong SceneMode;
        public ulong SensorFramerate;
    }
}
