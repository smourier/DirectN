// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1095,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_MIC_ARRAY_GEOMETRY
    {
        public ushort usVersion;
        public ushort usMicArrayType;
        public short wVerticalAngleBegin;
        public short wVerticalAngleEnd;
        public short wHorizontalAngleBegin;
        public short wHorizontalAngleEnd;
        public ushort usFrequencyBandLo;
        public ushort usFrequencyBandHi;
        public ushort usNumberOfMicrophones;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public KSAUDIO_MICROPHONE_COORDINATES[] KsMicCoord;
    }
}
