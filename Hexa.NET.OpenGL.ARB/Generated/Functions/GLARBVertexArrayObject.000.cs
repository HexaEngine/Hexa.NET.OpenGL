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
	public static unsafe partial class GLARBVertexArrayObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindVertexArrayNative(uint array)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(array);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(array);
			#endif
		}

		public static void BindVertexArray(uint array)
		{
			BindVertexArrayNative(array);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteVertexArraysNative(int n, uint* arrays)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[1])(n, arrays);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)arrays);
			#endif
		}

		public static void DeleteVertexArrays(int n, uint* arrays)
		{
			DeleteVertexArraysNative(n, arrays);
		}

		public static void DeleteVertexArray(uint array)
		{
			DeleteVertexArraysNative(1, &array);
		}

		public static void DeleteVertexArrays(int n, ref uint arrays)
		{
			fixed (uint* parrays0 = &arrays)
			{
				DeleteVertexArraysNative(n, parrays0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenVertexArraysNative(int n, uint* arrays)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[2])(n, arrays);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(n, (nint)arrays);
			#endif
		}

		public static void GenVertexArrays(int n, uint* arrays)
		{
			GenVertexArraysNative(n, arrays);
		}

		public static uint GenVertexArray()
		{
			uint result;
			GenVertexArraysNative(1, &result);
			return result;
		}

		public static void GenVertexArrays(int n, ref uint arrays)
		{
			fixed (uint* parrays0 = &arrays)
			{
				GenVertexArraysNative(n, parrays0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsVertexArrayNative(uint array)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[3])(array);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[3])(array);
			#endif
		}

		public static bool IsVertexArray(uint array)
		{
			byte ret = IsVertexArrayNative(array);
			return ret != 0;
		}

	}
}
