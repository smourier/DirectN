// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_CALCPRIVATECRYPTOSESSIONPOLICYSIZE_0030 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATECRYPTOSESSIONSIZE_0030 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONPOLICYSIZE_0030 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONSIZE_0030 = System.IntPtr;
using PFND3D12DDI_CREATECRYPTOSESSION_0030 = System.IntPtr;
using PFND3D12DDI_CREATECRYPTOSESSIONPOLICY_0030 = System.IntPtr;
using PFND3D12DDI_DESTROYCRYPTOSESSION_0030 = System.IntPtr;
using PFND3D12DDI_DESTROYCRYPTOSESSIONPOLICY_0030 = System.IntPtr;
using PFND3D12DDI_GETKEYBASEDATA_0030 = System.IntPtr;
using PFND3D12DDI_OPENCRYPTOSESSION_0030 = System.IntPtr;
using PFND3D12DDI_OPENCRYPTOSESSIONPOLICY_0030 = System.IntPtr;
using PFND3D12DDI_TRANSFORMENCRYPTEDDATA_0030 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_STREAMING_0030
    {
        public IntPtr pfnCalcPrivateCryptoSessionSize;
        public IntPtr pfnCreateCryptoSession;
        public IntPtr pfnCalcPrivateOpenedCryptoSessionSize;
        public IntPtr pfnOpenCryptoSession;
        public IntPtr pfnDestroyCryptoSession;
        public IntPtr pfnGetKeyBaseData;
        public IntPtr pfnCalcPrivateCryptoSessionPolicySize;
        public IntPtr pfnCreateCryptoSessionPolicy;
        public IntPtr pfnCalcPrivateOpenedCryptoSessionPolicySize;
        public IntPtr pfnOpenCryptoSessionPolicy;
        public IntPtr pfnDestroyCryptoSessionPolicy;
        public IntPtr pfnTransformEncryptedData;
    }
}
