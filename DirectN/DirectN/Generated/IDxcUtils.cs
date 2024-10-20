// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    /// <summary>
    /// Various utility functions for DXC.
    /// </summary>
    [ComImport, Guid("4605c4cb-2019-492a-ada4-65f20bb7d67f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcUtils
    {
        /// <summary>
        /// Create a sub-blob that holds a reference to the outer blob and points to its memory.
        /// </summary>
        [PreserveSig]
        HRESULT CreateBlobFromBlob(/* _In_ */ IDxcBlob pBlob, uint offset, uint length, /* _COM_Outptr_ */ out IDxcBlob ppResult);
        
        /// <summary>
        /// Create a blob referencing existing memory, with no copy.
        /// </summary>
        [PreserveSig]
        HRESULT CreateBlobFromPinned(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pData, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding ppBlobEncoding);
        
        /// <summary>
        /// Create a blob, taking ownership of memory allocated with the supplied allocator.
        /// </summary>
        [PreserveSig]
        HRESULT MoveToBlob(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] pData, IMalloc pIMalloc, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding ppBlobEncoding);
        
        /// <summary>
        /// Create a blob containing a copy of the existing data.
        /// </summary>
        [PreserveSig]
        HRESULT CreateBlob(/* _In_bytecount_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pData, int size, uint codePage, /* _COM_Outptr_ */ out IDxcBlobEncoding ppBlobEncoding);
        
        /// <summary>
        /// Create a blob with data loaded from a file.
        /// </summary>
        [PreserveSig]
        HRESULT LoadFile(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* optional(UINT32) */ IntPtr pCodePage, /* _COM_Outptr_ */ out IDxcBlobEncoding ppBlobEncoding);
        
        /// <summary>
        /// Create a stream that reads data from a blob.
        /// </summary>
        [PreserveSig]
        HRESULT CreateReadOnlyStreamFromBlob(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IStream ppStream);
        
        /// <summary>
        /// Create default file-based include handler.
        /// </summary>
        [PreserveSig]
        HRESULT CreateDefaultIncludeHandler(/* _COM_Outptr_ */ out IDxcIncludeHandler ppResult);
        
        /// <summary>
        /// Convert or return matching encoded text blob as UTF-8.
        /// </summary>
        [PreserveSig]
        HRESULT GetBlobAsUtf8(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IDxcBlobUtf8 ppBlobEncoding);
        
        /// <summary>
        /// Convert or return matching encoded text blob as UTF-16.
        /// </summary>
        [PreserveSig]
        HRESULT GetBlobAsWide(/* _In_ */ IDxcBlob pBlob, /* _COM_Outptr_ */ out IDxcBlobWide ppBlobEncoding);
        
        /// <summary>
        /// Retrieve a single part from a DXIL container.
        /// </summary>
        [PreserveSig]
        HRESULT GetDxilContainerPart(/* _In_ */ ref DxcBuffer pShader, /* _In_ */ uint DxcPart, /* _Outptr_result_nullonfailure_ */ out IntPtr ppPartData, /* _Out_ */ out uint pPartSizeInBytes);
        
        /// <summary>
        /// Create reflection interface from serialized DXIL container or the DXC_OUT_REFLECTION blob contents.
        /// </summary>
        [PreserveSig]
        HRESULT CreateReflection(/* _In_ */ ref DxcBuffer pData, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, IntPtr ppvReflection);
        
        /// <summary>
        /// Build arguments that can be passed to the Compile method.
        /// </summary>
        [PreserveSig]
        HRESULT BuildArguments(/* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* ///< Optional file name for pSource. Used in errors and include handlers. _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryPoint, /* ///< Entry point name (-E). _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* optional(LPCWSTR) */ IntPtr pArguments, /* ///< Array of pointers to arguments. _In_ */ uint argCount, /* ///< Number of arguments. _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DxcDefine[] pDefines, /* ///< Array of defines. _In_ */ int defineCount, /* ///< Number of defines. _COM_Outptr_ */ out IDxcCompilerArgs ppArgs);
        
        /// <summary>
        /// Retrieve the hash and contents of a shader PDB.
        /// </summary>
        [PreserveSig]
        HRESULT GetPDBContents(/* _In_ */ IDxcBlob pPDBBlob, /* _COM_Outptr_ */ out IDxcBlob ppHash, /* _COM_Outptr_ */ out IDxcBlob ppContainer);
    }
}
