using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDVTARGETDEVICE
    {
        public int tdSize;
        public short tdDriverNameOffset;
        public short tdDeviceNameOffset;
        public short tdPortNameOffset;
        public short tdExtDevmodeOffset;
    }
}
