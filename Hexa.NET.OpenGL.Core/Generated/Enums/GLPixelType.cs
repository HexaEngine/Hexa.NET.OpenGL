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
	public enum GLPixelType : uint
	{
		/// <summary>
		/// Specifies a signed byte data type.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		Byte = unchecked((uint)0x1400),

		/// <summary>
		/// Specifies an unsigned byte data type.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnsignedByte = unchecked((uint)0x1401),

		/// <summary>
		/// Specifies a signed short data type.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		Short = unchecked((uint)0x1402),

		/// <summary>
		/// Specifies an unsigned short data type.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnsignedShort = unchecked((uint)0x1403),

		/// <summary>
		/// Specifies a signed integer data type.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		Int = unchecked((uint)0x1404),

		/// <summary>
		/// Specifies an unsigned integer data type.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnsignedInt = unchecked((uint)0x1405),

		/// <summary>
		/// Specifies a floating-point data type.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_shader</remarks>
		Float = unchecked((uint)0x1406),

		/// <summary>
		/// Specifies a half-precision floating-point data type.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_half_float_vertex</remarks>
		HalfFloat = unchecked((uint)0x140B),

		/// <summary>
		/// Specifies a half-precision data type for ARB extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_half_float_pixel</remarks>
		HalfFloatArb = unchecked((uint)0x140B),

		/// <summary>
		/// Specifies a half-precision data type for NV extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		HalfFloatNv = unchecked((uint)0x140B),

		/// <summary>
		/// Specifies a half-precision data type for Apple extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_float_pixels</remarks>
		HalfApple = unchecked((uint)0x140B),

		/// <summary>
		/// Specifies a bitmap data type.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		Bitmap = unchecked((uint)0x1A00),

		/// <summary>
		/// Specifies a format with 3 bits for red, 3 bits for green, and 2 bits for blue.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedByte332 = unchecked((uint)0x8032),

		/// <summary>
		/// Specifies a format with 3 bits for red, 3 bits for green, and 2 bits for blue for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_packed_pixels</remarks>
		UnsignedByte332Ext = unchecked((uint)0x8032),

		/// <summary>
		/// Specifies a format with 4 bits for each color channel and 4 bits for alpha.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedShort4444 = unchecked((uint)0x8033),

		/// <summary>
		/// Specifies a format with 4 bits for each color channel and 4 bits for alpha for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_packed_pixels</remarks>
		UnsignedShort4444Ext = unchecked((uint)0x8033),

		/// <summary>
		/// Specifies a format with 5 bits for red, 5 bits for green, 5 bits for blue, and 1 bit for alpha.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedShort5551 = unchecked((uint)0x8034),

		/// <summary>
		/// Specifies a format with 5 bits for red, 5 bits for green, 5 bits for blue, and 1 bit for alpha for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_packed_pixels</remarks>
		UnsignedShort5551Ext = unchecked((uint)0x8034),

		/// <summary>
		/// Specifies a format with 8 bits for each color channel and 8 bits for alpha.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedInt8888 = unchecked((uint)0x8035),

		/// <summary>
		/// Specifies a format with 8 bits for each color channel and 8 bits for alpha for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_packed_pixels</remarks>
		UnsignedInt8888Ext = unchecked((uint)0x8035),

		/// <summary>
		/// Specifies a format with 10 bits for each color channel and 2 bits for alpha.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedInt1010102 = unchecked((uint)0x8036),

		/// <summary>
		/// Specifies a format with 10 bits for each color channel and 2 bits for alpha for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_packed_pixels</remarks>
		UnsignedInt1010102Ext = unchecked((uint)0x8036),

		/// <summary>
		/// Specifies unsigned byte format in 2-3-3 reversed order.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedByte233Rev = unchecked((uint)0x8362),

		/// <summary>
		/// Specifies unsigned byte format in 2-3-3 reversed order (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		UnsignedByte233RevExt = unchecked((uint)0x8362),

		/// <summary>
		/// Specifies unsigned short format in 5-6-5 format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedShort565 = unchecked((uint)0x8363),

		/// <summary>
		/// Specifies unsigned short format in 5-6-5 format (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		UnsignedShort565Ext = unchecked((uint)0x8363),

		/// <summary>
		/// Specifies unsigned short format in 5-6-5 format reversed.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedShort565Rev = unchecked((uint)0x8364),

		/// <summary>
		/// Specifies unsigned short format in 5-6-5 reversed (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		UnsignedShort565RevExt = unchecked((uint)0x8364),

		/// <summary>
		/// Specifies unsigned short format in 4-4-4-4 reversed.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedShort4444Rev = unchecked((uint)0x8365),

		/// <summary>
		/// Specifies unsigned short format in 4-4-4-4 reversed (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		UnsignedShort4444RevExt = unchecked((uint)0x8365),

		/// <summary>
		/// Specifies unsigned short format in 4-4-4-4 reversed for images.
		/// </summary>
		/// <remarks></remarks>
		UnsignedShort4444RevImg = unchecked((uint)0x8365),

		/// <summary>
		/// Specifies unsigned short format in 1-5-5-5 reversed.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedShort1555Rev = unchecked((uint)0x8366),

		/// <summary>
		/// Specifies unsigned short format in 1-5-5-5 reversed (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		UnsignedShort1555RevExt = unchecked((uint)0x8366),

		/// <summary>
		/// Specifies unsigned int format in 8-8-8-8 reversed.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnsignedInt8888Rev = unchecked((uint)0x8367),

		/// <summary>
		/// Specifies unsigned int format in 8-8-8-8 reversed (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		UnsignedInt8888RevExt = unchecked((uint)0x8367),

		/// <summary>
		/// Specifies unsigned int format in 2-10-10-10 reversed.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_type_2_10_10_10_rev</remarks>
		UnsignedInt2101010Rev = unchecked((uint)0x8368),

		/// <summary>
		/// Specifies unsigned int format in 2-10-10-10 reversed (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		UnsignedInt2101010RevExt = unchecked((uint)0x8368),

		/// <summary>
		/// Specifies a 24-bit depth and 8-bit stencil format.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		UnsignedInt248 = unchecked((uint)0x84FA),

		/// <summary>
		/// Specifies a 24-bit depth and 8-bit stencil format (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_packed_depth_stencil</remarks>
		UnsignedInt248Ext = unchecked((uint)0x84FA),

		/// <summary>
		/// Specifies a 24-bit depth and 8-bit stencil format (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_packed_depth_stencil</remarks>
		UnsignedInt248Nv = unchecked((uint)0x84FA),

		/// <summary>
		/// Specifies a 24-bit depth and 8-bit stencil format (OES extension).
		/// </summary>
		/// <remarks></remarks>
		UnsignedInt248Oes = unchecked((uint)0x84FA),

		/// <summary>
		/// Specifies the unsigned integer format 10F_11F_11F reversed.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_type_10f_11f_11f_rev</remarks>
		UnsignedInt10F11F11FRev = unchecked((uint)0x8C3B),

		/// <summary>
		/// Specifies the unsigned integer format 10F_11F_11F reversed in the APPLE extension.
		/// </summary>
		/// <remarks></remarks>
		UnsignedInt10F11F11FRevApple = unchecked((uint)0x8C3B),

		/// <summary>
		/// Specifies the unsigned integer format 10F_11F_11F reversed (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_packed_float</remarks>
		UnsignedInt10F11F11FRevExt = unchecked((uint)0x8C3B),

		/// <summary>
		/// Specifies the unsigned integer format 5_9_9_9 reversed.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnsignedInt5999Rev = unchecked((uint)0x8C3E),

		/// <summary>
		/// Specifies the unsigned integer format 5_9_9_9 reversed in the APPLE extension.
		/// </summary>
		/// <remarks></remarks>
		UnsignedInt5999RevApple = unchecked((uint)0x8C3E),

		/// <summary>
		/// Specifies the unsigned integer format 5_9_9_9 reversed (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture_shared_exponent</remarks>
		UnsignedInt5999RevExt = unchecked((uint)0x8C3E),

		/// <summary>
		/// Specifies a format with 32-bit floating point and 24-bit unsigned integer depth.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_depth_buffer_float</remarks>
		Float32UnsignedInt248Rev = unchecked((uint)0x8DAD),

		/// <summary>
		/// Specifies a format with 32-bit floating point and 24-bit unsigned integer depth (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_depth_buffer_float</remarks>
		Float32UnsignedInt248RevNv = unchecked((uint)0x8DAD),
	}
}
