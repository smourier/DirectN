// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxcapi.h(155,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7f61fc7d-950d-467f-b3e3-3c02fb49187c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcIncludeHandler
    {
        [PreserveSig]
        HRESULT LoadSource(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFilename, /* // Candidate filename. _COM_Outptr_result_maybenull_ */ out IDxcBlob ppIncludeSource);
    }
}
