// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6f497062-f2e2-4624-8ea7-9dd40d81fc8d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWatermarkInfo
    {
        [PreserveSig]
        HRESULT GetWatermarkEntryCount(/* [in] */ tagWMT_WATERMARK_ENTRY_TYPE wmetType, /* [out] */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetWatermarkEntry(/* [in] */ tagWMT_WATERMARK_ENTRY_TYPE wmetType, /* [in] */ uint dwEntryNum, /* [out] */ out __WMT_WATERMARK_ENTRY pEntry);
    }
}
