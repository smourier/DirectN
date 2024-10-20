// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Additional outputs from a DXC operation.
    /// </summary>
    [ComImport, Guid("319b37a2-a5c2-494a-a5de-4801b2faf989"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcExtraOutputs
    {
        /// <summary>
        /// Retrieves the number of outputs available
        /// </summary>
        [PreserveSig]
        uint GetOutputCount();
        
        /// <summary>
        /// Retrieves the specified output.
        /// </summary>
        [PreserveSig]
        HRESULT GetOutput(/* _In_ */ uint uIndex, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _COM_Outptr_opt_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject, /* _COM_Outptr_opt_result_maybenull_ */ out IDxcBlobWide ppOutputType, /* _COM_Outptr_opt_result_maybenull_ */ out IDxcBlobWide ppOutputName);
    }
}
