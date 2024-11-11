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
	public unsafe partial class GLEXTMultisampledRenderToTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferTexture2DMultisampleEXTNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level, int samples)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, int, void>)funcTable[0])(target, attachment, textarget, texture, level, samples);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, int, void>)funcTable[0])(target, attachment, textarget, texture, level, samples);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_multisampled_render_to_texture</remarks>
		public void FramebufferTexture2DMultisampleEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level, int samples)
		{
			FramebufferTexture2DMultisampleEXTNative(target, attachment, textarget, texture, level, samples);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void RenderbufferStorageMultisampleEXTNative(GLRenderbufferTarget target, int samples, GLInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, int, GLInternalFormat, int, int, void>)funcTable[1])(target, samples, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, int, GLInternalFormat, int, int, void>)funcTable[1])(target, samples, internalformat, width, height);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_multisample<br/>GL_EXT_multisampled_render_to_texture</remarks>
		public void RenderbufferStorageMultisampleEXT(GLRenderbufferTarget target, int samples, GLInternalFormat internalformat, int width, int height)
		{
			RenderbufferStorageMultisampleEXTNative(target, samples, internalformat, width, height);
		}

	}
}
