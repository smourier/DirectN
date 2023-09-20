// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DSI2_TRANSMISSION
    {
        public uint TotalBufferSize;
        public _DXGK_DSI2_TRANSMISSION__struct_0 __field_1;
        public ushort ReadWordCount;
        public ushort FinalCommandExtraPayload;
        public ushort MipiErrors;
        public ushort HostErrors;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _DXGK_DSI2_PACKET[] Packets;
    }
}
