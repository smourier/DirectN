// generated from <Windows SDK Path>\um\mfidl.h
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
