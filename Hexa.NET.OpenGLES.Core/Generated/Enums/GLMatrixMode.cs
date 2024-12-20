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
	public enum GLMatrixMode : uint
	{
		/// <summary>
		/// Specifies the modelview matrix stack.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Modelview = unchecked((uint)0x1700),

		/// <summary>
		/// Specifies the first modelview matrix for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_vertex_weighting</remarks>
		Modelview0Ext = unchecked((uint)0x1700),

		/// <summary>
		/// Specifies the projection matrix stack.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Projection = unchecked((uint)0x1701),

		/// <summary>
		/// Specifies the texture matrix stack.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Texture = unchecked((uint)0x1702),
	}
}
