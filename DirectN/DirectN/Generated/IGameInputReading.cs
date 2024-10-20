// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2156947a-e1fa-4de0-a30b-d812931dbd8d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameInputReading
    {
        [PreserveSig]
        GameInputKind GetInputKind();
        
        [PreserveSig]
        ulong GetSequenceNumber(/* THIS_ _In_ */ GameInputKind inputKind);
        
        [PreserveSig]
        ulong GetTimestamp();
        
        [PreserveSig]
        void GetDevice(/* THIS_ _Outptr_ */ out IGameInputDevice device);
        
        [PreserveSig]
        void GetRawReport(/* THIS_ _Outptr_result_maybenull_ */ out IGameInputRawDeviceReport report);
        
        [PreserveSig]
        uint GetControllerAxisCount();
        
        [PreserveSig]
        uint GetControllerAxisState(/* THIS_ _In_ */ int stateArrayCount, /* _Out_writes_(stateArrayCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] float[] stateArray);
        
        [PreserveSig]
        uint GetControllerButtonCount();
        
        [PreserveSig]
        uint GetControllerButtonState(/* THIS_ _In_ */ int stateArrayCount, /* _Out_writes_(stateArrayCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] bool[] stateArray);
        
        [PreserveSig]
        uint GetControllerSwitchCount();
        
        [PreserveSig]
        uint GetControllerSwitchState(/* THIS_ _In_ */ int stateArrayCount, /* _Out_writes_(stateArrayCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] GameInputSwitchPosition[] stateArray);
        
        [PreserveSig]
        uint GetKeyCount();
        
        [PreserveSig]
        uint GetKeyState(/* THIS_ _In_ */ int stateArrayCount, /* _Out_writes_(stateArrayCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] GameInputKeyState[] stateArray);
        
        [PreserveSig]
        void GetMouseState(/* THIS_ _Out_ */ out GameInputMouseState state);
        
        [PreserveSig]
        uint GetTouchCount();
        
        [PreserveSig]
        uint GetTouchState(/* THIS_ _In_ */ int stateArrayCount, /* _Out_writes_(stateArrayCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] GameInputTouchState[] stateArray);
        
        [PreserveSig]
        void GetMotionState(/* THIS_ _Out_ */ out GameInputMotionState state);
        
        [PreserveSig]
        void GetArcadeStickState(/* THIS_ _Out_ */ out GameInputArcadeStickState state);
        
        [PreserveSig]
        void GetFlightStickState(/* THIS_ _Out_ */ out GameInputFlightStickState state);
        
        [PreserveSig]
        void GetGamepadState(/* THIS_ _Out_ */ out GameInputGamepadState state);
        
        [PreserveSig]
        void GetRacingWheelState(/* THIS_ _Out_ */ out GameInputRacingWheelState state);
        
        [PreserveSig]
        void GetUiNavigationState(/* THIS_ _Out_ */ out GameInputUiNavigationState state);
    }
}
