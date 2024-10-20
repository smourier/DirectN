// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputDeviceInfo
    {
        public uint infoSize;
        public ushort vendorId;
        public ushort productId;
        public ushort revisionNumber;
        public byte interfaceNumber;
        public byte collectionNumber;
        public GameInputUsage usage;
        public GameInputVersion hardwareVersion;
        public GameInputVersion firmwareVersion;
        public APP_LOCAL_DEVICE_ID deviceId;
        public APP_LOCAL_DEVICE_ID deviceRootId;
        public GameInputDeviceFamily deviceFamily;
        public GameInputDeviceCapabilities capabilities;
        public GameInputKind supportedInput;
        public GameInputRumbleMotors supportedRumbleMotors;
        public uint inputReportCount;
        public uint outputReportCount;
        public uint featureReportCount;
        public uint controllerAxisCount;
        public uint controllerButtonCount;
        public uint controllerSwitchCount;
        public uint touchPointCount;
        public uint touchSensorCount;
        public uint forceFeedbackMotorCount;
        public uint hapticFeedbackMotorCount;
        public uint deviceStringCount;
        public uint deviceDescriptorSize;
        public IntPtr inputReportInfo;
        public IntPtr outputReportInfo;
        public IntPtr featureReportInfo;
        public IntPtr controllerAxisInfo;
        public IntPtr controllerButtonInfo;
        public IntPtr controllerSwitchInfo;
        public IntPtr keyboardInfo;
        public IntPtr mouseInfo;
        public IntPtr touchSensorInfo;
        public IntPtr motionInfo;
        public IntPtr arcadeStickInfo;
        public IntPtr flightStickInfo;
        public IntPtr gamepadInfo;
        public IntPtr racingWheelInfo;
        public IntPtr uiNavigationInfo;
        public IntPtr forceFeedbackMotorInfo;
        public IntPtr hapticFeedbackMotorInfo;
        public IntPtr displayName;
        public IntPtr deviceStrings;
        public IntPtr deviceDescriptorData;
        public GameInputSystemButtons supportedSystemButtons;
    }
}
