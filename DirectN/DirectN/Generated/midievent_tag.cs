// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmeapi.h(1021,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct midievent_tag
    {
        public uint dwDeltaTime;
        public uint dwStreamID;
        public uint dwEvent;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] dwParms;
    }
}
