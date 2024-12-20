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
	public unsafe partial class GLNVConservativeRasterPreSnapTriangles
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ConservativeRasterParameteriNVNative(GLEnum pname, int param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[0])(pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[0])(pname, param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_conservative_raster_pre_snap_triangles</remarks>
		public void ConservativeRasterParameteriNV(GLEnum pname, int param)
		{
			ConservativeRasterParameteriNVNative(pname, param);
		}

	}
}
