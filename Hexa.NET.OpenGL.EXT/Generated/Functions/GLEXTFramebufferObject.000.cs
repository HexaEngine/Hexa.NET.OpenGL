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

namespace Hexa.NET.OpenGL.EXT
{
	public static unsafe partial class GLEXTFramebufferObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindFramebufferEXTNative(GLFramebufferTarget target, uint framebuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, uint, void>)funcTable[0])(target, framebuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, uint, void>)funcTable[0])(target, framebuffer);
			#endif
		}

		public static void BindFramebufferEXT(GLFramebufferTarget target, uint framebuffer)
		{
			BindFramebufferEXTNative(target, framebuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindRenderbufferEXTNative(GLRenderbufferTarget target, uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, uint, void>)funcTable[1])(target, renderbuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, uint, void>)funcTable[1])(target, renderbuffer);
			#endif
		}

		public static void BindRenderbufferEXT(GLRenderbufferTarget target, uint renderbuffer)
		{
			BindRenderbufferEXTNative(target, renderbuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum CheckFramebufferStatusEXTNative(GLFramebufferTarget target)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLEnum>)funcTable[2])(target);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLEnum>)funcTable[2])(target);
			#endif
		}

		public static GLEnum CheckFramebufferStatusEXT(GLFramebufferTarget target)
		{
			GLEnum ret = CheckFramebufferStatusEXTNative(target);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteFramebuffersEXTNative(int n, uint* framebuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[3])(n, framebuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[3])(n, (nint)framebuffers);
			#endif
		}

		public static void DeleteFramebuffersEXT(int n, uint* framebuffers)
		{
			DeleteFramebuffersEXTNative(n, framebuffers);
		}

		public static void DeleteFramebuffersEX(uint framebuffer)
		{
			DeleteFramebuffersEXTNative(1, &framebuffer);
		}

		public static void DeleteFramebuffersEXT(int n, Span<uint> framebuffers)
		{
			fixed (uint* pframebuffers0 = framebuffers)
			{
				DeleteFramebuffersEXTNative(n, pframebuffers0);
			}
		}

		public static void DeleteFramebuffersEXT(int n, ref uint framebuffers)
		{
			fixed (uint* pframebuffers0 = &framebuffers)
			{
				DeleteFramebuffersEXTNative(n, pframebuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteRenderbuffersEXTNative(int n, uint* renderbuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[4])(n, renderbuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[4])(n, (nint)renderbuffers);
			#endif
		}

		public static void DeleteRenderbuffersEXT(int n, uint* renderbuffers)
		{
			DeleteRenderbuffersEXTNative(n, renderbuffers);
		}

		public static void DeleteRenderbuffersEX(uint renderbuffer)
		{
			DeleteRenderbuffersEXTNative(1, &renderbuffer);
		}

		public static void DeleteRenderbuffersEXT(int n, Span<uint> renderbuffers)
		{
			fixed (uint* prenderbuffers0 = renderbuffers)
			{
				DeleteRenderbuffersEXTNative(n, prenderbuffers0);
			}
		}

		public static void DeleteRenderbuffersEXT(int n, ref uint renderbuffers)
		{
			fixed (uint* prenderbuffers0 = &renderbuffers)
			{
				DeleteRenderbuffersEXTNative(n, prenderbuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FramebufferRenderbufferEXTNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLRenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLRenderbufferTarget, uint, void>)funcTable[5])(target, attachment, renderbuffertarget, renderbuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLRenderbufferTarget, uint, void>)funcTable[5])(target, attachment, renderbuffertarget, renderbuffer);
			#endif
		}

		public static void FramebufferRenderbufferEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLRenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			FramebufferRenderbufferEXTNative(target, attachment, renderbuffertarget, renderbuffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FramebufferTexture1DEXTNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[6])(target, attachment, textarget, texture, level);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[6])(target, attachment, textarget, texture, level);
			#endif
		}

		public static void FramebufferTexture1DEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			FramebufferTexture1DEXTNative(target, attachment, textarget, texture, level);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FramebufferTexture2DEXTNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[7])(target, attachment, textarget, texture, level);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, void>)funcTable[7])(target, attachment, textarget, texture, level);
			#endif
		}

		public static void FramebufferTexture2DEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level)
		{
			FramebufferTexture2DEXTNative(target, attachment, textarget, texture, level);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FramebufferTexture3DEXTNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level, int zoffset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, int, void>)funcTable[8])(target, attachment, textarget, texture, level, zoffset);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, int, void>)funcTable[8])(target, attachment, textarget, texture, level, zoffset);
			#endif
		}

		public static void FramebufferTexture3DEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level, int zoffset)
		{
			FramebufferTexture3DEXTNative(target, attachment, textarget, texture, level, zoffset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenFramebuffersEXTNative(int n, uint* framebuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[9])(n, framebuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[9])(n, (nint)framebuffers);
			#endif
		}

		public static void GenFramebuffersEXT(int n, uint* framebuffers)
		{
			GenFramebuffersEXTNative(n, framebuffers);
		}

		public static uint GenFramebuffersEX()
		{
			uint result;
			GenFramebuffersEXTNative(1, &result);
			return result;
		}

		public static void GenFramebuffersEXT(int n, Span<uint> framebuffers)
		{
			fixed (uint* pframebuffers0 = framebuffers)
			{
				GenFramebuffersEXTNative(n, pframebuffers0);
			}
		}

		public static void GenFramebuffersEXT(int n, ref uint framebuffers)
		{
			fixed (uint* pframebuffers0 = &framebuffers)
			{
				GenFramebuffersEXTNative(n, pframebuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenRenderbuffersEXTNative(int n, uint* renderbuffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[10])(n, renderbuffers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[10])(n, (nint)renderbuffers);
			#endif
		}

		public static void GenRenderbuffersEXT(int n, uint* renderbuffers)
		{
			GenRenderbuffersEXTNative(n, renderbuffers);
		}

		public static uint GenRenderbuffersEX()
		{
			uint result;
			GenRenderbuffersEXTNative(1, &result);
			return result;
		}

		public static void GenRenderbuffersEXT(int n, Span<uint> renderbuffers)
		{
			fixed (uint* prenderbuffers0 = renderbuffers)
			{
				GenRenderbuffersEXTNative(n, prenderbuffers0);
			}
		}

		public static void GenRenderbuffersEXT(int n, ref uint renderbuffers)
		{
			fixed (uint* prenderbuffers0 = &renderbuffers)
			{
				GenRenderbuffersEXTNative(n, prenderbuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenerateMipmapEXTNative(GLTextureTarget target)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, void>)funcTable[11])(target);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, void>)funcTable[11])(target);
			#endif
		}

		public static void GenerateMipmapEXT(GLTextureTarget target)
		{
			GenerateMipmapEXTNative(target);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetFramebufferAttachmentParameterivEXTNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLFramebufferAttachmentParameterName, int*, void>)funcTable[12])(target, attachment, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLFramebufferAttachmentParameterName, nint, void>)funcTable[12])(target, attachment, pname, (nint)@params);
			#endif
		}

		public static void GetFramebufferAttachmentParameterivEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, int* @params)
		{
			GetFramebufferAttachmentParameterivEXTNative(target, attachment, pname, @params);
		}

		public static void GetFramebufferAttachmentParameterivEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, out int @params)
		{
			int pparams;
			GetFramebufferAttachmentParameterivEXTNative(target, attachment, pname, &pparams);
			@params = pparams;
		}

		public static void GetFramebufferAttachmentParameterivEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLFramebufferAttachmentParameterName pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetFramebufferAttachmentParameterivEXTNative(target, attachment, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetRenderbufferParameterivEXTNative(GLRenderbufferTarget target, GLRenderbufferParameterName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLRenderbufferParameterName, int*, void>)funcTable[13])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLRenderbufferParameterName, nint, void>)funcTable[13])(target, pname, (nint)@params);
			#endif
		}

		public static void GetRenderbufferParameterivEXT(GLRenderbufferTarget target, GLRenderbufferParameterName pname, int* @params)
		{
			GetRenderbufferParameterivEXTNative(target, pname, @params);
		}

		public static void GetRenderbufferParameterivEXT(GLRenderbufferTarget target, GLRenderbufferParameterName pname, out int @params)
		{
			int pparams;
			GetRenderbufferParameterivEXTNative(target, pname, &pparams);
			@params = pparams;
		}

		public static void GetRenderbufferParameterivEXT(GLRenderbufferTarget target, GLRenderbufferParameterName pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetRenderbufferParameterivEXTNative(target, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsFramebufferEXTNative(uint framebuffer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[14])(framebuffer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[14])(framebuffer);
			#endif
		}

		public static bool IsFramebufferEXT(uint framebuffer)
		{
			byte ret = IsFramebufferEXTNative(framebuffer);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsRenderbufferEXTNative(uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[15])(renderbuffer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[15])(renderbuffer);
			#endif
		}

		public static bool IsRenderbufferEXT(uint renderbuffer)
		{
			byte ret = IsRenderbufferEXTNative(renderbuffer);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void RenderbufferStorageEXTNative(GLRenderbufferTarget target, GLInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLInternalFormat, int, int, void>)funcTable[16])(target, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, GLInternalFormat, int, int, void>)funcTable[16])(target, internalformat, width, height);
			#endif
		}

		public static void RenderbufferStorageEXT(GLRenderbufferTarget target, GLInternalFormat internalformat, int width, int height)
		{
			RenderbufferStorageEXTNative(target, internalformat, width, height);
		}

	}
}
