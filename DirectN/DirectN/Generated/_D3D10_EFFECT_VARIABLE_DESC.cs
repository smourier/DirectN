// generated from <Windows SDK Path>\um\d3d10effect.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_EFFECT_VARIABLE_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Semantic;
        public uint Flags;
        public uint Annotations;
        public uint BufferOffset;
        public uint ExplicitBindPoint;
    }
}
