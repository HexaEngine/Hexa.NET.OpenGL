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
	/// <summary>
	/// Should be shared with WGLGLX, but aren't since the FORWARD_COMPATIBLE and DEBUG values are swapped vs. WGLGLX.<br/>
	/// </summary>
	public enum GLContextFlagMask : uint
	{
		/// <summary>
		/// Forward compatible context flag.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ForwardCompatibleBit = unchecked((uint)0x00000001),

		/// <summary>
		/// Debug context flag.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		DebugBit = unchecked((uint)0x00000002),

		/// <summary>
		/// Debug context flag (KHR).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_debug</remarks>
		DebugBitKhr = unchecked((uint)0x00000002),

		/// <summary>
		/// Robust access context flag.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		RobustAccessBit = unchecked((uint)0x00000004),

		/// <summary>
		/// Robust access context flag (ARB).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		RobustAccessBitArb = unchecked((uint)0x00000004),

		/// <summary>
		/// No error context flag.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		NoErrorBit = unchecked((uint)0x00000008),

		/// <summary>
		/// No error context flag (KHR).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_no_error</remarks>
		NoErrorBitKhr = unchecked((uint)0x00000008),

		/// <summary>
		/// Protected content context flag (EXT).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_protected_textures</remarks>
		ProtectedContentBitExt = unchecked((uint)0x00000010),
	}
}
