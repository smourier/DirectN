// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmdeviceapi.h(1351,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("302ae7f9-d7e0-43e4-971b-1f8293613d2a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSystemEffectsPropertyStore
    {
        [PreserveSig]
        HRESULT OpenDefaultPropertyStore(/* [annotation][in] _In_ */ uint stgmAccess, /* [annotation][out] _COM_Outptr_ */ out IPropertyStore propStore);
        
        [PreserveSig]
        HRESULT OpenUserPropertyStore(/* [annotation][in] _In_ */ uint stgmAccess, /* [annotation][out] _COM_Outptr_ */ out IPropertyStore propStore);
        
        [PreserveSig]
        HRESULT OpenVolatilePropertyStore(/* [annotation][in] _In_ */ uint stgmAccess, /* [annotation][out] _COM_Outptr_ */ out IPropertyStore propStore);
        
        [PreserveSig]
        HRESULT ResetUserPropertyStore();
        
        [PreserveSig]
        HRESULT ResetVolatilePropertyStore();
        
        [PreserveSig]
        HRESULT RegisterPropertyChangeNotification(/* [annotation][in] _In_ */ IAudioSystemEffectsPropertyChangeNotificationClient callback);
        
        [PreserveSig]
        HRESULT UnregisterPropertyChangeNotification(/* [annotation][in] _In_ */ IAudioSystemEffectsPropertyChangeNotificationClient callback);
    }
}
