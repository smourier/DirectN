// generated from <Windows SDK Path>\um\spatialaudioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpatialAudioClientActivationParams
    {
        public Guid tracingContextId;
        public Guid appId;
        public int majorVersion;
        public int minorVersion1;
        public int minorVersion2;
        public int minorVersion3;
    }
}
