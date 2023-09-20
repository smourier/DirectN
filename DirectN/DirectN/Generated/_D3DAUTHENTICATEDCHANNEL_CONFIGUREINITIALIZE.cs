// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE
    {
        public _D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;
        public uint StartSequenceQuery;
        public uint StartSequenceConfigure;
    }
}
