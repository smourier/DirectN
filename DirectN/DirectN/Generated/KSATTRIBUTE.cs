﻿// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ks.h(1125,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSATTRIBUTE
    {
        public uint Size;
        public uint Flags;
        public Guid Attribute;
    }
}
