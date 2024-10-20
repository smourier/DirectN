// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputControllerSwitchInfo
    {
        public GameInputKind mappedInputKinds;
        public GameInputLabel label;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)] 
        public GameInputLabel[] positionLabels;
        public GameInputSwitchKind kind;
        public ushort legacyDInputIndex;
        public ushort legacyHidIndex;
        public uint rawReportIndex;
        public IntPtr inputReport;
        public IntPtr inputReportItem;
    }
}
