// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12shader.h(387,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8e349d19-54db-4a56-9dc9-119d87bdb804"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12LibraryReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D12_LIBRARY_DESC pDesc);
        
        [PreserveSig]
        ID3D12FunctionReflection GetFunctionByIndex(/* THIS_ _In_ */ int FunctionIndex);
    }
}
