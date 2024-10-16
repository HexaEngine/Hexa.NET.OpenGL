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
	public static unsafe partial class GLOESTexture3D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CompressedTexImage3DOESNative(GLTextureTarget target, int level, GLInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLInternalFormat, int, int, int, int, int, void*, void>)funcTable[0])(target, level, internalformat, width, height, depth, border, imageSize, data);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLInternalFormat, int, int, int, int, int, nint, void>)funcTable[0])(target, level, internalformat, width, height, depth, border, imageSize, (nint)data);
			#endif
		}

		public static void CompressedTexImage3DOES(GLTextureTarget target, int level, GLInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data)
		{
			CompressedTexImage3DOESNative(target, level, internalformat, width, height, depth, border, imageSize, data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CompressedTexSubImage3DOESNative(GLTextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, GLInternalFormat format, int imageSize, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, GLInternalFormat, int, void*, void>)funcTable[1])(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, GLInternalFormat, int, nint, void>)funcTable[1])(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, (nint)data);
			#endif
		}

		public static void CompressedTexSubImage3DOES(GLTextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, GLInternalFormat format, int imageSize, void* data)
		{
			CompressedTexSubImage3DOESNative(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CopyTexSubImage3DOESNative(GLEnum target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, int, int, int, int, int, int, int, void>)funcTable[2])(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, int, int, int, int, int, int, int, void>)funcTable[2])(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			#endif
		}

		public static void CopyTexSubImage3DOES(GLEnum target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			CopyTexSubImage3DOESNative(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FramebufferTexture3DOESNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level, int zoffset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, int, void>)funcTable[3])(target, attachment, textarget, texture, level, zoffset);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, GLTextureTarget, uint, int, int, void>)funcTable[3])(target, attachment, textarget, texture, level, zoffset);
			#endif
		}

		public static void FramebufferTexture3DOES(GLFramebufferTarget target, GLFramebufferAttachment attachment, GLTextureTarget textarget, uint texture, int level, int zoffset)
		{
			FramebufferTexture3DOESNative(target, attachment, textarget, texture, level, zoffset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexImage3DOESNative(GLTextureTarget target, int level, GLInternalFormat internalformat, int width, int height, int depth, int border, GLPixelFormat format, GLPixelType type, void* pixels)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLInternalFormat, int, int, int, int, GLPixelFormat, GLPixelType, void*, void>)funcTable[4])(target, level, internalformat, width, height, depth, border, format, type, pixels);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLInternalFormat, int, int, int, int, GLPixelFormat, GLPixelType, nint, void>)funcTable[4])(target, level, internalformat, width, height, depth, border, format, type, (nint)pixels);
			#endif
		}

		public static void TexImage3DOES(GLTextureTarget target, int level, GLInternalFormat internalformat, int width, int height, int depth, int border, GLPixelFormat format, GLPixelType type, void* pixels)
		{
			TexImage3DOESNative(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexSubImage3DOESNative(GLTextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, GLPixelFormat format, GLPixelType type, void* pixels)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, GLPixelFormat, GLPixelType, void*, void>)funcTable[5])(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, GLPixelFormat, GLPixelType, nint, void>)funcTable[5])(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (nint)pixels);
			#endif
		}

		public static void TexSubImage3DOES(GLTextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, GLPixelFormat format, GLPixelType type, void* pixels)
		{
			TexSubImage3DOESNative(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

	}
}