// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1284,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Status_HEVC
    {
        public ushort StatusReportFeedbackNumber;
        public _DXVA_PicEntry_HEVC CurrPic;
        public byte bBufType;
        public byte bStatus;
        public byte bReserved8Bits;
        public ushort wNumMbsAffected;
    }
}
