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

namespace Hexa.NET.OpenGL.NV
{
	public static unsafe partial class GLNVPixelDataRange
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FlushPixelDataRangeNVNative(GLPixelDataRangeTargetNV target)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelDataRangeTargetNV, void>)funcTable[0])(target);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelDataRangeTargetNV, void>)funcTable[0])(target);
			#endif
		}

		public static void FlushPixelDataRangeNV(GLPixelDataRangeTargetNV target)
		{
			FlushPixelDataRangeNVNative(target);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PixelDataRangeNVNative(GLPixelDataRangeTargetNV target, int length, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelDataRangeTargetNV, int, void*, void>)funcTable[1])(target, length, pointer);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelDataRangeTargetNV, int, nint, void>)funcTable[1])(target, length, (nint)pointer);
			#endif
		}

		public static void PixelDataRangeNV(GLPixelDataRangeTargetNV target, int length, void* pointer)
		{
			PixelDataRangeNVNative(target, length, pointer);
		}

	}
}