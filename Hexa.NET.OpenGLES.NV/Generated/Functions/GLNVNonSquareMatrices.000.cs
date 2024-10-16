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

namespace Hexa.NET.OpenGLES.NV
{
	public static unsafe partial class GLNVNonSquareMatrices
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix2x3fvNVNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[0])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[0])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix2x3fvNV(int location, int count, byte transpose, float* value)
		{
			UniformMatrix2x3fvNVNative(location, count, transpose, value);
		}

		public static void UniformMatrix2x3fvNV(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix2x3fvNVNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix2x4fvNVNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[1])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[1])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix2x4fvNV(int location, int count, byte transpose, float* value)
		{
			UniformMatrix2x4fvNVNative(location, count, transpose, value);
		}

		public static void UniformMatrix2x4fvNV(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix2x4fvNVNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix3x2fvNVNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[2])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[2])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix3x2fvNV(int location, int count, byte transpose, float* value)
		{
			UniformMatrix3x2fvNVNative(location, count, transpose, value);
		}

		public static void UniformMatrix3x2fvNV(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix3x2fvNVNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix3x4fvNVNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[3])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[3])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix3x4fvNV(int location, int count, byte transpose, float* value)
		{
			UniformMatrix3x4fvNVNative(location, count, transpose, value);
		}

		public static void UniformMatrix3x4fvNV(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix3x4fvNVNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix4x2fvNVNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[4])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[4])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix4x2fvNV(int location, int count, byte transpose, float* value)
		{
			UniformMatrix4x2fvNVNative(location, count, transpose, value);
		}

		public static void UniformMatrix4x2fvNV(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix4x2fvNVNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix4x3fvNVNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[5])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[5])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix4x3fvNV(int location, int count, byte transpose, float* value)
		{
			UniformMatrix4x3fvNVNative(location, count, transpose, value);
		}

		public static void UniformMatrix4x3fvNV(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix4x3fvNVNative(location, count, transpose, pvalue0);
			}
		}

	}
}