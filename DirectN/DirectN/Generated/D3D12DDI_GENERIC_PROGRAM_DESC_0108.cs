// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_GENERIC_PROGRAM_DESC_0108
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ProgramName;
        public uint NumExports;
        public IntPtr pExports;
        public uint NumSubobjects;
        public IntPtr pSubobjects;
    }
}
