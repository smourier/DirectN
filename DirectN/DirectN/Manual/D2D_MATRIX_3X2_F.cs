using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_MATRIX_3X2_F
    {
        public float _11;
        public float _12;
        public float _21;
        public float _22;
        public float _31;
        public float _32;

        public D2D_MATRIX_3X2_F(
            float m11, float m12,
            float m21, float m22,
            float m31, float m32
            )
        {
            _11 = m11;
            _12 = m12;
            _21 = m21;
            _22 = m22;
            _31 = m31;
            _32 = m32;
        }

        public float Determinant => _11 * _22 - _12 * _21;

        public static D2D_MATRIX_3X2_F Identity()
        {
            var m = new D2D_MATRIX_3X2_F();
            m._11 = 1;
            m._22 = 1;
            return m;
        }

        public D2D_MATRIX_3X2_F? Inverse()
        {
            var det = Determinant;
            if (det == 0)
                return null;

            var m = new D2D_MATRIX_3X2_F();
            m._11 = _22 / det;
            m._12 = -_12 / det;
            m._21 = -_21 / det;
            m._22 = _11 / det;
            m._31 = (_21 * _32 - _31 * _22) / det;
            m._32 = (_31 * _12 - _11 * _32) / det;
            return m;
        }

        public static D2D_MATRIX_3X2_F Translation(float width, float height)
        {
            var m = new D2D_MATRIX_3X2_F();
            m._11 = 1;
            m._22 = 1;
            m._31 = width;
            m._32 = height;
            return m;
        }

        public static D2D_MATRIX_3X2_F Scale(float width, float height, float centerX = 0, float centerY = 0)
        {
            var m = new D2D_MATRIX_3X2_F();
            m._11 = width;
            m._22 = height;
            m._31 = centerX - width * centerX;
            m._32 = centerY - height * centerY;
            return m;
        }

        public static D2D_MATRIX_3X2_F Rotation(float degrees, float centerX = 0, float centerY = 0)
        {
            var m = new D2D_MATRIX_3X2_F();
            var radians = degrees * (Math.PI / 180);
            var sin = Math.Sin(radians);
            var cos = Math.Cos(radians);
            m._11 = (float)cos;
            m._12 = (float)sin;
            m._21 = (float)-sin;
            m._22 = (float)cos;
            m._31 = (float)(centerX - centerX * cos + centerY * sin);
            m._32 = (float)(centerY - centerX * sin - centerY * cos);
            return m;
        }

        public static D2D_MATRIX_3X2_F Skew(float degreesX, float degreesY, float centerX = 0, float centerY = 0)
        {
            var m = new D2D_MATRIX_3X2_F();
            var tanx = Math.Tan(degreesX * (Math.PI / 180));
            var tany = Math.Tan(degreesY * (Math.PI / 180));
            m._11 = 1;
            m._12 = (float)tany;
            m._21 = (float)tanx;
            m._22 = 1;
            m._31 = (float)(-tanx * centerY);
            m._32 = (float)(-tany * centerX);
            return m;
        }

        public static D2D_MATRIX_3X2_F Divide(D2D_MATRIX_3X2_F a, D2D_MATRIX_3X2_F b)
        {
            var inv = b.Inverse();
            if (!inv.HasValue)
                throw new DivideByZeroException();

            return Multiply(a, inv.Value);
        }

        public static D2D_MATRIX_3X2_F Divide(ref D2D_MATRIX_3X2_F a, ref D2D_MATRIX_3X2_F b)
        {
            var inv = b.Inverse();
            if (!inv.HasValue)
                throw new DivideByZeroException();

            return Multiply(a, inv.Value);
        }

        public static D2D_MATRIX_3X2_F Multiply(D2D_MATRIX_3X2_F a, D2D_MATRIX_3X2_F b)
        {
            var m = new D2D_MATRIX_3X2_F();
            m._11 = a._11 * b._11 + a._12 * b._21;
            m._12 = a._11 * b._12 + a._12 * b._22;
            m._21 = a._21 * b._11 + a._22 * b._21;
            m._22 = a._21 * b._12 + a._22 * b._22;
            m._31 = a._31 * b._11 + a._32 * b._21 + b._31;
            m._32 = a._31 * b._12 + a._32 * b._22 + b._32;
            return m;
        }

        public static D2D_MATRIX_3X2_F Multiply(ref D2D_MATRIX_3X2_F a, ref D2D_MATRIX_3X2_F b)
        {
            var m = new D2D_MATRIX_3X2_F();
            m._11 = a._11 * b._11 + a._12 * b._21;
            m._12 = a._11 * b._12 + a._12 * b._22;
            m._21 = a._21 * b._11 + a._22 * b._21;
            m._22 = a._21 * b._12 + a._22 * b._22;
            m._31 = a._31 * b._11 + a._32 * b._21 + b._31;
            m._32 = a._31 * b._12 + a._32 * b._22 + b._32;
            return m;
        }

        public D2D_POINT_2F Multiply(D2D_POINT_2F point) => new D2D_POINT_2F(point.x * _11 + point.y * _21 + _31, point.x * _12 + point.y * _22 + _32);
        public IEnumerable<D2D_POINT_2F> Multiply(IEnumerable<D2D_POINT_2F> points)
        {
            if (points == null)
                yield break;

            foreach (var pt in points)
            {
                yield return Multiply(pt);
            }
        }

        public static D2D_MATRIX_3X2_F operator *(D2D_MATRIX_3X2_F left, D2D_MATRIX_3X2_F right) => Multiply(left, right);
        public static D2D_MATRIX_3X2_F operator /(D2D_MATRIX_3X2_F left, D2D_MATRIX_3X2_F right) => Divide(left, right);
    }
}
