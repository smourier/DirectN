// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(5083,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_VBI_FRAME_INFO
    {
        public uint ExtendedHeaderSize;
        public uint dwFrameFlags;
        public long PictureNumber;
        public long DropCount;
        public uint dwSamplingFrequency;
        public tagKS_TVTUNER_CHANGE_INFO TvTunerChangeInfo;
        public tagKS_VBIINFOHEADER VBIInfoHeader;
    }
}
