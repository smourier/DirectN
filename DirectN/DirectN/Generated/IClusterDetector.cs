// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmcodecdsp.h(4970,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3f07f7b7-c680-41d9-9423-915107ec9ff9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IClusterDetector
    {
        [PreserveSig]
        HRESULT Initialize(/* [in] */ ushort wBaseEntryLevel, /* [in] */ ushort wClusterEntryLevel);
        
        [PreserveSig]
        HRESULT Detect(/* [in] */ uint dwMaxNumClusters, /* [in] */ float fMinClusterDuration, /* [in] */ float fMaxClusterDuration, /* [in] */ IToc pSrcToc, /* [out] */ out IToc ppDstToc);
    }
}
