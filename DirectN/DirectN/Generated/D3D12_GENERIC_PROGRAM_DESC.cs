// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_GENERIC_PROGRAM_DESC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ProgramName;
        public uint NumExports;
        public IntPtr pExports;
        public uint NumSubobjects;
        public IntPtr ppSubobjects;
    }
}
