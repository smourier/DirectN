// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8207,9)
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
