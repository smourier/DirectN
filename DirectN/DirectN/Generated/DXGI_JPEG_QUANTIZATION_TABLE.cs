﻿// generated from <Windows SDK Path>\shared\dxgitype.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_JPEG_QUANTIZATION_TABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] Elements;
    }
}
