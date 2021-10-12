// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcontainer.h(1318,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("12558291-e399-11d5-bc2a-00b0d0f3f4ab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFASFMutualExclusion
    {
        [PreserveSig]
        HRESULT GetType(/* [out] */ out Guid pguidType);
        
        [PreserveSig]
        HRESULT SetType(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType);
        
        [PreserveSig]
        HRESULT GetRecordCount(/* [out] */ out uint pdwRecordCount);
        
        [PreserveSig]
        HRESULT GetStreamsForRecord(/* [in] */ uint dwRecordNumber, /* [out] */ out ushort pwStreamNumArray, /* [out][in] */ ref uint pcStreams);
        
        [PreserveSig]
        HRESULT AddStreamForRecord(/* [in] */ uint dwRecordNumber, /* [in] */ ushort wStreamNumber);
        
        [PreserveSig]
        HRESULT RemoveStreamFromRecord(/* [in] */ uint dwRecordNumber, /* [in] */ ushort wStreamNumber);
        
        [PreserveSig]
        HRESULT RemoveRecord(/* [in] */ uint dwRecordNumber);
        
        [PreserveSig]
        HRESULT AddRecord(/* [out] */ out uint pdwRecordNumber);
        
        [PreserveSig]
        HRESULT Clone(/* [out] */ out IMFASFMutualExclusion ppIMutex);
    }
}
