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
	public static unsafe partial class GLNVConservativeRasterDilate
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ConservativeRasterParameterfNVNative(GLEnum pname, float value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, float, void>)funcTable[0])(pname, value);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, float, void>)funcTable[0])(pname, value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_conservative_raster_dilate</remarks>
		public static void ConservativeRasterParameterfNV(GLEnum pname, float value)
		{
			ConservativeRasterParameterfNVNative(pname, value);
		}

	}
}
