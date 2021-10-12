// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8138,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_HISTORY_BUFFER_HEADER
    {
        public uint RenderCbSequence;
        public uint NumTimestamps;
        public uint PrivateDataSize;
        public uint Reserved;
    }
}
