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

namespace Hexa.NET.OpenGL.APPLE
{
	public static unsafe partial class GLAPPLEVertexArrayObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindVertexArrayAPPLENative(uint array)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(array);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(array);
			#endif
		}

		public static void BindVertexArrayAPPLE(uint array)
		{
			BindVertexArrayAPPLENative(array);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteVertexArraysAPPLENative(int n, uint* arrays)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[1])(n, arrays);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)arrays);
			#endif
		}

		public static void DeleteVertexArraysAPPLE(int n, uint* arrays)
		{
			DeleteVertexArraysAPPLENative(n, arrays);
		}

		public static void DeleteVertexArraysAPPLE(int n, ref uint arrays)
		{
			fixed (uint* parrays0 = &arrays)
			{
				DeleteVertexArraysAPPLENative(n, parrays0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenVertexArraysAPPLENative(int n, uint* arrays)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[2])(n, arrays);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(n, (nint)arrays);
			#endif
		}

		public static void GenVertexArraysAPPLE(int n, uint* arrays)
		{
			GenVertexArraysAPPLENative(n, arrays);
		}

		public static void GenVertexArraysAPPLE(int n, ref uint arrays)
		{
			fixed (uint* parrays0 = &arrays)
			{
				GenVertexArraysAPPLENative(n, parrays0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsVertexArrayAPPLENative(uint array)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[3])(array);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[3])(array);
			#endif
		}

		public static bool IsVertexArrayAPPLE(uint array)
		{
			byte ret = IsVertexArrayAPPLENative(array);
			return ret != 0;
		}

	}
}