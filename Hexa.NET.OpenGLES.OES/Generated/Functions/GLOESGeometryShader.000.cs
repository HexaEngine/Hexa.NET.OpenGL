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

namespace Hexa.NET.OpenGLES.OES
{
	public unsafe partial class GLOESGeometryShader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferTextureOESNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, uint texture, int level)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, uint, int, void>)funcTable[0])(target, attachment, texture, level);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, uint, int, void>)funcTable[0])(target, attachment, texture, level);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_geometry_shader</remarks>
		public void FramebufferTextureOES(GLFramebufferTarget target, GLFramebufferAttachment attachment, uint texture, int level)
		{
			FramebufferTextureOESNative(target, attachment, texture, level);
		}

	}
}
