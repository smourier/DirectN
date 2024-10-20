// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ed342442-6343-4e16-bb82-a3a577874e56"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceConfiguration1 : ID3D12DeviceConfiguration
    {
        // ID3D12DeviceConfiguration
        [PreserveSig]
        new D3D12_DEVICE_CONFIGURATION_DESC GetDesc();
        
        [PreserveSig]
        new HRESULT GetEnabledExperimentalFeatures(/* _Out_writes_(NumGuids) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] Guid[] pGuids, int NumGuids);
        
        [PreserveSig]
        new HRESULT SerializeVersionedRootSignature(/* _In_ */ ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC pDesc, /* _COM_Outptr_ */ out ID3D10Blob ppResult, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppError);
        
        [PreserveSig]
        new HRESULT CreateVersionedRootSignatureDeserializer(/* _In_reads_bytes_(Size) */ IntPtr pBlob, IntPtr Size, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDeserializer);
        
        // ID3D12DeviceConfiguration1
        [PreserveSig]
        HRESULT CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(/* _In_reads_bytes_(Size) */ IntPtr pLibraryBlob, IntPtr Size, [MarshalAs(UnmanagedType.LPWStr)] string RootSignatureSubobjectName, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDeserializer);
    }
}
