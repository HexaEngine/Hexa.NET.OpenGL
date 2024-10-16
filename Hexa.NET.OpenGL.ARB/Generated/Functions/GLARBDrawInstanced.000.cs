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
	public static unsafe partial class GLARBDrawInstanced
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawArraysInstancedARBNative(GLPrimitiveType mode, int first, int count, int primcount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, int, void>)funcTable[0])(mode, first, count, primcount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, int, void>)funcTable[0])(mode, first, count, primcount);
			#endif
		}

		public static void DrawArraysInstancedARB(GLPrimitiveType mode, int first, int count, int primcount)
		{
			DrawArraysInstancedARBNative(mode, first, count, primcount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawElementsInstancedARBNative(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int primcount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, void*, int, void>)funcTable[1])(mode, count, type, indices, primcount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, nint, int, void>)funcTable[1])(mode, count, type, (nint)indices, primcount);
			#endif
		}

		public static void DrawElementsInstancedARB(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int primcount)
		{
			DrawElementsInstancedARBNative(mode, count, type, indices, primcount);
		}

	}
}
