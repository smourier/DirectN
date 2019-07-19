// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(2253,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusData
    {
        public Guid rApp;
        public uint dwFlags;
        public uint dwData;
        public uint ExtendedInfoValidMask;
        public uint ExtendedInfoData;
    }
}
