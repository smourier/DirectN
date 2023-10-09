using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    public static class WindowsFunctions
    {
        public static readonly WndProc DefWndProc = Marshal.GetDelegateForFunctionPointer<WndProc>(WindowsFunctions.GetProcAddress(WindowsFunctions.GetModuleHandle("user32.dll"), "DefWindowProcW"));

        [DllImport("user32", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr CreateWindowEx(WS_EX dwExStyle, string lpClassName, string lpWindowName, WS dwStyle, int X, int Y, int nWidth, int nHeight, IntPtr hwndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

        [DllImport("user32")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32")]
        public static extern bool DestroyWindow(IntPtr hWnd);

        [DllImport("user32")]
        public static extern IntPtr GetCursor();

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool PostMessage(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam);
        public static bool PostMessage(IntPtr hWnd, int msg) => PostMessage(hWnd, msg, IntPtr.Zero, IntPtr.Zero);

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam);
        public static IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wparam) => SendMessage(hWnd, msg, wparam, IntPtr.Zero);

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool PeekMessage(ref MSG lpMsg, IntPtr hWnd, int wMsgFilterMin, int wMsgFilterMax, int wRemoveMsg);

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool TranslateMessage(ref MSG msg);

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern int DispatchMessage(ref MSG msg);

        [DllImport("user32", ExactSpelling = true)]
        public static extern bool GetIconInfo(IntPtr hIcon, out ICONINFO info);

        [DllImport("user32")]
        public static extern IntPtr GetActiveWindow();

        [DllImport("user32")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32")]
        public static extern IntPtr GetShellWindow();

        [DllImport("user32")]
        public static extern IntPtr GetWindow(IntPtr hWnd, int uCmd);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        public static extern bool SetWindowText(IntPtr hwnd, string text);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool GetMessage(ref MSG msg, IntPtr hwnd, int uMsgFilterMin, int uMsgFilterMax);

        [DllImport("user32")]
        public static extern bool GetMonitorInfo(IntPtr hmonitor, ref MONITORINFO info);

        [DllImport("user32")]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32", SetLastError = true)]
        public static extern IntPtr MonitorFromWindow(IntPtr hwnd, MONITOR_FLAGS dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int cx, int cy, SWP flags);

        [DllImport("user32")]
        public static extern int MapWindowPoints(IntPtr hWndFrom, IntPtr hWndTo, ref tagRECT rect, int cPoints);

        [DllImport("user32")]
        public static extern bool GetClientRect(IntPtr hwnd, out tagRECT rect);

        [DllImport("user32")]
        public static extern bool GetWindowRect(IntPtr hwnd, out tagRECT rect);

        [DllImport("user32", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr64(IntPtr hwnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr32(IntPtr hdnw, int nIndex, IntPtr dwNewLong);

        [DllImport("user32", EntryPoint = "GetWindowLongPtr", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLongPtr64(IntPtr hwnd, int nIndex);

        [DllImport("user32", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLong32(IntPtr hwnd, int nIndex);

        [DllImport("user32")]
        public static extern short GetAsyncKeyState(VirtualKeys vkey);

        [DllImport("user32")]
        public static extern short GetKeyState(VirtualKeys vkey);

        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern short RegisterClass(ref WNDCLASS wc);

        [DllImport("user32", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern short UnregisterClass(string lpClassName, IntPtr hInstance);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        public static extern bool GetClassInfo(IntPtr hInst, string lpszClass, out WNDCLASSPtr wc);

        [DllImport("user32")]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32")]
        public static extern bool DestroyIcon(IntPtr hIcon);

        [DllImport("user32")]
        public static extern bool ShowWindow(IntPtr hwnd, SW nCmdShow);

        [DllImport("user32")]
        public static extern bool AdjustWindowRectExForDpi(ref tagRECT lpRect, WS dwStyle, bool bMenu, WS_EX dwExStyle, int dpi);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetDpiForWindow(IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetMessagePos();

        [DllImport("user32", ExactSpelling = true)]
        public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern IntPtr WindowFromPoint(tagPOINT point);

        [DllImport("user32", ExactSpelling = true)]
        public static extern IntPtr SetTimer(IntPtr hWnd, IntPtr nIDEvent, int uElapse, IntPtr lpTimerProc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern bool KillTimer(IntPtr hWnd, IntPtr uIDEvent);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetSystemMetrics(SM index);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetSysColor(COLOR index);

        [DllImport("user32", SetLastError = true)]
        public static extern bool DestroyCaret();

        [DllImport("user32")]
        public static extern bool IsZoomed(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int GetDoubleClickTime();

        [DllImport("user32")]
        public static extern uint GetCaretBlinkTime();

        [DllImport("user32")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32")]
        public static extern IntPtr BeginPaint(IntPtr hwnd, ref PAINTSTRUCT lpPaint);

        [DllImport("user32")]
        public static extern bool EndPaint(IntPtr hwnd, ref PAINTSTRUCT lpPaint);

        [DllImport("user32")]
        public static extern IntPtr SetCapture(IntPtr hwnd);

        [DllImport("user32")]
        public static extern bool ReleaseCapture();

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern int MapVirtualKey(uint uCode, int uMapType);

        [DllImport("user32")]
        public static extern bool ScreenToClient(IntPtr hwnd, ref tagPOINT pt);

        [DllImport("user32")]
        public static extern bool ClientToScreen(IntPtr hwnd, ref tagPOINT pt);

        [DllImport("user32")]
        public static extern bool GetCursorPos(ref tagPOINT pt);

        [DllImport("user32", SetLastError = true)]
        public static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32", SetLastError = true)]
        public static extern bool SetCaretPos(int X, int Y);

        [DllImport("user32")]
        public static extern bool SystemParametersInfo(int uiAction, int uiParam, out int pvParam, bool fWinIni);

        [DllImport("user32", ExactSpelling = true)]
        public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT tme);

        [DllImport("user32")]
        public static extern HRESULT SetWindowCompositionAttribute(IntPtr hwnd, ref WINDOWCOMPOSITIONATTRIBDATA data);

        [DllImport("user32")]
        public static extern HRESULT GetWindowCompositionAttribute(IntPtr hwnd, ref WINDOWCOMPOSITIONATTRIBDATA data);

        [DllImport("gdi32")]
        public static extern IntPtr GetStockObject(int i);

        [DllImport("gdi32", CharSet = CharSet.Auto)]
        public static extern int GetObject(IntPtr h, int c, out BITMAP bmp);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool DeleteObject(IntPtr ho);

        [DllImport("dwmapi")]
        public static extern bool DwmDefWindowProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, out IntPtr plResult);

        [DllImport("dwmapi")]
        public static extern HRESULT DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS pMarInset);

        [DllImport("dwmapi")]
        public static extern HRESULT DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE dwAttribute, ref int pvAttribute, int cbAttribute);

        [DllImport("dwmapi")]
        public static extern HRESULT DwmGetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE dwAttribute, ref tagRECT pvAttribute, int cbAttribute);

        [DllImport("dwmapi")]
        public static extern HRESULT DwmGetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE dwAttribute, ref int pvAttribute, int cbAttribute);

        [DllImport("uxtheme")]
        public static extern HRESULT GetThemeColor(IntPtr themeHandle, int iPartId, int iStateId, int iPropId, out int pColor);

        [DllImport("uxtheme", CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenThemeData(IntPtr hwnd, string pszClassList);

        [DllImport("uxtheme")]
        public static extern int CloseThemeData(IntPtr hTheme);

        [DllImport("uxtheme")]
        public static extern int GetThemeSysColor(IntPtr themeHandle, COLOR index);

        [DllImport("shell32", CharSet = CharSet.Unicode)]
        public static extern int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

#pragma warning disable CA2101 // Specify marshaling for P/Invoke string arguments
        [DllImport("kernel32", CharSet = CharSet.Ansi)]
#pragma warning restore CA2101 // Specify marshaling for P/Invoke string arguments
        public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetModuleHandle(string modName);

        [DllImport("kernel32")]
        public static extern IntPtr GetConsoleWindow();

        public static int GetPointerId(IntPtr wParam) => Extensions.LOWORD(wParam);
        public static POINTER_MESSAGE_FLAGS GetPointerFlags(IntPtr wParam) => (POINTER_MESSAGE_FLAGS)Extensions.HIWORD(wParam);
        public static int GetWheelDelta(IntPtr wParam) => Extensions.HIWORD(wParam);

        public static bool EnableMouseInPointer() => EnableMouseInPointer(true);

        public static POINTER_INPUT_TYPE GetPointerType(int id)
        {
            GetPointerType(id, out var type);
            return type;
        }

        public static POINTER_INFO GetPointerInfo(int id)
        {
            GetPointerInfo(id, out var info);
            return info;
        }

        public static POINTER_TOUCH_INFO GetPointerTouchInfo(int id)
        {
            GetPointerTouchInfo(id, out var info);
            return info;
        }

        public static POINTER_PEN_INFO GetPointerPenInfo(int id)
        {
            GetPointerPenInfo(id, out var info);
            return info;
        }

        [DllImport("user32", SetLastError = true)]
        public static extern bool SkipPointerFrameMessages(int pointerId);

        [DllImport("user32", SetLastError = true)]
        private static extern bool GetPointerType(int pointerId, out POINTER_INPUT_TYPE pointerType);

        [DllImport("user32", SetLastError = true)]
        private static extern bool GetPointerInfo(int pointerId, out POINTER_INFO pointerInfo);

        [DllImport("user32", SetLastError = true)]
        private static extern bool GetPointerTouchInfo(int pointerId, out POINTER_TOUCH_INFO touchInfo);

        [DllImport("user32", SetLastError = true)]
        private static extern bool GetPointerPenInfo(int pointerId, out POINTER_PEN_INFO penInfo);

        [DllImport("user32")]
        public static extern bool IsMouseInPointerEnabled();

        [DllImport("user32", SetLastError = true)]
        private static extern bool EnableMouseInPointer(bool fEnable);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern IntPtr MB_GetString(int button);
        public static string GetMessageBoxString(DialogBoxCommand button, bool removeMnemonics = true)
        {
            var ptr = MB_GetString((int)(button - 1));
            if (ptr == IntPtr.Zero)
                return null;

            var str = Marshal.PtrToStringUni(ptr);
            if (removeMnemonics)
                return str.Replace("&", string.Empty);

            return str;
        }

        [DllImport("user32")]
        public static extern bool EnableWindow(IntPtr hwnd, bool bEnable);

        [DllImport("user32")]
        public static extern bool IsWindowEnabled(IntPtr hwnd);

        [DllImport("user32")]
        public static extern bool SetWindowDisplayAffinity(IntPtr hwnd, WDA dwAffinity);

        [DllImport("user32")]
        private static extern bool GetWindowDisplayAffinity(IntPtr hwnd, out WDA pdwAffinity);

        public static WDA GetWindowDisplayAffinity(IntPtr hwnd)
        {
            GetWindowDisplayAffinity(hwnd, out var affinity);
            return affinity;
        }

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern IntPtr GetModuleFileName(IntPtr hModule, StringBuilder lpFilename, int nSize);

        public static string GetModuleFileName(IntPtr hModule)
        {
            var sb = new StringBuilder(1024);
            GetModuleFileName(hModule, sb, sb.Capacity);
            return sb.ToString().Nullify();
        }

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr LoadLibrary(string lpLibFileName);

        public static int GetWindowThreadId(IntPtr handle) => GetWindowThreadProcessId(handle, out _);
        public static int GetWindowProcessId(IntPtr handle)
        {
            GetWindowThreadProcessId(handle, out int processId);
            return processId;
        }

        public static string GetWindowModuleFileName(IntPtr handle)
        {
            var sb = new StringBuilder(1024);
            GetWindowModuleFileName(handle, sb, sb.Capacity);
            return sb.ToString();
        }

        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern int GetWindowModuleFileName(IntPtr handle, StringBuilder pszFileName, int cchFileNameMax);

        [DllImport("user32")]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

        [DllImport("user32")]
        private static extern bool EnumChildWindows(IntPtr hWndParent, EnumChildProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32", SetLastError = true)]
        private static extern bool EnumWindows(EnumChildProc lpEnumFunc, IntPtr lParam);

        private delegate bool EnumWindowsProc(IntPtr handle, IntPtr lParam);
        private delegate bool EnumChildProc(IntPtr handle, IntPtr lParam);

        public static IReadOnlyList<IntPtr> EnumerateChildWindows(IntPtr handle)
        {
            var list = new List<IntPtr>();
            EnumChildWindows(handle, (h, l) =>
            {
                list.Add(h);
                return true;
            }, IntPtr.Zero);
            return list.AsReadOnly();
        }

        public static IReadOnlyList<IntPtr> EnumerateTopLevelWindows()
        {
            var list = new List<IntPtr>();
            EnumWindows((h, l) =>
            {
                list.Add(h);
                return true;
            }, IntPtr.Zero);
            return list.AsReadOnly();
        }
    }
}
