// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7f61fc7d-950d-467f-b3e3-3c02fb49187c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcIncludeHandler
    {
        [PreserveSig]
        HRESULT LoadSource(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFilename, /* // Candidate filename. _COM_Outptr_result_maybenull_ */ out IDxcBlob ppIncludeSource);
    }
}
