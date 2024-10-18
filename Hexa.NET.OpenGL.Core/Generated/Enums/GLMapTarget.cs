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
	public enum GLMapTarget : uint
	{
		/// <summary>
		/// Specifies a one-dimensional color map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1Color4 = unchecked((uint)0x0D90),

		/// <summary>
		/// Specifies a one-dimensional index map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1Index = unchecked((uint)0x0D91),

		/// <summary>
		/// Specifies a one-dimensional normal map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1Normal = unchecked((uint)0x0D92),

		/// <summary>
		/// Specifies the first texture coordinate in a one-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1TextureCoord1 = unchecked((uint)0x0D93),

		/// <summary>
		/// Specifies the second texture coordinate in a one-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1TextureCoord2 = unchecked((uint)0x0D94),

		/// <summary>
		/// Specifies the third texture coordinate in a one-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1TextureCoord3 = unchecked((uint)0x0D95),

		/// <summary>
		/// Specifies the fourth texture coordinate in a one-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1TextureCoord4 = unchecked((uint)0x0D96),

		/// <summary>
		/// Specifies a three-dimensional vertex map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1Vertex3 = unchecked((uint)0x0D97),

		/// <summary>
		/// Specifies a four-dimensional vertex map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map1Vertex4 = unchecked((uint)0x0D98),

		/// <summary>
		/// Specifies a two-dimensional color map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2Color4 = unchecked((uint)0x0DB0),

		/// <summary>
		/// Specifies a two-dimensional index map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2Index = unchecked((uint)0x0DB1),

		/// <summary>
		/// Specifies a two-dimensional normal map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2Normal = unchecked((uint)0x0DB2),

		/// <summary>
		/// Specifies the first texture coordinate in a two-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2TextureCoord1 = unchecked((uint)0x0DB3),

		/// <summary>
		/// Specifies the second texture coordinate in a two-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2TextureCoord2 = unchecked((uint)0x0DB4),

		/// <summary>
		/// Specifies the third texture coordinate in a two-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2TextureCoord3 = unchecked((uint)0x0DB5),

		/// <summary>
		/// Specifies the fourth texture coordinate in a two-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2TextureCoord4 = unchecked((uint)0x0DB6),

		/// <summary>
		/// Specifies a three-dimensional vertex map for two-dimensional evaluation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2Vertex3 = unchecked((uint)0x0DB7),

		/// <summary>
		/// Specifies a four-dimensional vertex map for two-dimensional evaluation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Map2Vertex4 = unchecked((uint)0x0DB8),

		/// <summary>
		/// Specifies geometry deformation (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		GeometryDeformationSgix = unchecked((uint)0x8194),

		/// <summary>
		/// Specifies texture deformation (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		TextureDeformationSgix = unchecked((uint)0x8195),
	}
}
