// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputControllerButtonInfo
    {
        public GameInputKind mappedInputKinds;
        public GameInputLabel label;
        public ushort legacyDInputIndex;
        public ushort legacyHidIndex;
        public uint rawReportIndex;
        public IntPtr inputReport;
        public IntPtr inputReportItem;
    }
}
