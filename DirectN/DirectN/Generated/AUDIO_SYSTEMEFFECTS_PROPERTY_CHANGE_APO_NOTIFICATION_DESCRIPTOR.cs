// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineextensionapo.h(506,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR
    {
        public IntPtr device;
        public Guid propertyStoreContext;
    }
}
