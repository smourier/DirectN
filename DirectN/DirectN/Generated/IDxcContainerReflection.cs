// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface to DxcContainerReflection.
    /// </summary>
    [ComImport, Guid("d2c21b26-8350-4bdc-976a-331ce6f4c54c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcContainerReflection
    {
        /// <summary>
        /// Choose the container to perform reflection on
        /// </summary>
        [PreserveSig]
        HRESULT Load(/* _In_ */ IDxcBlob pContainer);
        
        /// <summary>
        /// Retrieves the number of parts in the container.
        /// </summary>
        [PreserveSig]
        HRESULT GetPartCount(/* _Out_ */ out uint pResult);
        
        /// <summary>
        /// Retrieve the kind of a specified part.
        /// </summary>
        [PreserveSig]
        HRESULT GetPartKind(uint idx, /* _Out_ */ out uint pResult);
        
        /// <summary>
        /// Retrieve the content of a specified part.
        /// </summary>
        [PreserveSig]
        HRESULT GetPartContent(uint idx, /* _COM_Outptr_ */ out IDxcBlob ppResult);
        
        /// <summary>
        /// Retrieve the index of the first part with the specified kind.
        /// </summary>
        [PreserveSig]
        HRESULT FindFirstPartKind(uint kind, /* _Out_ */ out uint pResult);
        
        /// <summary>
        /// Retrieve the reflection interface for a specified part.
        /// </summary>
        [PreserveSig]
        HRESULT GetPartReflection(uint idx, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, IntPtr ppvObject);
    }
}
