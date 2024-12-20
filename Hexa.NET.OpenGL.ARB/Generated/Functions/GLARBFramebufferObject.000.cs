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

namespace Hexa.NET.OpenGL.ARB
{
	public unsafe partial class GLARBFramebufferObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindFramebufferNative(GLFramebufferTarget target, uint framebuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, uint, void>)funcTable[0])(target, framebuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, uint, void>)funcTable[0])(target, framebuffer);
			#endif
		}

		/// <summary>
		/// Bind a framebuffer to a framebuffer target
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void BindFramebuffer(GLFramebufferTarget target, uint framebuffer)
		{
			BindFramebufferNative(target, framebuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindRenderbufferNative(GLRenderbufferTarget target, uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, uint, void>)funcTable[1])(target, renderbuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, uint, void>)funcTable[1])(target, renderbuffer);
			#endif
		}

		/// <summary>
		/// Bind a renderbuffer to a renderbuffer target
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void BindRenderbuffer(GLRenderbufferTarget target, uint renderbuffer)
		{
			BindRenderbufferNative(target, renderbuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlitFramebufferNative(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, GLClearBufferMask mask, GLBlitFramebufferFilter filter)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, int, int, GLClearBufferMask, GLBlitFramebufferFilter, void>)funcTable[2])(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, int, int, GLClearBufferMask, GLBlitFramebufferFilter, void>)funcTable[2])(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			#endif
		}

		/// <summary>
		/// Copy a block of pixels from one framebuffer object to another
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, GLClearBufferMask mask, GLBlitFramebufferFilter filter)
		{
			BlitFramebufferNative(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal GLEnum CheckFramebufferStatusNative(GLFramebufferTarget target)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLEnum>)funcTable[3])(target);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLEnum>)funcTable[3])(target);
			#endif
		}

		/// <summary>
		/// Check the completeness status of a framebuffer
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public GLEnum CheckFramebufferStatus(GLFramebufferTarget target)
		{
			GLEnum ret = CheckFramebufferStatusNative(target);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DeleteFramebuffersNative(int n, uint* framebuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[4])(n, framebuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[4])(n, (nint)framebuffers);
			#endif
		}

		/// <summary>
		/// Delete framebuffer objects
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void DeleteFramebuffers(int n, uint* framebuffers)
		{
			DeleteFramebuffersNative(n, framebuffers);
		}

		/// <summary>
		/// Delete framebuffer objects
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void DeleteFramebuffer(uint framebuffer)
		{
			DeleteFramebuffersNative(1, &framebuffer);
		}

		/// <summary>
		/// Delete framebuffer objects
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void DeleteFramebuffers(int n, Span<uint> framebuffers)
		{
			fixed (uint* pframebuffers0 = framebuffers)
			{
				DeleteFramebuffersNative(n, pframebuffers0);
			}
		}

		/// <summary>
		/// Delete framebuffer objects
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void DeleteFramebuffers(int n, ref uint framebuffers)
		{
			fixed (uint* pframebuffers0 = &framebuffers)
			{
				DeleteFramebuffersNative(n, pframebuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DeleteRenderbuffersNative(int n, uint* renderbuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[5])(n, renderbuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[5])(n, (nint)renderbuffers);
			#endif
		}

		/// <summary>
		/// Delete renderbuffer objects
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void DeleteRenderbuffers(int n, uint* renderbuffers)
		{
			DeleteRenderbuffersNative(n, renderbuffers);
		}

		/// <summary>
		/// Delete renderbuffer objects
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void DeleteRenderbuffer(uint renderbuffer)
		{
			DeleteRenderbuffersNative(1, &renderbuffer);
		}

		/// <summary>
		/// Delete renderbuffer objects
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void DeleteRenderbuffers(int n, Span<uint> renderbuffers)
		{
			fixed (uint* prenderbuffers0 = renderbuffers)
			{
				DeleteRenderbuffersNative(n, prenderbuffers0);
			}
		}

		/// <summary>
		/// Delete renderbuffer objects
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void DeleteRenderbuffers(int n, ref uint renderbuffers)
		{
			fixed (uint* prenderbuffers0 = &renderbuffers)
			{
				DeleteRenderbuffersNative(n, prenderbuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferRenderbufferNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLRenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLRenderbufferTarget, uint, void>)funcTable[6])(target, attachment, renderbuffertarget, renderbuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLRenderbufferTarget, uint, void>)funcTable[6])(target, attachment, renderbuffertarget, renderbuffer);
			#endif
		}

		/// <summary>
		/// Attach a renderbuffer as a logical buffer of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void FramebufferRenderbuffer(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLRenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			FramebufferRenderbufferNative(target, attachment, renderbuffertarget, renderbuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferTexture1DNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[7])(target, attachment, textarget, texture, level);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[7])(target, attachment, textarget, texture, level);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void FramebufferTexture1D(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			FramebufferTexture1DNative(target, attachment, textarget, texture, level);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferTexture2DNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[8])(target, attachment, textarget, texture, level);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[8])(target, attachment, textarget, texture, level);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void FramebufferTexture2D(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			FramebufferTexture2DNative(target, attachment, textarget, texture, level);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferTexture3DNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level, int zoffset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, int, void>)funcTable[9])(target, attachment, textarget, texture, level, zoffset);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, int, void>)funcTable[9])(target, attachment, textarget, texture, level, zoffset);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void FramebufferTexture3D(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level, int zoffset)
		{
			FramebufferTexture3DNative(target, attachment, textarget, texture, level, zoffset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferTextureLayerNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, uint texture, int level, int layer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, uint, int, int, void>)funcTable[10])(target, attachment, texture, level, layer);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, uint, int, int, void>)funcTable[10])(target, attachment, texture, level, layer);
			#endif
		}

		/// <summary>
		/// Attach a single layer of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void FramebufferTextureLayer(GLFramebufferTarget target, GLFramebufferAttachment attachment, uint texture, int level, int layer)
		{
			FramebufferTextureLayerNative(target, attachment, texture, level, layer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GenFramebuffersNative(int n, uint* framebuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[11])(n, framebuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[11])(n, (nint)framebuffers);
			#endif
		}

		/// <summary>
		/// Generate framebuffer object names
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GenFramebuffers(int n, uint* framebuffers)
		{
			GenFramebuffersNative(n, framebuffers);
		}

		/// <summary>
		/// Generate framebuffer object names
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public uint GenFramebuffer()
		{
			uint result;
			GenFramebuffersNative(1, &result);
			return result;
		}

		/// <summary>
		/// Generate framebuffer object names
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GenFramebuffers(int n, Span<uint> framebuffers)
		{
			fixed (uint* pframebuffers0 = framebuffers)
			{
				GenFramebuffersNative(n, pframebuffers0);
			}
		}

		/// <summary>
		/// Generate framebuffer object names
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GenFramebuffers(int n, ref uint framebuffers)
		{
			fixed (uint* pframebuffers0 = &framebuffers)
			{
				GenFramebuffersNative(n, pframebuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GenRenderbuffersNative(int n, uint* renderbuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[12])(n, renderbuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[12])(n, (nint)renderbuffers);
			#endif
		}

		/// <summary>
		/// Generate renderbuffer object names
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GenRenderbuffers(int n, uint* renderbuffers)
		{
			GenRenderbuffersNative(n, renderbuffers);
		}

		/// <summary>
		/// Generate renderbuffer object names
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public uint GenRenderbuffer()
		{
			uint result;
			GenRenderbuffersNative(1, &result);
			return result;
		}

		/// <summary>
		/// Generate renderbuffer object names
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GenRenderbuffers(int n, Span<uint> renderbuffers)
		{
			fixed (uint* prenderbuffers0 = renderbuffers)
			{
				GenRenderbuffersNative(n, prenderbuffers0);
			}
		}

		/// <summary>
		/// Generate renderbuffer object names
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GenRenderbuffers(int n, ref uint renderbuffers)
		{
			fixed (uint* prenderbuffers0 = &renderbuffers)
			{
				GenRenderbuffersNative(n, prenderbuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GenerateMipmapNative(GLTextureTarget target)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, void>)funcTable[13])(target);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, void>)funcTable[13])(target);
			#endif
		}

		/// <summary>
		/// Generate mipmaps for a specified texture object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GenerateMipmap(GLTextureTarget target)
		{
			GenerateMipmapNative(target);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetFramebufferAttachmentParameterivNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLFramebufferAttachmentParameterName, int*, void>)funcTable[14])(target, attachment, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLFramebufferAttachmentParameterName, nint, void>)funcTable[14])(target, attachment, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// Retrieve information about attachments of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GetFramebufferAttachmentParameteriv(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, int* @params)
		{
			GetFramebufferAttachmentParameterivNative(target, attachment, pname, @params);
		}

		/// <summary>
		/// Retrieve information about attachments of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GetFramebufferAttachmentParameteriv(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, out int @params)
		{
			int pparam;
			GetFramebufferAttachmentParameterivNative(target, attachment, pname, &pparam);
			@params = pparam;
		}

		/// <summary>
		/// Retrieve information about attachments of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GetFramebufferAttachmentParameteriv(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetFramebufferAttachmentParameterivNative(target, attachment, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetRenderbufferParameterivNative(GLRenderbufferTarget target, GLRenderbufferParameterName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLRenderbufferParameterName, int*, void>)funcTable[15])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLRenderbufferParameterName, nint, void>)funcTable[15])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// Query a named parameter of a renderbuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GetRenderbufferParameteriv(GLRenderbufferTarget target, GLRenderbufferParameterName pname, int* @params)
		{
			GetRenderbufferParameterivNative(target, pname, @params);
		}

		/// <summary>
		/// Query a named parameter of a renderbuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GetRenderbufferParameteriv(GLRenderbufferTarget target, GLRenderbufferParameterName pname, out int @params)
		{
			int pparam;
			GetRenderbufferParameterivNative(target, pname, &pparam);
			@params = pparam;
		}

		/// <summary>
		/// Query a named parameter of a renderbuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void GetRenderbufferParameteriv(GLRenderbufferTarget target, GLRenderbufferParameterName pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetRenderbufferParameterivNative(target, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal byte IsFramebufferNative(uint framebuffer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[16])(framebuffer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[16])(framebuffer);
			#endif
		}

		/// <summary>
		/// Determine if a name corresponds to a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public bool IsFramebuffer(uint framebuffer)
		{
			byte ret = IsFramebufferNative(framebuffer);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal byte IsRenderbufferNative(uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[17])(renderbuffer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[17])(renderbuffer);
			#endif
		}

		/// <summary>
		/// Determine if a name corresponds to a renderbuffer object
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public bool IsRenderbuffer(uint renderbuffer)
		{
			byte ret = IsRenderbufferNative(renderbuffer);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void RenderbufferStorageNative(GLRenderbufferTarget target, GLInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLInternalFormat, int, int, void>)funcTable[18])(target, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLInternalFormat, int, int, void>)funcTable[18])(target, internalformat, width, height);
			#endif
		}

		/// <summary>
		/// Establish data storage, format and dimensions of a
		///     renderbuffer object's image
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void RenderbufferStorage(GLRenderbufferTarget target, GLInternalFormat internalformat, int width, int height)
		{
			RenderbufferStorageNative(target, internalformat, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void RenderbufferStorageMultisampleNative(GLRenderbufferTarget target, int samples, GLInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, int, GLInternalFormat, int, int, void>)funcTable[19])(target, samples, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, int, GLInternalFormat, int, int, void>)funcTable[19])(target, samples, internalformat, width, height);
			#endif
		}

		/// <summary>
		/// Establish data storage, format, dimensions and sample count of
		///     a renderbuffer object's image
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		public void RenderbufferStorageMultisample(GLRenderbufferTarget target, int samples, GLInternalFormat internalformat, int width, int height)
		{
			RenderbufferStorageMultisampleNative(target, samples, internalformat, width, height);
		}

	}
}
