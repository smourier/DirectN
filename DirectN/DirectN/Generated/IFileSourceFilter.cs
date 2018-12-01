// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(6154,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a868a6-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFileSourceFilter
    {
        [PreserveSig]
        HRESULT Load(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, /* [annotation][unique][in] _In_opt_ */ ref _AMMediaType pmt);
        
        [PreserveSig]
        HRESULT GetCurFile(/* [annotation][out] _Out_ */ out IntPtr ppszFileName, /* [annotation][out] _Out_opt_ */ out _AMMediaType pmt);
    }
}
