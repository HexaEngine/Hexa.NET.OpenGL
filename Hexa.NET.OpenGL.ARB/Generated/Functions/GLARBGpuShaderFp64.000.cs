// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Runtime.CompilerServices;
using System.Numerics;

namespace Hexa.NET.OpenGL.ARB
{
	public static unsafe partial class GLARBGpuShaderFp64
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetUniformdvNative(uint program, int location, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, double*, void>)funcTable[0])(program, location, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[0])(program, location, (nint)@params);
			#endif
		}

		public static void GetUniformdv(uint program, int location, double* @params)
		{
			GetUniformdvNative(program, location, @params);
		}

		public static void GetUniformdv(uint program, int location, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				GetUniformdvNative(program, location, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform1dNative(int location, double x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, double, void>)funcTable[1])(location, x);
			#else
			((delegate* unmanaged[Cdecl]<int, double, void>)funcTable[1])(location, x);
			#endif
		}

		public static void Uniform1d(int location, double x)
		{
			Uniform1dNative(location, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform1dvNative(int location, int count, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, double*, void>)funcTable[2])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[2])(location, count, (nint)value);
			#endif
		}

		public static void Uniform1dv(int location, int count, double* value)
		{
			Uniform1dvNative(location, count, value);
		}

		public static void Uniform1dv(int location, int count, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				Uniform1dvNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform2dNative(int location, double x, double y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, double, double, void>)funcTable[3])(location, x, y);
			#else
			((delegate* unmanaged[Cdecl]<int, double, double, void>)funcTable[3])(location, x, y);
			#endif
		}

		public static void Uniform2d(int location, double x, double y)
		{
			Uniform2dNative(location, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform2dvNative(int location, int count, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, double*, void>)funcTable[4])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[4])(location, count, (nint)value);
			#endif
		}

		public static void Uniform2dv(int location, int count, double* value)
		{
			Uniform2dvNative(location, count, value);
		}

		public static void Uniform2dv(int location, int count, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				Uniform2dvNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform3dNative(int location, double x, double y, double z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, double, double, double, void>)funcTable[5])(location, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<int, double, double, double, void>)funcTable[5])(location, x, y, z);
			#endif
		}

		public static void Uniform3d(int location, double x, double y, double z)
		{
			Uniform3dNative(location, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform3dvNative(int location, int count, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, double*, void>)funcTable[6])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[6])(location, count, (nint)value);
			#endif
		}

		public static void Uniform3dv(int location, int count, double* value)
		{
			Uniform3dvNative(location, count, value);
		}

		public static void Uniform3dv(int location, int count, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				Uniform3dvNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform4dNative(int location, double x, double y, double z, double w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, double, double, double, double, void>)funcTable[7])(location, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<int, double, double, double, double, void>)funcTable[7])(location, x, y, z, w);
			#endif
		}

		public static void Uniform4d(int location, double x, double y, double z, double w)
		{
			Uniform4dNative(location, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform4dvNative(int location, int count, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, double*, void>)funcTable[8])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[8])(location, count, (nint)value);
			#endif
		}

		public static void Uniform4dv(int location, int count, double* value)
		{
			Uniform4dvNative(location, count, value);
		}

		public static void Uniform4dv(int location, int count, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				Uniform4dvNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix2dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[9])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[9])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix2dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix2dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix2dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix2dvNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix2x3dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[10])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[10])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix2x3dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix2x3dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix2x3dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix2x3dvNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix2x4dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[11])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[11])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix2x4dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix2x4dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix2x4dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix2x4dvNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix3dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[12])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[12])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix3dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix3dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix3dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix3dvNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix3x2dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[13])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[13])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix3x2dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix3x2dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix3x2dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix3x2dvNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix3x4dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[14])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[14])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix3x4dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix3x4dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix3x4dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix3x4dvNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix4dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[15])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[15])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix4dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix4dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix4dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix4dvNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix4x2dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[16])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[16])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix4x2dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix4x2dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix4x2dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix4x2dvNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix4x3dvNative(int location, int count, byte transpose, double* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, double*, void>)funcTable[17])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[17])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix4x3dv(int location, int count, byte transpose, double* value)
		{
			UniformMatrix4x3dvNative(location, count, transpose, value);
		}

		public static void UniformMatrix4x3dv(int location, int count, byte transpose, ref double value)
		{
			fixed (double* pvalue0 = &value)
			{
				UniformMatrix4x3dvNative(location, count, transpose, pvalue0);
			}
		}

	}
}
