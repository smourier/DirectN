using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDVTARGETDEVICE
    {
        public uint tdSize;
        public ushort tdDriverNameOffset;
        public ushort tdDeviceNameOffset;
        public ushort tdPortNameOffset;
        public ushort tdExtDevmodeOffset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] tdData;
    }
}
