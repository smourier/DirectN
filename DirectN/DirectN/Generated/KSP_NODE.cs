// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(154,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSP_NODE
    {
        public KSIDENTIFIER Property;
        public uint NodeId;
        public uint Reserved;
    }
}
