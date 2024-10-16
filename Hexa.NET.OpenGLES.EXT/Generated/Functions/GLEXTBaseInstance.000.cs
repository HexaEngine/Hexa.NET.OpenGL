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
	public static unsafe partial class GLEXTBaseInstance
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawArraysInstancedBaseInstanceEXTNative(GLPrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, int, uint, void>)funcTable[0])(mode, first, count, instancecount, baseinstance);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, int, uint, void>)funcTable[0])(mode, first, count, instancecount, baseinstance);
			#endif
		}

		public static void DrawArraysInstancedBaseInstanceEXT(GLPrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
		{
			DrawArraysInstancedBaseInstanceEXTNative(mode, first, count, instancecount, baseinstance);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawElementsInstancedBaseInstanceEXTNative(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int instancecount, uint baseinstance)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, void*, int, uint, void>)funcTable[1])(mode, count, type, indices, instancecount, baseinstance);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, nint, int, uint, void>)funcTable[1])(mode, count, type, (nint)indices, instancecount, baseinstance);
			#endif
		}

		public static void DrawElementsInstancedBaseInstanceEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int instancecount, uint baseinstance)
		{
			DrawElementsInstancedBaseInstanceEXTNative(mode, count, type, indices, instancecount, baseinstance);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawElementsInstancedBaseVertexBaseInstanceEXTNative(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, void*, int, int, uint, void>)funcTable[2])(mode, count, type, indices, instancecount, basevertex, baseinstance);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, nint, int, int, uint, void>)funcTable[2])(mode, count, type, (nint)indices, instancecount, basevertex, baseinstance);
			#endif
		}

		public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance)
		{
			DrawElementsInstancedBaseVertexBaseInstanceEXTNative(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}

	}
}
