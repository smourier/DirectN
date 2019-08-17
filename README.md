# DirectN
Direct Interop code for .NET : DXGI, WIC, DirectX 9 to 12, Direct2D, Direct Write, Direct Composition, Media Foundation, WASAPI, CodecAPI, GDI, Spatial Audio, DVD, Windows Media Player, etc.

The easiest way to use this is reference the nuget package: https://www.nuget.org/packages/DirectN/

Or you can pick the C# source files you want (among the 6000 .cs provided), but it can be difficult because the dependencies between all these technologies make extracting a small portion quite difficult (and they are one of the reasons why DirectN exists...).

DirectN allows you to port C/C++ code to C#, or to write C# code from scratch, more easily than with other existing interop libraries in this domain because one of its main objective is to use exactly the same names and types (interfaces, enums, structures, constants, methods, arguments, guids, etc.) that the native concepts. So you can read the official documentation, use existing C/C++ samples, and start coding with .NET right away.

Everything is in the same namespace so you don't need to know where is defined this or that interface, constants, etc.

For example, the exact same C# version of the "Capture screen using DirectX" code here: https://stackoverflow.com/questions/30021274/capture-screen-using-directx is this:

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
                        frame.WritePixels(height, stride, stride * height, pixels).ThrowOnError();
                        frame.Commit().ThrowOnError();
                        encoder.Commit().ThrowOnError();
                    }
                }
            }
        }
        return 0;
    }

And the C++ version is this:

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

 * Note 1: there are currently some issues with sructures that contain unions. This will be fixed soon. If you have a specific problem with that, just create an issue
 * Note 2: the functions.cs file has some issues. everything in the Generated folder is, well, automatically generated. If you have a specific problem with that, just create an issue
 * Note 3: the tool that builds the Generated folder is not open source.
