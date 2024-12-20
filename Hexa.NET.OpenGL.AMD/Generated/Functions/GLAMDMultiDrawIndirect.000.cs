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

namespace Hexa.NET.OpenGL.AMD
{
	public unsafe partial class GLAMDMultiDrawIndirect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiDrawArraysIndirectAMDNative(GLPrimitiveType mode, void* indirect, int primcount, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, void*, int, int, void>)funcTable[0])(mode, indirect, primcount, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, nint, int, int, void>)funcTable[0])(mode, (nint)indirect, primcount, stride);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_multi_draw_indirect</remarks>
		public void MultiDrawArraysIndirectAMD(GLPrimitiveType mode, void* indirect, int primcount, int stride)
		{
			MultiDrawArraysIndirectAMDNative(mode, indirect, primcount, stride);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_multi_draw_indirect</remarks>
		public void MultiDrawArraysIndirectAMD(GLPrimitiveType mode, nint indirect, int primcount, int stride)
		{
			MultiDrawArraysIndirectAMDNative(mode, (void*)indirect, primcount, stride);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_multi_draw_indirect</remarks>
		public void MultiDrawArraysIndirectAMD<TIndirect>(GLPrimitiveType mode, Span<TIndirect> indirect, int primcount, int stride) where TIndirect : unmanaged
		{
			fixed (TIndirect* pindirect0 = indirect)
			{
				MultiDrawArraysIndirectAMDNative(mode, pindirect0, primcount, stride);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiDrawElementsIndirectAMDNative(GLPrimitiveType mode, GLDrawElementsType type, void* indirect, int primcount, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, GLDrawElementsType, void*, int, int, void>)funcTable[1])(mode, type, indirect, primcount, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, GLDrawElementsType, nint, int, int, void>)funcTable[1])(mode, type, (nint)indirect, primcount, stride);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_multi_draw_indirect</remarks>
		public void MultiDrawElementsIndirectAMD(GLPrimitiveType mode, GLDrawElementsType type, void* indirect, int primcount, int stride)
		{
			MultiDrawElementsIndirectAMDNative(mode, type, indirect, primcount, stride);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_multi_draw_indirect</remarks>
		public void MultiDrawElementsIndirectAMD(GLPrimitiveType mode, GLDrawElementsType type, nint indirect, int primcount, int stride)
		{
			MultiDrawElementsIndirectAMDNative(mode, type, (void*)indirect, primcount, stride);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_multi_draw_indirect</remarks>
		public void MultiDrawElementsIndirectAMD<TIndirect>(GLPrimitiveType mode, GLDrawElementsType type, Span<TIndirect> indirect, int primcount, int stride) where TIndirect : unmanaged
		{
			fixed (TIndirect* pindirect0 = indirect)
			{
				MultiDrawElementsIndirectAMDNative(mode, type, pindirect0, primcount, stride);
			}
		}

	}
}
