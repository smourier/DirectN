// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_OPENADAPTER
    {
        public IntPtr hAdapter;
        public uint Interface;
        public uint Version;
        public IntPtr pAdapterCallbacks;
        public IntPtr pAdapterFuncs;
        public uint DriverVersion;
    }
}
