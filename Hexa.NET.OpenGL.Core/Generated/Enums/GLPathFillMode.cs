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

namespace Hexa.NET.OpenGL
{
	public enum GLPathFillMode : uint
	{
		/// <summary>
		/// Specifies a logical inversion operation.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_NV_blend_equation_advanced</remarks>
		Invert = unchecked((uint)0x150A),

		/// <summary>
		/// Specifies the fill mode for paths (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_path_rendering</remarks>
		Nv = unchecked((uint)0x9080),

		/// <summary>
		/// Increments the count for certain operations in NV path rendering.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_path_rendering</remarks>
		CountUpNv = unchecked((uint)0x9088),

		/// <summary>
		/// Decrements the count for certain operations in NV path rendering.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_path_rendering</remarks>
		CountDownNv = unchecked((uint)0x9089),
	}
}
