﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2479,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_TABLE_REQUEST
    {
        public D3D12DDI_TABLE_TYPE tableType;
        public uint numTables;
    }
}
