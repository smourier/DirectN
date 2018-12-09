// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmiutils.h(1029,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_SWbemQueryQualifiedName
    {
        public uint m_uVersion;
        public uint m_uTokenType;
        public uint m_uNameListSize;
        public IntPtr m_ppszNameList;
        public bool m_bArraysUsed;
        public IntPtr m_pbArrayElUsed;
        public IntPtr m_puArrayIndex;
    }
}
