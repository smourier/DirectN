// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(862,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This is the interface implemented by an effect author, along with the constructor and registration information.
    /// </summary>
    [ComImport, Guid("a248fd3f-3e6c-4e63-9f03-7f68ecc91db9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1EffectImpl
    {
        [PreserveSig]
        HRESULT Initialize(/* _In_ */ ID2D1EffectContext effectContext, /* _In_ */ ID2D1TransformGraph transformGraph);
        
        [PreserveSig]
        HRESULT PrepareForRender(D2D1_CHANGE_TYPE changeType);
        
        [PreserveSig]
        HRESULT SetGraph(/* _In_ */ ID2D1TransformGraph transformGraph);
    }
}
