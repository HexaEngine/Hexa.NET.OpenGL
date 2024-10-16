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

namespace Hexa.NET.OpenGLES.EXT
{
	public static unsafe partial class GLEXTDrawInstanced
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawArraysInstancedEXTNative(GLPrimitiveType mode, int start, int count, int primcount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, int, void>)funcTable[0])(mode, start, count, primcount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, int, void>)funcTable[0])(mode, start, count, primcount);
			#endif
		}

		public static void DrawArraysInstancedEXT(GLPrimitiveType mode, int start, int count, int primcount)
		{
			DrawArraysInstancedEXTNative(mode, start, count, primcount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawElementsInstancedEXTNative(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int primcount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, void*, int, void>)funcTable[1])(mode, count, type, indices, primcount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, nint, int, void>)funcTable[1])(mode, count, type, (nint)indices, primcount);
			#endif
		}

		public static void DrawElementsInstancedEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int primcount)
		{
			DrawElementsInstancedEXTNative(mode, count, type, indices, primcount);
		}

	}
}
