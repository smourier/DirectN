// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10effect.h(327,9)
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
