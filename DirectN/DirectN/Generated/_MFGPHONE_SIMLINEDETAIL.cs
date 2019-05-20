// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfgphone.h(115,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _MFGPHONE_SIMLINEDETAIL
    {
        public uint SimSlot;
        public _MFGPHONE_SIMSTATE SimState;
        public _MFGPHONE_REGISTRATIONSTATE RegistrationState;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string NetworkName;
        public _MFGPHONE_LINESYSTEMTYPE LineSystemType;
        public uint SignalStrength;
        public _MFGPHONE_CALLSTATUS CallStatus;
    }
}
