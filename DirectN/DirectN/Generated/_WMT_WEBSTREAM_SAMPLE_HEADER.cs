﻿// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _WMT_WEBSTREAM_SAMPLE_HEADER
    {
        public ushort cbLength;
        public ushort wPart;
        public ushort cTotalParts;
        public ushort wSampleType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string wszURL;
    }
}
