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
	public enum GLInvalidateFramebufferAttachment : uint
	{
		/// <summary>
		/// Specifies the color buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		Color = unchecked((uint)0x1800),

		/// <summary>
		/// Specifies the depth buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		Depth = unchecked((uint)0x1801),

		/// <summary>
		/// Specifies the stencil buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		Stencil = unchecked((uint)0x1802),

		/// <summary>
		/// Specifies a depth-stencil attachment for framebuffers.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		DepthStencilAttachment = unchecked((uint)0x821A),

		/// <summary>
		/// Specifies the first color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment0 = unchecked((uint)0x8CE0),

		/// <summary>
		/// Specifies the first color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment0Ext = unchecked((uint)0x8CE0),

		/// <summary>
		/// Specifies the first color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment0Nv = unchecked((uint)0x8CE0),

		/// <summary>
		/// Specifies the first color attachment (OES extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment0Oes = unchecked((uint)0x8CE0),

		/// <summary>
		/// Specifies the second color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment1 = unchecked((uint)0x8CE1),

		/// <summary>
		/// Specifies the second color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment1Ext = unchecked((uint)0x8CE1),

		/// <summary>
		/// Specifies the second color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment1Nv = unchecked((uint)0x8CE1),

		/// <summary>
		/// Specifies the third color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment2 = unchecked((uint)0x8CE2),

		/// <summary>
		/// Specifies the third color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment2Ext = unchecked((uint)0x8CE2),

		/// <summary>
		/// Specifies the third color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment2Nv = unchecked((uint)0x8CE2),

		/// <summary>
		/// Specifies the fourth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment3 = unchecked((uint)0x8CE3),

		/// <summary>
		/// Specifies the fourth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment3Ext = unchecked((uint)0x8CE3),

		/// <summary>
		/// Specifies the fourth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment3Nv = unchecked((uint)0x8CE3),

		/// <summary>
		/// Specifies the fifth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment4 = unchecked((uint)0x8CE4),

		/// <summary>
		/// Specifies the fifth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment4Ext = unchecked((uint)0x8CE4),

		/// <summary>
		/// Specifies the fifth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment4Nv = unchecked((uint)0x8CE4),

		/// <summary>
		/// Specifies the sixth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment5 = unchecked((uint)0x8CE5),

		/// <summary>
		/// Specifies the sixth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment5Ext = unchecked((uint)0x8CE5),

		/// <summary>
		/// Specifies the sixth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment5Nv = unchecked((uint)0x8CE5),

		/// <summary>
		/// Specifies the seventh color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment6 = unchecked((uint)0x8CE6),

		/// <summary>
		/// Specifies the seventh color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment6Ext = unchecked((uint)0x8CE6),

		/// <summary>
		/// Specifies the seventh color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment6Nv = unchecked((uint)0x8CE6),

		/// <summary>
		/// Specifies the eighth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment7 = unchecked((uint)0x8CE7),

		/// <summary>
		/// Specifies the eighth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment7Ext = unchecked((uint)0x8CE7),

		/// <summary>
		/// Specifies the eighth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment7Nv = unchecked((uint)0x8CE7),

		/// <summary>
		/// Specifies the ninth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment8 = unchecked((uint)0x8CE8),

		/// <summary>
		/// Specifies the ninth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment8Ext = unchecked((uint)0x8CE8),

		/// <summary>
		/// Specifies the ninth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment8Nv = unchecked((uint)0x8CE8),

		/// <summary>
		/// Specifies the tenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment9 = unchecked((uint)0x8CE9),

		/// <summary>
		/// Specifies the tenth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment9Ext = unchecked((uint)0x8CE9),

		/// <summary>
		/// Specifies the tenth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment9Nv = unchecked((uint)0x8CE9),

		/// <summary>
		/// Specifies the eleventh color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment10 = unchecked((uint)0x8CEA),

		/// <summary>
		/// Specifies the eleventh color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment10Ext = unchecked((uint)0x8CEA),

		/// <summary>
		/// Specifies the eleventh color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment10Nv = unchecked((uint)0x8CEA),

		/// <summary>
		/// Specifies the twelfth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment11 = unchecked((uint)0x8CEB),

		/// <summary>
		/// Specifies the twelfth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment11Ext = unchecked((uint)0x8CEB),

		/// <summary>
		/// Specifies the twelfth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment11Nv = unchecked((uint)0x8CEB),

		/// <summary>
		/// Specifies the thirteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment12 = unchecked((uint)0x8CEC),

		/// <summary>
		/// Specifies the thirteenth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment12Ext = unchecked((uint)0x8CEC),

		/// <summary>
		/// Specifies the thirteenth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment12Nv = unchecked((uint)0x8CEC),

		/// <summary>
		/// Specifies the fourteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment13 = unchecked((uint)0x8CED),

		/// <summary>
		/// Specifies the fourteenth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment13Ext = unchecked((uint)0x8CED),

		/// <summary>
		/// Specifies the fourteenth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment13Nv = unchecked((uint)0x8CED),

		/// <summary>
		/// Specifies the fifteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment14 = unchecked((uint)0x8CEE),

		/// <summary>
		/// Specifies the fifteenth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment14Ext = unchecked((uint)0x8CEE),

		/// <summary>
		/// Specifies the fifteenth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment14Nv = unchecked((uint)0x8CEE),

		/// <summary>
		/// Specifies the sixteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorAttachment15 = unchecked((uint)0x8CEF),

		/// <summary>
		/// Specifies the sixteenth color attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ColorAttachment15Ext = unchecked((uint)0x8CEF),

		/// <summary>
		/// Specifies the sixteenth color attachment (NV extension).
		/// </summary>
		/// <remarks></remarks>
		ColorAttachment15Nv = unchecked((uint)0x8CEF),

		/// <summary>
		/// Specifies the seventeenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment16 = unchecked((uint)0x8CF0),

		/// <summary>
		/// Specifies the eighteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment17 = unchecked((uint)0x8CF1),

		/// <summary>
		/// Specifies the nineteenth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment18 = unchecked((uint)0x8CF2),

		/// <summary>
		/// Specifies the twentieth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment19 = unchecked((uint)0x8CF3),

		/// <summary>
		/// Specifies the twenty-first color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment20 = unchecked((uint)0x8CF4),

		/// <summary>
		/// Specifies the twenty-second color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment21 = unchecked((uint)0x8CF5),

		/// <summary>
		/// Specifies the twenty-third color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment22 = unchecked((uint)0x8CF6),

		/// <summary>
		/// Specifies the twenty-fourth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment23 = unchecked((uint)0x8CF7),

		/// <summary>
		/// Specifies the twenty-fifth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment24 = unchecked((uint)0x8CF8),

		/// <summary>
		/// Specifies the twenty-sixth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment25 = unchecked((uint)0x8CF9),

		/// <summary>
		/// Specifies the twenty-seventh color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment26 = unchecked((uint)0x8CFA),

		/// <summary>
		/// Specifies the twenty-eighth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment27 = unchecked((uint)0x8CFB),

		/// <summary>
		/// Specifies the twenty-ninth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment28 = unchecked((uint)0x8CFC),

		/// <summary>
		/// Specifies the thirtieth color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment29 = unchecked((uint)0x8CFD),

		/// <summary>
		/// Specifies the thirty-first color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment30 = unchecked((uint)0x8CFE),

		/// <summary>
		/// Specifies the thirty-second color attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		ColorAttachment31 = unchecked((uint)0x8CFF),

		/// <summary>
		/// Specifies the depth attachment.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		DepthAttachment = unchecked((uint)0x8D00),

		/// <summary>
		/// Specifies the depth attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		DepthAttachmentExt = unchecked((uint)0x8D00),

		/// <summary>
		/// Specifies the depth attachment (OES extension).
		/// </summary>
		/// <remarks></remarks>
		DepthAttachmentOes = unchecked((uint)0x8D00),

		/// <summary>
		/// Specifies the stencil attachment (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		StencilAttachmentExt = unchecked((uint)0x8D20),

		/// <summary>
		/// Specifies the stencil attachment (OES extension).
		/// </summary>
		/// <remarks></remarks>
		StencilAttachmentOes = unchecked((uint)0x8D20),
	}
}
