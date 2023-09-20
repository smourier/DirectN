// generated from <Windows SDK Path>\um\mmdeviceapi.h
using System;
using System.Runtime.InteropServices;
using PROPERTYKEY = DirectN._tagpropertykey;

namespace DirectN
{
    [ComImport, Guid("20049d40-56d5-400e-a2ef-385599feed49"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSystemEffectsPropertyChangeNotificationClient
    {
        [PreserveSig]
        HRESULT OnPropertyChanged(/* [annotation][in] _In_ */ __MIDL___MIDL_itf_mmdeviceapi_0000_0008_0002 type, /* [annotation][in] _In_ */ PROPERTYKEY key);
    }
}
