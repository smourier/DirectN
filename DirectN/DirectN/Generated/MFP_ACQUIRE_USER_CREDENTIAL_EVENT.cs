// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfplay.h(1212,9)
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
