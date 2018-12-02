// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmp2dlna.h(80,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0c012799-1b61-4c10-bda9-04445be5f561"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDLNASinkInit
    {
        [PreserveSig]
        HRESULT Initialize(ref IMFByteStream pByteStream, bool fPal);
    }
}
