﻿// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagMIXERCONTROLA
    {
        public uint cbStruct;
        public uint dwControlID;
        public uint dwControlType;
        public uint fdwControl;
        public uint cMultipleItems;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)] 
        public string szShortName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string szName;
        public tagMIXERCONTROLA__union_0 Bounds;
        public tagMIXERCONTROLA__union_1 Metrics;
    }
}
