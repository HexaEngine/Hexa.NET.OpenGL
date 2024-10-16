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

namespace Hexa.NET.OpenGL.NV
{
	public static unsafe partial class GLNVTextureMultisample
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexImage2DMultisampleCoverageNVNative(GLTextureTarget target, int coverageSamples, int colorSamples, GLInternalFormat internalFormat, int width, int height, byte fixedSampleLocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, GLInternalFormat, int, int, byte, void>)funcTable[0])(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, GLInternalFormat, int, int, byte, void>)funcTable[0])(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			#endif
		}

		public static void TexImage2DMultisampleCoverageNV(GLTextureTarget target, int coverageSamples, int colorSamples, GLInternalFormat internalFormat, int width, int height, byte fixedSampleLocations)
		{
			TexImage2DMultisampleCoverageNVNative(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexImage3DMultisampleCoverageNVNative(GLTextureTarget target, int coverageSamples, int colorSamples, GLInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, GLInternalFormat, int, int, int, byte, void>)funcTable[1])(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, GLInternalFormat, int, int, int, byte, void>)funcTable[1])(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			#endif
		}

		public static void TexImage3DMultisampleCoverageNV(GLTextureTarget target, int coverageSamples, int colorSamples, GLInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations)
		{
			TexImage3DMultisampleCoverageNVNative(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureImage2DMultisampleCoverageNVNative(uint texture, GLTextureTarget target, int coverageSamples, int colorSamples, GLInternalFormat internalFormat, int width, int height, byte fixedSampleLocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, int, int, GLInternalFormat, int, int, byte, void>)funcTable[2])(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, int, int, GLInternalFormat, int, int, byte, void>)funcTable[2])(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			#endif
		}

		public static void TextureImage2DMultisampleCoverageNV(uint texture, GLTextureTarget target, int coverageSamples, int colorSamples, GLInternalFormat internalFormat, int width, int height, byte fixedSampleLocations)
		{
			TextureImage2DMultisampleCoverageNVNative(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureImage2DMultisampleNVNative(uint texture, GLTextureTarget target, int samples, GLInternalFormat internalFormat, int width, int height, byte fixedSampleLocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, int, GLInternalFormat, int, int, byte, void>)funcTable[3])(texture, target, samples, internalFormat, width, height, fixedSampleLocations);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, int, GLInternalFormat, int, int, byte, void>)funcTable[3])(texture, target, samples, internalFormat, width, height, fixedSampleLocations);
			#endif
		}

		public static void TextureImage2DMultisampleNV(uint texture, GLTextureTarget target, int samples, GLInternalFormat internalFormat, int width, int height, byte fixedSampleLocations)
		{
			TextureImage2DMultisampleNVNative(texture, target, samples, internalFormat, width, height, fixedSampleLocations);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureImage3DMultisampleCoverageNVNative(uint texture, GLTextureTarget target, int coverageSamples, int colorSamples, GLInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, int, int, GLInternalFormat, int, int, int, byte, void>)funcTable[4])(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, int, int, GLInternalFormat, int, int, int, byte, void>)funcTable[4])(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			#endif
		}

		public static void TextureImage3DMultisampleCoverageNV(uint texture, GLTextureTarget target, int coverageSamples, int colorSamples, GLInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations)
		{
			TextureImage3DMultisampleCoverageNVNative(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureImage3DMultisampleNVNative(uint texture, GLTextureTarget target, int samples, GLInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, int, GLInternalFormat, int, int, int, byte, void>)funcTable[5])(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, int, GLInternalFormat, int, int, int, byte, void>)funcTable[5])(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);
			#endif
		}

		public static void TextureImage3DMultisampleNV(uint texture, GLTextureTarget target, int samples, GLInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations)
		{
			TextureImage3DMultisampleNVNative(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);
		}

	}
}
