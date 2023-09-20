// generated from <Windows SDK Path>\um\wincodecsdk.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("00675040-6908-45f8-86a3-49c7dfd6d9ad"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICPersistStream
    {
        [PreserveSig]
        HRESULT LoadEx(/* [unique][in] __RPC__in_opt */ IStream pIStream, /* optional(GUID) */ IntPtr pguidPreferredVendor, /* [in] */ uint dwPersistOptions);
        
        [PreserveSig]
        HRESULT SaveEx(/* [in] __RPC__in_opt */ IStream pIStream, /* [in] */ uint dwPersistOptions, /* [in] */ bool fClearDirty);
    }
}
