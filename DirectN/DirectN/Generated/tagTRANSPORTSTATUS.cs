// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(6774,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagTRANSPORTSTATUS
    {
        public int Mode;
        public int LastError;
        public int RecordInhibit;
        public int ServoLock;
        public int MediaPresent;
        public int MediaLength;
        public int MediaSize;
        public int MediaTrackCount;
        public int MediaTrackLength;
        public int MediaTrackSide;
        public int MediaType;
        public int LinkMode;
        public int NotifyOn;
    }
}
