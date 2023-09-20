// generated from <Windows SDK Path>\um\d3d10effect.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_EFFECT_TYPE_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string TypeName;
        public int Class;
        public int Type;
        public uint Elements;
        public uint Members;
        public uint Rows;
        public uint Columns;
        public uint PackedSize;
        public uint UnpackedSize;
        public uint Stride;
    }
}
