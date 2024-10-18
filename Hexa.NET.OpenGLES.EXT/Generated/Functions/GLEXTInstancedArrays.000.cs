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
	public static unsafe partial class GLEXTInstancedArrays
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

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_instanced<br/>GL_EXT_instanced_arrays</remarks>
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

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_instanced<br/>GL_EXT_instanced_arrays</remarks>
		public static void DrawElementsInstancedEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int primcount)
		{
			DrawElementsInstancedEXTNative(mode, count, type, indices, primcount);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_instanced<br/>GL_EXT_instanced_arrays</remarks>
		public static void DrawElementsInstancedEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, nint indices, int primcount)
		{
			DrawElementsInstancedEXTNative(mode, count, type, (void*)indices, primcount);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_instanced<br/>GL_EXT_instanced_arrays</remarks>
		public static void DrawElementsInstancedEXT<TIndices>(GLPrimitiveType mode, int count, GLDrawElementsType type, Span<TIndices> indices, int primcount) where TIndices : unmanaged
		{
			fixed (TIndices* pindices0 = indices)
			{
				DrawElementsInstancedEXTNative(mode, count, type, pindices0, primcount);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribDivisorEXTNative(uint index, uint divisor)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[2])(index, divisor);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[2])(index, divisor);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_instanced_arrays</remarks>
		public static void VertexAttribDivisorEXT(uint index, uint divisor)
		{
			VertexAttribDivisorEXTNative(index, divisor);
		}

	}
}
