﻿// generated from <Windows SDK Path>\um\strmif.h
using System;

namespace DirectN
{
    [Flags]
    public enum VMRRenderPrefs
    {
        RenderPrefs_RestrictToInitialMonitor = 0x00000000,
        RenderPrefs_ForceOffscreen = 0x00000001,
        RenderPrefs_ForceOverlays = 0x00000002,
        RenderPrefs_AllowOverlays = 0x00000000,
        RenderPrefs_AllowOffscreen = 0x00000000,
        RenderPrefs_DoNotRenderColorKeyAndBorder = 0x00000008,
        RenderPrefs_Reserved = 0x00000010,
        RenderPrefs_PreferAGPMemWhenMixing = 0x00000020,
        RenderPrefs_Mask = 0x0000003F,
    }
}
