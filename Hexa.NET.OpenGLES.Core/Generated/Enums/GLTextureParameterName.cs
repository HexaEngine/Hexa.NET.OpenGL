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
	public enum GLTextureParameterName : uint
	{
		/// <summary>
		/// Specifies the width of the texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Width = unchecked((uint)0x1000),

		/// <summary>
		/// Specifies the height of the texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Height = unchecked((uint)0x1001),

		/// <summary>
		/// Specifies the internal format of the texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		InternalFormat = unchecked((uint)0x1003),

		/// <summary>
		/// Specifies the number of components in the texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Components = unchecked((uint)0x1003),

		/// <summary>
		/// Specifies the border color of the texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		BorderColor = unchecked((uint)0x1004),

		/// <summary>
		/// Specifies the border color for NV extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_texture_border_clamp</remarks>
		BorderColorNv = unchecked((uint)0x1004),

		/// <summary>
		/// Specifies the width of the texture border.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Border = unchecked((uint)0x1005),

		/// <summary>
		/// Specifies the texture magnification filter.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		MagFilter = unchecked((uint)0x2800),

		/// <summary>
		/// Specifies the texture minification filter.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		MinFilter = unchecked((uint)0x2801),

		/// <summary>
		/// Specifies the texture wrapping mode for the S coordinate.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		WrapS = unchecked((uint)0x2802),

		/// <summary>
		/// Specifies the texture wrapping mode for the T coordinate.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		WrapT = unchecked((uint)0x2803),

		/// <summary>
		/// Specifies the size of the red component in texture formats.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		RedSize = unchecked((uint)0x805C),

		/// <summary>
		/// Specifies the size of the green component in texture formats.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		GreenSize = unchecked((uint)0x805D),

		/// <summary>
		/// Specifies the size of the blue component in texture formats.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		BlueSize = unchecked((uint)0x805E),

		/// <summary>
		/// Specifies the size of the alpha component in texture formats.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		AlphaSize = unchecked((uint)0x805F),

		/// <summary>
		/// Specifies the size of the luminance component in texture formats.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		LuminanceSize = unchecked((uint)0x8060),

		/// <summary>
		/// Specifies the size of the intensity component in texture formats.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		IntensitySize = unchecked((uint)0x8061),

		/// <summary>
		/// Specifies texture priority for texture operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Priority = unchecked((uint)0x8066),

		/// <summary>
		/// Specifies texture priority for texture operations for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture_object</remarks>
		PriorityExt = unchecked((uint)0x8066),

		/// <summary>
		/// Specifies whether a texture is resident in graphics memory.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Resident = unchecked((uint)0x8067),

		/// <summary>
		/// Specifies the depth of a 3D texture for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture3D</remarks>
		DepthExt = unchecked((uint)0x8071),

		/// <summary>
		/// Specifies the wrapping mode for the R coordinate of 3D textures.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		WrapR = unchecked((uint)0x8072),

		/// <summary>
		/// Specifies the wrapping mode for the R coordinate of 3D textures for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture3D</remarks>
		WrapRExt = unchecked((uint)0x8072),

		/// <summary>
		/// Specifies the wrapping mode for the R coordinate of 3D textures for OES extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_texture_3D</remarks>
		WrapROes = unchecked((uint)0x8072),

		/// <summary>
		/// Specifies the level of detail for textures (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		DetailTextureLevelSgis = unchecked((uint)0x809A),

		/// <summary>
		/// Specifies the mode for detail textures (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		DetailTextureModeSgis = unchecked((uint)0x809B),

		/// <summary>
		/// Specifies function points for detail textures (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		DetailTextureFuncPointsSgis = unchecked((uint)0x809C),

		/// <summary>
		/// Specifies function points for texture sharpening (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		SharpenTextureFuncPointsSgis = unchecked((uint)0x80B0),

		/// <summary>
		/// Specifies shadow ambient properties for SGIX extensions.
		/// </summary>
		/// <remarks></remarks>
		ShadowAmbientSgix = unchecked((uint)0x80BF),

		/// <summary>
		/// Specifies dual texture selection (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		DualTextureSelectSgis = unchecked((uint)0x8124),

		/// <summary>
		/// Specifies quad texture selection (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		QuadTextureSelectSgis = unchecked((uint)0x8125),

		/// <summary>
		/// Specifies the size of a 4D texture (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		Texture4DsizeSgis = unchecked((uint)0x8136),

		/// <summary>
		/// Specifies the wrap mode for the Q coordinate (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		WrapQSgis = unchecked((uint)0x8137),

		/// <summary>
		/// Specifies the minimum level of detail for textures.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		MinLod = unchecked((uint)0x813A),

		/// <summary>
		/// Specifies the minimum level of detail for texture filtering (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		MinLodSgis = unchecked((uint)0x813A),

		/// <summary>
		/// Specifies the maximum level of detail for texture filtering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		MaxLod = unchecked((uint)0x813B),

		/// <summary>
		/// Specifies the maximum level of detail for texture filtering (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		MaxLodSgis = unchecked((uint)0x813B),

		/// <summary>
		/// Specifies the base mipmap level of a texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		BaseLevel = unchecked((uint)0x813C),

		/// <summary>
		/// Specifies the base mipmap level of a texture (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		BaseLevelSgis = unchecked((uint)0x813C),

		/// <summary>
		/// Specifies the maximum mipmap level of a texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		MaxLevel = unchecked((uint)0x813D),

		/// <summary>
		/// Specifies the maximum mipmap level of a texture (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		MaxLevelSgis = unchecked((uint)0x813D),

		/// <summary>
		/// Specifies the size of the four-component texture filter (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		Filter4SizeSgis = unchecked((uint)0x8147),

		/// <summary>
		/// Specifies the center of the clipmap (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ClipmapCenterSgix = unchecked((uint)0x8171),

		/// <summary>
		/// Specifies the frame of the clipmap (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ClipmapFrameSgix = unchecked((uint)0x8172),

		/// <summary>
		/// Specifies the offset for the clipmap (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ClipmapOffsetSgix = unchecked((uint)0x8173),

		/// <summary>
		/// Specifies the virtual depth of the clipmap (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ClipmapVirtualDepthSgix = unchecked((uint)0x8174),

		/// <summary>
		/// Specifies the LOD offset for the clipmap (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ClipmapLodOffsetSgix = unchecked((uint)0x8175),

		/// <summary>
		/// Specifies the depth of the clipmap (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ClipmapDepthSgix = unchecked((uint)0x8176),

		/// <summary>
		/// Specifies the bias for post texture filtering (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		PostTextureFilterBiasSgix = unchecked((uint)0x8179),

		/// <summary>
		/// Specifies the scale for post texture filtering (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		PostTextureFilterScaleSgix = unchecked((uint)0x817A),

		/// <summary>
		/// Specifies the LOD bias for the S texture coordinate (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		LodBiasSSgix = unchecked((uint)0x818E),

		/// <summary>
		/// Specifies the LOD bias for the T texture coordinate (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		LodBiasTSgix = unchecked((uint)0x818F),

		/// <summary>
		/// Specifies the LOD bias for the R texture coordinate (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		LodBiasRSgix = unchecked((uint)0x8190),

		/// <summary>
		/// Specifies the generation of mipmaps.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		GenerateMipmap = unchecked((uint)0x8191),

		/// <summary>
		/// Specifies the generation of mipmaps (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		GenerateMipmapSgis = unchecked((uint)0x8191),

		/// <summary>
		/// Specifies texture comparison behavior (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		CompareSgix = unchecked((uint)0x819A),

		/// <summary>
		/// Specifies the operator used for texture comparison (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		CompareOperatorSgix = unchecked((uint)0x819B),

		/// <summary>
		/// Specifies the less than or equal comparison for texture (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		LequalRSgix = unchecked((uint)0x819C),

		/// <summary>
		/// Specifies the greater than or equal comparison for texture (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		GequalRSgix = unchecked((uint)0x819D),

		/// <summary>
		/// Specifies the maximum clamp value for S texture coordinates (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		MaxClampSSgix = unchecked((uint)0x8369),

		/// <summary>
		/// Specifies the maximum clamp value for T texture coordinates (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		MaxClampTSgix = unchecked((uint)0x836A),

		/// <summary>
		/// Specifies the maximum clamp value for R texture coordinates (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		MaxClampRSgix = unchecked((uint)0x836B),

		/// <summary>
		/// Specifies memory layout for textures (INTEL extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_INTEL_map_texture</remarks>
		MemoryLayoutIntel = unchecked((uint)0x83FF),

		/// <summary>
		/// Specifies the maximum anisotropic filtering level.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_texture_filter_anisotropic</remarks>
		MaxAnisotropy = unchecked((uint)0x84FE),

		/// <summary>
		/// Specifies the LOD bias applied to textures.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		LodBias = unchecked((uint)0x8501),

		/// <summary>
		/// Specifies the comparison mode for texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		CompareMode = unchecked((uint)0x884C),

		/// <summary>
		/// Specifies the comparison function for texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		CompareFunc = unchecked((uint)0x884D),

		/// <summary>
		/// Specifies the swizzle component for red in texture operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_texture_swizzle</remarks>
		SwizzleR = unchecked((uint)0x8E42),

		/// <summary>
		/// Specifies the swizzle component for green in texture operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_texture_swizzle</remarks>
		SwizzleG = unchecked((uint)0x8E43),

		/// <summary>
		/// Specifies the swizzle component for blue in texture operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_texture_swizzle</remarks>
		SwizzleB = unchecked((uint)0x8E44),

		/// <summary>
		/// Specifies the swizzle component for alpha in texture operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_texture_swizzle</remarks>
		SwizzleA = unchecked((uint)0x8E45),

		/// <summary>
		/// Specifies the swizzle components for RGBA in texture operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_texture_swizzle</remarks>
		SwizzleRgba = unchecked((uint)0x8E46),

		/// <summary>
		/// Indicates support for unnormalized texture coordinates in ARM architecture.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARM_texture_unnormalized_coordinates</remarks>
		UnnormalizedCoordinatesArm = unchecked((uint)0x8F6A),

		/// <summary>
		/// Specifies the mode for depth-stencil textures.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_stencil_texturing</remarks>
		DepthStencilTextureMode = unchecked((uint)0x90EA),

		/// <summary>
		/// Specifies the tiling mode for textures (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_memory_object</remarks>
		TilingExt = unchecked((uint)0x9580),

		/// <summary>
		/// Specifies the cutoff density for foveated textures (QCOM extension).
		/// </summary>
		/// <remarks></remarks>
		FoveatedCutoffDensityQcom = unchecked((uint)0x96A0),

		/// <summary>
		/// Specifies Y component degamma for textures (QCOM extension).
		/// </summary>
		/// <remarks></remarks>
		YDegammaQcom = unchecked((uint)0x9710),

		/// <summary>
		/// Specifies CbCr component degamma for textures (QCOM extension).
		/// </summary>
		/// <remarks></remarks>
		CbcrDegammaQcom = unchecked((uint)0x9711),
	}
}
