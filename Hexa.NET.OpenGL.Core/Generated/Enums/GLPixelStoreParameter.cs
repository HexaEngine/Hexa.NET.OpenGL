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
	public enum GLPixelStoreParameter : uint
	{
		/// <summary>
		/// Enables or disables swapping of bytes when unpacking pixel data.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnpackSwapBytes = unchecked((uint)0x0CF0),

		/// <summary>
		/// Specifies whether the least significant bit is unpacked first.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnpackLsbFirst = unchecked((uint)0x0CF1),

		/// <summary>
		/// Specifies the number of pixels in a row when unpacking.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnpackRowLength = unchecked((uint)0x0CF2),

		/// <summary>
		/// Specifies the row length for unpacking, specific to EXT extensions.
		/// </summary>
		/// <remarks></remarks>
		UnpackRowLengthExt = unchecked((uint)0x0CF2),

		/// <summary>
		/// Specifies the number of rows to skip when unpacking.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnpackSkipRows = unchecked((uint)0x0CF3),

		/// <summary>
		/// Specifies the number of rows to skip, specific to EXT extensions.
		/// </summary>
		/// <remarks></remarks>
		UnpackSkipRowsExt = unchecked((uint)0x0CF3),

		/// <summary>
		/// Specifies the number of pixels to skip when unpacking.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnpackSkipPixels = unchecked((uint)0x0CF4),

		/// <summary>
		/// Specifies the number of pixels to skip, specific to EXT extensions.
		/// </summary>
		/// <remarks></remarks>
		UnpackSkipPixelsExt = unchecked((uint)0x0CF4),

		/// <summary>
		/// Specifies the alignment of pixel data in memory when unpacking.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		UnpackAlignment = unchecked((uint)0x0CF5),

		/// <summary>
		/// Enables or disables swapping of bytes when packing pixel data.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		PackSwapBytes = unchecked((uint)0x0D00),

		/// <summary>
		/// Specifies whether the least significant bit is packed first.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		PackLsbFirst = unchecked((uint)0x0D01),

		/// <summary>
		/// Specifies the number of pixels in a row when packing.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		PackRowLength = unchecked((uint)0x0D02),

		/// <summary>
		/// Specifies the row length for packing, specific to NV extensions.
		/// </summary>
		/// <remarks></remarks>
		PackRowLengthNv = unchecked((uint)0x0D02),

		/// <summary>
		/// Specifies the number of rows to skip when packing.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		PackSkipRows = unchecked((uint)0x0D03),

		/// <summary>
		/// Specifies the number of rows to skip, specific to NV extensions.
		/// </summary>
		/// <remarks></remarks>
		PackSkipRowsNv = unchecked((uint)0x0D03),

		/// <summary>
		/// Specifies the number of pixels to skip when packing.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		PackSkipPixels = unchecked((uint)0x0D04),

		/// <summary>
		/// Specifies the number of pixels to skip, specific to NV extensions.
		/// </summary>
		/// <remarks></remarks>
		PackSkipPixelsNv = unchecked((uint)0x0D04),

		/// <summary>
		/// Specifies the alignment of pixel data in memory when packing.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		PackAlignment = unchecked((uint)0x0D05),

		/// <summary>
		/// Specifies the number of images to skip when packing textures.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		PackSkipImages = unchecked((uint)0x806B),

		/// <summary>
		/// Specifies the number of images to skip when packing textures for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture3D</remarks>
		PackSkipImagesExt = unchecked((uint)0x806B),

		/// <summary>
		/// Specifies the height of images in the texture packing.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		PackImageHeight = unchecked((uint)0x806C),

		/// <summary>
		/// Specifies the height of images in the texture packing for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture3D</remarks>
		PackImageHeightExt = unchecked((uint)0x806C),

		/// <summary>
		/// Specifies the number of images to skip when unpacking textures.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnpackSkipImages = unchecked((uint)0x806D),

		/// <summary>
		/// Specifies the number of images to skip when unpacking textures for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture3D</remarks>
		UnpackSkipImagesExt = unchecked((uint)0x806D),

		/// <summary>
		/// Specifies the height of images in the texture unpacking.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.2 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		UnpackImageHeight = unchecked((uint)0x806E),

		/// <summary>
		/// Specifies the height of images in the texture unpacking for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture3D</remarks>
		UnpackImageHeightExt = unchecked((uint)0x806E),

		/// <summary>
		/// Specifies the number of volumes to skip when packing (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		PackSkipVolumesSgis = unchecked((uint)0x8130),

		/// <summary>
		/// Specifies the depth of the packed image (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		PackImageDepthSgis = unchecked((uint)0x8131),

		/// <summary>
		/// Specifies the number of volumes to skip when unpacking (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		UnpackSkipVolumesSgis = unchecked((uint)0x8132),

		/// <summary>
		/// Specifies the depth of the unpacked image (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		UnpackImageDepthSgis = unchecked((uint)0x8133),

		/// <summary>
		/// Specifies the width of pixel tiles (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		TileWidthSgix = unchecked((uint)0x8140),

		/// <summary>
		/// Specifies the height of pixel tiles (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		TileHeightSgix = unchecked((uint)0x8141),

		/// <summary>
		/// Specifies the width of the pixel tile grid (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		TileGridWidthSgix = unchecked((uint)0x8142),

		/// <summary>
		/// Specifies the height of the pixel tile grid (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		TileGridHeightSgix = unchecked((uint)0x8143),

		/// <summary>
		/// Specifies the depth of the pixel tile grid (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		TileGridDepthSgix = unchecked((uint)0x8144),

		/// <summary>
		/// Specifies the size of the pixel tile cache (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		TileCacheSizeSgix = unchecked((uint)0x8145),

		/// <summary>
		/// Specifies packing resample method (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		PackResampleSgix = unchecked((uint)0x842E),

		/// <summary>
		/// Specifies unpacking resample method (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		UnpackResampleSgix = unchecked((uint)0x842F),

		/// <summary>
		/// Specifies the subsample rate for packing (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		PackSubsampleRateSgix = unchecked((uint)0x85A0),

		/// <summary>
		/// Specifies the subsample rate for unpacking (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		UnpackSubsampleRateSgix = unchecked((uint)0x85A1),

		/// <summary>
		/// Specifies packing for resampling textures in OML extensions.
		/// </summary>
		/// <remarks></remarks>
		PackResampleOml = unchecked((uint)0x8984),

		/// <summary>
		/// Specifies unpacking for resampling textures in OML extensions.
		/// </summary>
		/// <remarks></remarks>
		UnpackResampleOml = unchecked((uint)0x8985),
	}
}
