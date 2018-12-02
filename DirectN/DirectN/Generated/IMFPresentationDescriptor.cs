// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(5692,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("03cb2711-24d7-4db6-a17f-f3a7a479a536"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPresentationDescriptor
    {
        [PreserveSig]
        HRESULT GetStreamDescriptorCount(/* [out] __RPC__out */ out uint pdwDescriptorCount);
        
        [PreserveSig]
        HRESULT GetStreamDescriptorByIndex(/* [in] */ uint dwIndex, /* [out] __RPC__out */ out bool pfSelected, /* [out] __RPC__deref_out_opt */ out IMFStreamDescriptor ppDescriptor);
        
        [PreserveSig]
        HRESULT SelectStream(/* [in] */ uint dwDescriptorIndex);
        
        [PreserveSig]
        HRESULT DeselectStream(/* [in] */ uint dwDescriptorIndex);
        
        [PreserveSig]
        HRESULT Clone(/* [out] __RPC__deref_out_opt */ out IMFPresentationDescriptor ppPresentationDescriptor);
    }
}
