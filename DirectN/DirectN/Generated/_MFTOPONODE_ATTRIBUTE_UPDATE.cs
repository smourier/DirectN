// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(10676,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFTOPONODE_ATTRIBUTE_UPDATE
    {
        public ulong NodeId;
        public Guid guidAttributeKey;
        public _MF_ATTRIBUTE_TYPE attrType;
        public _MFTOPONODE_ATTRIBUTE_UPDATE__union_0 __union_3;
    }
}
