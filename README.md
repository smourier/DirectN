# DirectN
Direct Interop code for .NET Framework, .NET Core and .NET 5+ : DXGI, WIC, DirectX 9 to 12, Direct2D, Direct Write, Direct Composition, Media Foundation, WASAPI, CodecAPI, GDI, Spatial Audio, DVD, Windows Media Player, UWP DXInterop, WinUI3, etc.

The easiest way to use this is reference the nuget package: https://www.nuget.org/packages/DirectN/ (.NET Framework) or https://www.nuget.org/packages/DirectNCore/ (.NET Core and .NET 5, 6, 7, etc.) or https://www.nuget.org/packages/DirectNStandard/ (.NET Standard).

Or you can pick the C# source files you want (among the 10000 .cs provided ...). It can be sometimes difficult because the dependencies between all these technologies can make extracting a small portion quite difficult (and they are one of the reasons why DirectN exists...). However this is possible as demonstrated in this other project: [Windows Interface Composition Engine ("Wice")](https://github.com/aelyo-softworks/Wice) wich uses only ~700 files (less than 10%) from DirectN.

## Same names and types than the native concepts!
DirectN allows you to port C/C++ code to C#, or to write C# code from scratch, probably more easily than with other existing interop libraries in this domain because one of its main objective is to use exactly the **same names and types than the native concepts** (interfaces, enums, structures, constants, methods, arguments, guids, etc.) . So you can read the official documentation, use existing C/C++ samples, and start coding with .NET right away.

By design, everything is in the same namespace (and in the same assembly if you use the whole package) so you don't need to know where is defined this or that interface, constants, etc.

## Natural .NET programming!
All native COM interfaces are generated as .NET (COM) interfaces, not classes or fancy/complex/unsafe structs. COM utility wrappers are also provided (ComObject, ComMemory, etc.), and many extension methods are also provided for some COM interfaces (the principle used can be extended to any COM method, but this part is not generated). They allow easier .NET programming, but they are not strictly needed. Most of this is possible because **DirectN represent COM inheritance by .NET inheritance** (so, DirectN.IWICImagingFactory2 derives from DirectN.IWICImagingFactory for example).

And last but not least, marking code using DirectN as *unsafe is not required*. 😅

## Easy port from C/C++ to C#!
For example, the exact same C# version of the "Capture screen using DirectX" code here: https://stackoverflow.com/questions/30021274/capture-screen-using-directx is this:

```csharp
static HRESULT Direct3D9TakeScreenshots(uint adapter, int count)
{
    using (var d3d = new ComObject<IDirect3D9>(Functions.Direct3DCreate9(Constants.D3D_SDK_VERSION)))
    {
        var mode = new _D3DDISPLAYMODE();
        d3d.Object.GetAdapterDisplayMode(adapter, ref mode).ThrowOnError();

        var parameters = new _D3DPRESENT_PARAMETERS_();
        parameters.Windowed = true;
        parameters.BackBufferCount = 1;
        parameters.BackBufferHeight = mode.Height;
        parameters.BackBufferWidth = mode.Width;
        parameters.SwapEffect = _D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD;

        d3d.Object.CreateDevice(adapter, _D3DDEVTYPE.D3DDEVTYPE_HAL, IntPtr.Zero, Constants.D3DCREATE_SOFTWARE_VERTEXPROCESSING, ref parameters, out var dev).ThrowOnError();
        using (var device = new ComObject<IDirect3DDevice9>(dev))
        {
            dev.CreateOffscreenPlainSurface(mode.Width, mode.Height, _D3DFORMAT.D3DFMT_A8R8G8B8, _D3DPOOL.D3DPOOL_SYSTEMMEM, out var surf, IntPtr.Zero).ThrowOnError();
            using (var surface = new ComObject<IDirect3DSurface9>(surf))
            {
                var rc = new _D3DLOCKED_RECT();
                var rect = new tagRECT();
                surf.LockRect(ref rc, ref rect, 0).ThrowOnError();
                var pitch = rc.Pitch;
                surf.UnlockRect();

                var shots = new byte[count][];
                for (var i = 0; i < count; i++)
                {
                    shots[i] = new byte[pitch * mode.Height];
                }

                var sw = new Stopwatch();
                sw.Start();
                for (var i = 0; i < count; i++)
                {
                    dev.GetFrontBufferData(0, surf).ThrowOnError();
                    surf.LockRect(ref rc, ref rect, 0).ThrowOnError();
                    Marshal.Copy(rc.pBits, shots[i], 0, shots[i].Length);
                    surf.UnlockRect().ThrowOnError();
                }
                Console.WriteLine("Elapsed: " + sw.Elapsed);

                for (var i = 0; i < count; i++)
                {
                    SavePixelsToFile32bppPBGRA(mode.Width, mode.Height, (uint)pitch, shots[i], "cap" + i + ".png", WICConstants.GUID_ContainerFormatPng).ThrowOnError();
                }
            }
        }
    }
    return 0;
}

static HRESULT SavePixelsToFile32bppPBGRA(uint width, uint height, uint stride, byte[] pixels, string filePath, Guid format)
{
    if (filePath == null)
        throw new ArgumentNullException(nameof(filePath));

    using (var fac = new ComObject<IWICImagingFactory>((IWICImagingFactory)new WicImagingFactory()))
    {
        fac.Object.CreateStream(out var stream).ThrowOnError();
        using (new ComObject<IWICStream>(stream))
        {
            const int GENERIC_WRITE = 0x40000000;
            stream.InitializeFromFilename(filePath, GENERIC_WRITE).ThrowOnError();
            fac.Object.CreateEncoder(format, IntPtr.Zero, out var encoder).ThrowOnError();
            using (new ComObject<IWICBitmapEncoder>(encoder))
            {
                encoder.Initialize(stream, WICBitmapEncoderCacheOption.WICBitmapEncoderNoCache).ThrowOnError();
                encoder.CreateNewFrame(out var frame, out var bag).ThrowOnError();
                using (new ComObject<IWICBitmapFrameEncode>(frame))
                {
                    frame.Initialize(null).ThrowOnError();
                    frame.SetSize(width, height).ThrowOnError();
                    frame.SetPixelFormat(ref format).ThrowOnError();
                    frame.WritePixels(height, stride, (int)(stride * height), pixels).ThrowOnError();
                    frame.Commit().ThrowOnError();
                    encoder.Commit().ThrowOnError();
                }
            }
        }
    }
    return 0;
}
```

And the C++ version is this (as you can see, they are almost identical, while the C# version is even smaller and easier to read):

```c++
HRESULT Direct3D9TakeScreenshots(UINT adapter, UINT count)
{
  HRESULT hr = S_OK;
  IDirect3D9 *d3d = nullptr;
  IDirect3DDevice9 *device = nullptr;
  IDirect3DSurface9 *surface = nullptr;
  D3DPRESENT_PARAMETERS parameters = { 0 };
  D3DDISPLAYMODE mode;
  D3DLOCKED_RECT rc;
  UINT pitch;
  SYSTEMTIME st;
  LPBYTE *shots = nullptr;

  // init D3D and get screen size
  d3d = Direct3DCreate9(D3D_SDK_VERSION);
  HRCHECK(d3d->GetAdapterDisplayMode(adapter, &mode));

  parameters.Windowed = TRUE;
  parameters.BackBufferCount = 1;
  parameters.BackBufferHeight = mode.Height;
  parameters.BackBufferWidth = mode.Width;
  parameters.SwapEffect = D3DSWAPEFFECT_DISCARD;
  parameters.hDeviceWindow = NULL;

  // create device & capture surface
  HRCHECK(d3d->CreateDevice(adapter, D3DDEVTYPE_HAL, NULL, D3DCREATE_SOFTWARE_VERTEXPROCESSING, &parameters, &device));
  HRCHECK(device->CreateOffscreenPlainSurface(mode.Width, mode.Height, D3DFMT_A8R8G8B8, D3DPOOL_SYSTEMMEM, &surface, nullptr));

  // compute the required buffer size
  HRCHECK(surface->LockRect(&rc, NULL, 0));
  pitch = rc.Pitch;
  HRCHECK(surface->UnlockRect());

  // allocate screenshots buffers
  shots = new LPBYTE[count];
  for (UINT i = 0; i < count; i++)
  {
    shots[i] = new BYTE[pitch * mode.Height];
  }

  GetSystemTime(&st); // measure the time we spend doing <count> captures
  wprintf(L"%i:%i:%i.%i\n", st.wHour, st.wMinute, st.wSecond, st.wMilliseconds);
  for (UINT i = 0; i < count; i++)
  {
    // get the data
    HRCHECK(device->GetFrontBufferData(0, surface));

    // copy it into our buffers
    HRCHECK(surface->LockRect(&rc, NULL, 0));
    CopyMemory(shots[i], rc.pBits, rc.Pitch * mode.Height);
    HRCHECK(surface->UnlockRect());
  }
  GetSystemTime(&st);
  wprintf(L"%i:%i:%i.%i\n", st.wHour, st.wMinute, st.wSecond, st.wMilliseconds);

  // save all screenshots
  for (UINT i = 0; i < count; i++)
  {
    WCHAR file[100];
    wsprintf(file, L"cap%i.png", i);
    HRCHECK(SavePixelsToFile32bppPBGRA(mode.Width, mode.Height, pitch, shots[i], file, GUID_ContainerFormatPng));
  }

cleanup:
  if (shots != nullptr)
  {
    for (UINT i = 0; i < count; i++)
    {
      delete shots[i];
    }
    delete[] shots;
  }
  RELEASE(surface);
  RELEASE(device);
  RELEASE(d3d);
  return hr;
}

HRESULT SavePixelsToFile32bppPBGRA(UINT width, UINT height, UINT stride, LPBYTE pixels, LPWSTR filePath, const GUID &format)
{
  if (!filePath || !pixels)
    return E_INVALIDARG;

  HRESULT hr = S_OK;
  IWICImagingFactory *factory = nullptr;
  IWICBitmapEncoder *encoder = nullptr;
  IWICBitmapFrameEncode *frame = nullptr;
  IWICStream *stream = nullptr;
  GUID pf = GUID_WICPixelFormat32bppPBGRA;
  BOOL coInit = CoInitialize(nullptr);

  HRCHECK(CoCreateInstance(CLSID_WICImagingFactory, nullptr, CLSCTX_INPROC_SERVER, IID_PPV_ARGS(&factory)));
  HRCHECK(factory->CreateStream(&stream));
  HRCHECK(stream->InitializeFromFilename(filePath, GENERIC_WRITE));
  HRCHECK(factory->CreateEncoder(format, nullptr, &encoder));
  HRCHECK(encoder->Initialize(stream, WICBitmapEncoderNoCache));
  HRCHECK(encoder->CreateNewFrame(&frame, nullptr)); // we don't use options here
  HRCHECK(frame->Initialize(nullptr)); // we dont' use any options here
  HRCHECK(frame->SetSize(width, height));
  HRCHECK(frame->SetPixelFormat(&pf));
  HRCHECK(frame->WritePixels(height, stride, stride * height, pixels));
  HRCHECK(frame->Commit());
  HRCHECK(encoder->Commit());

cleanup:
  RELEASE(stream);
  RELEASE(frame);
  RELEASE(encoder);
  RELEASE(factory);
  if (coInit) CoUninitialize();
  return hr;
}
```

 * Note 1: there  currently may be some issues with sructures that contain unions. If you have a specific problem with that, just create an issue;
 * Note 2: the functions.cs file has some issues as everything in the Generated folder is, well, automatically generated. If you have a specific problem with that, just create an issue;
 * Note 3: the tool that builds the Generated folder is not open source.

 # Winforms .NET 6 - Direct3D11 minimal sample.
 The **DirectN.MinimalD3D11** sample here https://github.com/smourier/DirectN/tree/master/DirectN/DirectN.MinimalD3D11 has been ported to C# from here: https://gist.github.com/d7samurai/261c69490cce0620d0bfc93003cd1052 which features *"a minimal Direct3D11 "uncluttered direct3d 11 setup and rendering primer for newcomers to the api"* sample.

 It's dependent on DirectN, .NET 6, Windows Forms and ... that's it. Here is the output (believe me, it rotates):

  ![Sample](/Assets/minimald3d11.png?raw=true)
Full credits go to d7Samurai: https://gist.github.com/d7samurai

Note: the code also works with .NET Core 3.1 to 5, it's just a project configuration matter.

 # WinUI3 .NET 6 - Direct3D11 minimal sample.
 The **DirectN.WinUI3.MinimalD3D11** sample here https://github.com/smourier/DirectN/tree/master/DirectN/DirectN.WinUI3.MinimalD3D11 has been ported to C# from here: https://gist.github.com/d7samurai/abab8a580d0298cb2f34a44eec41d39d which features a minimal Direct3D11 *"'API familiarizer' - an uncluttered Direct3D 11 setup & basic rendering reference implementation, in the form of a complete, runnable Windows application contained in a single function and laid out in a linear, step-by-step fashion"* sample.

 It's dependent on DirectN, .NET 6, WinUI3 (using **SwapChainPanel** https://learn.microsoft.com/en-us/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.swapchainpanel), and ... that's it. Here is the output (believe me, it rotates):

  ![Sample](/Assets/minimald3d11_pt3.png?raw=true)
Full credits go to d7Samurai: https://gist.github.com/d7samurai

