// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(6264,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a2104830-7c70-11cf-8bce-00aa00a3f1a6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFileSinkFilter
    {
        [PreserveSig]
        HRESULT SetFileName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, /* optional(_AMMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        HRESULT GetCurFile(/* [annotation][out] _Out_ */ out IntPtr ppszFileName, /* [annotation][out] _Out_ */ out _AMMediaType pmt);
    }
}
