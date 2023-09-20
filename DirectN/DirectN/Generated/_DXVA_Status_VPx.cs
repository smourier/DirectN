// generated from <Windows SDK Path>\um\dxva.h
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
