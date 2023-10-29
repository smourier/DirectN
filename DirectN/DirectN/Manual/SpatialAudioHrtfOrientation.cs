using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SpatialAudioHrtfOrientation
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public float orientation;
    }
}
