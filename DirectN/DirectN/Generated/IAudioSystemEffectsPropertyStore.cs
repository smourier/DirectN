// generated from <Windows SDK Path>\um\mmdeviceapi.h
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
