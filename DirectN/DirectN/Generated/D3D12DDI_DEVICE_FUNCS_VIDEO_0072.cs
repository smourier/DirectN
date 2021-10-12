// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12097,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0072 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0072 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEVIDEOEXTENSIONCOMMANDSIZE_0061 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0072 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEODECODER_0072 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEODECODERHEAP_0072 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEOEXTENSIONCOMMAND_0063 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEOPROCESSOR_0072 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEODECODER_0021 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEOEXTENSIONCOMMAND_0063 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEOMOTIONESTIMATOR_0053 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEOMOTIONVECTORHEAP_0053 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 = System.IntPtr;
using PFND3D12DDI_VIDEO_GETCAPS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DEVICE_FUNCS_VIDEO_0072
    {
        public IntPtr pfnGetCaps;
        public IntPtr pfnCalcPrivateVideoDecoderSize;
        public IntPtr pfnCreateVideoDecoder;
        public IntPtr pfnDestroyVideoDecoder;
        public IntPtr pfnCalcPrivateVideoDecoderHeapSize;
        public IntPtr pfnCreateVideoDecoderHeap;
        public IntPtr pfnDestroyVideoDecoderHeap;
        public IntPtr pfnCalcPrivateVideoProcessorSize;
        public IntPtr pfnCreateVideoProcessor;
        public IntPtr pfnDestroyVideoProcessor;
        public IntPtr pfnCalcPrivateVideoMotionEstimatorSize;
        public IntPtr pfnCreateVideoMotionEstimator;
        public IntPtr pfnDestroyVideoMotionEstimator;
        public IntPtr pfnCalcPrivateVideoMotionVectorHeapSize;
        public IntPtr pfnCreateVideoMotionVectorHeap;
        public IntPtr pfnDestroyVideoMotionVectorHeap;
        public IntPtr pfnCalcPrivateVideoExtensionCommandSize;
        public IntPtr pfnCreateVideoExtensionCommand;
        public IntPtr pfnDestroyVideoExtensionCommand;
    }
}
