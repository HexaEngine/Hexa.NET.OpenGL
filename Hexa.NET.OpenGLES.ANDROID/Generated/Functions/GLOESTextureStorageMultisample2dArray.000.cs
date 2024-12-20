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

namespace Hexa.NET.OpenGLES.ANDROID
{
	public unsafe partial class GLOESTextureStorageMultisample2dArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexStorage3DMultisampleOESNative(GLTextureTarget target, int samples, GLSizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, int, byte, void>)funcTable[0])(target, samples, internalformat, width, height, depth, *((byte*)(&fixedsamplelocations)));
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, int, byte, void>)funcTable[0])(target, samples, internalformat, width, height, depth, *((byte*)(&fixedsamplelocations)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_texture_storage_multisample_2d_array</remarks>
		public void TexStorage3DMultisampleOES(GLTextureTarget target, int samples, GLSizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			TexStorage3DMultisampleOESNative(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

	}
}
