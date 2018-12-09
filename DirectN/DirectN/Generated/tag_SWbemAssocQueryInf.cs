// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmiutils.h(1180,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_SWbemAssocQueryInf
    {
        public uint m_uVersion;
        public uint m_uAnalysisType;
        public uint m_uFeatureMask;
        public IntPtr m_pPath;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszPath;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszQueryText;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszResultClass;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszAssocClass;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszRole;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszResultRole;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszRequiredQualifier;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string m_pszRequiredAssocQualifier;
    }
}
