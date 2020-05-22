// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(2519,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ee4c8fe2-34b2-11d3-a3bf-006097c9b344"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPCdromCollection
    {
        [PreserveSig]
        HRESULT get_count(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT item(/* [in] */ int lIndex, /* [retval][out] */ out IWMPCdrom ppItem);
        
        [PreserveSig]
        HRESULT getByDriveSpecifier(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrDriveSpecifier, /* [retval][out] */ out IWMPCdrom ppCdrom);
    }
}
