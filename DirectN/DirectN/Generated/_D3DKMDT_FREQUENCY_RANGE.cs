﻿// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_FREQUENCY_RANGE
    {
        public _D3DDDI_RATIONAL MinVSyncFreq;
        public _D3DDDI_RATIONAL MaxVSyncFreq;
        public _D3DDDI_RATIONAL MinHSyncFreq;
        public _D3DDDI_RATIONAL MaxHSyncFreq;
    }
}
