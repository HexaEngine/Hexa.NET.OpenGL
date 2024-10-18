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
	public enum GLReadBufferMode : uint
	{
		/// <summary>
		/// Indicates no value or null.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_NV_register_combiners<br/>GL_KHR_context_flush_control</remarks>
		None = unchecked((uint)0),

		/// <summary>
		/// No value, specific to OES extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_framebuffer_object</remarks>
		NoneOes = unchecked((uint)0),

		/// <summary>
		/// Front left color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		FrontLeft = unchecked((uint)0x0400),

		/// <summary>
		/// Front right color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		FrontRight = unchecked((uint)0x0401),

		/// <summary>
		/// Back left color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		BackLeft = unchecked((uint)0x0402),

		/// <summary>
		/// Back right color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		BackRight = unchecked((uint)0x0403),

		/// <summary>
		/// Front color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Front = unchecked((uint)0x0404),

		/// <summary>
		/// Back color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_ES3_1_compatibility</remarks>
		Back = unchecked((uint)0x0405),

		/// <summary>
		/// Left color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Left = unchecked((uint)0x0406),

		/// <summary>
		/// Right color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Right = unchecked((uint)0x0407),

		/// <summary>
		/// Auxiliary color buffer 0.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Aux0 = unchecked((uint)0x0409),

		/// <summary>
		/// Auxiliary color buffer 1.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Aux1 = unchecked((uint)0x040A),

		/// <summary>
		/// Auxiliary color buffer 2.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Aux2 = unchecked((uint)0x040B),

		/// <summary>
		/// Auxiliary color buffer 3.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Aux3 = unchecked((uint)0x040C),

		/// <summary>
		/// Specifies the first color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment0 = unchecked((uint)0x8CE0),

		/// <summary>
		/// Specifies the second color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment1 = unchecked((uint)0x8CE1),

		/// <summary>
		/// Specifies the third color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment2 = unchecked((uint)0x8CE2),

		/// <summary>
		/// Specifies the fourth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment3 = unchecked((uint)0x8CE3),

		/// <summary>
		/// Specifies the fifth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment4 = unchecked((uint)0x8CE4),

		/// <summary>
		/// Specifies the sixth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment5 = unchecked((uint)0x8CE5),

		/// <summary>
		/// Specifies the seventh color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment6 = unchecked((uint)0x8CE6),

		/// <summary>
		/// Specifies the eighth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment7 = unchecked((uint)0x8CE7),

		/// <summary>
		/// Specifies the ninth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment8 = unchecked((uint)0x8CE8),

		/// <summary>
		/// Specifies the tenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment9 = unchecked((uint)0x8CE9),

		/// <summary>
		/// Specifies the eleventh color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment10 = unchecked((uint)0x8CEA),

		/// <summary>
		/// Specifies the twelfth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment11 = unchecked((uint)0x8CEB),

		/// <summary>
		/// Specifies the thirteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment12 = unchecked((uint)0x8CEC),

		/// <summary>
		/// Specifies the fourteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment13 = unchecked((uint)0x8CED),

		/// <summary>
		/// Specifies the fifteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment14 = unchecked((uint)0x8CEE),

		/// <summary>
		/// Specifies the sixteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment15 = unchecked((uint)0x8CEF),
	}
}
