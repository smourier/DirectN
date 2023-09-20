// generated from <Windows SDK Path>\um\audioengineextensionapo.h
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
