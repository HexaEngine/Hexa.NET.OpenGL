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
	public enum GLVertexBufferObjectUsage : uint
	{
		/// <summary>
		/// Specifies a hint that data will be set frequently and used for drawing.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		StreamDraw = unchecked((uint)0x88E0),

		/// <summary>
		/// Specifies a hint that data will be read frequently.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		StreamRead = unchecked((uint)0x88E1),

		/// <summary>
		/// Specifies a hint that data will be copied frequently.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		StreamCopy = unchecked((uint)0x88E2),

		/// <summary>
		/// Specifies a hint that data will be set once and used for drawing.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		StaticDraw = unchecked((uint)0x88E4),

		/// <summary>
		/// Specifies a hint that data will be read once.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		StaticRead = unchecked((uint)0x88E5),

		/// <summary>
		/// Specifies a hint that data will be copied once.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		StaticCopy = unchecked((uint)0x88E6),

		/// <summary>
		/// Specifies a hint that data will be changed frequently and used for drawing.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		DynamicDraw = unchecked((uint)0x88E8),

		/// <summary>
		/// Specifies a hint that data will be read frequently.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		DynamicRead = unchecked((uint)0x88E9),

		/// <summary>
		/// Specifies a hint that data will be copied frequently.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		DynamicCopy = unchecked((uint)0x88EA),
	}
}
