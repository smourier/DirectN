// generated from <Windows SDK Path>\um\wmpservices.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d683162f-57d4-4108-8373-4a9676d1c2e9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPConvert
    {
        [PreserveSig]
        HRESULT ConvertFile(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrInputFile, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrDestinationFolder, /* [out] */ out IntPtr pbstrOutputFile);
        
        [PreserveSig]
        HRESULT GetErrorURL(/* [out] */ out IntPtr pbstrURL);
    }
}
