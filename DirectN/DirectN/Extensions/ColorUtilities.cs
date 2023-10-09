using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ColorUtilities
    {
        private static readonly Lazy<ConcurrentDictionary<string, ImmersiveColor>> _immersiveColors = new Lazy<ConcurrentDictionary<string, ImmersiveColor>>(GetImmersiveColors, true);
        public static IReadOnlyDictionary<string, ImmersiveColor> ImmersiveColors => _immersiveColors.Value;

        public static _D3DCOLORVALUE? GetColor(string name, _D3DCOLORVALUE? defaultValue = null)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (!_immersiveColors.Value.TryRemove(name, out var value))
                return defaultValue;

            return value.Color;
        }

        public static IEnumerable<Tuple<COLOR, _D3DCOLORVALUE>> SysColors
        {
            get
            {
                foreach (var value in Enum.GetValues(typeof(COLOR)))
                {
                    var color = (COLOR)value;
                    yield return new Tuple<COLOR, _D3DCOLORVALUE>(color, GetSysColor(color));
                }
            }
        }

        public static IEnumerable<Tuple<COLOR, _D3DCOLORVALUE>> GetThemeSysColors(IntPtr theme)
        {
            foreach (var value in Enum.GetValues(typeof(COLOR)))
            {
                var color = (COLOR)value;
                yield return new Tuple<COLOR, _D3DCOLORVALUE>(color, GetThemeSysColor(theme, color));
            }
        }

        public static _D3DCOLORVALUE GetSysColor(COLOR color) => _D3DCOLORVALUE.FromCOLORREF(WindowsFunctions.GetSysColor(color));
        public static _D3DCOLORVALUE GetThemeSysColor(IntPtr theme, COLOR color) => _D3DCOLORVALUE.FromCOLORREF(WindowsFunctions.GetThemeSysColor(theme, color));
        public static _D3DCOLORVALUE GetThemeColor(string classList, int partId = 0, int stateId = 0, int propId = 0, _D3DCOLORVALUE? defaultColor = null, IntPtr? hwnd = null)
        {
            if (classList == null)
                throw new ArgumentNullException(nameof(classList));

            var theme = WindowsFunctions.OpenThemeData(hwnd ?? IntPtr.Zero, classList);
            if (theme == IntPtr.Zero)
                return defaultColor ?? _D3DCOLORVALUE.Black;

            try
            {
                var hr = WindowsFunctions.GetThemeColor(theme, partId, stateId, propId, out var color);
                if (hr.IsError)
                    return defaultColor ?? _D3DCOLORVALUE.Black;

                return _D3DCOLORVALUE.FromCOLORREF(color);
            }
            finally
            {
                WindowsFunctions.CloseThemeData(theme);
            }
        }

        private static ConcurrentDictionary<string, ImmersiveColor> GetImmersiveColors()
        {
            var dic = new ConcurrentDictionary<string, ImmersiveColor>(StringComparer.OrdinalIgnoreCase);
            try
            {
                GetUserColorPreference(out var pref, false);
                var i = 0;
                do
                {
                    var ptr = GetImmersiveColorNamedTypeByIndex(i);
                    if (ptr == IntPtr.Zero)
                        break;

                    var nt = Marshal.PtrToStructure<IMMERSIVE_COLOR_NAMED_TYPES>(ptr);
                    var color = GetColorFromPreference(ref pref, nt.colorType, false, IMMERSIVE_HC_CACHE_MODE.IHCM_USE_CACHED_VALUE);
                    var ic = new ImmersiveColor(nt.pszColorType, nt.colorType);
                    ic.Color = _D3DCOLORVALUE.FromCOLORREF(color);
                    dic[ic.Name] = ic;
                    i++;
                }
                while (true);
            }
            catch
            {
                // do nothing
            }
            return dic;
        }

        [DllImport("uxtheme", EntryPoint = "#100")]
        static extern IntPtr GetImmersiveColorNamedTypeByIndex(int index);

        [DllImport("uxtheme")]
        static extern int GetUserColorPreference(out IMMERSIVE_COLOR_PREFERENCE pcpPreference, bool fForceReload);

        [DllImport("uxtheme")]
        static extern int GetColorFromPreference(ref IMMERSIVE_COLOR_PREFERENCE cpcpPreference, int colorType, bool fNoHighContrast, IMMERSIVE_HC_CACHE_MODE mode);

        private enum IMMERSIVE_HC_CACHE_MODE
        {
            IHCM_USE_CACHED_VALUE = 0,
            IHCM_REFRESH = 1,
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct IMMERSIVE_COLOR_NAMED_TYPES
        {
            public string pszColorType;
            public int colorType;

            public override string ToString() => pszColorType + " (" + colorType + ")";
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct IMMERSIVE_COLOR_PREFERENCE
        {
            public uint dwColorSetIndex;
            public uint crStartColor;
            public uint crAccentColor;
        }
    }
}
