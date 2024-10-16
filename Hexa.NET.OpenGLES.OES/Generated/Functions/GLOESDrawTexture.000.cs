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

namespace Hexa.NET.OpenGLES.OES
{
	public static unsafe partial class GLOESDrawTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTexfOESNative(float x, float y, float z, float width, float height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, float, float, void>)funcTable[0])(x, y, z, width, height);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, float, float, void>)funcTable[0])(x, y, z, width, height);
			#endif
		}

		public static void DrawTexfOES(float x, float y, float z, float width, float height)
		{
			DrawTexfOESNative(x, y, z, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTexfvOESNative(float* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[1])(coords);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[1])((nint)coords);
			#endif
		}

		public static void DrawTexfvOES(float* coords)
		{
			DrawTexfvOESNative(coords);
		}

		public static void DrawTexfvOES(ref float coords)
		{
			fixed (float* pcoords0 = &coords)
			{
				DrawTexfvOESNative(pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTexiOESNative(int x, int y, int z, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, void>)funcTable[2])(x, y, z, width, height);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, void>)funcTable[2])(x, y, z, width, height);
			#endif
		}

		public static void DrawTexiOES(int x, int y, int z, int width, int height)
		{
			DrawTexiOESNative(x, y, z, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTexivOESNative(int* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[3])(coords);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[3])((nint)coords);
			#endif
		}

		public static void DrawTexivOES(int* coords)
		{
			DrawTexivOESNative(coords);
		}

		public static void DrawTexivOES(ref int coords)
		{
			fixed (int* pcoords0 = &coords)
			{
				DrawTexivOESNative(pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTexsOESNative(short x, short y, short z, short width, short height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, short, short, short, void>)funcTable[4])(x, y, z, width, height);
			#else
			((delegate* unmanaged[Cdecl]<short, short, short, short, short, void>)funcTable[4])(x, y, z, width, height);
			#endif
		}

		public static void DrawTexsOES(short x, short y, short z, short width, short height)
		{
			DrawTexsOESNative(x, y, z, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTexsvOESNative(short* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[5])(coords);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[5])((nint)coords);
			#endif
		}

		public static void DrawTexsvOES(short* coords)
		{
			DrawTexsvOESNative(coords);
		}

		public static void DrawTexsvOES(ref short coords)
		{
			fixed (short* pcoords0 = &coords)
			{
				DrawTexsvOESNative(pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTexxOESNative(int x, int y, int z, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, void>)funcTable[6])(x, y, z, width, height);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, void>)funcTable[6])(x, y, z, width, height);
			#endif
		}

		public static void DrawTexxOES(int x, int y, int z, int width, int height)
		{
			DrawTexxOESNative(x, y, z, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTexxvOESNative(int* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[7])(coords);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[7])((nint)coords);
			#endif
		}

		public static void DrawTexxvOES(int* coords)
		{
			DrawTexxvOESNative(coords);
		}

		public static void DrawTexxvOES(ref int coords)
		{
			fixed (int* pcoords0 = &coords)
			{
				DrawTexxvOESNative(pcoords0);
			}
		}

	}
}