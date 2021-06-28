// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(15606,5)
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
