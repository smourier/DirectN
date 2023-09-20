// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
