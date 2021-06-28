// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ocidl.h(6514,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cf51ed10-62fe-11cf-bf86-00a0c9034836"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IQuickActivate
    {
        [PreserveSig]
        HRESULT QuickActivate(/* [in] */ ref tagQACONTAINER pQaContainer, /* [out][in] */ ref tagQACONTROL pQaControl);
        
        [PreserveSig]
        HRESULT SetContentExtent(/* [in] __RPC__in */ ref tagSIZE pSizel);
        
        [PreserveSig]
        HRESULT GetContentExtent(/* [out] __RPC__out */ out tagSIZE pSizel);
    }
}
