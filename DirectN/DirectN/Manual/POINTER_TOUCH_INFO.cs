using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINTER_TOUCH_INFO
    {
        public POINTER_INFO pointerInfo;
        public TOUCH_FLAGS touchFlags;
        public TOUCH_MASK touchMask;
        public tagRECT rcContact;
        public tagRECT rcContactRaw;
        public uint orientation;
        public uint pressure;
    }
}
