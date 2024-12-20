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
	public unsafe partial class GLEXTEGLImageStorage
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void EGLImageTargetTexStorageEXTNative(GLEnum target, GLeglImageOES image, int* attribList)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLeglImageOES, int*, void>)funcTable[0])(target, image, attribList);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLeglImageOES, nint, void>)funcTable[0])(target, image, (nint)attribList);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_EGL_image_storage</remarks>
		public void EGLImageTargetTexStorageEXT(GLEnum target, GLeglImageOES image, int* attribList)
		{
			EGLImageTargetTexStorageEXTNative(target, image, attribList);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_EGL_image_storage</remarks>
		public void EGLImageTargetTexStorageEXT(GLEnum target, GLeglImageOES image, Span<int> attribList)
		{
			fixed (int* pattribList0 = attribList)
			{
				EGLImageTargetTexStorageEXTNative(target, image, pattribList0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_EGL_image_storage</remarks>
		public void EGLImageTargetTexStorageEXT(GLEnum target, GLeglImageOES image, ref int attribList)
		{
			fixed (int* pattribList0 = &attribList)
			{
				EGLImageTargetTexStorageEXTNative(target, image, pattribList0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void EGLImageTargetTextureStorageEXTNative(uint texture, GLeglImageOES image, int* attribList)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLeglImageOES, int*, void>)funcTable[1])(texture, image, attribList);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLeglImageOES, nint, void>)funcTable[1])(texture, image, (nint)attribList);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_EGL_image_storage</remarks>
		public void EGLImageTargetTextureStorageEXT(uint texture, GLeglImageOES image, int* attribList)
		{
			EGLImageTargetTextureStorageEXTNative(texture, image, attribList);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_EGL_image_storage</remarks>
		public void EGLImageTargetTextureStorageEXT(uint texture, GLeglImageOES image, Span<int> attribList)
		{
			fixed (int* pattribList0 = attribList)
			{
				EGLImageTargetTextureStorageEXTNative(texture, image, pattribList0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_EGL_image_storage</remarks>
		public void EGLImageTargetTextureStorageEXT(uint texture, GLeglImageOES image, ref int attribList)
		{
			fixed (int* pattribList0 = &attribList)
			{
				EGLImageTargetTextureStorageEXTNative(texture, image, pattribList0);
			}
		}

	}
}
