using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2cd2d921-c447-44a7-a13c-4adabfc247e3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFAttributes
    {
        [PreserveSig]
        HRESULT GetItem([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, PropVariant pValue);

        [PreserveSig]
        HRESULT GetItemType([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out MF_ATTRIBUTE_TYPE pType);

        [PreserveSig]
        HRESULT CompareItem([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, PropVariant Value, out bool pbResult);

        [PreserveSig]
        HRESULT Compare(IMFAttributes pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, out bool pbResult);

        [PreserveSig]
        HRESULT GetUINT32([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out uint punValue);

        [PreserveSig]
        HRESULT GetUINT64([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out ulong punValue);

        [PreserveSig]
        HRESULT GetDouble([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out double pfValue);

        [PreserveSig]
        HRESULT GetGUID([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out Guid pguidValue);

        [PreserveSig]
        HRESULT GetStringLength([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out int pcchLength);

        [PreserveSig]
        HRESULT GetString([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPWStr)] string pwszValue, int cchBufSize, ref int pcchLength);

        [PreserveSig]
        HRESULT GetAllocatedString([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out IntPtr ppwszValue, out int pcchLength);

        [PreserveSig]
        HRESULT GetBlobSize([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out int pcbBlobSize);

        [PreserveSig]
        HRESULT GetBlob([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, IntPtr pBuf, int cbBufSize, ref int pcbBlobSize);

        [PreserveSig]
        HRESULT GetAllocatedBlob([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out IntPtr ppBuf, out int pcbSize);

        [PreserveSig]
        HRESULT GetUnknown([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppv);

        [PreserveSig]
        HRESULT SetItem([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, PropVariant Value);

        [PreserveSig]
        HRESULT DeleteItem([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey);

        [PreserveSig]
        HRESULT DeleteAllItems();

        [PreserveSig]
        HRESULT SetUINT32([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unValue);

        [PreserveSig]
        HRESULT SetUINT64([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, ulong unValue);

        [PreserveSig]
        HRESULT SetDouble([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fValue);

        [PreserveSig]
        HRESULT SetGUID([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPStruct)] Guid guidValue);

        [PreserveSig]
        HRESULT SetString([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPWStr)] string wszValue);

        [PreserveSig]
        HRESULT SetBlob([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, IntPtr pBuf, uint cbBufSize);

        [PreserveSig]
        HRESULT SetUnknown([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        HRESULT LockStore();

        [PreserveSig]
        HRESULT UnlockStore();

        [PreserveSig]
        HRESULT GetCount(out int pcItems);

        [PreserveSig]
        HRESULT GetItemByIndex(int unIndex, out Guid pguidKey, PropVariant pValue);

        [PreserveSig]
        HRESULT CopyAllItems(out IMFAttributes pDest);
    }
}
