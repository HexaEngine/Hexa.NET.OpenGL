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
	public enum GLEnableCap : uint
	{
		PointSmooth = unchecked((uint)0x0B10),
		LineSmooth = unchecked((uint)0x0B20),
		LineStipple = unchecked((uint)0x0B24),
		PolygonSmooth = unchecked((uint)0x0B41),
		PolygonStipple = unchecked((uint)0x0B42),
		CullFace = unchecked((uint)0x0B44),
		Lighting = unchecked((uint)0x0B50),
		ColorMaterial = unchecked((uint)0x0B57),
		Fog = unchecked((uint)0x0B60),
		DepthTest = unchecked((uint)0x0B71),
		StencilTest = unchecked((uint)0x0B90),
		Normalize = unchecked((uint)0x0BA1),
		AlphaTest = unchecked((uint)0x0BC0),
		Dither = unchecked((uint)0x0BD0),
		Blend = unchecked((uint)0x0BE2),
		IndexLogicOp = unchecked((uint)0x0BF1),
		ColorLogicOp = unchecked((uint)0x0BF2),
		ScissorTest = unchecked((uint)0x0C11),
		TextureGenS = unchecked((uint)0x0C60),
		TextureGenT = unchecked((uint)0x0C61),
		TextureGenR = unchecked((uint)0x0C62),
		TextureGenQ = unchecked((uint)0x0C63),
		AutoNormal = unchecked((uint)0x0D80),
		Map1Color4 = unchecked((uint)0x0D90),
		Map1Index = unchecked((uint)0x0D91),
		Map1Normal = unchecked((uint)0x0D92),
		Map1TextureCoord1 = unchecked((uint)0x0D93),
		Map1TextureCoord2 = unchecked((uint)0x0D94),
		Map1TextureCoord3 = unchecked((uint)0x0D95),
		Map1TextureCoord4 = unchecked((uint)0x0D96),
		Map1Vertex3 = unchecked((uint)0x0D97),
		Map1Vertex4 = unchecked((uint)0x0D98),
		Map2Color4 = unchecked((uint)0x0DB0),
		Map2Index = unchecked((uint)0x0DB1),
		Map2Normal = unchecked((uint)0x0DB2),
		Map2TextureCoord1 = unchecked((uint)0x0DB3),
		Map2TextureCoord2 = unchecked((uint)0x0DB4),
		Map2TextureCoord3 = unchecked((uint)0x0DB5),
		Map2TextureCoord4 = unchecked((uint)0x0DB6),
		Map2Vertex3 = unchecked((uint)0x0DB7),
		Map2Vertex4 = unchecked((uint)0x0DB8),
		Texture1D = unchecked((uint)0x0DE0),
		Texture2D = unchecked((uint)0x0DE1),
		PolygonOffsetPoint = unchecked((uint)0x2A01),
		PolygonOffsetLine = unchecked((uint)0x2A02),
		ClipPlane0 = unchecked((uint)0x3000),
		ClipDistance0 = unchecked((uint)0x3000),
		ClipPlane1 = unchecked((uint)0x3001),
		ClipDistance1 = unchecked((uint)0x3001),
		ClipPlane2 = unchecked((uint)0x3002),
		ClipDistance2 = unchecked((uint)0x3002),
		ClipPlane3 = unchecked((uint)0x3003),
		ClipDistance3 = unchecked((uint)0x3003),
		ClipPlane4 = unchecked((uint)0x3004),
		ClipDistance4 = unchecked((uint)0x3004),
		ClipPlane5 = unchecked((uint)0x3005),
		ClipDistance5 = unchecked((uint)0x3005),
		ClipDistance6 = unchecked((uint)0x3006),
		ClipDistance7 = unchecked((uint)0x3007),
		Light0 = unchecked((uint)0x4000),
		Light1 = unchecked((uint)0x4001),
		Light2 = unchecked((uint)0x4002),
		Light3 = unchecked((uint)0x4003),
		Light4 = unchecked((uint)0x4004),
		Light5 = unchecked((uint)0x4005),
		Light6 = unchecked((uint)0x4006),
		Light7 = unchecked((uint)0x4007),
		Convolution1DExt = unchecked((uint)0x8010),
		Convolution2DExt = unchecked((uint)0x8011),
		Separable2DExt = unchecked((uint)0x8012),
		HistogramExt = unchecked((uint)0x8024),
		MinmaxExt = unchecked((uint)0x802E),
		PolygonOffsetFill = unchecked((uint)0x8037),
		RescaleNormalExt = unchecked((uint)0x803A),
		Texture3DExt = unchecked((uint)0x806F),
		VertexArray = unchecked((uint)0x8074),
		NormalArray = unchecked((uint)0x8075),
		ColorArray = unchecked((uint)0x8076),
		IndexArray = unchecked((uint)0x8077),
		TextureCoordArray = unchecked((uint)0x8078),
		EdgeFlagArray = unchecked((uint)0x8079),
		InterlaceSgix = unchecked((uint)0x8094),
		Multisample = unchecked((uint)0x809D),
		MultisampleSgis = unchecked((uint)0x809D),
		SampleAlphaToCoverage = unchecked((uint)0x809E),
		SampleAlphaToMaskSgis = unchecked((uint)0x809E),
		SampleAlphaToOne = unchecked((uint)0x809F),
		SampleAlphaToOneSgis = unchecked((uint)0x809F),
		SampleCoverage = unchecked((uint)0x80A0),
		SampleMaskSgis = unchecked((uint)0x80A0),
		TextureColorTableSgi = unchecked((uint)0x80BC),
		ColorTable = unchecked((uint)0x80D0),
		ColorTableSgi = unchecked((uint)0x80D0),
		PostConvolutionColorTable = unchecked((uint)0x80D1),
		PostConvolutionColorTableSgi = unchecked((uint)0x80D1),
		PostColorMatrixColorTable = unchecked((uint)0x80D2),
		PostColorMatrixColorTableSgi = unchecked((uint)0x80D2),
		Texture4DSgis = unchecked((uint)0x8134),
		PixelTexGenSgix = unchecked((uint)0x8139),
		SpriteSgix = unchecked((uint)0x8148),
		ReferencePlaneSgix = unchecked((uint)0x817D),
		IrInstrument1Sgix = unchecked((uint)0x817F),
		CalligraphicFragmentSgix = unchecked((uint)0x8183),
		FramezoomSgix = unchecked((uint)0x818B),
		FogOffsetSgix = unchecked((uint)0x8198),
		SharedTexturePaletteExt = unchecked((uint)0x81FB),
		DebugOutputSynchronous = unchecked((uint)0x8242),
		AsyncHistogramSgix = unchecked((uint)0x832C),
		PixelTextureSgis = unchecked((uint)0x8353),
		AsyncTexImageSgix = unchecked((uint)0x835C),
		AsyncDrawPixelsSgix = unchecked((uint)0x835D),
		AsyncReadPixelsSgix = unchecked((uint)0x835E),
		FragmentLightingSgix = unchecked((uint)0x8400),
		FragmentColorMaterialSgix = unchecked((uint)0x8401),
		FragmentLight0Sgix = unchecked((uint)0x840C),
		FragmentLight1Sgix = unchecked((uint)0x840D),
		FragmentLight2Sgix = unchecked((uint)0x840E),
		FragmentLight3Sgix = unchecked((uint)0x840F),
		FragmentLight4Sgix = unchecked((uint)0x8410),
		FragmentLight5Sgix = unchecked((uint)0x8411),
		FragmentLight6Sgix = unchecked((uint)0x8412),
		FragmentLight7Sgix = unchecked((uint)0x8413),
		TextureRectangle = unchecked((uint)0x84F5),
		TextureRectangleArb = unchecked((uint)0x84F5),
		TextureRectangleNv = unchecked((uint)0x84F5),
		TextureCubeMap = unchecked((uint)0x8513),
		TextureCubeMapArb = unchecked((uint)0x8513),
		TextureCubeMapExt = unchecked((uint)0x8513),
		TextureCubeMapOes = unchecked((uint)0x8513),
		ProgramPointSize = unchecked((uint)0x8642),
		DepthClamp = unchecked((uint)0x864F),
		TextureCubeMapSeamless = unchecked((uint)0x884F),
		SampleShading = unchecked((uint)0x8C36),
		RasterizerDiscard = unchecked((uint)0x8C89),
		TextureGenStrOes = unchecked((uint)0x8D60),
		PrimitiveRestartFixedIndex = unchecked((uint)0x8D69),
		FramebufferSrgb = unchecked((uint)0x8DB9),
		SampleMask = unchecked((uint)0x8E51),
		FetchPerSampleArm = unchecked((uint)0x8F65),
		PrimitiveRestart = unchecked((uint)0x8F9D),
		DebugOutput = unchecked((uint)0x92E0),
		ShadingRateImagePerPrimitiveNv = unchecked((uint)0x95B1),
		FramebufferFetchNoncoherentQcom = unchecked((uint)0x96A2),
		ShadingRatePreserveAspectRatioQcom = unchecked((uint)0x96A5),
	}
}