using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ACCENT_POLICY
    {
        public ACCENT_STATE AccentState;
        public uint AccentFlags;
        public uint GradientColor;
        public int AnimationId;
    }
}
