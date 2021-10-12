// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(713,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a producer of pixels that can fill an arbitrary 2D plane.
    /// </summary>
    [ComImport, Guid("c9b664e5-74a1-4378-9ac2-eefc37a3f4d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ImageSource : ID2D1Image
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
        
        // ID2D1ImageSource
        [PreserveSig]
        HRESULT OfferResources();
        
        [PreserveSig]
        HRESULT TryReclaimResources(/* _Out_ */ out bool resourcesDiscarded);
    }
}
