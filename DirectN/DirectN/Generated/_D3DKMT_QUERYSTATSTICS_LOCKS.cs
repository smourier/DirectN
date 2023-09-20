// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
