// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(4437,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a04bfb29-08ef-43d6-a49c-a9bdbdcbe686"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Device1
    {
        [PreserveSig]
        void GetImmediateContext1(/* [annotation] _Outptr_ */ out ID3D11DeviceContext1 ppImmediateContext);
        
        [PreserveSig]
        HRESULT CreateDeferredContext1(uint ContextFlags, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DeviceContext1 ppDeferredContext);
        
        [PreserveSig]
        HRESULT CreateBlendState1(/* [annotation] _In_ */ ref D3D11_BLEND_DESC1 pBlendStateDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11BlendState1 ppBlendState);
        
        [PreserveSig]
        HRESULT CreateRasterizerState1(/* [annotation] _In_ */ ref D3D11_RASTERIZER_DESC1 pRasterizerDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11RasterizerState1 ppRasterizerState);
        
        [PreserveSig]
        HRESULT CreateDeviceContextState(uint Flags, /* [annotation] _In_reads_( FeatureLevels ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, uint SDKVersion, [MarshalAs(UnmanagedType.LPStruct)] Guid EmulatedInterface, /* [annotation] _Out_opt_ */ out D3D_FEATURE_LEVEL pChosenFeatureLevel, /* optional(ID3DDeviceContextState) */ out IntPtr ppContextState);
        
        [PreserveSig]
        HRESULT OpenSharedResource1(/* [annotation] _In_ */ IntPtr hResource, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid returnedInterface, /* [annotation] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);
        
        [PreserveSig]
        HRESULT OpenSharedResourceByName(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpName, /* [annotation] _In_ */ uint dwDesiredAccess, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid returnedInterface, /* [annotation] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);
    }
}
