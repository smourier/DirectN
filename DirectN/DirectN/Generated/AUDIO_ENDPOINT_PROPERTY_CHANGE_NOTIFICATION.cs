// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineextensionapo.h(469,9)
using System;
using System.Runtime.InteropServices;
using PROPERTYKEY = DirectN._tagpropertykey;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION
    {
        public IntPtr endpoint;
        public IntPtr propertyStore;
        public PROPERTYKEY propertyKey;
    }
}
