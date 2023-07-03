// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(8110,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _tagKSJACK_SINK_INFORMATION
    {
        public KSJACK_SINK_CONNECTIONTYPE ConnType;
        public ushort ManufacturerId;
        public ushort ProductId;
        public ushort AudioLatency;
        public bool HDCPCapable;
        public bool AICapable;
        public byte SinkDescriptionLength;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string SinkDescription;
        public LUID PortId;
    }
}
