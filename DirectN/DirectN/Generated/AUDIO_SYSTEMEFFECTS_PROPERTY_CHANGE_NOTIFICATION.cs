// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;
using PROPERTYKEY = DirectN._tagpropertykey;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION
    {
        public IntPtr endpoint;
        public Guid propertyStoreContext;
        public __MIDL___MIDL_itf_mmdeviceapi_0000_0008_0002 propertyStoreType;
        public IntPtr propertyStore;
        public PROPERTYKEY propertyKey;
    }
}
