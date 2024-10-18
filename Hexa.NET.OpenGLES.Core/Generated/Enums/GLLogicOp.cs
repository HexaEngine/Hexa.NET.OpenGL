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
	public enum GLLogicOp : uint
	{
		/// <summary>
		/// Specifies a clear operation for buffers.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Clear = unchecked((uint)0x1500),

		/// <summary>
		/// Specifies a logical AND operation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		And = unchecked((uint)0x1501),

		/// <summary>
		/// Specifies a logical AND operation with reverse.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		AndReverse = unchecked((uint)0x1502),

		/// <summary>
		/// Specifies a copy operation for buffers.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Copy = unchecked((uint)0x1503),

		/// <summary>
		/// Specifies a logical AND operation followed by inversion.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		AndInverted = unchecked((uint)0x1504),

		/// <summary>
		/// Specifies a no-operation, effectively does nothing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Noop = unchecked((uint)0x1505),

		/// <summary>
		/// Specifies a logical XOR operation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Xor = unchecked((uint)0x1506),

		/// <summary>
		/// Specifies a logical OR operation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Or = unchecked((uint)0x1507),

		/// <summary>
		/// Specifies a logical NOR operation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Nor = unchecked((uint)0x1508),

		/// <summary>
		/// Specifies a logical equivalence operation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Equiv = unchecked((uint)0x1509),

		/// <summary>
		/// Specifies a logical inversion operation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_NV_blend_equation_advanced</remarks>
		Invert = unchecked((uint)0x150A),

		/// <summary>
		/// Specifies a logical OR operation with reverse.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		OrReverse = unchecked((uint)0x150B),

		/// <summary>
		/// Specifies a copy operation that inverts the source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		CopyInverted = unchecked((uint)0x150C),

		/// <summary>
		/// Specifies a logical OR operation followed by inversion.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		OrInverted = unchecked((uint)0x150D),

		/// <summary>
		/// Specifies a logical NAND operation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Nand = unchecked((uint)0x150E),

		/// <summary>
		/// Specifies a set operation for buffers.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Set = unchecked((uint)0x150F),
	}
}
