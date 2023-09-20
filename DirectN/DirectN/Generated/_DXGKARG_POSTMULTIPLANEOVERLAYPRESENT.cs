// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_POSTMULTIPLANEOVERLAYPRESENT
    {
        public uint VidPnTargetId;
        public uint PhysicalAdapterMask;
        public uint LayerIndex;
        public ulong PresentID;
    }
}
