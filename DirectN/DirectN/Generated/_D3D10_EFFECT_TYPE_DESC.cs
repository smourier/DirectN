// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10effect.h(271,9)
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
