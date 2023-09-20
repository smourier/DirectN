// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TUNER_SCAN_CAPS_S
    {
        public KSIDENTIFIER Property;
        public bool fSupportsHardwareAssistedScanning;
        public uint SupportedBroadcastStandards;
        public IntPtr GUIDBucket;
        public uint lengthofBucket;
    }
}
