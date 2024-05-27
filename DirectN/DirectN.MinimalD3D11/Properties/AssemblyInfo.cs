using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif
[assembly: AssemblyTitle("DirectN.MinimalD3D11")]
[assembly: AssemblyCompany("Simon Mourier")]
[assembly: AssemblyProduct("DirectN")]
[assembly: AssemblyDescription("Interop Code for .NET : DXGI, WIC, DirectX 9 to 12, Direct2D, Direct Write, Direct Composition, Media Foundation, WASAPI, CodecAPI, GDI, Spatial Audio, DVD, Windows Media Player, UWP DXInterop, etc.")]
[assembly: AssemblyCopyright("Copyright © 2017-2024 Simon Mourier. All rights reserved. Original code by d7samurai.")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("3a848cdf-7b72-49de-92f7-30b640369d75")]

[assembly: AssemblyVersion("1.16.1.0")]
[assembly: AssemblyFileVersion("1.16.1.0")]
[assembly: AssemblyInformationalVersion("1.16.1.0")]

[assembly: SupportedOSPlatform("windows10.0.19041.0")]
