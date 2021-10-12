// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1756,9)
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
