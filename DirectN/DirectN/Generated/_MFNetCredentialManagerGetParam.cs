// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(11409,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFNetCredentialManagerGetParam
    {
        public HRESULT hrOp;
        public bool fAllowLoggedOnUser;
        public bool fClearTextPackage;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszUrl;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszSite;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszRealm;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszPackage;
        public int nRetries;
    }
}
