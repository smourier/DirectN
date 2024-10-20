// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputControllerAxisInfo
    {
        public GameInputKind mappedInputKinds;
        public GameInputLabel label;
        public bool isContinuous;
        public bool isNonlinear;
        public bool isQuantized;
        public bool hasRestValue;
        public float restValue;
        public ulong resolution;
        public ushort legacyDInputIndex;
        public ushort legacyHidIndex;
        public uint rawReportIndex;
        public IntPtr inputReport;
        public IntPtr inputReportItem;
    }
}
