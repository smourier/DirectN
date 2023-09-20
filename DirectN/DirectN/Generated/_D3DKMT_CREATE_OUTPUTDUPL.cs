// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATE_OUTPUTDUPL
    {
        public uint hAdapter;
        public uint VidPnSourceId;
        public uint KeyedMutexCount;
        public uint RequiredKeyedMutexCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public _D3DKMT_OUTPUTDUPL_KEYEDMUTEX[] KeyedMutexs;
        public _D3DKMT_OUTPUTDUPLCREATIONFLAGS Flags;
    }
}
