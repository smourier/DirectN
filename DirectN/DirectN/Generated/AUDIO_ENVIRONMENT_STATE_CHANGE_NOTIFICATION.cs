// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;
using PROPERTYKEY = DirectN._tagpropertykey;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_ENVIRONMENT_STATE_CHANGE_NOTIFICATION
    {
        public IntPtr propertyStore;
        public PROPERTYKEY propertyKey;
    }
}
