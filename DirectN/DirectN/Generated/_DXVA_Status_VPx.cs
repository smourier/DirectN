// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(1472,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Status_VPx
    {
        public uint StatusReportFeedbackNumber;
        public _DXVA_PicEntry_VPx CurrPic;
        public byte bBufType;
        public byte bStatus;
        public byte bReserved8Bits;
        public ushort wNumMbsAffected;
    }
}
