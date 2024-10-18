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
	public enum GLTextureGenParameter : uint
	{
		/// <summary>
		/// Specifies the texture generation mode.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Mode = unchecked((uint)0x2500),

		/// <summary>
		/// Specifies the texture generation mode for OES extensions.
		/// </summary>
		/// <remarks></remarks>
		ModeOes = unchecked((uint)0x2500),

		/// <summary>
		/// Specifies the object plane for texture generation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		ObjectPlane = unchecked((uint)0x2501),

		/// <summary>
		/// Specifies the eye plane for texture coordinate generation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat<br/><br/>Used by Extensions:<br/>GL_NV_fog_distance</remarks>
		EyePlane = unchecked((uint)0x2502),

		/// <summary>
		/// Specifies the eye point for calculations (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		EyePointSgis = unchecked((uint)0x81F4),

		/// <summary>
		/// Specifies the object point for calculations (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		ObjectPointSgis = unchecked((uint)0x81F5),

		/// <summary>
		/// Specifies the eye line for calculations (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		EyeLineSgis = unchecked((uint)0x81F6),

		/// <summary>
		/// Specifies the object line for calculations (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		ObjectLineSgis = unchecked((uint)0x81F7),
	}
}
