// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(766,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents an image source which shares resources with an original image source.
    /// </summary>
    [ComImport, Guid("7f1f79e5-2796-416c-8f55-700f911445e5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1TransformedImageSource : ID2D1Image
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
        
        // ID2D1TransformedImageSource
        [PreserveSig]
        void GetSource(/* _Outptr_result_maybenull_ */ out ID2D1ImageSource imageSource);
        
        [PreserveSig]
        void GetProperties(/* _Out_ */ out D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties);
    }
}
