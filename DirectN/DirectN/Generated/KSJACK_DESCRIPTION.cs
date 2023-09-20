// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;
using EPcxConnectionType = DirectN.eConnType;
using EPcxGenLocation = DirectN.__enum_23181;
using EPcxGeoLocation = DirectN.__enum_24782;
using EPxcPortConnection = DirectN.ePortConn;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSJACK_DESCRIPTION
    {
        public uint ChannelMapping;
        public uint Color;
        public EPcxConnectionType ConnectionType;
        public EPcxGeoLocation GeoLocation;
        public EPcxGenLocation GenLocation;
        public EPxcPortConnection PortConnection;
        public bool IsConnected;
    }
}
