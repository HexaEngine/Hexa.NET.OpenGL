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

namespace Hexa.NET.OpenGL.MESA
{
	public static unsafe partial class GLMESAWindowPos
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2dMESANative(double x, double y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, void>)funcTable[0])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<double, double, void>)funcTable[0])(x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2dMESA(double x, double y)
		{
			WindowPos2dMESANative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2dvMESANative(double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[1])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[1])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2dvMESA(double* v)
		{
			WindowPos2dvMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2dvMESA(Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				WindowPos2dvMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2dvMESA(ref double v)
		{
			fixed (double* pv0 = &v)
			{
				WindowPos2dvMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2fMESANative(float x, float y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, void>)funcTable[2])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<float, float, void>)funcTable[2])(x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2fMESA(float x, float y)
		{
			WindowPos2fMESANative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2fvMESANative(float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[3])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[3])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2fvMESA(float* v)
		{
			WindowPos2fvMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2fvMESA(Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				WindowPos2fvMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2fvMESA(ref float v)
		{
			fixed (float* pv0 = &v)
			{
				WindowPos2fvMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2iMESANative(int x, int y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, void>)funcTable[4])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<int, int, void>)funcTable[4])(x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2iMESA(int x, int y)
		{
			WindowPos2iMESANative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2ivMESANative(int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[5])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[5])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2ivMESA(int* v)
		{
			WindowPos2ivMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2ivMESA(Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				WindowPos2ivMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2ivMESA(ref int v)
		{
			fixed (int* pv0 = &v)
			{
				WindowPos2ivMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2sMESANative(short x, short y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, void>)funcTable[6])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<short, short, void>)funcTable[6])(x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2sMESA(short x, short y)
		{
			WindowPos2sMESANative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos2svMESANative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[7])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[7])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2svMESA(short* v)
		{
			WindowPos2svMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2svMESA(Span<short> v)
		{
			fixed (short* pv0 = v)
			{
				WindowPos2svMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos2svMESA(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				WindowPos2svMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3dMESANative(double x, double y, double z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[8])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[8])(x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3dMESA(double x, double y, double z)
		{
			WindowPos3dMESANative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3dvMESANative(double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[9])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[9])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3dvMESA(double* v)
		{
			WindowPos3dvMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3dvMESA(Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				WindowPos3dvMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3dvMESA(ref double v)
		{
			fixed (double* pv0 = &v)
			{
				WindowPos3dvMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3fMESANative(float x, float y, float z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[10])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[10])(x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3fMESA(float x, float y, float z)
		{
			WindowPos3fMESANative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3fvMESANative(float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[11])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[11])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3fvMESA(float* v)
		{
			WindowPos3fvMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3fvMESA(Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				WindowPos3fvMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3fvMESA(ref float v)
		{
			fixed (float* pv0 = &v)
			{
				WindowPos3fvMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3iMESANative(int x, int y, int z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[12])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[12])(x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3iMESA(int x, int y, int z)
		{
			WindowPos3iMESANative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3ivMESANative(int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[13])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[13])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3ivMESA(int* v)
		{
			WindowPos3ivMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3ivMESA(Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				WindowPos3ivMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3ivMESA(ref int v)
		{
			fixed (int* pv0 = &v)
			{
				WindowPos3ivMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3sMESANative(short x, short y, short z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[14])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[14])(x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3sMESA(short x, short y, short z)
		{
			WindowPos3sMESANative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3svMESANative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[15])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[15])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3svMESA(short* v)
		{
			WindowPos3svMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3svMESA(Span<short> v)
		{
			fixed (short* pv0 = v)
			{
				WindowPos3svMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos3svMESA(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				WindowPos3svMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos4dMESANative(double x, double y, double z, double w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, double, double, void>)funcTable[16])(x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<double, double, double, double, void>)funcTable[16])(x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4dMESA(double x, double y, double z, double w)
		{
			WindowPos4dMESANative(x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos4dvMESANative(double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[17])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[17])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4dvMESA(double* v)
		{
			WindowPos4dvMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4dvMESA(Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				WindowPos4dvMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4dvMESA(ref double v)
		{
			fixed (double* pv0 = &v)
			{
				WindowPos4dvMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos4fMESANative(float x, float y, float z, float w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, float, void>)funcTable[18])(x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, float, void>)funcTable[18])(x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4fMESA(float x, float y, float z, float w)
		{
			WindowPos4fMESANative(x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos4fvMESANative(float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[19])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[19])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4fvMESA(float* v)
		{
			WindowPos4fvMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4fvMESA(Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				WindowPos4fvMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4fvMESA(ref float v)
		{
			fixed (float* pv0 = &v)
			{
				WindowPos4fvMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos4iMESANative(int x, int y, int z, int w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, void>)funcTable[20])(x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, void>)funcTable[20])(x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4iMESA(int x, int y, int z, int w)
		{
			WindowPos4iMESANative(x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos4ivMESANative(int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[21])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[21])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4ivMESA(int* v)
		{
			WindowPos4ivMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4ivMESA(Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				WindowPos4ivMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4ivMESA(ref int v)
		{
			fixed (int* pv0 = &v)
			{
				WindowPos4ivMESANative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos4sMESANative(short x, short y, short z, short w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, short, short, void>)funcTable[22])(x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<short, short, short, short, void>)funcTable[22])(x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4sMESA(short x, short y, short z, short w)
		{
			WindowPos4sMESANative(x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos4svMESANative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[23])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[23])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4svMESA(short* v)
		{
			WindowPos4svMESANative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4svMESA(Span<short> v)
		{
			fixed (short* pv0 = v)
			{
				WindowPos4svMESANative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_MESA_window_pos</remarks>
		public static void WindowPos4svMESA(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				WindowPos4svMESANative(pv0);
			}
		}

	}
}
