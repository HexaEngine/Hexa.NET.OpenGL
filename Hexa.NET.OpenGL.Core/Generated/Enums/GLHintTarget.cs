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
	public enum GLHintTarget : uint
	{
		/// <summary>
		/// Hints to the OpenGL implementation for perspective correction.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		PerspectiveCorrectionHint = unchecked((uint)0x0C50),

		/// <summary>
		/// Hints to the OpenGL implementation for point smoothing.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		PointSmoothHint = unchecked((uint)0x0C51),

		/// <summary>
		/// Hints to the OpenGL implementation for line smoothing.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		LineSmoothHint = unchecked((uint)0x0C52),

		/// <summary>
		/// Hints to the OpenGL implementation for polygon smoothing.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		PolygonSmoothHint = unchecked((uint)0x0C53),

		/// <summary>
		/// Hints to the OpenGL implementation for fog calculations.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.X<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		FogHint = unchecked((uint)0x0C54),

		/// <summary>
		/// Specifies hints for packing CMYK data for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_cmyka</remarks>
		PackCmykHintExt = unchecked((uint)0x800E),

		/// <summary>
		/// Specifies hints for unpacking CMYK data for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_cmyka</remarks>
		UnpackCmykHintExt = unchecked((uint)0x800F),

		/// <summary>
		/// Specifies the hint for using the Phong shading model in Win32 extensions.
		/// </summary>
		/// <remarks></remarks>
		PhongHintWin = unchecked((uint)0x80EB),

		/// <summary>
		/// Specifies the hint for clipping volume (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_clip_volume_hint</remarks>
		ClipVolumeClippingHintExt = unchecked((uint)0x80F0),

		/// <summary>
		/// Specifies a hint for multi-buffered textures (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		TextureMultiBufferHintSgix = unchecked((uint)0x812E),

		/// <summary>
		/// Specifies a hint for generating mipmaps.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.4 - GL 1.5<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		GenerateMipmapHint = unchecked((uint)0x8192),

		/// <summary>
		/// Specifies a hint for generating mipmaps (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		GenerateMipmapHintSgis = unchecked((uint)0x8192),

		/// <summary>
		/// Specifies a hint that program binaries are retrievable.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		ProgramBinaryRetrievableHint = unchecked((uint)0x8257),

		/// <summary>
		/// Specifies hints for convolution operations (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ConvolutionHintSgix = unchecked((uint)0x8316),

		/// <summary>
		/// Specifies hints for scale-bias operations (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ScalebiasHintSgix = unchecked((uint)0x8322),

		/// <summary>
		/// Specifies hints for line quality (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		LineQualityHintSgix = unchecked((uint)0x835B),

		/// <summary>
		/// Specifies vertex pre-clipping (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		VertexPreclipSgix = unchecked((uint)0x83EE),

		/// <summary>
		/// Specifies hints for vertex pre-clipping (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		VertexPreclipHintSgix = unchecked((uint)0x83EF),

		/// <summary>
		/// Specifies the hint for texture compression.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.3 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X</remarks>
		TextureCompressionHint = unchecked((uint)0x84EF),

		/// <summary>
		/// Specifies the hint for texture compression (ARB extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_texture_compression</remarks>
		TextureCompressionHintArb = unchecked((uint)0x84EF),

		/// <summary>
		/// Specifies the storage hint for vertex arrays (APPLE extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_range</remarks>
		VertexArrayStorageHintApple = unchecked((uint)0x851F),

		/// <summary>
		/// Specifies the hint for multisample filtering (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_multisample_filter_hint</remarks>
		MultisampleFilterHintNv = unchecked((uint)0x8534),

		/// <summary>
		/// Specifies a hint for transformations (APPLE extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_transform_hint</remarks>
		TransformHintApple = unchecked((uint)0x85B1),

		/// <summary>
		/// Specifies texture storage hints (APPLE extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_texture_range</remarks>
		TextureStorageHintApple = unchecked((uint)0x85BC),

		/// <summary>
		/// Specifies the hint for fragment shader derivative calculations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		FragmentShaderDerivativeHint = unchecked((uint)0x8B8B),

		/// <summary>
		/// Specifies the hint for fragment shader derivative calculations (ARB extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_shader</remarks>
		FragmentShaderDerivativeHintArb = unchecked((uint)0x8B8B),

		/// <summary>
		/// Specifies the hint for fragment shader derivative calculations (OES extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentShaderDerivativeHintOes = unchecked((uint)0x8B8B),

		/// <summary>
		/// Specifies a hint for binning control in the QCOM extension.
		/// </summary>
		/// <remarks></remarks>
		BinningControlHintQcom = unchecked((uint)0x8FB0),

		/// <summary>
		/// Indicates a preference for double buffering (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		PreferDoublebufferHintPgi = unchecked((uint)0x1A1F8),

		/// <summary>
		/// Indicates a hint to conserve memory (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		ConserveMemoryHintPgi = unchecked((uint)0x1A1FD),

		/// <summary>
		/// Indicates a hint to reclaim memory (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		ReclaimMemoryHintPgi = unchecked((uint)0x1A1FE),

		/// <summary>
		/// Indicates a hint to begin using native graphics (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		NativeGraphicsBeginHintPgi = unchecked((uint)0x1A203),

		/// <summary>
		/// Indicates a hint to end using native graphics (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		NativeGraphicsEndHintPgi = unchecked((uint)0x1A204),

		/// <summary>
		/// Indicates a hint for always fast rendering (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		AlwaysFastHintPgi = unchecked((uint)0x1A20C),

		/// <summary>
		/// Indicates a hint for always soft rendering (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		AlwaysSoftHintPgi = unchecked((uint)0x1A20D),

		/// <summary>
		/// Indicates a hint to allow drawing of objects (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		AllowDrawObjHintPgi = unchecked((uint)0x1A20E),

		/// <summary>
		/// Indicates a hint to allow drawing of windows (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		AllowDrawWinHintPgi = unchecked((uint)0x1A20F),

		/// <summary>
		/// Indicates a hint to allow drawing of fragments (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		AllowDrawFrgHintPgi = unchecked((uint)0x1A210),

		/// <summary>
		/// Indicates a hint to allow drawing of memory (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		AllowDrawMemHintPgi = unchecked((uint)0x1A211),

		/// <summary>
		/// Indicates a hint for strict depth function checks (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		StrictDepthfuncHintPgi = unchecked((uint)0x1A216),

		/// <summary>
		/// Indicates a hint for strict lighting checks (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		StrictLightingHintPgi = unchecked((uint)0x1A217),

		/// <summary>
		/// Indicates a hint for strict scissor checks (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		StrictScissorHintPgi = unchecked((uint)0x1A218),

		/// <summary>
		/// Indicates a hint for full stipple rendering (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		FullStippleHintPgi = unchecked((uint)0x1A219),

		/// <summary>
		/// Indicates a hint for near clipping (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		ClipNearHintPgi = unchecked((uint)0x1A220),

		/// <summary>
		/// Indicates a hint for far clipping (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		ClipFarHintPgi = unchecked((uint)0x1A221),

		/// <summary>
		/// Indicates a hint for wide line rendering (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		WideLineHintPgi = unchecked((uint)0x1A222),

		/// <summary>
		/// Indicates a hint for backface normal rendering (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		BackNormalsHintPgi = unchecked((uint)0x1A223),

		/// <summary>
		/// Indicates a hint for vertex data optimization (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		VertexDataHintPgi = unchecked((uint)0x1A22A),

		/// <summary>
		/// Indicates a hint for vertex consistency (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		VertexConsistentHintPgi = unchecked((uint)0x1A22B),

		/// <summary>
		/// Indicates a hint for material side rendering (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		MaterialSideHintPgi = unchecked((uint)0x1A22C),

		/// <summary>
		/// Indicates a hint for the maximum vertex count (PGI extension).
		/// </summary>
		/// <remarks></remarks>
		MaxVertexHintPgi = unchecked((uint)0x1A22D),
	}
}
