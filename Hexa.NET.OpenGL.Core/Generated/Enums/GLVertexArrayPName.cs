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
	public enum GLVertexArrayPName : uint
	{
		/// <summary>
		/// Specifies the relative offset for vertex attributes.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_binding</remarks>
		AttribRelativeOffset = unchecked((uint)0x82D5),

		/// <summary>
		/// Specifies whether the vertex attribute array is enabled.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		AttribArrayEnabled = unchecked((uint)0x8622),

		/// <summary>
		/// Specifies the size of the vertex attribute array.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		AttribArraySize = unchecked((uint)0x8623),

		/// <summary>
		/// Specifies the stride of the vertex attribute array.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		AttribArrayStride = unchecked((uint)0x8624),

		/// <summary>
		/// Specifies the type of the vertex attribute array.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		AttribArrayType = unchecked((uint)0x8625),

		/// <summary>
		/// Specifies long vertex attribute array functionality.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6</remarks>
		AttribArrayLong = unchecked((uint)0x874E),

		/// <summary>
		/// Specifies whether vertex attributes are normalized.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		AttribArrayNormalized = unchecked((uint)0x886A),

		/// <summary>
		/// Specifies if the vertex attribute array contains integer data.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		AttribArrayInteger = unchecked((uint)0x88FD),

		/// <summary>
		/// Specifies the divisor for a vertex attribute array.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X</remarks>
		AttribArrayDivisor = unchecked((uint)0x88FE),
	}
}
