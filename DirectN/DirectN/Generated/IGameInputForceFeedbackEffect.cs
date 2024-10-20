// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("51bda05e-f742-45d9-b085-9444ae48381d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameInputForceFeedbackEffect
    {
        [PreserveSig]
        void GetDevice(/* THIS_ _Outptr_ */ out IGameInputDevice device);
        
        [PreserveSig]
        uint GetMotorIndex();
        
        [PreserveSig]
        void GetGain();
        
        [PreserveSig]
        void SetGain(/* THIS_ _In_ */ float gain);
        
        [PreserveSig]
        void GetParams(/* THIS_ _Out_ */ out GameInputForceFeedbackParams @params);
        
        [PreserveSig]
        void SetParams(/* THIS_ _In_ */ ref GameInputForceFeedbackParams @params);
        
        [PreserveSig]
        GameInputFeedbackEffectState GetState();
        
        [PreserveSig]
        void SetState(/* THIS_ _In_ */ GameInputFeedbackEffectState state);
    }
}
