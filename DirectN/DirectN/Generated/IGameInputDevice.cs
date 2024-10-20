// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;
using size_t = System.UInt64;

namespace DirectN
{
    [ComImport, Guid("31dd86fb-4c1b-408a-868f-439b3cd47125"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameInputDevice
    {
        [PreserveSig]
        GameInputDeviceInfo GetDeviceInfo();
        
        [PreserveSig]
        GameInputDeviceStatus GetDeviceStatus();
        
        [PreserveSig]
        void GetBatteryState(/* THIS_ _Out_ */ out GameInputBatteryState state);
        
        [PreserveSig]
        HRESULT CreateForceFeedbackEffect(/* THIS_ _In_ */ uint motorIndex, /* _In_ */ ref GameInputForceFeedbackParams @params, /* _COM_Outptr_ */ out IGameInputForceFeedbackEffect effect);
        
        [PreserveSig]
        void IsForceFeedbackMotorPoweredOn(/* THIS_ _In_ */ uint motorIndex);
        
        [PreserveSig]
        void SetForceFeedbackMotorGain(/* THIS_ _In_ */ uint motorIndex, /* _In_ */ float masterGain);
        
        [PreserveSig]
        HRESULT SetHapticMotorState(/* THIS_ _In_ */ uint motorIndex, /* optional(GameInputHapticFeedbackParams) */ IntPtr @params);
        
        [PreserveSig]
        void SetRumbleState(/* optional(GameInputRumbleParams) */ IntPtr @params);
        
        [PreserveSig]
        void SetInputSynchronizationState(/* THIS_ _In_ */ bool enabled);
        
        [PreserveSig]
        void SendInputSynchronizationHint();
        
        [PreserveSig]
        void PowerOff();
        
        [PreserveSig]
        HRESULT CreateRawDeviceReport(/* THIS_ _In_ */ uint reportId, /* _In_ */ GameInputRawDeviceReportKind reportKind, /* _COM_Outptr_ */ out IGameInputRawDeviceReport report);
        
        [PreserveSig]
        HRESULT GetRawDeviceFeature(/* THIS_ _In_ */ uint reportId, /* _COM_Outptr_ */ out IGameInputRawDeviceReport report);
        
        [PreserveSig]
        HRESULT SetRawDeviceFeature(/* THIS_ _In_ */ IGameInputRawDeviceReport report);
        
        [PreserveSig]
        HRESULT SendRawDeviceOutput(/* THIS_ _In_ */ IGameInputRawDeviceReport report);
        
        [PreserveSig]
        HRESULT SendRawDeviceOutputWithResponse(/* THIS_ _In_ */ IGameInputRawDeviceReport requestReport, /* _COM_Outptr_ */ out IGameInputRawDeviceReport responseReport);
        
        [PreserveSig]
        HRESULT ExecuteRawDeviceIoControl(/* THIS_ _In_ */ uint controlCode, /* _In_ */ ulong inputBufferSize, /* optional(void) */ IntPtr inputBuffer, /* _In_ */ ulong outputBufferSize, /* optional(void) */ IntPtr outputBuffer, /* optional(size_t) */ IntPtr outputSize);
        
        [PreserveSig]
        void AcquireExclusiveRawDeviceAccess(/* THIS_ _In_ */ ulong timeoutInMicroseconds);
        
        [PreserveSig]
        void ReleaseExclusiveRawDeviceAccess();
    }
}
