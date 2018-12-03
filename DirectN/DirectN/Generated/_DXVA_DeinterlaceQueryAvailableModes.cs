// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(616,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_DeinterlaceQueryAvailableModes
    {
        public uint Size;
        public uint NumGuids;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public Guid[] Guids;
    }
}
