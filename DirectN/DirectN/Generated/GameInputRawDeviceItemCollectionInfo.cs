// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputRawDeviceItemCollectionInfo
    {
        public GameInputRawDeviceItemCollectionKind kind;
        public uint childCount;
        public uint siblingCount;
        public uint usageCount;
        public IntPtr usages;
        public IntPtr parent;
        public IntPtr firstSibling;
        public IntPtr previousSibling;
        public IntPtr nextSibling;
        public IntPtr lastSibling;
        public IntPtr firstChild;
        public IntPtr lastChild;
    }
}
