// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(20901,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_TIMECODE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint Hours1 => InteropRuntime.GetUInt32Bits(__bits, 0, 4);
        public uint Hours10 => InteropRuntime.GetUInt32Bits(__bits, 4, 4);
        public uint Minutes1 => InteropRuntime.GetUInt32Bits(__bits, 8, 4);
        public uint Minutes10 => InteropRuntime.GetUInt32Bits(__bits, 12, 4);
        public uint Seconds1 => InteropRuntime.GetUInt32Bits(__bits, 16, 4);
        public uint Seconds10 => InteropRuntime.GetUInt32Bits(__bits, 20, 4);
        public uint Frames1 => InteropRuntime.GetUInt32Bits(__bits, 24, 4);
        public uint Frames10 => InteropRuntime.GetUInt32Bits(__bits, 28, 2);
        public uint FrameRateCode => InteropRuntime.GetUInt32Bits(__bits, 30, 2);
    }
}
