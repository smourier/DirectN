// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVICE_CREATION_PARAMETERS_32
    {
        public uint AdapterOrdinal;
        public _D3DDEVTYPE DeviceType;
        public IntPtr hFocusWindow;
        public uint BehaviorFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDEVICE_CREATION_PARAMETERS_64
    {
        public uint AdapterOrdinal;
        public _D3DDEVTYPE DeviceType;
        public IntPtr hFocusWindow;
        public uint BehaviorFlags;
    }
}
