// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(5513,9)
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
