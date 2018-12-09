// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmcodecdsp.h(1397,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("cee3def2-3808-414d-be66-fafd472210bc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMValidate
    {
        [PreserveSig]
        HRESULT SetIdentifier(/* [in] */ Guid guidValidationID);
    }
}
