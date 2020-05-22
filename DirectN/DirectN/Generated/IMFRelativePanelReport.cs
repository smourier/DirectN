// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(21226,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f25362ea-2c0e-447f-81e2-755914cdc0c3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRelativePanelReport
    {
        [PreserveSig]
        HRESULT GetRelativePanel(/* [annotation][out] _Out_ */ out uint panel);
    }
}
