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

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVConservativeRaster
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SubpixelPrecisionBiasNVNative(uint xbits, uint ybits)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[0])(xbits, ybits);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[0])(xbits, ybits);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_conservative_raster</remarks>
		public void SubpixelPrecisionBiasNV(uint xbits, uint ybits)
		{
			SubpixelPrecisionBiasNVNative(xbits, ybits);
		}

	}
}
