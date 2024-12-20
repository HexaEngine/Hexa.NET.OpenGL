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
using System.Numerics;

namespace Hexa.NET.OpenGLES
{
	/// <summary>
	/// Texture memory layouts for INTEL_map_texture<br/>
	/// </summary>
	public enum GLMapTextureFormatINTEL : uint
	{
		/// <summary>
		/// Default memory layout (Intel).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_INTEL_map_texture</remarks>
		LayoutDefaultIntel = unchecked((uint)0),

		/// <summary>
		/// Linear memory layout (Intel).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_INTEL_map_texture</remarks>
		LayoutLinearIntel = unchecked((uint)1),

		/// <summary>
		/// Linear CPU cached memory layout (Intel).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_INTEL_map_texture</remarks>
		LayoutLinearCpuCachedIntel = unchecked((uint)2),
	}
}
