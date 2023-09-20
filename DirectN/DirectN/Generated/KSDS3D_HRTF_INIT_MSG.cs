// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;
using KSDS3D_HRTF_FILTER_QUALITY = DirectN.__enum_43102;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_HRTF_INIT_MSG
    {
        public uint Size;
        public KSDS3D_HRTF_FILTER_QUALITY Quality;
        public float SampleRate;
        public uint MaxFilterSize;
        public uint FilterTransientMuteLength;
        public uint FilterOverlapBufferLength;
        public uint OutputOverlapBufferLength;
        public uint Reserved;
    }
}
