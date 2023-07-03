// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(6898,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSPROPERTY_NETWORKCAMERACONTROL_METADATA_INFO
    {
        public uint MetadataItems;
        public uint Size;
        public bool PTZStatus;
        public bool Events;
        public bool Analytics;
        public bool Reserved;
    }
}
