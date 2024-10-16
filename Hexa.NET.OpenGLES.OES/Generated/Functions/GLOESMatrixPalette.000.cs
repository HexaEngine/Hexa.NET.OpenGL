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
	public static unsafe partial class GLOESMatrixPalette
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CurrentPaletteMatrixOESNative(uint matrixpaletteindex)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(matrixpaletteindex);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(matrixpaletteindex);
			#endif
		}

		public static void CurrentPaletteMatrixOES(uint matrixpaletteindex)
		{
			CurrentPaletteMatrixOESNative(matrixpaletteindex);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void LoadPaletteFromModelViewMatrixOESNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#endif
		}

		public static void LoadPaletteFromModelViewMatrixOES()
		{
			LoadPaletteFromModelViewMatrixOESNative();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MatrixIndexPointerOESNative(int size, GLMatrixIndexPointerTypeARB type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLMatrixIndexPointerTypeARB, int, void*, void>)funcTable[2])(size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<int, GLMatrixIndexPointerTypeARB, int, nint, void>)funcTable[2])(size, type, stride, (nint)pointer);
			#endif
		}

		public static void MatrixIndexPointerOES(int size, GLMatrixIndexPointerTypeARB type, int stride, void* pointer)
		{
			MatrixIndexPointerOESNative(size, type, stride, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WeightPointerOESNative(int size, GLEnum type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLEnum, int, void*, void>)funcTable[3])(size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<int, GLEnum, int, nint, void>)funcTable[3])(size, type, stride, (nint)pointer);
			#endif
		}

		public static void WeightPointerOES(int size, GLEnum type, int stride, void* pointer)
		{
			WeightPointerOESNative(size, type, stride, pointer);
		}

	}
}