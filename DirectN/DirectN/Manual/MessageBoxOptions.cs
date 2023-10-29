using System;

namespace DirectN
{
    [Flags]
    public enum MessageBoxOptions
    {
        ApplicationModal = 0,
        SystemModal = 0x1000,
        TaskModal = 0x2000,
        SetForeground = 0x10000,
        DefaultDesktopOnly = 0x20000,
        Right = 0x80000,
        RtlReading = 0x100000,
        TopMost = 0x00040000,
        ServiceNotification = 0x200000,
    }
}
