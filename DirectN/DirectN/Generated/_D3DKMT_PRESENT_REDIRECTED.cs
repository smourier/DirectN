// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(730,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENT_REDIRECTED
    {
        public uint hSyncObj;
        public uint hDevice;
        public ulong WaitedFenceValue;
        public _D3DKMT_PRESENTHISTORYTOKEN PresentHistoryToken;
        public _D3DKMT_PRESENT_REDIRECTEDS_FLAGS Flags;
        public uint hSource;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
    }
}
