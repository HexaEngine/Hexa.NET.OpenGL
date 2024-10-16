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
	public enum GLTransformFeedbackPName : uint
	{
		/// <summary>
		/// Specifies the start of the transform feedback buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		BufferStart = unchecked((uint)0x8C84),

		/// <summary>
		/// Specifies the size of the transform feedback buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		BufferSize = unchecked((uint)0x8C85),

		/// <summary>
		/// Specifies the binding of the transform feedback buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		BufferBinding = unchecked((uint)0x8C8F),

		/// <summary>
		/// Indicates that transform feedback is paused.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6</remarks>
		Paused = unchecked((uint)0x8E23),

		/// <summary>
		/// Indicates that transform feedback is active.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6</remarks>
		Active = unchecked((uint)0x8E24),
	}
}
