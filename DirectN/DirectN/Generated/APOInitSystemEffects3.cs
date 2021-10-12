// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineextensionapo.h(237,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APOInitSystemEffects3
    {
        public APOInitBaseStruct APOInit;
        public IntPtr pAPOEndpointProperties;
        public IntPtr pServiceProvider;
        public IntPtr pDeviceCollection;
        public uint nSoftwareIoDeviceInCollection;
        public uint nSoftwareIoConnectorIndex;
        public Guid AudioProcessingMode;
        public bool InitializeForDiscoveryOnly;
    }
}
