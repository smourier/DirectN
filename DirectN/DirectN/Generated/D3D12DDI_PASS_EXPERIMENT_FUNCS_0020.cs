// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(10355,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_BEGIN_PASS = System.IntPtr;
using PFND3D12DDI_CALC_PRIVATE_PASS_SIZE = System.IntPtr;
using PFND3D12DDI_CREATE_PASS = System.IntPtr;
using PFND3D12DDI_DESTROY_PASS = System.IntPtr;
using PFND3D12DDI_END_PASS = System.IntPtr;
using PFND3D12DDI_GET_PASS_OPTIMIZATION_FLOW = System.IntPtr;
using PFND3D12DDI_OPTIMIZE_PASS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_PASS_EXPERIMENT_FUNCS_0020
    {
        public IntPtr pfnCalcPrivatePassSize;
        public IntPtr pfnCreatePass;
        public IntPtr pfnDestroyPass;
        public IntPtr pfnGetPassOptimizationFlow;
        public IntPtr pfnBeginPass;
        public IntPtr pfnEndPass;
        public IntPtr pfnOptimizePass;
    }
}
