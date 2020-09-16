using System;
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
    }
}
