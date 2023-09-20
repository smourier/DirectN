// generated from <Windows SDK Path>\shared\ks.h
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
