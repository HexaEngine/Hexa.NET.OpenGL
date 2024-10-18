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
	public enum GLClipControlDepth : uint
	{
		/// <summary>
		/// Specifies the clip space depth range from -1 to 1.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_clip_control</remarks>
		NegativeOneToOne = unchecked((uint)0x935E),

		/// <summary>
		/// Specifies the clip space depth range from 0 to 1.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_clip_control</remarks>
		ZeroToOne = unchecked((uint)0x935F),
	}
}
