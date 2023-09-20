// generated from <Windows SDK Path>\um\mfplay.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFP_ACQUIRE_USER_CREDENTIAL_EVENT
    {
        public MFP_EVENT_HEADER header;
        public IntPtr dwUserData;
        public bool fProceedWithAuthentication;
        public HRESULT hrAuthenticationStatus;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszURL;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszSite;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszRealm;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszPackage;
        public int nRetries;
        public uint flags;
        public IntPtr pCredential;
    }
}
