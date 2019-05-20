// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(6789,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagTRANSPORTAUDIOPARMS
    {
        public int EnableOutput;
        public int EnableRecord;
        public int EnableSelsync;
        public int Input;
        public int MonitorSource;
    }
}
