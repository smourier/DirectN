// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Status_AV1
    {
        public uint StatusReportFeedbackNumber;
        public _DXVA_PicEntry_AV1 CurrPic;
        public byte BufType;
        public byte Status;
        public byte Reserved8Bits;
        public ushort NumMbsAffected;
    }
}
