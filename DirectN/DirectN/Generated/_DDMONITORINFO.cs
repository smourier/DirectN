// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDMONITORINFO
    {
        public ushort Manufacturer;
        public ushort Product;
        public uint SerialNumber;
        public Guid DeviceIdentifier;
        public int Mode640x480;
        public int Mode800x600;
        public int Mode1024x768;
        public int Mode1280x1024;
        public int Mode1600x1200;
        public int ModeReserved1;
        public int ModeReserved2;
        public int ModeReserved3;
    }
}
