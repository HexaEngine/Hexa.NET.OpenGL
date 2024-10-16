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

namespace Hexa.NET.OpenGLES.NV
{
	public static unsafe partial class GLNVDrawInstanced
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawArraysInstancedNVNative(GLPrimitiveType mode, int first, int count, int primcount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, int, void>)funcTable[0])(mode, first, count, primcount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, int, void>)funcTable[0])(mode, first, count, primcount);
			#endif
		}

		public static void DrawArraysInstancedNV(GLPrimitiveType mode, int first, int count, int primcount)
		{
			DrawArraysInstancedNVNative(mode, first, count, primcount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawElementsInstancedNVNative(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int primcount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, void*, int, void>)funcTable[1])(mode, count, type, indices, primcount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, nint, int, void>)funcTable[1])(mode, count, type, (nint)indices, primcount);
			#endif
		}

		public static void DrawElementsInstancedNV(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int primcount)
		{
			DrawElementsInstancedNVNative(mode, count, type, indices, primcount);
		}

	}
}