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
	public static unsafe partial class GLARBWindowPos
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2dARBNative(double x, double y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, void>)funcTable[0])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<double, double, void>)funcTable[0])(x, y);
			#endif
		}

		public static void WindowPos2dARB(double x, double y)
		{
			WindowPos2dARBNative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2dvARBNative(double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[1])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[1])((nint)v);
			#endif
		}

		public static void WindowPos2dvARB(double* v)
		{
			WindowPos2dvARBNative(v);
		}

		public static void WindowPos2dvARB(Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				WindowPos2dvARBNative(pv0);
			}
		}

		public static void WindowPos2dvARB(ref double v)
		{
			fixed (double* pv0 = &v)
			{
				WindowPos2dvARBNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2fARBNative(float x, float y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, void>)funcTable[2])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<float, float, void>)funcTable[2])(x, y);
			#endif
		}

		public static void WindowPos2fARB(float x, float y)
		{
			WindowPos2fARBNative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2fvARBNative(float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[3])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[3])((nint)v);
			#endif
		}

		public static void WindowPos2fvARB(float* v)
		{
			WindowPos2fvARBNative(v);
		}

		public static void WindowPos2fvARB(Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				WindowPos2fvARBNative(pv0);
			}
		}

		public static void WindowPos2fvARB(ref float v)
		{
			fixed (float* pv0 = &v)
			{
				WindowPos2fvARBNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2iARBNative(int x, int y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, void>)funcTable[4])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<int, int, void>)funcTable[4])(x, y);
			#endif
		}

		public static void WindowPos2iARB(int x, int y)
		{
			WindowPos2iARBNative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2ivARBNative(int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[5])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[5])((nint)v);
			#endif
		}

		public static void WindowPos2ivARB(int* v)
		{
			WindowPos2ivARBNative(v);
		}

		public static void WindowPos2ivARB(Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				WindowPos2ivARBNative(pv0);
			}
		}

		public static void WindowPos2ivARB(ref int v)
		{
			fixed (int* pv0 = &v)
			{
				WindowPos2ivARBNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2sARBNative(short x, short y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, void>)funcTable[6])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<short, short, void>)funcTable[6])(x, y);
			#endif
		}

		public static void WindowPos2sARB(short x, short y)
		{
			WindowPos2sARBNative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2svARBNative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[7])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[7])((nint)v);
			#endif
		}

		public static void WindowPos2svARB(short* v)
		{
			WindowPos2svARBNative(v);
		}

		public static void WindowPos2svARB(Span<short> v)
		{
			fixed (short* pv0 = v)
			{
				WindowPos2svARBNative(pv0);
			}
		}

		public static void WindowPos2svARB(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				WindowPos2svARBNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3dARBNative(double x, double y, double z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[8])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[8])(x, y, z);
			#endif
		}

		public static void WindowPos3dARB(double x, double y, double z)
		{
			WindowPos3dARBNative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3dvARBNative(double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[9])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[9])((nint)v);
			#endif
		}

		public static void WindowPos3dvARB(double* v)
		{
			WindowPos3dvARBNative(v);
		}

		public static void WindowPos3dvARB(Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				WindowPos3dvARBNative(pv0);
			}
		}

		public static void WindowPos3dvARB(ref double v)
		{
			fixed (double* pv0 = &v)
			{
				WindowPos3dvARBNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3fARBNative(float x, float y, float z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[10])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[10])(x, y, z);
			#endif
		}

		public static void WindowPos3fARB(float x, float y, float z)
		{
			WindowPos3fARBNative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3fvARBNative(float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[11])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[11])((nint)v);
			#endif
		}

		public static void WindowPos3fvARB(float* v)
		{
			WindowPos3fvARBNative(v);
		}

		public static void WindowPos3fvARB(Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				WindowPos3fvARBNative(pv0);
			}
		}

		public static void WindowPos3fvARB(ref float v)
		{
			fixed (float* pv0 = &v)
			{
				WindowPos3fvARBNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3iARBNative(int x, int y, int z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[12])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[12])(x, y, z);
			#endif
		}

		public static void WindowPos3iARB(int x, int y, int z)
		{
			WindowPos3iARBNative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3ivARBNative(int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[13])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[13])((nint)v);
			#endif
		}

		public static void WindowPos3ivARB(int* v)
		{
			WindowPos3ivARBNative(v);
		}

		public static void WindowPos3ivARB(Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				WindowPos3ivARBNative(pv0);
			}
		}

		public static void WindowPos3ivARB(ref int v)
		{
			fixed (int* pv0 = &v)
			{
				WindowPos3ivARBNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3sARBNative(short x, short y, short z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[14])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[14])(x, y, z);
			#endif
		}

		public static void WindowPos3sARB(short x, short y, short z)
		{
			WindowPos3sARBNative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3svARBNative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[15])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[15])((nint)v);
			#endif
		}

		public static void WindowPos3svARB(short* v)
		{
			WindowPos3svARBNative(v);
		}

		public static void WindowPos3svARB(Span<short> v)
		{
			fixed (short* pv0 = v)
			{
				WindowPos3svARBNative(pv0);
			}
		}

		public static void WindowPos3svARB(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				WindowPos3svARBNative(pv0);
			}
		}

	}
}
