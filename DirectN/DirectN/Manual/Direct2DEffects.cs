using System;

namespace DirectN
{
    public static class Direct2DEffects
    {
        public static string GetEffectName(Guid guid) => typeof(Direct2DEffects).GetGuidName(guid);

        public static readonly Guid CLSID_D2D12DAffineTransform = new Guid("6aa97485-6354-4cfc-908c-e4a74f62c96c");
        public static readonly Guid CLSID_D2D13DPerspectiveTransform = new Guid("c2844d0b-3d86-46e7-85ba-526c9240f3fb");
        public static readonly Guid CLSID_D2D13DTransform = new Guid("e8467b04-ec61-4b8a-b5de-d4d73debea5a");
        public static readonly Guid CLSID_D2D1ArithmeticComposite = new Guid("fc151437-049a-4784-a24a-f1c4daf20987");
        public static readonly Guid CLSID_D2D1Atlas = new Guid("913e2be4-fdcf-4fe2-a5f0-2454f14ff408");
        public static readonly Guid CLSID_D2D1BitmapSource = new Guid("5fb6c24d-c6dd-4231-9404-50f4d5c3252d");
        public static readonly Guid CLSID_D2D1Blend = new Guid("81c5b77b-13f8-4cdd-ad20-c890547ac65d");
        public static readonly Guid CLSID_D2D1Border = new Guid("2a2d49c0-4acf-43c7-8c6a-7c4a27874d27");
        public static readonly Guid CLSID_D2D1Brightness = new Guid("8cea8d1e-77b0-4986-b3b9-2f0c0eae7887");
        public static readonly Guid CLSID_D2D1ColorManagement = new Guid("1a28524c-fdd6-4aa4-ae8f-837eb8267b37");
        public static readonly Guid CLSID_D2D1ColorMatrix = new Guid("921f03d6-641c-47df-852d-b4bb6153ae11");
        public static readonly Guid CLSID_D2D1Composite = new Guid("48fc9f51-f6ac-48f1-8b58-3b28ac46f76d");
        public static readonly Guid CLSID_D2D1ConvolveMatrix = new Guid("407f8c08-5533-4331-a341-23cc3877843e");
        public static readonly Guid CLSID_D2D1Crop = new Guid("e23f7110-0e9a-4324-af47-6a2c0c46f35b");
        public static readonly Guid CLSID_D2D1DirectionalBlur = new Guid("174319a6-58e9-49b2-bb63-caf2c811a3db");
        public static readonly Guid CLSID_D2D1DiscreteTransfer = new Guid("90866fcd-488e-454b-af06-e5041b66c36c");
        public static readonly Guid CLSID_D2D1DisplacementMap = new Guid("edc48364-0417-4111-9450-43845fa9f890");
        public static readonly Guid CLSID_D2D1DistantDiffuse = new Guid("3e7efd62-a32d-46d4-a83c-5278889ac954");
        public static readonly Guid CLSID_D2D1DistantSpecular = new Guid("428c1ee5-77b8-4450-8ab5-72219c21abda");
        public static readonly Guid CLSID_D2D1DpiCompensation = new Guid("6c26c5c7-34e0-46fc-9cfd-e5823706e228");
        public static readonly Guid CLSID_D2D1Flood = new Guid("61c23c20-ae69-4d8e-94cf-50078df638f2");
        public static readonly Guid CLSID_D2D1GammaTransfer = new Guid("409444c4-c419-41a0-b0c1-8cd0c0a18e42");
        public static readonly Guid CLSID_D2D1GaussianBlur = new Guid("1feb6d69-2fe6-4ac9-8c58-1d7f93e7a6a5");
        public static readonly Guid CLSID_D2D1Scale = new Guid("9daf9369-3846-4d0e-a44e-0c607934a5d7");
        public static readonly Guid CLSID_D2D1Histogram = new Guid("881db7d0-f7ee-4d4d-a6d2-4697acc66ee8");
        public static readonly Guid CLSID_D2D1HueRotation = new Guid("0f4458ec-4b32-491b-9e85-bd73f44d3eb6");
        public static readonly Guid CLSID_D2D1LinearTransfer = new Guid("ad47c8fd-63ef-4acc-9b51-67979c036c06");
        public static readonly Guid CLSID_D2D1LuminanceToAlpha = new Guid("41251ab7-0beb-46f8-9da7-59e93fcce5de");
        public static readonly Guid CLSID_D2D1Morphology = new Guid("eae6c40d-626a-4c2d-bfcb-391001abe202");
        public static readonly Guid CLSID_D2D1OpacityMetadata = new Guid("6c53006a-4450-4199-aa5b-ad1656fece5e");
        public static readonly Guid CLSID_D2D1PointDiffuse = new Guid("b9e303c3-c08c-4f91-8b7b-38656bc48c20");
        public static readonly Guid CLSID_D2D1PointSpecular = new Guid("09c3ca26-3ae2-4f09-9ebc-ed3865d53f22");
        public static readonly Guid CLSID_D2D1Premultiply = new Guid("06eab419-deed-4018-80d2-3e1d471adeb2");
        public static readonly Guid CLSID_D2D1Saturation = new Guid("5cb2d9cf-327d-459f-a0ce-40c0b2086bf7");
        public static readonly Guid CLSID_D2D1Shadow = new Guid("c67ea361-1863-4e69-89db-695d3e9a5b6b");
        public static readonly Guid CLSID_D2D1SpotDiffuse = new Guid("818a1105-7932-44f4-aa86-08ae7b2f2c93");
        public static readonly Guid CLSID_D2D1SpotSpecular = new Guid("edae421e-7654-4a37-9db8-71acc1beb3c1");
        public static readonly Guid CLSID_D2D1TableTransfer = new Guid("5bf818c3-5e43-48cb-b631-868396d6a1d4");
        public static readonly Guid CLSID_D2D1Tile = new Guid("b0784138-3b76-4bc5-b13b-0fa2ad02659f");
        public static readonly Guid CLSID_D2D1Turbulence = new Guid("cf2bb6ae-889a-4ad7-ba29-a2fd732c9fc9");
        public static readonly Guid CLSID_D2D1UnPremultiply = new Guid("fb9ac489-ad8d-41ed-9999-bb6347d110f7");
        public static readonly Guid CLSID_D2D1YCbCr = new Guid("99503cc1-66c7-45c9-a875-8ad8a7914401");
        public static readonly Guid CLSID_D2D1Contrast = new Guid("b648a78a-0ed5-4f80-a94a-8e825aca6b77");
        public static readonly Guid CLSID_D2D1RgbToHue = new Guid("23f3e5ec-91e8-4d3d-ad0a-afadc1004aa1");
        public static readonly Guid CLSID_D2D1HueToRgb = new Guid("7b78a6bd-0141-4def-8a52-6356ee0cbdd5");
        public static readonly Guid CLSID_D2D1ChromaKey = new Guid("74c01f5b-2a0d-408c-88e2-c7a3c7197742");
        public static readonly Guid CLSID_D2D1Emboss = new Guid("b1c5eb2b-0348-43f0-8107-4957cacba2ae");
        public static readonly Guid CLSID_D2D1Exposure = new Guid("b56c8cfa-f634-41ee-bee0-ffa617106004");
        public static readonly Guid CLSID_D2D1Grayscale = new Guid("36dde0eb-3725-42e0-836d-52fb20aee644");
        public static readonly Guid CLSID_D2D1Invert = new Guid("e0c3784d-cb39-4e84-b6fd-6b72f0810263");
        public static readonly Guid CLSID_D2D1Posterize = new Guid("2188945e-33a3-4366-b7bc-086bd02d0884");
        public static readonly Guid CLSID_D2D1Sepia = new Guid("3a1af410-5f1d-4dbe-84df-915da79b7153");
        public static readonly Guid CLSID_D2D1Sharpen = new Guid("c9b887cb-c5ff-4dc5-9779-273dcf417c7d");
        public static readonly Guid CLSID_D2D1Straighten = new Guid("4da47b12-79a3-4fb0-8237-bbc3b2a4de08");
        public static readonly Guid CLSID_D2D1TemperatureTint = new Guid("89176087-8af9-4a08-aeb1-895f38db1766");
        public static readonly Guid CLSID_D2D1Vignette = new Guid("c00c40be-5e67-4ca3-95b4-f4b02c115135");
        public static readonly Guid CLSID_D2D1EdgeDetection = new Guid("eff583ca-cb07-4aa9-ac5d-2cc44c76460f");
        public static readonly Guid CLSID_D2D1HighlightsShadows = new Guid("cadc8384-323f-4c7e-a361-2e2b24df6ee4");
        public static readonly Guid CLSID_D2D1LookupTable3D = new Guid("349e0eda-0088-4a79-9ca3-c7e300202020");
        public static readonly Guid CLSID_D2D1Opacity = new Guid("811d79a4-de28-4454-8094-c64685f8bd4c");
        public static readonly Guid CLSID_D2D1AlphaMask = new Guid("c80ecff0-3fd5-4f05-8328-c5d1724b4f0a");
        public static readonly Guid CLSID_D2D1CrossFade = new Guid("12f575e8-4db1-485f-9a84-03a07dd3829f");
        public static readonly Guid CLSID_D2D1Tint = new Guid("36312b17-f7dd-4014-915d-ffca768cf211");
        public static readonly Guid CLSID_D2D1WhiteLevelAdjustment = new Guid("44a1cadb-6cdd-4818-8ff4-26c1cfe95bdb");
        public static readonly Guid CLSID_D2D1HdrToneMap = new Guid("7b0b748d-4610-4486-a90c-999d9a2e2b11");
    }
}
