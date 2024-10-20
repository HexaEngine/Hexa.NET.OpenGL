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
	public static unsafe partial class GLOESFramebufferObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindFramebufferOESNative(GLFramebufferTarget target, uint framebuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, uint, void>)funcTable[0])(target, framebuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, uint, void>)funcTable[0])(target, framebuffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void BindFramebufferOES(GLFramebufferTarget target, uint framebuffer)
		{
			BindFramebufferOESNative(target, framebuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindRenderbufferOESNative(GLRenderbufferTarget target, uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, uint, void>)funcTable[1])(target, renderbuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, uint, void>)funcTable[1])(target, renderbuffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void BindRenderbufferOES(GLRenderbufferTarget target, uint renderbuffer)
		{
			BindRenderbufferOESNative(target, renderbuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum CheckFramebufferStatusOESNative(GLFramebufferTarget target)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLEnum>)funcTable[2])(target);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLEnum>)funcTable[2])(target);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static GLEnum CheckFramebufferStatusOES(GLFramebufferTarget target)
		{
			GLEnum ret = CheckFramebufferStatusOESNative(target);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteFramebuffersOESNative(int n, uint* framebuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[3])(n, framebuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[3])(n, (nint)framebuffers);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void DeleteFramebuffersOES(int n, uint* framebuffers)
		{
			DeleteFramebuffersOESNative(n, framebuffers);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void DeleteFramebuffersOE(uint framebuffer)
		{
			DeleteFramebuffersOESNative(1, &framebuffer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void DeleteFramebuffersOES(int n, Span<uint> framebuffers)
		{
			fixed (uint* pframebuffers0 = framebuffers)
			{
				DeleteFramebuffersOESNative(n, pframebuffers0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void DeleteFramebuffersOES(int n, ref uint framebuffers)
		{
			fixed (uint* pframebuffers0 = &framebuffers)
			{
				DeleteFramebuffersOESNative(n, pframebuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteRenderbuffersOESNative(int n, uint* renderbuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[4])(n, renderbuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[4])(n, (nint)renderbuffers);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void DeleteRenderbuffersOES(int n, uint* renderbuffers)
		{
			DeleteRenderbuffersOESNative(n, renderbuffers);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void DeleteRenderbuffersOE(uint renderbuffer)
		{
			DeleteRenderbuffersOESNative(1, &renderbuffer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void DeleteRenderbuffersOES(int n, Span<uint> renderbuffers)
		{
			fixed (uint* prenderbuffers0 = renderbuffers)
			{
				DeleteRenderbuffersOESNative(n, prenderbuffers0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void DeleteRenderbuffersOES(int n, ref uint renderbuffers)
		{
			fixed (uint* prenderbuffers0 = &renderbuffers)
			{
				DeleteRenderbuffersOESNative(n, prenderbuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FramebufferRenderbufferOESNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLRenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLRenderbufferTarget, uint, void>)funcTable[5])(target, attachment, renderbuffertarget, renderbuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLRenderbufferTarget, uint, void>)funcTable[5])(target, attachment, renderbuffertarget, renderbuffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void FramebufferRenderbufferOES(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLRenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			FramebufferRenderbufferOESNative(target, attachment, renderbuffertarget, renderbuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FramebufferTexture2DOESNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[6])(target, attachment, textarget, texture, level);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[6])(target, attachment, textarget, texture, level);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void FramebufferTexture2DOES(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			FramebufferTexture2DOESNative(target, attachment, textarget, texture, level);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenFramebuffersOESNative(int n, uint* framebuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[7])(n, framebuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[7])(n, (nint)framebuffers);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GenFramebuffersOES(int n, uint* framebuffers)
		{
			GenFramebuffersOESNative(n, framebuffers);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static uint GenFramebuffersOE()
		{
			uint result;
			GenFramebuffersOESNative(1, &result);
			return result;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GenFramebuffersOES(int n, Span<uint> framebuffers)
		{
			fixed (uint* pframebuffers0 = framebuffers)
			{
				GenFramebuffersOESNative(n, pframebuffers0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GenFramebuffersOES(int n, ref uint framebuffers)
		{
			fixed (uint* pframebuffers0 = &framebuffers)
			{
				GenFramebuffersOESNative(n, pframebuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenRenderbuffersOESNative(int n, uint* renderbuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[8])(n, renderbuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[8])(n, (nint)renderbuffers);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GenRenderbuffersOES(int n, uint* renderbuffers)
		{
			GenRenderbuffersOESNative(n, renderbuffers);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static uint GenRenderbuffersOE()
		{
			uint result;
			GenRenderbuffersOESNative(1, &result);
			return result;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GenRenderbuffersOES(int n, Span<uint> renderbuffers)
		{
			fixed (uint* prenderbuffers0 = renderbuffers)
			{
				GenRenderbuffersOESNative(n, prenderbuffers0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GenRenderbuffersOES(int n, ref uint renderbuffers)
		{
			fixed (uint* prenderbuffers0 = &renderbuffers)
			{
				GenRenderbuffersOESNative(n, prenderbuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenerateMipmapOESNative(GLTextureTarget target)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, void>)funcTable[9])(target);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, void>)funcTable[9])(target);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GenerateMipmapOES(GLTextureTarget target)
		{
			GenerateMipmapOESNative(target);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetFramebufferAttachmentParameterivOESNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLFramebufferAttachmentParameterName, int*, void>)funcTable[10])(target, attachment, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLFramebufferAttachmentParameterName, nint, void>)funcTable[10])(target, attachment, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GetFramebufferAttachmentParameterivOES(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, int* @params)
		{
			GetFramebufferAttachmentParameterivOESNative(target, attachment, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GetFramebufferAttachmentParameterivOES(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetFramebufferAttachmentParameterivOESNative(target, attachment, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GetFramebufferAttachmentParameterivOES(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetFramebufferAttachmentParameterivOESNative(target, attachment, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetRenderbufferParameterivOESNative(GLRenderbufferTarget target, GLRenderbufferParameterName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLRenderbufferParameterName, int*, void>)funcTable[11])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLRenderbufferParameterName, nint, void>)funcTable[11])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GetRenderbufferParameterivOES(GLRenderbufferTarget target, GLRenderbufferParameterName pname, int* @params)
		{
			GetRenderbufferParameterivOESNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GetRenderbufferParameterivOES(GLRenderbufferTarget target, GLRenderbufferParameterName pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetRenderbufferParameterivOESNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void GetRenderbufferParameterivOES(GLRenderbufferTarget target, GLRenderbufferParameterName pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetRenderbufferParameterivOESNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsFramebufferOESNative(uint framebuffer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[12])(framebuffer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[12])(framebuffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static bool IsFramebufferOES(uint framebuffer)
		{
			byte ret = IsFramebufferOESNative(framebuffer);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsRenderbufferOESNative(uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[13])(renderbuffer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[13])(renderbuffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static bool IsRenderbufferOES(uint renderbuffer)
		{
			byte ret = IsRenderbufferOESNative(renderbuffer);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void RenderbufferStorageOESNative(GLRenderbufferTarget target, GLInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLInternalFormat, int, int, void>)funcTable[14])(target, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLInternalFormat, int, int, void>)funcTable[14])(target, internalformat, width, height);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		public static void RenderbufferStorageOES(GLRenderbufferTarget target, GLInternalFormat internalformat, int width, int height)
		{
			RenderbufferStorageOESNative(target, internalformat, width, height);
		}

	}
}
