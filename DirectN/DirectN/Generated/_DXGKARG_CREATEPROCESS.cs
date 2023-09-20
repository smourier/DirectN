// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
        public IntPtr pProcessName;
    }
}
