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
	public static unsafe partial class GLNVScissorExclusive
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ScissorExclusiveArrayvNVNative(uint first, int count, int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, void>)funcTable[0])(first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[0])(first, count, (nint)v);
			#endif
		}

		public static void ScissorExclusiveArrayvNV(uint first, int count, int* v)
		{
			ScissorExclusiveArrayvNVNative(first, count, v);
		}

		public static void ScissorExclusiveArrayvNV(uint first, int count, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				ScissorExclusiveArrayvNVNative(first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ScissorExclusiveNVNative(int x, int y, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, void>)funcTable[1])(x, y, width, height);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, void>)funcTable[1])(x, y, width, height);
			#endif
		}

		public static void ScissorExclusiveNV(int x, int y, int width, int height)
		{
			ScissorExclusiveNVNative(x, y, width, height);
		}

	}
}
