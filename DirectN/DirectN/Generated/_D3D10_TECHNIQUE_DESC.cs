// generated from <Windows SDK Path>\um\d3d10effect.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_TECHNIQUE_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public uint Passes;
        public uint Annotations;
    }
}
