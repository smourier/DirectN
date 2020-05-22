// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(9029,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5acd6aa0-f482-11ce-8b67-00aa00a3f1a6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IConfigAviMux
    {
        [PreserveSig]
        HRESULT SetMasterStream(/* [in] */ int iStream);
        
        [PreserveSig]
        HRESULT GetMasterStream(/* [annotation][out] _Out_ */ out int pStream);
        
        [PreserveSig]
        HRESULT SetOutputCompatibilityIndex(/* [in] */ bool fOldIndex);
        
        [PreserveSig]
        HRESULT GetOutputCompatibilityIndex(/* [annotation][out] _Out_ */ out bool pfOldIndex);
    }
}
