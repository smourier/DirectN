// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(10492,5)
using System;
using System.Runtime.InteropServices;
using MFSequencerElementId = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("197cd219-19cb-4de1-a64c-acf2edcbe59e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSequencerSource
    {
        [PreserveSig]
        HRESULT AppendTopology(/* [in] */ IMFTopology pTopology, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out MFSequencerElementId pdwId);
        
        [PreserveSig]
        HRESULT DeleteTopology(/* [in] */ uint dwId);
        
        [PreserveSig]
        HRESULT GetPresentationContext(/* [in] */ IMFPresentationDescriptor pPD, /* optional(MFSequencerElementId) */ IntPtr pId, /* [annotation][optional][out] _Out_opt_ */ out IMFTopology ppTopology);
        
        [PreserveSig]
        HRESULT UpdateTopology(/* [in] */ uint dwId, /* [in] */ IMFTopology pTopology);
        
        [PreserveSig]
        HRESULT UpdateTopologyFlags(/* [in] */ uint dwId, /* [in] */ uint dwFlags);
    }
}
