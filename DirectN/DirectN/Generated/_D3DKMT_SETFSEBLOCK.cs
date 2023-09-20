// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETFSEBLOCK
    {
        public LUID AdapterLuid;
        public uint hAdapter;
        public uint VidPnSourceId;
        public _D3DKMT_SETFSEBLOCKFLAGS Flags;
    }
}
