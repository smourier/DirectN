using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class D3D11Functions
    {
        public static IComObject<ID3D11Device> D3D11CreateDevice(
            IDXGIAdapter adapter,
            D3D_DRIVER_TYPE driverType,
            D3D11_CREATE_DEVICE_FLAG flags,
            D3D_FEATURE_LEVEL[] featureLevels = null,
            uint sdkVersion = Constants.D3D11_SDK_VERSION)
        {
            //featureLevels = featureLevels ?? new D3D_FEATURE_LEVEL[]
            //{
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_1,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_1,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_0,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_3,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_2,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_1
            //};

            D3D11CreateDevice(
                adapter,
                driverType,
                IntPtr.Zero,
                (uint)flags,
                featureLevels,
                (uint)(featureLevels?.Length).GetValueOrDefault(),
                sdkVersion,
                out ID3D11Device device,
                out D3D_FEATURE_LEVEL level,
                out ID3D11DeviceContext dc).ThrowOnError();
            if (dc != null)
            {
                Marshal.ReleaseComObject(dc);
            }
            return new ComObject<ID3D11Device>(device);
        }

        public static IComObject<ID3D11Device> D3D11CreateDevice(
            IDXGIAdapter adapter,
            D3D_DRIVER_TYPE driverType,
            D3D11_CREATE_DEVICE_FLAG flags,
            out IComObject<ID3D11DeviceContext> deviceContext,
            D3D_FEATURE_LEVEL[] featureLevels = null,
            uint sdkVersion = Constants.D3D11_SDK_VERSION)
        {
            //featureLevels = featureLevels ?? new D3D_FEATURE_LEVEL[]
            //{
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_1,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_1,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_0,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_3,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_2,
            //        D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_1
            //};

            D3D11CreateDevice(
                adapter,
                driverType,
                IntPtr.Zero,
                (uint)flags,
                featureLevels,
                (uint)(featureLevels?.Length).GetValueOrDefault(),
                sdkVersion,
                out ID3D11Device device,
                out D3D_FEATURE_LEVEL level,
                out ID3D11DeviceContext dc).ThrowOnError();
            deviceContext = new ComObject<ID3D11DeviceContext>(dc);
            return new ComObject<ID3D11Device>(device);
        }

        public static IComObject<ID3D10Blob> D3DCompileFromFile(string filename, string entrypoint, string target)
        {
            if (filename == null)
                throw new ArgumentNullException(nameof(filename));

            if (entrypoint == null)
                throw new ArgumentNullException(nameof(entrypoint));

            if (target == null)
                throw new ArgumentNullException(nameof(target));

            var hr = D3DCompileFromFile(filename, null, null, entrypoint, target, 0, 0, out var blob, out var msg);
            if (msg != null)
            {
                if (hr.IsError)
                {
                    var ptr = msg.GetBufferPointer();
                    var len = msg.GetBufferSize().ToInt32();
                    if (ptr != IntPtr.Zero && len > 0)
                    {
                        var str = Marshal.PtrToStringAnsi(ptr, len).Nullify();
                        if (str != null)
                        {
                            Marshal.ReleaseComObject(msg);
                            throw new Win32Exception(hr.Value, str);
                        }
                    }
                }
                Marshal.ReleaseComObject(msg);
            }
            hr.ThrowOnError();
            return new ComObject<ID3D10Blob>(blob);
        }

        [DllImport("d3d11", ExactSpelling = true)]
        public static extern HRESULT D3D11CreateDevice(IDXGIAdapter pAdapter, D3D_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, uint SDKVersion, out ID3D11Device ppDevice, out D3D_FEATURE_LEVEL pFeatureLevel, out ID3D11DeviceContext ppImmediateContext);

        [DllImport("D3DCompiler_47", ExactSpelling = true, CharSet = CharSet.Ansi)]
        public static extern HRESULT D3DCompileFromFile([MarshalAs(UnmanagedType.LPWStr)] string pFileName, _D3D_SHADER_MACRO[] pDefines, ID3DInclude pInclude, [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, [MarshalAs(UnmanagedType.LPStr)] string pTarget, uint Flags1, uint Flags2, out ID3D10Blob ppCode, out ID3D10Blob ppErrorMsgs);
    }
}
