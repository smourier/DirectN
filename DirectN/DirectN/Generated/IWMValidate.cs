// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cee3def2-3808-414d-be66-fafd472210bc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMValidate
    {
        [PreserveSig]
        HRESULT SetIdentifier(/* [in] */ Guid guidValidationID);
    }
}
