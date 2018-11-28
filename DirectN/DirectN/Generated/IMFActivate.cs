using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7FEE9E9A-4A89-47a6-899C-B6A53A70FB67"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFActivate : IMFAttributes
    {
        // IMFAttributes
        [PreserveSig]
        new HRESULT GetItem([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, PropVariant pValue);

        [PreserveSig]
        new HRESULT GetItemType([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out MF_ATTRIBUTE_TYPE pType);

        [PreserveSig]
        new HRESULT CompareItem([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, PropVariant Value, out bool pbResult);

        [PreserveSig]
        new HRESULT Compare(IMFAttributes pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, out bool pbResult);

        [PreserveSig]
        new HRESULT GetUINT32([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out uint punValue);

        [PreserveSig]
        new HRESULT GetUINT64([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out ulong punValue);

        [PreserveSig]
        new HRESULT GetDouble([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out double pfValue);

        [PreserveSig]
        new HRESULT GetGUID([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out Guid pguidValue);

        [PreserveSig]
        new HRESULT GetStringLength([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out int pcchLength);

        [PreserveSig]
        new HRESULT GetString([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPWStr)] string pwszValue, int cchBufSize, ref int pcchLength);

        [PreserveSig]
        new HRESULT GetAllocatedString([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out IntPtr ppwszValue, out int pcchLength);

        [PreserveSig]
        new HRESULT GetBlobSize([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out int pcbBlobSize);

        [PreserveSig]
        new HRESULT GetBlob([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, IntPtr pBuf, int cbBufSize, ref int pcbBlobSize);

        [PreserveSig]
        new HRESULT GetAllocatedBlob([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out IntPtr ppBuf, out int pcbSize);

        [PreserveSig]
        new HRESULT GetUnknown([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppv);

        [PreserveSig]
        new HRESULT SetItem([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, PropVariant Value);

        [PreserveSig]
        new HRESULT DeleteItem([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey);

        [PreserveSig]
        new HRESULT DeleteAllItems();

        [PreserveSig]
        new HRESULT SetUINT32([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unValue);

        [PreserveSig]
        new HRESULT SetUINT64([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, ulong unValue);

        [PreserveSig]
        new HRESULT SetDouble([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fValue);

        [PreserveSig]
        new HRESULT SetGUID([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPStruct)] Guid guidValue);

        [PreserveSig]
        new HRESULT SetString([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPWStr)] string wszValue);

        [PreserveSig]
        new HRESULT SetBlob([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, IntPtr pBuf, uint cbBufSize);

        [PreserveSig]
        new HRESULT SetUnknown([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        new HRESULT LockStore();

        [PreserveSig]
        new HRESULT UnlockStore();

        [PreserveSig]
        new HRESULT GetCount(out int pcItems);

        [PreserveSig]
        new HRESULT GetItemByIndex(int unIndex, out Guid pguidKey, PropVariant pValue);

        [PreserveSig]
        new HRESULT CopyAllItems(out IMFAttributes pDest);

        // IMFActivate
        [PreserveSig]
        HRESULT ActivateObject([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppv);

        [PreserveSig]
        HRESULT ShutdownObject();

        [PreserveSig]
        HRESULT DetachObject();
    }
}
