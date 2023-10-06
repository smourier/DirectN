// generated from <Windows SDK Path>\um\mfvirtualcamera.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1c08a864-ef6c-4c75-af59-5f2d68da9563"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVirtualCamera : IMFAttributes
    {
        // IMFAttributes
        [PreserveSig]
        new HRESULT GetItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [full][out][in] __RPC__inout_opt */ [In, Out] PropVariant pValue);
        
        [PreserveSig]
        new HRESULT GetItemType(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out _MF_ATTRIBUTE_TYPE pType);
        
        [PreserveSig]
        new HRESULT CompareItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [In, Out] PropVariant Value, /* [out] __RPC__out */ out bool pbResult);
        
        [PreserveSig]
        new HRESULT Compare(/* __RPC__in_opt */ IMFAttributes pTheirs, _MF_ATTRIBUTES_MATCH_TYPE MatchType, /* [out] __RPC__out */ out bool pbResult);
        
        [PreserveSig]
        new HRESULT GetUINT32(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint punValue);
        
        [PreserveSig]
        new HRESULT GetUINT64(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out ulong punValue);
        
        [PreserveSig]
        new HRESULT GetDouble(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out double pfValue);
        
        [PreserveSig]
        new HRESULT GetGUID(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out Guid pguidValue);
        
        [PreserveSig]
        new HRESULT GetStringLength(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint pcchLength);
        
        [PreserveSig]
        new HRESULT GetString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][out] __RPC__out_ecount_full(cchBufSize) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszValue, uint cchBufSize, /* optional(UINT32) */ IntPtr pcchLength);
        
        [PreserveSig]
        new HRESULT GetAllocatedString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* optional(LPWSTR) */ IntPtr ppwszValue, /* [out] __RPC__out */ out uint pcchLength);
        
        [PreserveSig]
        new HRESULT GetBlobSize(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint pcbBlobSize);
        
        [PreserveSig]
        new HRESULT GetBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][out] __RPC__out_ecount_full(cbBufSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, int cbBufSize, /* optional(UINT32) */ IntPtr pcbBlobSize);
        
        [PreserveSig]
        new HRESULT GetAllocatedBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* optional(UINT8) */ out IntPtr ppBuf, /* [out] __RPC__out */ out uint pcbSize);
        
        [PreserveSig]
        new HRESULT GetUnknown(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        new HRESULT SetItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [In, Out] PropVariant Value);
        
        [PreserveSig]
        new HRESULT DeleteItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey);
        
        [PreserveSig]
        new HRESULT DeleteAllItems();
        
        [PreserveSig]
        new HRESULT SetUINT32(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unValue);
        
        [PreserveSig]
        new HRESULT SetUINT64(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, ulong unValue);
        
        [PreserveSig]
        new HRESULT SetDouble(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fValue);
        
        [PreserveSig]
        new HRESULT SetGUID(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidValue);
        
        [PreserveSig]
        new HRESULT SetString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string wszValue);
        
        [PreserveSig]
        new HRESULT SetBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][in] __RPC__in_ecount_full(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, int cbBufSize);
        
        [PreserveSig]
        new HRESULT SetUnknown(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);
        
        [PreserveSig]
        new HRESULT LockStore();
        
        [PreserveSig]
        new HRESULT UnlockStore();
        
        [PreserveSig]
        new HRESULT GetCount(/* [out] __RPC__out */ out uint pcItems);
        
        [PreserveSig]
        new HRESULT GetItemByIndex(uint unIndex, /* [out] __RPC__out */ out Guid pguidKey, /* [full][out][in] __RPC__inout_opt */ [In, Out] PropVariant pValue);
        
        [PreserveSig]
        new HRESULT CopyAllItems(/* [in] __RPC__in_opt */ IMFAttributes pDest);
        
        // IMFVirtualCamera
        [PreserveSig]
        HRESULT AddDeviceSourceInfo(/* [annotation][in] _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string DeviceSourceInfo);
        
        [PreserveSig]
        HRESULT AddProperty(/* [annotation][in] _In_ */ ref PROPERTYKEY pKey, /* [annotation][in] _In_ */ uint Type, /* [annotation][in] _In_reads_bytes_(cbData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] pbData, /* [annotation][in] _In_ */ int cbData);
        
        [PreserveSig]
        HRESULT AddRegistryEntry(/* [annotation][in] _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string EntryName, /* [annotation][in] _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string SubkeyPath, /* [annotation][in] _In_ */ uint dwRegType, /* [annotation][in] _In_reads_bytes_(cbData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] pbData, /* [annotation][in] _In_ */ int cbData);
        
        [PreserveSig]
        HRESULT Start(/* [annotation][in] _In_opt_ */ IMFAsyncCallback pCallback);
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Remove();
        
        [PreserveSig]
        HRESULT GetMediaSource(/* [annotation][out] _COM_Outptr_ */ out IMFMediaSource ppMediaSource);
        
        [PreserveSig]
        HRESULT SendCameraProperty(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid propertySet, /* [annotation][in] _In_ */ uint propertyId, /* [annotation][in] _In_ */ uint propertyFlags, /* optional(void) */ IntPtr propertyPayload, /* [annotation][in] _In_ */ uint propertyPayloadLength, /* optional(void) */ IntPtr data, /* [annotation][in] _In_ */ uint dataLength, /* [annotation][out] _Out_ */ out uint dataWritten);
        
        [PreserveSig]
        HRESULT CreateSyncEvent(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid kseventSet, /* [annotation][in] _In_ */ uint kseventId, /* [annotation][in] _In_ */ uint kseventFlags, /* [annotation][system_handle][in] _In_ */ IntPtr eventHandle, /* [annotation][out] _COM_Outptr_ */ out IMFCameraSyncObject cameraSyncObject);
        
        [PreserveSig]
        HRESULT CreateSyncSemaphore(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid kseventSet, /* [annotation][in] _In_ */ uint kseventId, /* [annotation][in] _In_ */ uint kseventFlags, /* [annotation][system_handle][in] _In_ */ IntPtr semaphoreHandle, /* [annotation][in] _In_ */ int semaphoreAdjustment, /* [annotation][out] _COM_Outptr_ */ out IMFCameraSyncObject cameraSyncObject);
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}
