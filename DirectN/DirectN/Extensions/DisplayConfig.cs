using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class DisplayConfig
    {
        public static DISPLAYCONFIG_PATH_INFO[] Query(QDC flags = QDC.QDC_ONLY_ACTIVE_PATHS)
        {
            var err = GetDisplayConfigBufferSizes(flags, out var pathCount, out var modeCount);
            if (err != 0)
                throw new Win32Exception(err);

            var paths = new DISPLAYCONFIG_PATH_INFO[pathCount];
            var modes = new DISPLAYCONFIG_MODE_INFO[modeCount];
            err = QueryDisplayConfig(flags, ref pathCount, paths, ref modeCount, modes, IntPtr.Zero);
            if (err != 0)
                throw new Win32Exception(err);

            return paths;
        }

        public static DISPLAYCONFIG_TARGET_DEVICE_NAME GetTargetName(DISPLAYCONFIG_PATH_INFO path)
        {
            var info = new DISPLAYCONFIG_TARGET_DEVICE_NAME();
            info.header.type = DISPLAYCONFIG_DEVICE_INFO.DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_NAME;
            info.header.size = (uint)Marshal.SizeOf<DISPLAYCONFIG_TARGET_DEVICE_NAME>();
            info.header.adapterId = path.targetInfo.adapterId;
            info.header.id = path.targetInfo.id;
            var err = DisplayConfigGetDeviceInfo(ref info);
            if (err != 0)
                throw new Win32Exception(err);

            return info;
        }

        public static _DISPLAYCONFIG_SDR_WHITE_LEVEL GetSdrWhiteLevel(DISPLAYCONFIG_PATH_INFO path)
        {
            var info = new _DISPLAYCONFIG_SDR_WHITE_LEVEL();
            info.header.type = DISPLAYCONFIG_DEVICE_INFO.DISPLAYCONFIG_DEVICE_INFO_GET_SDR_WHITE_LEVEL;
            info.header.size = (uint)Marshal.SizeOf<_DISPLAYCONFIG_SDR_WHITE_LEVEL>();
            info.header.adapterId = path.targetInfo.adapterId;
            info.header.id = path.targetInfo.id;
            var err = DisplayConfigGetDeviceInfo(ref info);
            if (err != 0)
                throw new Win32Exception(err);

            return info;
        }

        public static _DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION GetMonitorSpecialization(DISPLAYCONFIG_PATH_INFO path)
        {
            var info = new _DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION();
            info.header.type = DISPLAYCONFIG_DEVICE_INFO.DISPLAYCONFIG_DEVICE_INFO_GET_MONITOR_SPECIALIZATION;
            info.header.size = (uint)Marshal.SizeOf<_DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION>();
            info.header.adapterId = path.targetInfo.adapterId;
            info.header.id = path.targetInfo.id;
            var err = DisplayConfigGetDeviceInfo(ref info);
            if (err != 0)
                throw new Win32Exception(err);

            return info;
        }

        public static DISPLAYCONFIG_SOURCE_DEVICE_NAME GetSourceName(DISPLAYCONFIG_PATH_INFO path)
        {
            var info = new DISPLAYCONFIG_SOURCE_DEVICE_NAME();
            info.header.type = DISPLAYCONFIG_DEVICE_INFO.DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME;
            info.header.size = (uint)Marshal.SizeOf<DISPLAYCONFIG_SOURCE_DEVICE_NAME>();
            info.header.adapterId = path.sourceInfo.adapterId;
            info.header.id = path.sourceInfo.id;
            var err = DisplayConfigGetDeviceInfo(ref info);
            if (err != 0)
                throw new Win32Exception(err);

            return info;
        }

        public static _DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO GetAdvancedColorInfo(DISPLAYCONFIG_PATH_INFO path)
        {
            var info = new _DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO();
            info.header.type = DISPLAYCONFIG_DEVICE_INFO.DISPLAYCONFIG_DEVICE_INFO_GET_ADVANCED_COLOR_INFO;
            info.header.size = (uint)Marshal.SizeOf<_DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO>();
            info.header.adapterId = path.sourceInfo.adapterId;
            info.header.id = path.targetInfo.id;
            var err = DisplayConfigGetDeviceInfo(ref info);
            if (err != 0)
                throw new Win32Exception(err);

            return info;
        }

        public static string GetGdiDeviceName(int adapterIdHighPart, uint adapterIdLowPart, uint sourceId, bool throwOnError = true)
        {
            var info = new DISPLAYCONFIG_SOURCE_DEVICE_NAME();
            info.header.type = DISPLAYCONFIG_DEVICE_INFO.DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME;
            info.header.size = (uint)Marshal.SizeOf<DISPLAYCONFIG_SOURCE_DEVICE_NAME>();
            info.header.adapterId.HighPart = adapterIdHighPart;
            info.header.adapterId.LowPart = adapterIdLowPart;
            info.header.id = sourceId;
            var err = DisplayConfigGetDeviceInfo(ref info);
            if (err != 0)
            {
                if (throwOnError)
                    throw new Win32Exception(err);

                return null;
            }

            return info.viewGdiDeviceName;
        }

        public static uint? GetSourceId(uint targetId, QDC flags = QDC.QDC_ONLY_ACTIVE_PATHS)
        {
            var err = GetDisplayConfigBufferSizes(flags, out var pathCount, out var modeCount);
            if (err != 0)
                throw new Win32Exception(err);

            var paths = new DISPLAYCONFIG_PATH_INFO[pathCount];
            var modes = new DISPLAYCONFIG_MODE_INFO[modeCount];
            err = QueryDisplayConfig(flags, ref pathCount, paths, ref modeCount, modes, IntPtr.Zero);
            if (err != 0)
                throw new Win32Exception(err);

            var first = paths.FirstOrDefault(p => p.targetInfo.id == targetId);
            if (first.targetInfo.id == targetId)
                return first.sourceInfo.id;

            return null;
        }

        [DllImport("user32")]
        private static extern int GetDisplayConfigBufferSizes(QDC flags, out int numPathArrayElements, out int numModeInfoArrayElements);

        [DllImport("user32")]
        private static extern int QueryDisplayConfig(QDC flags, ref int numPathArrayElements, [In, Out] DISPLAYCONFIG_PATH_INFO[] pathArray, ref int numModeInfoArrayElements, [In, Out] DISPLAYCONFIG_MODE_INFO[] modeInfoArray, out DISPLAYCONFIG_TOPOLOGY_ID currentTopologyId);

        [DllImport("user32")]
        private static extern int QueryDisplayConfig(QDC flags, ref int numPathArrayElements, [In, Out] DISPLAYCONFIG_PATH_INFO[] pathArray, ref int numModeInfoArrayElements, [In, Out] DISPLAYCONFIG_MODE_INFO[] modeInfoArray, IntPtr currentTopologyId);

        [DllImport("user32")]
        private static extern int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_SOURCE_DEVICE_NAME requestPacket);

        [DllImport("user32")]
        private static extern int DisplayConfigGetDeviceInfo(ref _DISPLAYCONFIG_SDR_WHITE_LEVEL requestPacket);

        [DllImport("user32")]
        private static extern int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_TARGET_DEVICE_NAME requestPacket);

        [DllImport("user32")]
        private static extern int DisplayConfigGetDeviceInfo(ref _DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO requestPacket);

        [DllImport("user32")]
        private static extern int DisplayConfigGetDeviceInfo(ref _DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION requestPacket);
    }
}
