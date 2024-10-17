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
	public static unsafe partial class GLEXTMultiDrawIndirect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawArraysIndirectEXTNative(GLPrimitiveType mode, void* indirect, int drawcount, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, void*, int, int, void>)funcTable[0])(mode, indirect, drawcount, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, nint, int, int, void>)funcTable[0])(mode, (nint)indirect, drawcount, stride);
			#endif
		}

		public static void MultiDrawArraysIndirectEXT(GLPrimitiveType mode, void* indirect, int drawcount, int stride)
		{
			MultiDrawArraysIndirectEXTNative(mode, indirect, drawcount, stride);
		}

		public static void MultiDrawArraysIndirectEXT(GLPrimitiveType mode, nint indirect, int drawcount, int stride)
		{
			MultiDrawArraysIndirectEXTNative(mode, (void*)indirect, drawcount, stride);
		}

		public static void MultiDrawArraysIndirectEXT<TIndirect>(GLPrimitiveType mode, Span<TIndirect> indirect, int drawcount, int stride) where TIndirect : unmanaged
		{
			fixed (TIndirect* pindirect0 = indirect)
			{
				MultiDrawArraysIndirectEXTNative(mode, pindirect0, drawcount, stride);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawElementsIndirectEXTNative(GLPrimitiveType mode, GLDrawElementsType type, void* indirect, int drawcount, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, GLDrawElementsType, void*, int, int, void>)funcTable[1])(mode, type, indirect, drawcount, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, GLDrawElementsType, nint, int, int, void>)funcTable[1])(mode, type, (nint)indirect, drawcount, stride);
			#endif
		}

		public static void MultiDrawElementsIndirectEXT(GLPrimitiveType mode, GLDrawElementsType type, void* indirect, int drawcount, int stride)
		{
			MultiDrawElementsIndirectEXTNative(mode, type, indirect, drawcount, stride);
		}

		public static void MultiDrawElementsIndirectEXT(GLPrimitiveType mode, GLDrawElementsType type, nint indirect, int drawcount, int stride)
		{
			MultiDrawElementsIndirectEXTNative(mode, type, (void*)indirect, drawcount, stride);
		}

		public static void MultiDrawElementsIndirectEXT<TIndirect>(GLPrimitiveType mode, GLDrawElementsType type, Span<TIndirect> indirect, int drawcount, int stride) where TIndirect : unmanaged
		{
			fixed (TIndirect* pindirect0 = indirect)
			{
				MultiDrawElementsIndirectEXTNative(mode, type, pindirect0, drawcount, stride);
			}
		}

	}
}
