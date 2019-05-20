// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(967,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Status_H264
    {
        public uint StatusReportFeedbackNumber;
        public _DXVA_PicEntry_H264 CurrPic;
        public byte field_pic_flag;
        public byte bDXVA_Func;
        public byte bBufType;
        public byte bStatus;
        public byte bReserved8Bits;
        public ushort wNumMbsAffected;
    }
}
