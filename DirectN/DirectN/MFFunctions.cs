using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class MFFunctions
    {
        [DllImport("mfplat")]
        public static extern HRESULT MFShutdown();

        [DllImport("mfplat")]
        public static extern HRESULT MFStartup(uint Version, uint dwFlags);

        public static void MFStartup() => MFStartup((Constants.MF_SDK_VERSION << 16) | Constants.MF_API_VERSION, Constants.MFSTARTUP_FULL).ThrowOnError();

        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMemoryBuffer(uint cbMaxLength, out IMFMediaBuffer ppBuffer);

        public static ComObject<IMFMediaBuffer> MFCreateMemoryBuffer(uint cbMaxLength) => MFCreateMemoryBuffer<IMFMediaBuffer>(cbMaxLength);
        public static ComObject<T> MFCreateMemoryBuffer<T>(uint cbMaxLength) where T : IMFMediaBuffer
        {
            MFCreateMemoryBuffer(cbMaxLength, out var sample).ThrowOnError();
            return new ComObject<T>((T)sample);
        }

        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSample(out IMFSample ppIMFSample);

        public static ComObject<IMFSample> MFCreateSample() => MFCreateSample<IMFSample>();
        public static ComObject<T> MFCreateSample<T>() where T : IMFSample
        {
            MFCreateSample(out var sample).ThrowOnError();
            return new ComObject<T>((T)sample);
        }

        [DllImport("mfplat")]
        public static extern HRESULT MFCreateDXGISurfaceBuffer([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, uint uSubresourceIndex, bool fBottomUpWhenLinear, out IMFMediaBuffer ppBuffer);

        public static ComObject<T> MFCreateDXGISurfaceBuffer<T>(object surface, int resourceIndex, bool bottomUpWhenLinear) where T : IMFMediaBuffer
        {
            MFCreateDXGISurfaceBuffer(typeof(ID3D11Texture2D).GUID, surface, (uint)resourceIndex, bottomUpWhenLinear, out var buffer).ThrowOnError();
            return new ComObject<T>((T)buffer);
        }

        [DllImport("mfplat")]
        public static extern HRESULT MFCreateDXGIDeviceManager(out uint resetToken, out IMFDXGIDeviceManager ppDeviceManager);

        public static ComObject<IMFDXGIDeviceManager> MFCreateDXGIDeviceManager() => MFCreateDXGIDeviceManager();
        public static ComObject<IMFDXGIDeviceManager> MFCreateDXGIDeviceManager(out uint resetToken) => MFCreateDXGIDeviceManager<IMFDXGIDeviceManager>(out resetToken);
        public static ComObject<T> MFCreateDXGIDeviceManager<T>(out uint resetToken) where T : IMFDXGIDeviceManager
        {
            MFCreateDXGIDeviceManager(out resetToken, out var manager).ThrowOnError();
            return new ComObject<T>((T)manager);
        }

        [DllImport("mfplat")]
        public static extern HRESULT MFTEnumEx(
            Guid guidCategory,
            _MFT_ENUM_FLAG Flags,
            ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pInputType,
            ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pOutputType,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out IMFActivate[] pppMFTActivate,
            out int pnumMFTActivate);

        [DllImport("mfplat")]
        public static extern HRESULT MFTEnumEx(
            Guid guidCategory,
            _MFT_ENUM_FLAG Flags,
            IntPtr pInputType,
            ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pOutputType,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out IMFActivate[] pppMFTActivate,
            out int pnumMFTActivate);

        public static IReadOnlyList<ComObject<IMFActivate>> MFTEnumEx(Guid categoryId, _MFT_ENUM_FLAG flags, __MIDL___MIDL_itf_mfobjects_0000_0008_0003? inputType = null, __MIDL___MIDL_itf_mfobjects_0000_0008_0003? outputType = null)
        {
            var it = inputType ?? new __MIDL___MIDL_itf_mfobjects_0000_0008_0003();
            var ot = outputType ?? new __MIDL___MIDL_itf_mfobjects_0000_0008_0003();
            MFTEnumEx(categoryId, flags, IntPtr.Zero, ref ot, out var activate, out var count).ThrowOnError();
            var list = new List<ComObject<IMFActivate>>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new ComObject<IMFActivate>(activate[i]));
            }
            return list;
        }
    }
}
