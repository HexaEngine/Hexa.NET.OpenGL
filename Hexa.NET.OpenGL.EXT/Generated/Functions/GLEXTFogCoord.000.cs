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

namespace Hexa.NET.OpenGL.EXT
{
	public static unsafe partial class GLEXTFogCoord
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FogCoordPointerEXTNative(GLFogPointerTypeEXT type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFogPointerTypeEXT, int, void*, void>)funcTable[0])(type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<GLFogPointerTypeEXT, int, nint, void>)funcTable[0])(type, stride, (nint)pointer);
			#endif
		}

		public static void FogCoordPointerEXT(GLFogPointerTypeEXT type, int stride, void* pointer)
		{
			FogCoordPointerEXTNative(type, stride, pointer);
		}

		public static void FogCoordPointerEXT(GLFogPointerTypeEXT type, int stride, nint pointer)
		{
			FogCoordPointerEXTNative(type, stride, (void*)pointer);
		}

		public static void FogCoordPointerEXT<TPointer>(GLFogPointerTypeEXT type, int stride, Span<TPointer> pointer) where TPointer : unmanaged
		{
			fixed (TPointer* ppointer0 = pointer)
			{
				FogCoordPointerEXTNative(type, stride, ppointer0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FogCoorddEXTNative(double coord)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, void>)funcTable[1])(coord);
			#else
			((delegate* unmanaged[Cdecl]<double, void>)funcTable[1])(coord);
			#endif
		}

		public static void FogCoorddEXT(double coord)
		{
			FogCoorddEXTNative(coord);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FogCoorddvEXTNative(double* coord)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[2])(coord);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[2])((nint)coord);
			#endif
		}

		public static void FogCoorddvEXT(double* coord)
		{
			FogCoorddvEXTNative(coord);
		}

		public static void FogCoorddvEXT(Span<double> coord)
		{
			fixed (double* pcoord0 = coord)
			{
				FogCoorddvEXTNative(pcoord0);
			}
		}

		public static void FogCoorddvEXT(ref double coord)
		{
			fixed (double* pcoord0 = &coord)
			{
				FogCoorddvEXTNative(pcoord0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FogCoordfEXTNative(float coord)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, void>)funcTable[3])(coord);
			#else
			((delegate* unmanaged[Cdecl]<float, void>)funcTable[3])(coord);
			#endif
		}

		public static void FogCoordfEXT(float coord)
		{
			FogCoordfEXTNative(coord);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FogCoordfvEXTNative(float* coord)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[4])(coord);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[4])((nint)coord);
			#endif
		}

		public static void FogCoordfvEXT(float* coord)
		{
			FogCoordfvEXTNative(coord);
		}

		public static void FogCoordfvEXT(Span<float> coord)
		{
			fixed (float* pcoord0 = coord)
			{
				FogCoordfvEXTNative(pcoord0);
			}
		}

		public static void FogCoordfvEXT(ref float coord)
		{
			fixed (float* pcoord0 = &coord)
			{
				FogCoordfvEXTNative(pcoord0);
			}
		}

	}
}
