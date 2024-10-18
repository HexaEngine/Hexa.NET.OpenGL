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
	public enum GLPathColorFormat : uint
	{
		/// <summary>
		/// Indicates no value or null.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_NV_register_combiners<br/>GL_KHR_context_flush_control</remarks>
		None = unchecked((uint)0),

		/// <summary>
		/// Specifies the alpha component for transparency.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_AMD_interleaved_elements</remarks>
		Alpha = unchecked((uint)0x1906),

		/// <summary>
		/// Specifies a color in RGB format.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Rgb = unchecked((uint)0x1907),

		/// <summary>
		/// Specifies a color in RGBA format.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Rgba = unchecked((uint)0x1908),

		/// <summary>
		/// Specifies a grayscale color value.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Luminance = unchecked((uint)0x1909),

		/// <summary>
		/// Specifies a grayscale value with an alpha channel.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		LuminanceAlpha = unchecked((uint)0x190A),

		/// <summary>
		/// Specifies intensity format.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Intensity = unchecked((uint)0x8049),
	}
}
