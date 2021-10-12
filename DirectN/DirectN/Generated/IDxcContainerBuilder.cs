// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(525,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("334b1f50-2292-4b35-99a1-25588d8c17fe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcContainerBuilder
    {
        [PreserveSig]
        HRESULT Load(/* _In_ */ IDxcBlob pDxilContainerHeader);
        
        [PreserveSig]
        HRESULT AddPart(/* _In_ */ uint fourCC, /* _In_ */ IDxcBlob pSource);
        
        [PreserveSig]
        HRESULT RemovePart(/* _In_ */ uint fourCC);
        
        [PreserveSig]
        HRESULT SerializeContainer(/* _Out_ */ out IDxcOperationResult ppResult);
    }
}
