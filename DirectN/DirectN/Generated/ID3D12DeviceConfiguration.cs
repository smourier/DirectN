// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("78dbf87b-f766-422b-a61c-c8c446bdb9ad"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceConfiguration
    {
        [PreserveSig]
        D3D12_DEVICE_CONFIGURATION_DESC GetDesc();
        
        [PreserveSig]
        HRESULT GetEnabledExperimentalFeatures(/* _Out_writes_(NumGuids) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] Guid[] pGuids, int NumGuids);
        
        [PreserveSig]
        HRESULT SerializeVersionedRootSignature(/* _In_ */ ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC pDesc, /* _COM_Outptr_ */ out ID3D10Blob ppResult, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppError);
        
        [PreserveSig]
        HRESULT CreateVersionedRootSignatureDeserializer(/* _In_reads_bytes_(Size) */ IntPtr pBlob, IntPtr Size, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDeserializer);
    }
}
