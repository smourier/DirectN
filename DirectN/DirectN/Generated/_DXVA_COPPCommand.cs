// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(748,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPCommand
    {
        public Guid macKDI;
        public Guid guidCommandID;
        public uint dwSequence;
        public uint cbSizeData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)] 
        public byte CommandData;
    }
}
