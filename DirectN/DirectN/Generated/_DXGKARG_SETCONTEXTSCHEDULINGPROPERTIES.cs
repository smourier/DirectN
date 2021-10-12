// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4919,9)
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
