// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;
using GameInputCallbackToken = System.UInt64;
using GameInputDeviceCallback = System.IntPtr;
using GameInputKeyboardLayoutCallback = System.IntPtr;
using GameInputReadingCallback = System.IntPtr;
using GameInputSystemButtonCallback = System.IntPtr;

namespace DirectN
{
    [ComImport, Guid("11be2a7e-4254-445a-9c09-ffc40f006918"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameInput
    {
        [PreserveSig]
        ulong GetCurrentTimestamp();
        
        [PreserveSig]
        HRESULT GetCurrentReading(/* THIS_ _In_ */ GameInputKind inputKind, /* _In_opt_ */ IGameInputDevice device, /* _COM_Outptr_ */ out IGameInputReading reading);
        
        [PreserveSig]
        HRESULT GetNextReading(/* THIS_ _In_ */ IGameInputReading referenceReading, /* _In_ */ GameInputKind inputKind, /* _In_opt_ */ IGameInputDevice device, /* _COM_Outptr_ */ out IGameInputReading reading);
        
        [PreserveSig]
        HRESULT GetPreviousReading(/* THIS_ _In_ */ IGameInputReading referenceReading, /* _In_ */ GameInputKind inputKind, /* _In_opt_ */ IGameInputDevice device, /* _COM_Outptr_ */ out IGameInputReading reading);
        
        [PreserveSig]
        HRESULT GetTemporalReading(/* THIS_ _In_ */ ulong timestamp, /* _In_ */ IGameInputDevice device, /* _COM_Outptr_ */ out IGameInputReading reading);
        
        [PreserveSig]
        HRESULT RegisterReadingCallback(/* THIS_ _In_opt_ */ IGameInputDevice device, /* _In_ */ GameInputKind inputKind, /* _In_ */ float analogThreshold, /* optional(void) */ IntPtr context, /* _In_ */ ref GameInputReadingCallback callbackFunc, /* optional(GameInputCallbackToken) */ IntPtr callbackToken);
        
        [PreserveSig]
        HRESULT RegisterDeviceCallback(/* THIS_ _In_opt_ */ IGameInputDevice device, /* _In_ */ GameInputKind inputKind, /* _In_ */ GameInputDeviceStatus statusFilter, /* _In_ */ GameInputEnumerationKind enumerationKind, /* optional(void) */ IntPtr context, /* _In_ */ ref GameInputDeviceCallback callbackFunc, /* optional(GameInputCallbackToken) */ IntPtr callbackToken);
        
        [PreserveSig]
        HRESULT RegisterSystemButtonCallback(/* THIS_ _In_opt_ */ IGameInputDevice device, /* _In_ */ GameInputSystemButtons buttonFilter, /* optional(void) */ IntPtr context, /* _In_ */ ref GameInputSystemButtonCallback callbackFunc, /* optional(GameInputCallbackToken) */ IntPtr callbackToken);
        
        [PreserveSig]
        HRESULT RegisterKeyboardLayoutCallback(/* THIS_ _In_opt_ */ IGameInputDevice device, /* optional(void) */ IntPtr context, /* _In_ */ ref GameInputKeyboardLayoutCallback callbackFunc, /* optional(GameInputCallbackToken) */ IntPtr callbackToken);
        
        [PreserveSig]
        void StopCallback(/* THIS_ _In_ */ ulong callbackToken);
        
        [PreserveSig]
        void UnregisterCallback(/* THIS_ _In_ */ ulong callbackToken, /* _In_ */ ulong timeoutInMicroseconds);
        
        [PreserveSig]
        HRESULT CreateDispatcher(/* THIS_ _COM_Outptr_ */ out IGameInputDispatcher dispatcher);
        
        [PreserveSig]
        HRESULT CreateAggregateDevice(/* THIS_ _In_ */ GameInputKind inputKind, /* _COM_Outptr_ */ out IGameInputDevice device);
        
        [PreserveSig]
        HRESULT FindDeviceFromId(/* THIS_ _In_ */ ref APP_LOCAL_DEVICE_ID value, /* _COM_Outptr_ */ out IGameInputDevice device);
        
        [PreserveSig]
        HRESULT FindDeviceFromObject(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object value, /* _COM_Outptr_ */ out IGameInputDevice device);
        
        [PreserveSig]
        HRESULT FindDeviceFromPlatformHandle(/* THIS_ _In_ */ IntPtr value, /* _COM_Outptr_ */ out IGameInputDevice device);
        
        [PreserveSig]
        HRESULT FindDeviceFromPlatformString(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string value, /* _COM_Outptr_ */ out IGameInputDevice device);
        
        [PreserveSig]
        HRESULT EnableOemDeviceSupport(/* THIS_ _In_ */ ushort vendorId, /* _In_ */ ushort productId, /* _In_ */ byte interfaceNumber, /* _In_ */ byte collectionNumber);
        
        [PreserveSig]
        void SetFocusPolicy(/* THIS_ _In_ */ GameInputFocusPolicy policy);
    }
}
