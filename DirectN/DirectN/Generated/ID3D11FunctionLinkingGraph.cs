// generated from <Windows SDK Path>\um\d3d11shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("54133220-1ce8-43d3-8236-9855c5ceecff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11FunctionLinkingGraph
    {
        [PreserveSig]
        HRESULT CreateModuleInstance(/* THIS_ _COM_Outptr_ */ out ID3D11ModuleInstance ppModuleInstance, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorBuffer);
        
        [PreserveSig]
        HRESULT SetInputSignature(/* THIS_ __in_ecount(cInputParameters) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _D3D11_PARAMETER_DESC[] pInputParameters, /* _In_ */ int cInputParameters, /* _COM_Outptr_ */ out ID3D11LinkingNode ppInputNode);
        
        [PreserveSig]
        HRESULT SetOutputSignature(/* THIS_ __in_ecount(cOutputParameters) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _D3D11_PARAMETER_DESC[] pOutputParameters, /* _In_ */ int cOutputParameters, /* _COM_Outptr_ */ out ID3D11LinkingNode ppOutputNode);
        
        [PreserveSig]
        HRESULT CallFunction(/* THIS_ _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pModuleInstanceNamespace, /* _In_ */ ID3D11Module pModuleWithFunctionPrototype, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pFunctionName, /* _COM_Outptr_ */ out ID3D11LinkingNode ppCallNode);
        
        [PreserveSig]
        HRESULT PassValue(/* THIS_ _In_ */ ID3D11LinkingNode pSrcNode, /* _In_ */ int SrcParameterIndex, /* _In_ */ ID3D11LinkingNode pDstNode, /* _In_ */ int DstParameterIndex);
        
        [PreserveSig]
        HRESULT PassValueWithSwizzle(/* THIS_ _In_ */ ID3D11LinkingNode pSrcNode, /* _In_ */ int SrcParameterIndex, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pSrcSwizzle, /* _In_ */ ID3D11LinkingNode pDstNode, /* _In_ */ int DstParameterIndex, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDstSwizzle);
        
        [PreserveSig]
        HRESULT GetLastError(/* THIS_ _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorBuffer);
        
        [PreserveSig]
        HRESULT GenerateHlsl(/* THIS_ _In_ */ uint uFlags, /* // uFlags is reserved for future use. _COM_Outptr_ */ out ID3D10Blob ppBuffer);
    }
}
