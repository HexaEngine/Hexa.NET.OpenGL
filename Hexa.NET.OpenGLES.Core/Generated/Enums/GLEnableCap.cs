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
	public enum GLEnableCap : uint
	{
		/// <summary>
		/// Indicates point smoothing is enabled.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		PointSmooth = unchecked((uint)0x0B10),

		/// <summary>
		/// Indicates line smoothing is enabled.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		LineSmooth = unchecked((uint)0x0B20),

		/// <summary>
		/// Indicates line stipple pattern is enabled.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		LineStipple = unchecked((uint)0x0B24),

		/// <summary>
		/// Enables or disables polygon smoothing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		PolygonSmooth = unchecked((uint)0x0B41),

		/// <summary>
		/// Enables or disables polygon stippling.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		PolygonStipple = unchecked((uint)0x0B42),

		/// <summary>
		/// Enables or disables face culling.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		CullFace = unchecked((uint)0x0B44),

		/// <summary>
		/// Enables or disables lighting calculations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Lighting = unchecked((uint)0x0B50),

		/// <summary>
		/// Enables or disables color material.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ColorMaterial = unchecked((uint)0x0B57),

		/// <summary>
		/// Enables or disables fog effects.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_NV_register_combiners</remarks>
		Fog = unchecked((uint)0x0B60),

		/// <summary>
		/// Enables or disables depth testing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		DepthTest = unchecked((uint)0x0B71),

		/// <summary>
		/// Enables or disables stencil testing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		StencilTest = unchecked((uint)0x0B90),

		/// <summary>
		/// Enables or disables normalization of normals.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Normalize = unchecked((uint)0x0BA1),

		/// <summary>
		/// Enables or disables alpha testing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		AlphaTest = unchecked((uint)0x0BC0),

		/// <summary>
		/// Enables or disables dithering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Dither = unchecked((uint)0x0BD0),

		/// <summary>
		/// Enables or disables blending.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed<br/>GL_OES_draw_buffers_indexed</remarks>
		Blend = unchecked((uint)0x0BE2),

		/// <summary>
		/// Enables or disables index logic operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		IndexLogicOp = unchecked((uint)0x0BF1),

		/// <summary>
		/// Enables or disables color logic operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ColorLogicOp = unchecked((uint)0x0BF2),

		/// <summary>
		/// Enables or disables the scissor test.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array<br/>GL_NV_viewport_array<br/>GL_OES_viewport_array</remarks>
		ScissorTest = unchecked((uint)0x0C11),

		/// <summary>
		/// Enables or disables texture coordinate generation for the S coordinate.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TextureGenS = unchecked((uint)0x0C60),

		/// <summary>
		/// Enables or disables texture coordinate generation for the T coordinate.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TextureGenT = unchecked((uint)0x0C61),

		/// <summary>
		/// Enables or disables texture coordinate generation for the R coordinate.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TextureGenR = unchecked((uint)0x0C62),

		/// <summary>
		/// Enables or disables texture coordinate generation for the Q coordinate.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TextureGenQ = unchecked((uint)0x0C63),

		/// <summary>
		/// Enables or disables automatic normal generation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		AutoNormal = unchecked((uint)0x0D80),

		/// <summary>
		/// Specifies a one-dimensional color map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1Color4 = unchecked((uint)0x0D90),

		/// <summary>
		/// Specifies a one-dimensional index map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1Index = unchecked((uint)0x0D91),

		/// <summary>
		/// Specifies a one-dimensional normal map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1Normal = unchecked((uint)0x0D92),

		/// <summary>
		/// Specifies the first texture coordinate in a one-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1TextureCoord1 = unchecked((uint)0x0D93),

		/// <summary>
		/// Specifies the second texture coordinate in a one-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1TextureCoord2 = unchecked((uint)0x0D94),

		/// <summary>
		/// Specifies the third texture coordinate in a one-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1TextureCoord3 = unchecked((uint)0x0D95),

		/// <summary>
		/// Specifies the fourth texture coordinate in a one-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1TextureCoord4 = unchecked((uint)0x0D96),

		/// <summary>
		/// Specifies a three-dimensional vertex map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1Vertex3 = unchecked((uint)0x0D97),

		/// <summary>
		/// Specifies a four-dimensional vertex map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map1Vertex4 = unchecked((uint)0x0D98),

		/// <summary>
		/// Specifies a two-dimensional color map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2Color4 = unchecked((uint)0x0DB0),

		/// <summary>
		/// Specifies a two-dimensional index map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2Index = unchecked((uint)0x0DB1),

		/// <summary>
		/// Specifies a two-dimensional normal map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2Normal = unchecked((uint)0x0DB2),

		/// <summary>
		/// Specifies the first texture coordinate in a two-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2TextureCoord1 = unchecked((uint)0x0DB3),

		/// <summary>
		/// Specifies the second texture coordinate in a two-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2TextureCoord2 = unchecked((uint)0x0DB4),

		/// <summary>
		/// Specifies the third texture coordinate in a two-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2TextureCoord3 = unchecked((uint)0x0DB5),

		/// <summary>
		/// Specifies the fourth texture coordinate in a two-dimensional map.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2TextureCoord4 = unchecked((uint)0x0DB6),

		/// <summary>
		/// Specifies a three-dimensional vertex map for two-dimensional evaluation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2Vertex3 = unchecked((uint)0x0DB7),

		/// <summary>
		/// Specifies a four-dimensional vertex map for two-dimensional evaluation.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Map2Vertex4 = unchecked((uint)0x0DB8),

		/// <summary>
		/// Specifies a one-dimensional texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		Texture1D = unchecked((uint)0x0DE0),

		/// <summary>
		/// Specifies a two-dimensional texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2<br/>GL_EXT_sparse_texture</remarks>
		Texture2D = unchecked((uint)0x0DE1),

		/// <summary>
		/// Specifies polygon offset for point primitives.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		PolygonOffsetPoint = unchecked((uint)0x2A01),

		/// <summary>
		/// Specifies polygon offset for line primitives.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		PolygonOffsetLine = unchecked((uint)0x2A02),

		/// <summary>
		/// Specifies the first clipping plane.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipPlane0 = unchecked((uint)0x3000),

		/// <summary>
		/// Specifies the first clipping distance.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipDistance0 = unchecked((uint)0x3000),

		/// <summary>
		/// Specifies the second clipping plane.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipPlane1 = unchecked((uint)0x3001),

		/// <summary>
		/// Specifies the second clipping distance.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipDistance1 = unchecked((uint)0x3001),

		/// <summary>
		/// Specifies the third clipping plane.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipPlane2 = unchecked((uint)0x3002),

		/// <summary>
		/// Specifies the third clipping distance.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipDistance2 = unchecked((uint)0x3002),

		/// <summary>
		/// Specifies the fourth clipping plane.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipPlane3 = unchecked((uint)0x3003),

		/// <summary>
		/// Specifies the fourth clipping distance.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipDistance3 = unchecked((uint)0x3003),

		/// <summary>
		/// Specifies the fifth clipping plane.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipPlane4 = unchecked((uint)0x3004),

		/// <summary>
		/// Specifies the fifth clipping distance.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipDistance4 = unchecked((uint)0x3004),

		/// <summary>
		/// Specifies the sixth clipping plane.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipPlane5 = unchecked((uint)0x3005),

		/// <summary>
		/// Specifies the sixth clipping distance.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipDistance5 = unchecked((uint)0x3005),

		/// <summary>
		/// Specifies the seventh clipping distance.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipDistance6 = unchecked((uint)0x3006),

		/// <summary>
		/// Specifies the eighth clipping distance.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ClipDistance7 = unchecked((uint)0x3007),

		/// <summary>
		/// Specifies the first light source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Light0 = unchecked((uint)0x4000),

		/// <summary>
		/// Specifies the second light source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Light1 = unchecked((uint)0x4001),

		/// <summary>
		/// Specifies the third light source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Light2 = unchecked((uint)0x4002),

		/// <summary>
		/// Specifies the fourth light source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Light3 = unchecked((uint)0x4003),

		/// <summary>
		/// Specifies the fifth light source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Light4 = unchecked((uint)0x4004),

		/// <summary>
		/// Specifies the sixth light source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Light5 = unchecked((uint)0x4005),

		/// <summary>
		/// Specifies the seventh light source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Light6 = unchecked((uint)0x4006),

		/// <summary>
		/// Specifies the eighth light source.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Light7 = unchecked((uint)0x4007),

		/// <summary>
		/// Specifies 1D convolution operations for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		Convolution1DExt = unchecked((uint)0x8010),

		/// <summary>
		/// Specifies 2D convolution operations for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		Convolution2DExt = unchecked((uint)0x8011),

		/// <summary>
		/// Specifies separable 2D convolution operations for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		Separable2DExt = unchecked((uint)0x8012),

		/// <summary>
		/// Specifies histogram operations for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_histogram</remarks>
		HistogramExt = unchecked((uint)0x8024),

		/// <summary>
		/// Specifies min/max operations for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_histogram</remarks>
		MinmaxExt = unchecked((uint)0x802E),

		/// <summary>
		/// Specifies the polygon offset for filled polygons.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		PolygonOffsetFill = unchecked((uint)0x8037),

		/// <summary>
		/// Specifies that normals should be rescaled when they are transformed for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_rescale_normal</remarks>
		RescaleNormalExt = unchecked((uint)0x803A),

		/// <summary>
		/// Specifies a 3D texture for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture3D</remarks>
		Texture3DExt = unchecked((uint)0x806F),

		/// <summary>
		/// Specifies a vertex array for rendering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		VertexArray = unchecked((uint)0x8074),

		/// <summary>
		/// Specifies a normal array for rendering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		NormalArray = unchecked((uint)0x8075),

		/// <summary>
		/// Specifies a color array for rendering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ColorArray = unchecked((uint)0x8076),

		/// <summary>
		/// Specifies an index array for rendering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		IndexArray = unchecked((uint)0x8077),

		/// <summary>
		/// Specifies a texture coordinate array for rendering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TextureCoordArray = unchecked((uint)0x8078),

		/// <summary>
		/// Specifies an edge flag array for rendering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		EdgeFlagArray = unchecked((uint)0x8079),

		/// <summary>
		/// Specifies interlaced rendering mode for SGIX extensions.
		/// </summary>
		/// <remarks></remarks>
		InterlaceSgix = unchecked((uint)0x8094),

		/// <summary>
		/// Specifies multisampling for anti-aliasing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Multisample = unchecked((uint)0x809D),

		/// <summary>
		/// Specifies multisampling for anti-aliasing (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		MultisampleSgis = unchecked((uint)0x809D),

		/// <summary>
		/// Specifies alpha-to-coverage sampling for anti-aliasing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		SampleAlphaToCoverage = unchecked((uint)0x809E),

		/// <summary>
		/// Specifies alpha-to-mask sampling for anti-aliasing (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		SampleAlphaToMaskSgis = unchecked((uint)0x809E),

		/// <summary>
		/// Specifies sampling to one for anti-aliasing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		SampleAlphaToOne = unchecked((uint)0x809F),

		/// <summary>
		/// Specifies sampling to one for anti-aliasing (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		SampleAlphaToOneSgis = unchecked((uint)0x809F),

		/// <summary>
		/// Specifies the sample coverage value for alpha blending.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		SampleCoverage = unchecked((uint)0x80A0),

		/// <summary>
		/// Specifies the sample mask for controlling sample coverage (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		SampleMaskSgis = unchecked((uint)0x80A0),

		/// <summary>
		/// Specifies the texture color table (SGI extension).
		/// </summary>
		/// <remarks></remarks>
		TextureColorTableSgi = unchecked((uint)0x80BC),

		/// <summary>
		/// Specifies a color table for color lookup.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_imaging</remarks>
		ColorTable = unchecked((uint)0x80D0),

		/// <summary>
		/// Specifies a color table for color lookup (SGI extension).
		/// </summary>
		/// <remarks></remarks>
		ColorTableSgi = unchecked((uint)0x80D0),

		/// <summary>
		/// Specifies a color table for post-convolution processing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_imaging</remarks>
		PostConvolutionColorTable = unchecked((uint)0x80D1),

		/// <summary>
		/// Specifies a color table for post-convolution processing (SGI extension).
		/// </summary>
		/// <remarks></remarks>
		PostConvolutionColorTableSgi = unchecked((uint)0x80D1),

		/// <summary>
		/// Specifies a color table for post-color matrix processing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_imaging</remarks>
		PostColorMatrixColorTable = unchecked((uint)0x80D2),

		/// <summary>
		/// Specifies a color table for post-color matrix processing (SGI extension).
		/// </summary>
		/// <remarks></remarks>
		PostColorMatrixColorTableSgi = unchecked((uint)0x80D2),

		/// <summary>
		/// Specifies a 4D texture (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		Texture4DSgis = unchecked((uint)0x8134),

		/// <summary>
		/// Specifies pixel texture generation (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		PixelTexGenSgix = unchecked((uint)0x8139),

		/// <summary>
		/// Specifies the sprite (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		SpriteSgix = unchecked((uint)0x8148),

		/// <summary>
		/// Specifies the reference plane for operations (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		ReferencePlaneSgix = unchecked((uint)0x817D),

		/// <summary>
		/// Specifies the first instrument for IR measurements (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		IrInstrument1Sgix = unchecked((uint)0x817F),

		/// <summary>
		/// Specifies calligraphic fragments (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		CalligraphicFragmentSgix = unchecked((uint)0x8183),

		/// <summary>
		/// Specifies zoom behavior for frames (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FramezoomSgix = unchecked((uint)0x818B),

		/// <summary>
		/// Specifies the fog offset (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FogOffsetSgix = unchecked((uint)0x8198),

		/// <summary>
		/// Specifies shared texture palette behavior (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_shared_texture_palette</remarks>
		SharedTexturePaletteExt = unchecked((uint)0x81FB),

		/// <summary>
		/// Specifies synchronous debugging output behavior.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		DebugOutputSynchronous = unchecked((uint)0x8242),

		/// <summary>
		/// Specifies asynchronous histogram operations (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		AsyncHistogramSgix = unchecked((uint)0x832C),

		/// <summary>
		/// Specifies pixel texture operations (SGIS extension).
		/// </summary>
		/// <remarks></remarks>
		PixelTextureSgis = unchecked((uint)0x8353),

		/// <summary>
		/// Specifies asynchronous texture image operations (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		AsyncTexImageSgix = unchecked((uint)0x835C),

		/// <summary>
		/// Specifies asynchronous pixel drawing operations (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		AsyncDrawPixelsSgix = unchecked((uint)0x835D),

		/// <summary>
		/// Specifies asynchronous pixel reading operations (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		AsyncReadPixelsSgix = unchecked((uint)0x835E),

		/// <summary>
		/// Enables fragment lighting (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLightingSgix = unchecked((uint)0x8400),

		/// <summary>
		/// Specifies color material properties for fragments (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentColorMaterialSgix = unchecked((uint)0x8401),

		/// <summary>
		/// Specifies the first fragment light source (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLight0Sgix = unchecked((uint)0x840C),

		/// <summary>
		/// Specifies the second fragment light source (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLight1Sgix = unchecked((uint)0x840D),

		/// <summary>
		/// Specifies the third fragment light source (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLight2Sgix = unchecked((uint)0x840E),

		/// <summary>
		/// Specifies the fourth fragment light source (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLight3Sgix = unchecked((uint)0x840F),

		/// <summary>
		/// Specifies the fifth fragment light source (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLight4Sgix = unchecked((uint)0x8410),

		/// <summary>
		/// Specifies the sixth fragment light source (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLight5Sgix = unchecked((uint)0x8411),

		/// <summary>
		/// Specifies the seventh fragment light source (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLight6Sgix = unchecked((uint)0x8412),

		/// <summary>
		/// Specifies the eighth fragment light source (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		FragmentLight7Sgix = unchecked((uint)0x8413),

		/// <summary>
		/// Specifies a rectangle texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureRectangle = unchecked((uint)0x84F5),

		/// <summary>
		/// Specifies a rectangle texture (ARB extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_texture_rectangle</remarks>
		TextureRectangleArb = unchecked((uint)0x84F5),

		/// <summary>
		/// Specifies a rectangle texture (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_texture_rectangle</remarks>
		TextureRectangleNv = unchecked((uint)0x84F5),

		/// <summary>
		/// Specifies a cube map texture.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2<br/>GL_EXT_sparse_texture</remarks>
		TextureCubeMap = unchecked((uint)0x8513),

		/// <summary>
		/// Specifies a cube map texture (ARB extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_texture_cube_map</remarks>
		TextureCubeMapArb = unchecked((uint)0x8513),

		/// <summary>
		/// Specifies a cube map texture (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture_cube_map</remarks>
		TextureCubeMapExt = unchecked((uint)0x8513),

		/// <summary>
		/// Specifies a cube map texture (OES extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_texture_cube_map</remarks>
		TextureCubeMapOes = unchecked((uint)0x8513),

		/// <summary>
		/// Specifies the point size for programs.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ProgramPointSize = unchecked((uint)0x8642),

		/// <summary>
		/// Specifies whether depth clamping is enabled.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_depth_clamp</remarks>
		DepthClamp = unchecked((uint)0x864F),

		/// <summary>
		/// Enables seamless texture cube mapping.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_seamless_cube_map<br/>GL_ARB_seamless_cubemap_per_texture<br/>GL_AMD_seamless_cubemap_per_texture</remarks>
		TextureCubeMapSeamless = unchecked((uint)0x884F),

		/// <summary>
		/// Specifies sample shading for rendering.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		SampleShading = unchecked((uint)0x8C36),

		/// <summary>
		/// Specifies the rasterizer discard mode.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		RasterizerDiscard = unchecked((uint)0x8C89),

		/// <summary>
		/// Specifies the string for texture generation (OES extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_texture_cube_map</remarks>
		TextureGenStrOes = unchecked((uint)0x8D60),

		/// <summary>
		/// Specifies the fixed index for primitive restart.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_ES3_compatibility</remarks>
		PrimitiveRestartFixedIndex = unchecked((uint)0x8D69),

		/// <summary>
		/// Indicates support for sRGB framebuffer in OpenGL.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_sRGB</remarks>
		FramebufferSrgb = unchecked((uint)0x8DB9),

		/// <summary>
		/// Specifies a mask that controls sample writing.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_texture_multisample</remarks>
		SampleMask = unchecked((uint)0x8E51),

		/// <summary>
		/// Indicates whether per-sample fetching is supported in ARM shaders.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARM_shader_framebuffer_fetch</remarks>
		FetchPerSampleArm = unchecked((uint)0x8F65),

		/// <summary>
		/// Indicates the use of primitive restart in drawing commands.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		PrimitiveRestart = unchecked((uint)0x8F9D),

		/// <summary>
		/// Enables or disables debug output messages.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		DebugOutput = unchecked((uint)0x92E0),

		/// <summary>
		/// Specifies the shading rate image per primitive (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_primitive_shading_rate</remarks>
		ShadingRateImagePerPrimitiveNv = unchecked((uint)0x95B1),

		/// <summary>
		/// Indicates non-coherent framebuffer fetch (QCOM extension).
		/// </summary>
		/// <remarks></remarks>
		FramebufferFetchNoncoherentQcom = unchecked((uint)0x96A2),

		/// <summary>
		/// Preserves the aspect ratio for shading rates (QCOM extension).
		/// </summary>
		/// <remarks></remarks>
		ShadingRatePreserveAspectRatioQcom = unchecked((uint)0x96A5),
	}
}
