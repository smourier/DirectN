// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(17900,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6967f2c9-4e26-4b57-8894-799880f7ac7b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMLicenseRevocationAgent
    {
        [PreserveSig]
        HRESULT GetLRBChallenge(/* [in] */ ref byte pMachineID, /* [in] */ uint dwMachineIDLength, /* [in] */ ref byte pChallenge, /* [in] */ uint dwChallengeLength, /* [out] */ out byte pChallengeOutput, /* [out] */ out uint pdwChallengeOutputLength);
        
        [PreserveSig]
        HRESULT ProcessLRB(/* [in] */ ref byte pSignedLRB, /* [in] */ uint dwSignedLRBLength, /* [out] */ out byte pSignedACK, /* [out] */ out uint pdwSignedACKLength);
    }
}
