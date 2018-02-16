using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDXGIOutputExtensions
    {
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput1> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput2> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput3> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput4> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput5> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput6> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var desc = new DXGI_OUTPUT_DESC();
            output.GetDesc(out desc).ThrowOnError();
            return desc;
        }

        public static DXGI_OUTPUT_DESC1 GetDesc1(this ComObject<IDXGIOutput6> output) => GetDesc1(output?.Object);
        public static DXGI_OUTPUT_DESC1 GetDesc1(this IDXGIOutput6 output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var desc = new DXGI_OUTPUT_DESC1();
            output.GetDesc1(out desc).ThrowOnError();
            return desc;
        }

        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput1> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput2> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput3> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput4> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput5> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput6> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var desc = new DXGI_GAMMA_CONTROL_CAPABILITIES();
            if (output.GetGammaControlCapabilities(out desc).IsError)
                return null;

            return desc;
        }

        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput1> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput2> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput3> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput4> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput5> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput6> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var control = new DXGI_GAMMA_CONTROL();
            if (output.GetGammaControl(out control).IsError)
                return null;

            return control;
        }

        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput1> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput2> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput3> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput4> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput5> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput6> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var stats = new DXGI_FRAME_STATISTICS();
            if (output.GetFrameStatistics(out stats).IsError)
                return null;

            return stats;
        }

        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput1> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput2> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput3> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput4> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput5> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput6> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this IDXGIOutput output, DXGI_FORMAT format, DXGI_ENUM_MODES modes)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            // DXGI_FORMAT_R16G16B16A16_FLOAT
            // DXGI_FORMAT_R10G10B10A2_UNORM
            // DXGI_FORMAT_R8G8B8A8_UNORM
            // DXGI_FORMAT_R8G8B8A8_UNORM_SRGB
            // DXGI_FORMAT_B8G8R8A8_UNORM
            // DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM
            // DXGI_FORMAT_B8G8R8A8_UNORM_SRGB

            var list = new List<DXGI_MODE_DESC>();
            int num = 0;
            output.GetDisplayModeList(format, modes, ref num, null);
            if (num > 0)
            {
                var array = new DXGI_MODE_DESC[num];
                output.GetDisplayModeList(format, modes, ref num, array);
                list.AddRange(array);
            }
            return list;
        }

        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this ComObject<IDXGIOutput1> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList1(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this ComObject<IDXGIOutput2> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList1(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this ComObject<IDXGIOutput3> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList1(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this ComObject<IDXGIOutput4> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList1(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this ComObject<IDXGIOutput5> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList1(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this ComObject<IDXGIOutput6> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList1(output.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this IDXGIOutput1 output, DXGI_FORMAT format, DXGI_ENUM_MODES modes)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var list = new List<DXGI_MODE_DESC1>();
            int num = 0;
            output.GetDisplayModeList(format, modes, ref num, null);
            if (num > 0)
            {
                var array = new DXGI_MODE_DESC1[num];
                output.GetDisplayModeList1(format, modes, ref num, array);
                list.AddRange(array);
            }
            return list;
        }

        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput1> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput2> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput3> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput4> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput5> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput6> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this IDXGIOutput output, DXGI_MODE_DESC modeToMatch, object concernedDevice)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var closest = new DXGI_MODE_DESC();
            if (output.FindClosestMatchingMode(ref modeToMatch, out closest, ComObject.Unwrap(concernedDevice)).IsError)
                return null;

            return closest;
        }

        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this ComObject<IDXGIOutput1> output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice) => FindClosestMatchingMode1(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this ComObject<IDXGIOutput2> output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice) => FindClosestMatchingMode1(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this ComObject<IDXGIOutput3> output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice) => FindClosestMatchingMode1(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this ComObject<IDXGIOutput4> output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice) => FindClosestMatchingMode1(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this ComObject<IDXGIOutput5> output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice) => FindClosestMatchingMode1(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this ComObject<IDXGIOutput6> output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice) => FindClosestMatchingMode1(output.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this IDXGIOutput1 output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var closest = new DXGI_MODE_DESC1();
            if (output.FindClosestMatchingMode1(ref modeToMatch, out closest, ComObject.Unwrap(concernedDevice)).IsError)
                return null;

            return closest;
        }

        public static IDXGIOutputDuplication DuplicateOutput(this ComObject<IDXGIOutput1> output, object device) => DuplicateOutput(output.Object, device);
        public static IDXGIOutputDuplication DuplicateOutput(this ComObject<IDXGIOutput2> output, object device) => DuplicateOutput(output.Object, device);
        public static IDXGIOutputDuplication DuplicateOutput(this ComObject<IDXGIOutput3> output, object device) => DuplicateOutput(output.Object, device);
        public static IDXGIOutputDuplication DuplicateOutput(this ComObject<IDXGIOutput4> output, object device) => DuplicateOutput(output.Object, device);
        public static IDXGIOutputDuplication DuplicateOutput(this ComObject<IDXGIOutput5> output, object device) => DuplicateOutput(output.Object, device);
        public static IDXGIOutputDuplication DuplicateOutput(this ComObject<IDXGIOutput6> output, object device) => DuplicateOutput(output.Object, device);
        public static IDXGIOutputDuplication DuplicateOutput(this IDXGIOutput1 output, object device)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (device == null)
                throw new ArgumentNullException(nameof(device));

            output.DuplicateOutput(ComObject.Unwrap(device), out IDXGIOutputDuplication duplication).ThrowOnError();
            return duplication;
        }
    }
}
