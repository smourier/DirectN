// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface to DXC container builder.
    /// </summary>
    [ComImport, Guid("334b1f50-2292-4b35-99a1-25588d8c17fe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcContainerBuilder
    {
        /// <summary>
        /// Load a DxilContainer to the builder.
        /// </summary>
        [PreserveSig]
        HRESULT Load(/* _In_ */ IDxcBlob pDxilContainerHeader);
        
        /// <summary>
        /// Add a part to the container.
        /// </summary>
        [PreserveSig]
        HRESULT AddPart(/* _In_ */ uint fourCC, /* _In_ */ IDxcBlob pSource);
        
        /// <summary>
        /// Remove a part from the container.
        /// </summary>
        [PreserveSig]
        HRESULT RemovePart(/* _In_ */ uint fourCC);
        
        /// <summary>
        /// Build the container.
        /// </summary>
        [PreserveSig]
        HRESULT SerializeContainer(/* _Out_ */ out IDxcOperationResult ppResult);
    }
}
