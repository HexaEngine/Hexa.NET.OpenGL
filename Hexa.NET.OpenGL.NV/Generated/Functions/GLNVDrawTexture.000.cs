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
	public unsafe partial class GLNVDrawTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DrawTextureNVNative(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, float, float, float, float, float, float, float, float, float, void>)funcTable[0])(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, float, float, float, float, float, float, float, float, float, void>)funcTable[0])(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_draw_texture</remarks>
		public void DrawTextureNV(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1)
		{
			DrawTextureNVNative(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
		}

	}
}
