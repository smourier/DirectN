// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmiutils.h(1139,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_SWbemRpnEncodedQuery
    {
        public uint m_uVersion;
        public uint m_uTokenType;
        public ulong m_uParsedFeatureMask;
        public uint m_uDetectedArraySize;
        public IntPtr m_puDetectedFeatures;
        public uint m_uSelectListSize;
        public IntPtr m_ppSelectList;
        public uint m_uFromTargetType;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszOptionalFromPath;
        public uint m_uFromListSize;
        public IntPtr m_ppszFromList;
        public uint m_uWhereClauseSize;
        public IntPtr m_ppRpnWhereClause;
        public double m_dblWithinPolling;
        public double m_dblWithinWindow;
        public uint m_uOrderByListSize;
        public IntPtr m_ppszOrderByList;
        public IntPtr m_uOrderDirectionEl;
    }
}
