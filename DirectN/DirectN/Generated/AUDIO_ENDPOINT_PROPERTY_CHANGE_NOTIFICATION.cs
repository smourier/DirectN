// generated from <Windows SDK Path>\um\audioengineextensionapo.h
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
