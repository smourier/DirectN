// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmiutils.h(1172,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_SWbemAnalysisMatrixList
    {
        public uint m_uVersion;
        public uint m_uMatrixType;
        public uint m_uNumMatrices;
        public IntPtr m_pMatrices;
    }
}
