using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_MATRIX_4X4_F
    {
        public float _11;
        public float _12;
        public float _13;
        public float _14;
        public float _21;
        public float _22;
        public float _23;
        public float _24;
        public float _31;
        public float _32;
        public float _33;
        public float _34;
        public float _41;
        public float _42;
        public float _43;
        public float _44;

        public D2D_MATRIX_4X4_F(
            float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44
            )
        {
            _11 = m11;
            _12 = m12;
            _13 = m13;
            _14 = m14;
            _21 = m21;
            _22 = m22;
            _23 = m23;
            _24 = m24;
            _31 = m31;
            _32 = m32;
            _33 = m33;
            _34 = m34;
            _41 = m41;
            _42 = m42;
            _43 = m43;
            _44 = m44;
        }

        public float[] ToArray() => new[] {
            _11, _12, _13, _14,
            _21, _22, _23, _24,
            _31, _32, _33, _34,
            _41, _42, _43, _44,
        };

        public static D2D_MATRIX_4X4_F Identity()
        {
            var m = new D2D_MATRIX_4X4_F();
            m._11 = 1;
            m._22 = 1;
            m._33 = 1;
            m._44 = 1;
            return m;
        }

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.18362.0\um\d2d1_1helper.h
        public static D2D_MATRIX_4X4_F Translation(float x, float y, float z)
        {
            var translation = new D2D_MATRIX_4X4_F();
            translation._11 = 1f;
            translation._22 = 1f;
            translation._33 = 1f;
            translation._44 = 1f;
            translation._41 = x;
            translation._42 = y;
            translation._43 = z;
            return translation;
        }

        public static D2D_MATRIX_4X4_F Scale(float x, float y, float z)
        {
            var scale = new D2D_MATRIX_4X4_F();
            scale._11 = x;
            scale._22 = y;
            scale._33 = z;
            scale._44 = 1f;
            return scale;
        }

        public static D2D_MATRIX_4X4_F RotationX(float degrees)
        {
            var radians = degrees * (3.141592654f / 180f);
            D2D1Functions.D2D1SinCos(radians, out var sin, out var cos);
            return new D2D_MATRIX_4X4_F(
                1, 0, 0, 0,
                0, cos, sin, 0,
                0, -sin, cos, 0,
                0, 0, 0, 1
                );
        }

        public static D2D_MATRIX_4X4_F RotationY(float degrees)
        {
            var radians = degrees * (3.141592654f / 180f);
            D2D1Functions.D2D1SinCos(radians, out var sin, out var cos);
            return new D2D_MATRIX_4X4_F(
                cos, 0, -sin, 0,
                0, 1, 0, 0,
                sin, 0, cos, 0,
                0, 0, 0, 1
                );
        }

        public static D2D_MATRIX_4X4_F RotationZ(float degrees)
        {
            var radians = degrees * (3.141592654f / 180f);
            D2D1Functions.D2D1SinCos(radians, out var sin, out var cos);
            return new D2D_MATRIX_4X4_F(
                cos, sin, 0, 0,
                -sin, cos, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
                );
        }

        public static D2D_MATRIX_4X4_F Rotation(float degrees, float centerX = 0, float centerY = 0, float centerZ = 0)
        {
            var magnitude = D2D1Functions.D2D1Vec3Length(centerX, centerY, centerZ);
            centerX /= magnitude;
            centerY /= magnitude;
            centerZ /= magnitude;
            var radians = degrees * (3.141592654f / 180.0f);
            D2D1Functions.D2D1SinCos(radians, out var sin, out var cos);
            var oneMinusCos = 1 - cos;
            return new D2D_MATRIX_4X4_F(
                1 + oneMinusCos * (centerX * centerX - 1),
                centerZ * sin + oneMinusCos * centerX * centerY,
                -centerY * sin + oneMinusCos * centerX * centerZ,
                0,
                -centerZ * sin + oneMinusCos * centerY * centerX,
                1 + oneMinusCos * (centerY * centerY - 1),
                centerX * sin + oneMinusCos * centerY * centerZ,
                0,

                centerY * sin + oneMinusCos * centerZ * centerX,
                -centerX * sin + oneMinusCos * centerZ * centerY,
                1 + oneMinusCos * (centerZ * centerZ - 1),
                0,
                0, 0, 0, 1
                );
        }

        public static D2D_MATRIX_4X4_F SkewX(float degrees)
        {
            var radians = degrees * (3.141592654f / 180.0f);
            var tan = D2D1Functions.D2D1Tan(radians);
            return new D2D_MATRIX_4X4_F(
                1, 0, 0, 0,
                tan, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
                );
        }

        public static D2D_MATRIX_4X4_F SkewY(float degrees)
        {
            var radians = degrees * (3.141592654f / 180.0f);
            var tan = D2D1Functions.D2D1Tan(radians);
            return new D2D_MATRIX_4X4_F(
                1, tan, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
                );
        }

        public static D2D_MATRIX_4X4_F PerspectiveProjection(float depth)
        {
            var proj = 0f;
            if (depth > 0)
            {
                proj = -1 / depth;
            }
            return new D2D_MATRIX_4X4_F(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, proj,
                0, 0, 0, 1
                );
        }

        public static D2D_MATRIX_4X4_F Multiply(D2D_MATRIX_4X4_F a, D2D_MATRIX_4X4_F b)
        {
            var m = new D2D_MATRIX_4X4_F();
            m._11 = a._11 * b._11 + a._12 * b._21 + a._13 * b._31 + a._14 * b._41;
            m._12 = a._11 * b._12 + a._12 * b._22 + a._13 * b._32 + a._14 * b._42;
            m._13 = a._11 * b._13 + a._12 * b._23 + a._13 * b._33 + a._14 * b._43;
            m._14 = a._11 * b._14 + a._12 * b._24 + a._13 * b._34 + a._14 * b._44;
            m._21 = a._21 * b._11 + a._22 * b._21 + a._23 * b._31 + a._24 * b._41;
            m._22 = a._21 * b._12 + a._22 * b._22 + a._23 * b._32 + a._24 * b._42;
            m._23 = a._21 * b._13 + a._22 * b._23 + a._23 * b._33 + a._24 * b._43;
            m._24 = a._21 * b._14 + a._22 * b._24 + a._23 * b._34 + a._24 * b._44;
            m._31 = a._31 * b._11 + a._32 * b._21 + a._33 * b._31 + a._34 * b._41;
            m._32 = a._31 * b._12 + a._32 * b._22 + a._33 * b._32 + a._34 * b._42;
            m._33 = a._31 * b._13 + a._32 * b._23 + a._33 * b._33 + a._34 * b._43;
            m._34 = a._31 * b._14 + a._32 * b._24 + a._33 * b._34 + a._34 * b._44;
            m._41 = a._41 * b._11 + a._42 * b._21 + a._43 * b._31 + a._44 * b._41;
            m._42 = a._41 * b._12 + a._42 * b._22 + a._43 * b._32 + a._44 * b._42;
            m._43 = a._41 * b._13 + a._42 * b._23 + a._43 * b._33 + a._44 * b._43;
            m._44 = a._41 * b._14 + a._42 * b._24 + a._43 * b._34 + a._44 * b._44;
            return m;
        }

        public static D2D_MATRIX_4X4_F Multiply(ref D2D_MATRIX_4X4_F a, ref D2D_MATRIX_4X4_F b)
        {
            var m = new D2D_MATRIX_4X4_F();
            m._11 = a._11 * b._11 + a._12 * b._21 + a._13 * b._31 + a._14 * b._41;
            m._12 = a._11 * b._12 + a._12 * b._22 + a._13 * b._32 + a._14 * b._42;
            m._13 = a._11 * b._13 + a._12 * b._23 + a._13 * b._33 + a._14 * b._43;
            m._14 = a._11 * b._14 + a._12 * b._24 + a._13 * b._34 + a._14 * b._44;
            m._21 = a._21 * b._11 + a._22 * b._21 + a._23 * b._31 + a._24 * b._41;
            m._22 = a._21 * b._12 + a._22 * b._22 + a._23 * b._32 + a._24 * b._42;
            m._23 = a._21 * b._13 + a._22 * b._23 + a._23 * b._33 + a._24 * b._43;
            m._24 = a._21 * b._14 + a._22 * b._24 + a._23 * b._34 + a._24 * b._44;
            m._31 = a._31 * b._11 + a._32 * b._21 + a._33 * b._31 + a._34 * b._41;
            m._32 = a._31 * b._12 + a._32 * b._22 + a._33 * b._32 + a._34 * b._42;
            m._33 = a._31 * b._13 + a._32 * b._23 + a._33 * b._33 + a._34 * b._43;
            m._34 = a._31 * b._14 + a._32 * b._24 + a._33 * b._34 + a._34 * b._44;
            m._41 = a._41 * b._11 + a._42 * b._21 + a._43 * b._31 + a._44 * b._41;
            m._42 = a._41 * b._12 + a._42 * b._22 + a._43 * b._32 + a._44 * b._42;
            m._43 = a._41 * b._13 + a._42 * b._23 + a._43 * b._33 + a._44 * b._43;
            m._44 = a._41 * b._14 + a._42 * b._24 + a._43 * b._34 + a._44 * b._44;
            return m;
        }

        // https://docs.microsoft.com/en-us/windows/win32/direct3d9/d3dxmatrixortholh
        public static D2D_MATRIX_4X4_F OrthographicProjection(
            float width,
            float height,
            float zn,
            float zf)
            => new D2D_MATRIX_4X4_F(
                2 / width, 0, 0, 0,
                0, 2 / height, 0, 0,
                0, 0, 1 / (zf - zn), 0,
                0, 0, -zn / (zf - zn), 1);

        // https://docs.microsoft.com/en-us/windows/win32/direct3d9/d3dxmatrixperspectivelh
        public static D2D_MATRIX_4X4_F PerspectiveProjection(
            float width,
            float height,
            float zn,
            float zf)
            => new D2D_MATRIX_4X4_F(
                    2 * zn / width, 0, 0, 0,
                    0, 2 * zn / height, 0, 0,
                    0, 0, zf / (zf - zn), 1,
                    0, 0, zn * zf / (zn - zf), 0);

        public static D2D_MATRIX_4X4_F operator *(D2D_MATRIX_4X4_F left, D2D_MATRIX_4X4_F right) => Multiply(left, right);
    }
}
