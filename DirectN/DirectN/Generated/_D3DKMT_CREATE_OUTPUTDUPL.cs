// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3606,9)
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
