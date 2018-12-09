// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmiutils.h(1161,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_SWbemAnalysisMatrix
    {
        public uint m_uVersion;
        public uint m_uMatrixType;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszProperty;
        public uint m_uPropertyType;
        public uint m_uEntries;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object m_pValues;
        public IntPtr m_pbTruthTable;
    }
}
