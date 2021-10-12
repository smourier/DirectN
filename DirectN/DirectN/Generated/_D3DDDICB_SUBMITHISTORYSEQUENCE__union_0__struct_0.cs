// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(4264,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITHISTORYSEQUENCE__union_0__struct_0
    {
        public uint FirstAPISequenceNumberHigh;
        public uint CompletedAPISequenceNumberLow0Size;
        public uint CompletedAPISequenceNumberLow1Size;
        public uint BegunAPISequenceNumberLow0Size;
        public uint BegunAPISequenceNumberLow1Size;
    }
}
