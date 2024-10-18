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
	public enum GLDebugType : uint
	{
		/// <summary>
		/// Specifies that the implementation can ignore this parameter.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		DontCare = unchecked((uint)0x1100),

		/// <summary>
		/// Specifies an error type debug message.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		Error = unchecked((uint)0x824C),

		/// <summary>
		/// Specifies a deprecated behavior type debug message.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		DeprecatedBehavior = unchecked((uint)0x824D),

		/// <summary>
		/// Specifies an undefined behavior type debug message.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		UndefinedBehavior = unchecked((uint)0x824E),

		/// <summary>
		/// Specifies a portability type debug message.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		Portability = unchecked((uint)0x824F),

		/// <summary>
		/// Specifies a performance type debug message.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		Performance = unchecked((uint)0x8250),

		/// <summary>
		/// Specifies another type of debug message.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		Other = unchecked((uint)0x8251),

		/// <summary>
		/// Specifies a debug type marker.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		Marker = unchecked((uint)0x8268),

		/// <summary>
		/// Specifies the start of a debug push group.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		PushGroup = unchecked((uint)0x8269),

		/// <summary>
		/// Specifies the end of a debug push group.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		PopGroup = unchecked((uint)0x826A),
	}
}
