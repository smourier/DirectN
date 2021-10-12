// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(467,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("319b37a2-a5c2-494a-a5de-4801b2faf989"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcExtraOutputs
    {
        [PreserveSig]
        uint GetOutputCount();
        
        [PreserveSig]
        HRESULT GetOutput(/* _In_ */ uint uIndex, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _COM_Outptr_opt_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject, /* _COM_Outptr_opt_result_maybenull_ */ out IDxcBlobUtf16 ppOutputType, /* _COM_Outptr_opt_result_maybenull_ */ out IDxcBlobUtf16 ppOutputName);
    }
}
