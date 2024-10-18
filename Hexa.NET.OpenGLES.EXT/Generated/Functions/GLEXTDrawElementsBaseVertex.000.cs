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
	public static unsafe partial class GLEXTDrawElementsBaseVertex
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawElementsBaseVertexEXTNative(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int basevertex)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, void*, int, void>)funcTable[0])(mode, count, type, indices, basevertex);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, nint, int, void>)funcTable[0])(mode, count, type, (nint)indices, basevertex);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawElementsBaseVertexEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int basevertex)
		{
			DrawElementsBaseVertexEXTNative(mode, count, type, indices, basevertex);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawElementsBaseVertexEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, nint indices, int basevertex)
		{
			DrawElementsBaseVertexEXTNative(mode, count, type, (void*)indices, basevertex);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawElementsBaseVertexEXT<TIndices>(GLPrimitiveType mode, int count, GLDrawElementsType type, Span<TIndices> indices, int basevertex) where TIndices : unmanaged
		{
			fixed (TIndices* pindices0 = indices)
			{
				DrawElementsBaseVertexEXTNative(mode, count, type, pindices0, basevertex);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawElementsInstancedBaseVertexEXTNative(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int instancecount, int basevertex)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, void*, int, int, void>)funcTable[1])(mode, count, type, indices, instancecount, basevertex);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, GLDrawElementsType, nint, int, int, void>)funcTable[1])(mode, count, type, (nint)indices, instancecount, basevertex);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawElementsInstancedBaseVertexEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, void* indices, int instancecount, int basevertex)
		{
			DrawElementsInstancedBaseVertexEXTNative(mode, count, type, indices, instancecount, basevertex);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawElementsInstancedBaseVertexEXT(GLPrimitiveType mode, int count, GLDrawElementsType type, nint indices, int instancecount, int basevertex)
		{
			DrawElementsInstancedBaseVertexEXTNative(mode, count, type, (void*)indices, instancecount, basevertex);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawElementsInstancedBaseVertexEXT<TIndices>(GLPrimitiveType mode, int count, GLDrawElementsType type, Span<TIndices> indices, int instancecount, int basevertex) where TIndices : unmanaged
		{
			fixed (TIndices* pindices0 = indices)
			{
				DrawElementsInstancedBaseVertexEXTNative(mode, count, type, pindices0, instancecount, basevertex);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawRangeElementsBaseVertexEXTNative(GLPrimitiveType mode, uint start, uint end, int count, GLDrawElementsType type, void* indices, int basevertex)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, uint, int, GLDrawElementsType, void*, int, void>)funcTable[2])(mode, start, end, count, type, indices, basevertex);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, uint, int, GLDrawElementsType, nint, int, void>)funcTable[2])(mode, start, end, count, type, (nint)indices, basevertex);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawRangeElementsBaseVertexEXT(GLPrimitiveType mode, uint start, uint end, int count, GLDrawElementsType type, void* indices, int basevertex)
		{
			DrawRangeElementsBaseVertexEXTNative(mode, start, end, count, type, indices, basevertex);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawRangeElementsBaseVertexEXT(GLPrimitiveType mode, uint start, uint end, int count, GLDrawElementsType type, nint indices, int basevertex)
		{
			DrawRangeElementsBaseVertexEXTNative(mode, start, end, count, type, (void*)indices, basevertex);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex</remarks>
		public static void DrawRangeElementsBaseVertexEXT<TIndices>(GLPrimitiveType mode, uint start, uint end, int count, GLDrawElementsType type, Span<TIndices> indices, int basevertex) where TIndices : unmanaged
		{
			fixed (TIndices* pindices0 = indices)
			{
				DrawRangeElementsBaseVertexEXTNative(mode, start, end, count, type, pindices0, basevertex);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawElementsBaseVertexEXTNative(GLPrimitiveType mode, int* count, GLDrawElementsType type, void** indices, int drawcount, int* basevertex)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int*, GLDrawElementsType, void**, int, int*, void>)funcTable[3])(mode, count, type, indices, drawcount, basevertex);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, nint, GLDrawElementsType, nint, int, nint, void>)funcTable[3])(mode, (nint)count, type, (nint)indices, drawcount, (nint)basevertex);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex<br/>GL_OES_draw_elements_base_vertex</remarks>
		public static void MultiDrawElementsBaseVertexEXT(GLPrimitiveType mode, int* count, GLDrawElementsType type, void** indices, int drawcount, int* basevertex)
		{
			MultiDrawElementsBaseVertexEXTNative(mode, count, type, indices, drawcount, basevertex);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex<br/>GL_OES_draw_elements_base_vertex</remarks>
		public static void MultiDrawElementsBaseVertexEXT(GLPrimitiveType mode, Span<int> count, GLDrawElementsType type, void** indices, int drawcount, int* basevertex)
		{
			fixed (int* pcount0 = count)
			{
				MultiDrawElementsBaseVertexEXTNative(mode, pcount0, type, indices, drawcount, basevertex);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex<br/>GL_OES_draw_elements_base_vertex</remarks>
		public static void MultiDrawElementsBaseVertexEXT(GLPrimitiveType mode, ref int count, GLDrawElementsType type, void** indices, int drawcount, int* basevertex)
		{
			fixed (int* pcount0 = &count)
			{
				MultiDrawElementsBaseVertexEXTNative(mode, pcount0, type, indices, drawcount, basevertex);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex<br/>GL_OES_draw_elements_base_vertex</remarks>
		public static void MultiDrawElementsBaseVertexEXT(GLPrimitiveType mode, int* count, GLDrawElementsType type, void** indices, int drawcount, Span<int> basevertex)
		{
			fixed (int* pbasevertex0 = basevertex)
			{
				MultiDrawElementsBaseVertexEXTNative(mode, count, type, indices, drawcount, pbasevertex0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex<br/>GL_OES_draw_elements_base_vertex</remarks>
		public static void MultiDrawElementsBaseVertexEXT(GLPrimitiveType mode, int* count, GLDrawElementsType type, void** indices, int drawcount, ref int basevertex)
		{
			fixed (int* pbasevertex0 = &basevertex)
			{
				MultiDrawElementsBaseVertexEXTNative(mode, count, type, indices, drawcount, pbasevertex0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex<br/>GL_OES_draw_elements_base_vertex</remarks>
		public static void MultiDrawElementsBaseVertexEXT(GLPrimitiveType mode, Span<int> count, GLDrawElementsType type, void** indices, int drawcount, Span<int> basevertex)
		{
			fixed (int* pcount0 = count)
			{
				fixed (int* pbasevertex1 = basevertex)
				{
					MultiDrawElementsBaseVertexEXTNative(mode, pcount0, type, indices, drawcount, pbasevertex1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_elements_base_vertex<br/>GL_OES_draw_elements_base_vertex</remarks>
		public static void MultiDrawElementsBaseVertexEXT(GLPrimitiveType mode, ref int count, GLDrawElementsType type, void** indices, int drawcount, ref int basevertex)
		{
			fixed (int* pcount0 = &count)
			{
				fixed (int* pbasevertex1 = &basevertex)
				{
					MultiDrawElementsBaseVertexEXTNative(mode, pcount0, type, indices, drawcount, pbasevertex1);
				}
			}
		}

	}
}
