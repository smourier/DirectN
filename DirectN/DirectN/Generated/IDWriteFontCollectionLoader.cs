// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(1311,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The font collection loader interface is used to construct a collection of fonts given a particular type of key. The font collection loader interface is recommended to be implemented by a singleton object. IMPORTANT: font collection loader implementations must not register themselves with a DirectWrite factory inside their constructors and must not unregister themselves in their destructors, because registration and unregistration operations increment and decrement the object reference count respectively. Instead, registration and unregistration of font file loaders with DirectWrite factory should be performed outside of the font file loader implementation as a separate step.
    /// </summary>
    [ComImport, Guid("cca920e4-52f0-492b-bfa8-29c72ee0a468"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontCollectionLoader
    {
        [PreserveSig]
        HRESULT CreateEnumeratorFromKey(/* _In_ */ IDWriteFactory factory, /* _In_reads_bytes_(collectionKeySize) */ IntPtr collectionKey, uint collectionKeySize, /* _COM_Outptr_ */ out IDWriteFontFileEnumerator fontFileEnumerator);
    }
}
