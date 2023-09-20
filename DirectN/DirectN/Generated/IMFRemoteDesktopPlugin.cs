// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1cde6309-cae0-4940-907e-c1ec9c3d1d4a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRemoteDesktopPlugin
    {
        [PreserveSig]
        HRESULT UpdateTopology(/* [out][in] */ ref IMFTopology pTopology);
    }
}
