// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\spatialaudioclient.h(1106,9)
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
