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
	public static unsafe partial class GLOESEGLImage
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EGLImageTargetRenderbufferStorageOESNative(GLEnum target, GLeglImageOES image)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLeglImageOES, void>)funcTable[0])(target, image);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLeglImageOES, void>)funcTable[0])(target, image);
			#endif
		}

		public static void EGLImageTargetRenderbufferStorageOES(GLEnum target, GLeglImageOES image)
		{
			EGLImageTargetRenderbufferStorageOESNative(target, image);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EGLImageTargetTexture2DOESNative(GLEnum target, GLeglImageOES image)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLeglImageOES, void>)funcTable[1])(target, image);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLeglImageOES, void>)funcTable[1])(target, image);
			#endif
		}

		public static void EGLImageTargetTexture2DOES(GLEnum target, GLeglImageOES image)
		{
			EGLImageTargetTexture2DOESNative(target, image);
		}

	}
}
