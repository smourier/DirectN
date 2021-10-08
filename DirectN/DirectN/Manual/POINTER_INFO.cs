using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINTER_INFO
    {
        public POINTER_INPUT_TYPE pointerType;
        public int pointerId;
        public int frameId;
        public POINTER_FLAGS pointerFlags;
        public IntPtr sourceDevice;
        public IntPtr hwndTarget;
        public tagPOINT ptPixelLocation;
        public tagPOINT ptHimetricLocation;
        public tagPOINT ptPixelLocationRaw;
        public tagPOINT ptHimetricLocationRaw;
        public uint dwTime;
        public int historyCount;
        public int InputData;
        public POINTER_MOD dwKeyStates;
        public long PerformanceCount;
        public POINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
    }
}
