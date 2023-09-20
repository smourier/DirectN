// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETCONTEXTSCHEDULINGPROPERTIES
    {
        public IntPtr hContext;
        public _DXGK_SCHEDULING_PRIORITY_BAND priorityBand;
        public int realtimeBandPriorityLevel;
        public int inProcessPriority;
        public ulong quantum;
        public ulong gracePeriodSamePriority;
        public ulong gracePeriodLowerPriority;
    }
}
