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
	public static unsafe partial class GLARBTextureStorageMultisample
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexStorage2DMultisampleNative(GLTextureTarget target, int samples, GLSizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, byte, void>)funcTable[0])(target, samples, internalformat, width, height, *((byte*)(&fixedsamplelocations)));
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, byte, void>)funcTable[0])(target, samples, internalformat, width, height, *((byte*)(&fixedsamplelocations)));
			#endif
		}

		/// <summary>
		/// Specify storage for a two-dimensional multisample texture
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_texture_storage_multisample</remarks>
		public static void TexStorage2DMultisample(GLTextureTarget target, int samples, GLSizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
		{
			TexStorage2DMultisampleNative(target, samples, internalformat, width, height, fixedsamplelocations);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexStorage3DMultisampleNative(GLTextureTarget target, int samples, GLSizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, int, byte, void>)funcTable[1])(target, samples, internalformat, width, height, depth, *((byte*)(&fixedsamplelocations)));
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, int, byte, void>)funcTable[1])(target, samples, internalformat, width, height, depth, *((byte*)(&fixedsamplelocations)));
			#endif
		}

		/// <summary>
		/// Specify storage for a two-dimensional multisample array texture
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_texture_storage_multisample</remarks>
		public static void TexStorage3DMultisample(GLTextureTarget target, int samples, GLSizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			TexStorage3DMultisampleNative(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

	}
}
