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
	public unsafe partial class GLEXTDrawBuffers
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DrawBuffersEXTNative(int n, GLEnum* bufs)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLEnum*, void>)funcTable[0])(n, bufs);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[0])(n, (nint)bufs);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers</remarks>
		public void DrawBuffersEXT(int n, GLEnum* bufs)
		{
			DrawBuffersEXTNative(n, bufs);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers</remarks>
		public void DrawBuffersEXT(int n, Span<GLEnum> bufs)
		{
			fixed (GLEnum* pbufs0 = bufs)
			{
				DrawBuffersEXTNative(n, pbufs0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers</remarks>
		public void DrawBuffersEXT(int n, ref GLEnum bufs)
		{
			fixed (GLEnum* pbufs0 = &bufs)
			{
				DrawBuffersEXTNative(n, pbufs0);
			}
		}

	}
}
