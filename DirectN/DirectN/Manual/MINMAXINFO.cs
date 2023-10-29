using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MINMAXINFO
    {
        public tagPOINT ptReserved;
        public tagPOINT ptMaxSize;
        public tagPOINT ptMaxPosition;
        public tagPOINT ptMinTrackSize;
        public tagPOINT ptMaxTrackSize;
    }
}
