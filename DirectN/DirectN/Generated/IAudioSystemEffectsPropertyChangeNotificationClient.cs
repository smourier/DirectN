// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmdeviceapi.h(1261,5)
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
