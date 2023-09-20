// generated from <Windows SDK Path>\um\dxvahd.h
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
