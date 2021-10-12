// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcontainer.h(2203,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("57bdd80a-9b38-4838-b737-c58f670d7d4f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFASFMultiplexer
    {
        [PreserveSig]
        HRESULT Initialize(/* [in] */ IMFASFContentInfo pIContentInfo);
        
        [PreserveSig]
        HRESULT SetFlags(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetFlags(/* [out] */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT ProcessSample(/* [in] */ ushort wStreamNumber, /* [in] */ IMFSample pISample, /* [in] */ long hnsTimestampAdjust);
        
        [PreserveSig]
        HRESULT GetNextPacket(/* [out] */ out uint pdwStatusFlags, /* [out] */ out IMFSample ppIPacket);
        
        [PreserveSig]
        HRESULT Flush();
        
        [PreserveSig]
        HRESULT End(/* [out][in] */ ref IMFASFContentInfo pIContentInfo);
        
        [PreserveSig]
        HRESULT GetStatistics(/* [in] */ ushort wStreamNumber, /* [out] */ out ASF_MUX_STATISTICS pMuxStats);
        
        [PreserveSig]
        HRESULT SetSyncTolerance(/* [in] */ uint msSyncTolerance);
    }
}
