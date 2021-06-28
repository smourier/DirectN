// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxvahd.h(292,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_VPDEVCAPS
    {
        public _DXVAHD_DEVICE_TYPE DeviceType;
        public uint DeviceCaps;
        public uint FeatureCaps;
        public uint FilterCaps;
        public uint InputFormatCaps;
        public int InputPool;
        public uint OutputFormatCount;
        public uint InputFormatCount;
        public uint VideoProcessorCount;
        public uint MaxInputStreams;
        public uint MaxStreamStates;
    }
}
