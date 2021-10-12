// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3259,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PACKET_INFORMATION
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public _D3DKMT_QUERYSTATISTICS_QUEUE_PACKET_TYPE_INFORMATION[] QueuePacket;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public _D3DKMT_QUERYSTATISTICS_DMA_PACKET_TYPE_INFORMATION[] DmaPacket;
    }
}
