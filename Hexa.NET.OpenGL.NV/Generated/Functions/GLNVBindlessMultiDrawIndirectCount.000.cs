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
	public static unsafe partial class GLNVBindlessMultiDrawIndirectCount
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawArraysIndirectBindlessCountNVNative(GLPrimitiveType mode, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, void*, int, int, int, int, void>)funcTable[0])(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, nint, int, int, int, int, void>)funcTable[0])(mode, (nint)indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
			#endif
		}

		public static void MultiDrawArraysIndirectBindlessCountNV(GLPrimitiveType mode, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			MultiDrawArraysIndirectBindlessCountNVNative(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
		}

		public static void MultiDrawArraysIndirectBindlessCountNV(GLPrimitiveType mode, nint indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			MultiDrawArraysIndirectBindlessCountNVNative(mode, (void*)indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
		}

		public static void MultiDrawArraysIndirectBindlessCountNV<TIndirect>(GLPrimitiveType mode, Span<TIndirect> indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount) where TIndirect : unmanaged
		{
			fixed (TIndirect* pindirect0 = indirect)
			{
				MultiDrawArraysIndirectBindlessCountNVNative(mode, pindirect0, drawCount, maxDrawCount, stride, vertexBufferCount);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawElementsIndirectBindlessCountNVNative(GLPrimitiveType mode, GLDrawElementsType type, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, GLDrawElementsType, void*, int, int, int, int, void>)funcTable[1])(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, GLDrawElementsType, nint, int, int, int, int, void>)funcTable[1])(mode, type, (nint)indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
			#endif
		}

		public static void MultiDrawElementsIndirectBindlessCountNV(GLPrimitiveType mode, GLDrawElementsType type, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			MultiDrawElementsIndirectBindlessCountNVNative(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
		}

		public static void MultiDrawElementsIndirectBindlessCountNV(GLPrimitiveType mode, GLDrawElementsType type, nint indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount)
		{
			MultiDrawElementsIndirectBindlessCountNVNative(mode, type, (void*)indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
		}

		public static void MultiDrawElementsIndirectBindlessCountNV<TIndirect>(GLPrimitiveType mode, GLDrawElementsType type, Span<TIndirect> indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount) where TIndirect : unmanaged
		{
			fixed (TIndirect* pindirect0 = indirect)
			{
				MultiDrawElementsIndirectBindlessCountNVNative(mode, type, pindirect0, drawCount, maxDrawCount, stride, vertexBufferCount);
			}
		}

	}
}
