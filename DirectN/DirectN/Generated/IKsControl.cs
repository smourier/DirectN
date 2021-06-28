// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(560,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("28f54685-06fd-11d2-b27a-00a0c9223196"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsControl
    {
        [PreserveSig]
        HRESULT KsProperty(/* [in] */ ref KSIDENTIFIER Property, /* [in] */ uint PropertyLength, /* [out][in] */ out IntPtr PropertyData, /* [in] */ uint DataLength, /* [out] */ out uint BytesReturned);
        
        [PreserveSig]
        HRESULT KsMethod(/* [in] */ ref KSIDENTIFIER Method, /* [in] */ uint MethodLength, /* [out][in] */ out IntPtr MethodData, /* [in] */ uint DataLength, /* [out] */ out uint BytesReturned);
        
        [PreserveSig]
        HRESULT KsEvent(/* [in] */ ref KSIDENTIFIER Event, /* [in] */ uint EventLength, /* [out][in] */ out IntPtr EventData, /* [in] */ uint DataLength, /* [out] */ out uint BytesReturned);
    }
}
