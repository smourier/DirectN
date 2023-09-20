// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868a6-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFileSourceFilter
    {
        [PreserveSig]
        HRESULT Load(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, /* optional(_AMMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        HRESULT GetCurFile(/* [annotation][out] _Out_ */ out IntPtr ppszFileName, /* optional(_AMMediaType) */ IntPtr pmt);
    }
}
