// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CAMERACONTROL_REGION_OF_INTEREST_S
    {
        public tagRECT FocusRect;
        public bool AutoFocusLock;
        public bool AutoExposureLock;
        public bool AutoWhitebalanceLock;
        public __struct_ksmedia_123__union_0 __union_4;
    }
}
