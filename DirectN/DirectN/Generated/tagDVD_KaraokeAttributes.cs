﻿// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_KaraokeAttributes
    {
        public byte bVersion;
        public bool fMasterOfCeremoniesInGuideVocal1;
        public bool fDuet;
        public tagDVD_KARAOKE_ASSIGNMENT ChannelAssignment;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ushort[] wChannelContents;
    }
}
