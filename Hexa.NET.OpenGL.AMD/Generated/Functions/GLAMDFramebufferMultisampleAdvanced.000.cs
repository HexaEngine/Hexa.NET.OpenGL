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

namespace Hexa.NET.OpenGL.AMD
{
	public unsafe partial class GLAMDFramebufferMultisampleAdvanced
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void NamedRenderbufferStorageMultisampleAdvancedAMDNative(uint renderbuffer, int samples, int storageSamples, GLInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, GLInternalFormat, int, int, void>)funcTable[0])(renderbuffer, samples, storageSamples, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, GLInternalFormat, int, int, void>)funcTable[0])(renderbuffer, samples, storageSamples, internalformat, width, height);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_framebuffer_multisample_advanced</remarks>
		public void NamedRenderbufferStorageMultisampleAdvancedAMD(uint renderbuffer, int samples, int storageSamples, GLInternalFormat internalformat, int width, int height)
		{
			NamedRenderbufferStorageMultisampleAdvancedAMDNative(renderbuffer, samples, storageSamples, internalformat, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void RenderbufferStorageMultisampleAdvancedAMDNative(GLRenderbufferTarget target, int samples, int storageSamples, GLInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, int, int, GLInternalFormat, int, int, void>)funcTable[1])(target, samples, storageSamples, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLRenderbufferTarget, int, int, GLInternalFormat, int, int, void>)funcTable[1])(target, samples, storageSamples, internalformat, width, height);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_framebuffer_multisample_advanced</remarks>
		public void RenderbufferStorageMultisampleAdvancedAMD(GLRenderbufferTarget target, int samples, int storageSamples, GLInternalFormat internalformat, int width, int height)
		{
			RenderbufferStorageMultisampleAdvancedAMDNative(target, samples, storageSamples, internalformat, width, height);
		}

	}
}
