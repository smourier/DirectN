// generated from <Windows SDK Path>\um\mfmp2dlna.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0c012799-1b61-4c10-bda9-04445be5f561"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDLNASinkInit
    {
        [PreserveSig]
        HRESULT Initialize(IMFByteStream pByteStream, bool fPal);
    }
}
