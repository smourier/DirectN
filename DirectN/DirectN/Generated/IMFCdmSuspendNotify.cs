// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7a5645d2-43bd-47fd-87b7-dcd24cc7d692"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCdmSuspendNotify
    {
        [PreserveSig]
        HRESULT Begin();
        
        [PreserveSig]
        HRESULT End();
    }
}
