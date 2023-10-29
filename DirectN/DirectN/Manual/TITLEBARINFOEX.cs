using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TITLEBARINFOEX
    {
        public int cbSize;
        public tagRECT rcTitleBar;
        public STATE_SYSTEM rgstateTitleBar;
        public STATE_SYSTEM rgstateReserved;
        public STATE_SYSTEM rgstateMinimizeButton;
        public STATE_SYSTEM rgstateMaximizeButton;
        public STATE_SYSTEM rgstateHelpButton;
        public STATE_SYSTEM rgstateCloseButton;
        public tagRECT rgrectTitleBar;
        public tagRECT rgrectReserved;
        public tagRECT rgrectMinimizeButton;
        public tagRECT rgrectMaximizeButton;
        public tagRECT rgrectHelpButton;
        public tagRECT rgrectCloseButton;
    }
}
