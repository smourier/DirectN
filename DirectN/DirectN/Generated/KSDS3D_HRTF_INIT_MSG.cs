// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(1251,9)
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
