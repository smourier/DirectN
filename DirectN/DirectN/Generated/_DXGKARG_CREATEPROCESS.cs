// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4167,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEPROCESS
    {
        public IntPtr hDxgkProcess;
        public IntPtr hKmdProcess;
        public _DXGK_CREATEPROCESSFLAGS Flags;
        public uint NumPasid;
        public IntPtr pPasid;
        public IntPtr hKmdVmWorkerProcess;
        public uint ProcessNameLength;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char pProcessName;
    }
}
