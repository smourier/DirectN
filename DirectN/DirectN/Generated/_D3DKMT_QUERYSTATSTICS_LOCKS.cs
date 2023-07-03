// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3528,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATSTICS_LOCKS
    {
        public uint NbLocks;
        public uint NbLocksWaitFlag;
        public uint NbLocksDiscardFlag;
        public uint NbLocksNoOverwrite;
        public uint NbLocksNoReadSync;
        public uint NbLocksLinearization;
        public uint NbComplexLocks;
    }
}
