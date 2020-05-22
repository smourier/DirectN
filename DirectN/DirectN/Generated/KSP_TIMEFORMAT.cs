// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(576,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSP_TIMEFORMAT
    {
        public KSIDENTIFIER Property;
        public Guid SourceFormat;
        public Guid TargetFormat;
        public long Time;
    }
}
