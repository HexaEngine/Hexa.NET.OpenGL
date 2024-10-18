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

namespace Hexa.NET.OpenGLES.EXT
{
	public static unsafe partial class GLEXTRasterMultisample
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void RasterSamplesEXTNative(uint samples, bool fixedsamplelocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, byte, void>)funcTable[0])(samples, *((byte*)(&fixedsamplelocations)));
			#else
			((delegate* unmanaged[Cdecl]<uint, byte, void>)funcTable[0])(samples, *((byte*)(&fixedsamplelocations)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_raster_multisample<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public static void RasterSamplesEXT(uint samples, bool fixedsamplelocations)
		{
			RasterSamplesEXTNative(samples, fixedsamplelocations);
		}

	}
}
