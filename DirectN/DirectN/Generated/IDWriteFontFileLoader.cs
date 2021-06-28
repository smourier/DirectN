// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(671,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Font file loader interface handles loading font file resources of a particular type from a key. The font file loader interface is recommended to be implemented by a singleton object. IMPORTANT: font file loader implementations must not register themselves with DirectWrite factory inside their constructors and must not unregister themselves in their destructors, because registration and unregistration operations increment and decrement the object reference count respectively. Instead, registration and unregistration of font file loaders with DirectWrite factory should be performed outside of the font file loader implementation as a separate step.
    /// </summary>
    [ComImport, Guid("727cad4e-d6af-4c9e-8a08-d695b11caa49"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFileLoader
    {
        [PreserveSig]
        HRESULT CreateStreamFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, /* _COM_Outptr_ */ out IDWriteFontFileStream fontFileStream);
    }
}
