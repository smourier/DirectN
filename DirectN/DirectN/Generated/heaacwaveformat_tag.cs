﻿// generated from <Windows SDK Path>\shared\mmreg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct heaacwaveformat_tag
    {
        public heaacwaveinfo_tag wfInfo;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] pbAudioSpecificConfig;
    }
}
