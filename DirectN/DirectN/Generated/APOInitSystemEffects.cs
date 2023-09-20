// generated from <Windows SDK Path>\um\audioenginebaseapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APOInitSystemEffects
    {
        public APOInitBaseStruct APOInit;
        public IntPtr pAPOEndpointProperties;
        public IntPtr pAPOSystemEffectsProperties;
        public IntPtr pReserved;
        public IntPtr pDeviceCollection;
    }
}
