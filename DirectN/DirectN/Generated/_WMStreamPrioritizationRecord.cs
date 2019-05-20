// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(1463,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _WMStreamPrioritizationRecord
    {
        public ushort wStreamNumber;
        public bool fMandatory;
    }
}
