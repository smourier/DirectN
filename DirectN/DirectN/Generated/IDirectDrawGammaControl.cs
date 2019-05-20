// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddraw.h(2195,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("69c11c3e-b46b-11d1-ad7a-00c04fc29b4e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawGammaControl
    {
        [PreserveSig]
        HRESULT GetGammaRamp(uint __unnamed_0, ref _DDGAMMARAMP __unnamed_1);
        
        [PreserveSig]
        HRESULT SetGammaRamp(uint __unnamed_0, ref _DDGAMMARAMP __unnamed_1);
    }
}
