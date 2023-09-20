// generated from <Windows SDK Path>\shared\ksmedia.h
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
