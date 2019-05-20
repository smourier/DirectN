// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4562,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIRTUALMACHINEDATA
    {
        public IntPtr hKmdVmWorkerProcess;
        public IntPtr pVmGuid;
        public _DXGK_VIRTUALMACHINEDATAFLAGS Flags;
    }
}
