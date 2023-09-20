// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TUNER_SCAN_STATUS_S
    {
        public KSIDENTIFIER Property;
        public _TunerDecoderLockType LockStatus;
        public uint CurrentFrequency;
    }
}
