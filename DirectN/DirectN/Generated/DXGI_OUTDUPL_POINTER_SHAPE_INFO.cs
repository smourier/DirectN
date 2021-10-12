// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi1_2.h(255,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_OUTDUPL_POINTER_SHAPE_INFO
    {
        public uint Type;
        public uint Width;
        public uint Height;
        public uint Pitch;
        public tagPOINT HotSpot;
    }
}
