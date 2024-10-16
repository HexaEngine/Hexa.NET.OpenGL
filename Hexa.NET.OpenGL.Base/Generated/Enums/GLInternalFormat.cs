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
	public enum GLInternalFormat : uint
	{
		StencilIndex = unchecked((uint)0x1901),
		StencilIndexOes = unchecked((uint)0x1901),
		DepthComponent = unchecked((uint)0x1902),
		Red = unchecked((uint)0x1903),
		RedExt = unchecked((uint)0x1903),
		Rgb = unchecked((uint)0x1907),
		Rgba = unchecked((uint)0x1908),
		R3G3B2 = unchecked((uint)0x2A10),
		Alpha4 = unchecked((uint)0x803B),
		Alpha4Ext = unchecked((uint)0x803B),
		Alpha8 = unchecked((uint)0x803C),
		Alpha8Ext = unchecked((uint)0x803C),
		Alpha8Oes = unchecked((uint)0x803C),
		Alpha12 = unchecked((uint)0x803D),
		Alpha12Ext = unchecked((uint)0x803D),
		Alpha16 = unchecked((uint)0x803E),
		Alpha16Ext = unchecked((uint)0x803E),
		Luminance4 = unchecked((uint)0x803F),
		Luminance4Ext = unchecked((uint)0x803F),
		Luminance8 = unchecked((uint)0x8040),
		Luminance8Ext = unchecked((uint)0x8040),
		Luminance8Oes = unchecked((uint)0x8040),
		Luminance12 = unchecked((uint)0x8041),
		Luminance12Ext = unchecked((uint)0x8041),
		Luminance16 = unchecked((uint)0x8042),
		Luminance16Ext = unchecked((uint)0x8042),
		Luminance4Alpha4 = unchecked((uint)0x8043),
		Luminance4Alpha4Ext = unchecked((uint)0x8043),
		Luminance4Alpha4Oes = unchecked((uint)0x8043),
		Luminance6Alpha2 = unchecked((uint)0x8044),
		Luminance6Alpha2Ext = unchecked((uint)0x8044),
		Luminance8Alpha8 = unchecked((uint)0x8045),
		Luminance8Alpha8Ext = unchecked((uint)0x8045),
		Luminance8Alpha8Oes = unchecked((uint)0x8045),
		Luminance12Alpha4 = unchecked((uint)0x8046),
		Luminance12Alpha4Ext = unchecked((uint)0x8046),
		Luminance12Alpha12 = unchecked((uint)0x8047),
		Luminance12Alpha12Ext = unchecked((uint)0x8047),
		Luminance16Alpha16 = unchecked((uint)0x8048),
		Luminance16Alpha16Ext = unchecked((uint)0x8048),
		Intensity = unchecked((uint)0x8049),
		Intensity4 = unchecked((uint)0x804A),
		Intensity4Ext = unchecked((uint)0x804A),
		Intensity8 = unchecked((uint)0x804B),
		Intensity8Ext = unchecked((uint)0x804B),
		Intensity12 = unchecked((uint)0x804C),
		Intensity12Ext = unchecked((uint)0x804C),
		Intensity16 = unchecked((uint)0x804D),
		Intensity16Ext = unchecked((uint)0x804D),
		Rgb2Ext = unchecked((uint)0x804E),
		Rgb4 = unchecked((uint)0x804F),
		Rgb4Ext = unchecked((uint)0x804F),
		Rgb5 = unchecked((uint)0x8050),
		Rgb5Ext = unchecked((uint)0x8050),
		Rgb8 = unchecked((uint)0x8051),
		Rgb8Ext = unchecked((uint)0x8051),
		Rgb8Oes = unchecked((uint)0x8051),
		Rgb10 = unchecked((uint)0x8052),
		Rgb10Ext = unchecked((uint)0x8052),
		Rgb12 = unchecked((uint)0x8053),
		Rgb12Ext = unchecked((uint)0x8053),
		Rgb16 = unchecked((uint)0x8054),
		Rgb16Ext = unchecked((uint)0x8054),
		Rgba2 = unchecked((uint)0x8055),
		Rgba2Ext = unchecked((uint)0x8055),
		Rgba4 = unchecked((uint)0x8056),
		Rgba4Ext = unchecked((uint)0x8056),
		Rgba4Oes = unchecked((uint)0x8056),
		Rgb5A1 = unchecked((uint)0x8057),
		Rgb5A1Ext = unchecked((uint)0x8057),
		Rgb5A1Oes = unchecked((uint)0x8057),
		Rgba8 = unchecked((uint)0x8058),
		Rgba8Ext = unchecked((uint)0x8058),
		Rgba8Oes = unchecked((uint)0x8058),
		Rgb10A2 = unchecked((uint)0x8059),
		Rgb10A2Ext = unchecked((uint)0x8059),
		Rgba12 = unchecked((uint)0x805A),
		Rgba12Ext = unchecked((uint)0x805A),
		Rgba16 = unchecked((uint)0x805B),
		Rgba16Ext = unchecked((uint)0x805B),
		DualAlpha4Sgis = unchecked((uint)0x8110),
		DualAlpha8Sgis = unchecked((uint)0x8111),
		DualAlpha12Sgis = unchecked((uint)0x8112),
		DualAlpha16Sgis = unchecked((uint)0x8113),
		DualLuminance4Sgis = unchecked((uint)0x8114),
		DualLuminance8Sgis = unchecked((uint)0x8115),
		DualLuminance12Sgis = unchecked((uint)0x8116),
		DualLuminance16Sgis = unchecked((uint)0x8117),
		DualIntensity4Sgis = unchecked((uint)0x8118),
		DualIntensity8Sgis = unchecked((uint)0x8119),
		DualIntensity12Sgis = unchecked((uint)0x811A),
		DualIntensity16Sgis = unchecked((uint)0x811B),
		DualLuminanceAlpha4Sgis = unchecked((uint)0x811C),
		DualLuminanceAlpha8Sgis = unchecked((uint)0x811D),
		QuadAlpha4Sgis = unchecked((uint)0x811E),
		QuadAlpha8Sgis = unchecked((uint)0x811F),
		QuadLuminance4Sgis = unchecked((uint)0x8120),
		QuadLuminance8Sgis = unchecked((uint)0x8121),
		QuadIntensity4Sgis = unchecked((uint)0x8122),
		QuadIntensity8Sgis = unchecked((uint)0x8123),
		DepthComponent16 = unchecked((uint)0x81A5),
		DepthComponent16Arb = unchecked((uint)0x81A5),
		DepthComponent16Oes = unchecked((uint)0x81A5),
		DepthComponent16Sgix = unchecked((uint)0x81A5),
		DepthComponent24 = unchecked((uint)0x81A6),
		DepthComponent24Arb = unchecked((uint)0x81A6),
		DepthComponent24Oes = unchecked((uint)0x81A6),
		DepthComponent24Sgix = unchecked((uint)0x81A6),
		DepthComponent32 = unchecked((uint)0x81A7),
		DepthComponent32Arb = unchecked((uint)0x81A7),
		DepthComponent32Oes = unchecked((uint)0x81A7),
		DepthComponent32Sgix = unchecked((uint)0x81A7),
		CompressedRed = unchecked((uint)0x8225),
		CompressedRg = unchecked((uint)0x8226),
		Rg = unchecked((uint)0x8227),
		R8 = unchecked((uint)0x8229),
		R8Ext = unchecked((uint)0x8229),
		R16 = unchecked((uint)0x822A),
		R16Ext = unchecked((uint)0x822A),
		Rg8 = unchecked((uint)0x822B),
		Rg8Ext = unchecked((uint)0x822B),
		Rg16 = unchecked((uint)0x822C),
		Rg16Ext = unchecked((uint)0x822C),
		R16F = unchecked((uint)0x822D),
		R16FExt = unchecked((uint)0x822D),
		R32F = unchecked((uint)0x822E),
		R32FExt = unchecked((uint)0x822E),
		Rg16F = unchecked((uint)0x822F),
		Rg16FExt = unchecked((uint)0x822F),
		Rg32F = unchecked((uint)0x8230),
		Rg32FExt = unchecked((uint)0x8230),
		R8I = unchecked((uint)0x8231),
		R8Ui = unchecked((uint)0x8232),
		R16I = unchecked((uint)0x8233),
		R16Ui = unchecked((uint)0x8234),
		R32I = unchecked((uint)0x8235),
		R32Ui = unchecked((uint)0x8236),
		Rg8I = unchecked((uint)0x8237),
		Rg8Ui = unchecked((uint)0x8238),
		Rg16I = unchecked((uint)0x8239),
		Rg16Ui = unchecked((uint)0x823A),
		Rg32I = unchecked((uint)0x823B),
		Rg32Ui = unchecked((uint)0x823C),
		CompressedRgbS3TcDxt1Ext = unchecked((uint)0x83F0),
		CompressedRgbaS3TcDxt1Ext = unchecked((uint)0x83F1),
		CompressedRgbaS3TcDxt3Angle = unchecked((uint)0x83F2),
		CompressedRgbaS3TcDxt3Ext = unchecked((uint)0x83F2),
		CompressedRgbaS3TcDxt5Angle = unchecked((uint)0x83F3),
		CompressedRgbaS3TcDxt5Ext = unchecked((uint)0x83F3),
		CompressedRgb = unchecked((uint)0x84ED),
		CompressedRgba = unchecked((uint)0x84EE),
		DepthStencil = unchecked((uint)0x84F9),
		DepthStencilExt = unchecked((uint)0x84F9),
		DepthStencilNv = unchecked((uint)0x84F9),
		DepthStencilOes = unchecked((uint)0x84F9),
		DepthStencilMesa = unchecked((uint)0x8750),
		Rgba32F = unchecked((uint)0x8814),
		Rgba32FArb = unchecked((uint)0x8814),
		Rgba32FExt = unchecked((uint)0x8814),
		Rgb32F = unchecked((uint)0x8815),
		Rgb32FArb = unchecked((uint)0x8815),
		Rgb32FExt = unchecked((uint)0x8815),
		Rgba16F = unchecked((uint)0x881A),
		Rgba16FArb = unchecked((uint)0x881A),
		Rgba16FExt = unchecked((uint)0x881A),
		Rgb16F = unchecked((uint)0x881B),
		Rgb16FArb = unchecked((uint)0x881B),
		Rgb16FExt = unchecked((uint)0x881B),
		Depth24Stencil8 = unchecked((uint)0x88F0),
		Depth24Stencil8Ext = unchecked((uint)0x88F0),
		Depth24Stencil8Oes = unchecked((uint)0x88F0),
		R11FG11FB10F = unchecked((uint)0x8C3A),
		R11FG11FB10FApple = unchecked((uint)0x8C3A),
		R11FG11FB10FExt = unchecked((uint)0x8C3A),
		Rgb9E5 = unchecked((uint)0x8C3D),
		Rgb9E5Apple = unchecked((uint)0x8C3D),
		Rgb9E5Ext = unchecked((uint)0x8C3D),
		Srgb = unchecked((uint)0x8C40),
		SrgbExt = unchecked((uint)0x8C40),
		Srgb8 = unchecked((uint)0x8C41),
		Srgb8Ext = unchecked((uint)0x8C41),
		Srgb8Nv = unchecked((uint)0x8C41),
		SrgbAlpha = unchecked((uint)0x8C42),
		SrgbAlphaExt = unchecked((uint)0x8C42),
		Srgb8Alpha8 = unchecked((uint)0x8C43),
		Srgb8Alpha8Ext = unchecked((uint)0x8C43),
		CompressedSrgb = unchecked((uint)0x8C48),
		CompressedSrgbAlpha = unchecked((uint)0x8C49),
		CompressedSrgbS3TcDxt1Ext = unchecked((uint)0x8C4C),
		CompressedSrgbS3TcDxt1Nv = unchecked((uint)0x8C4C),
		CompressedSrgbAlphaS3TcDxt1Ext = unchecked((uint)0x8C4D),
		CompressedSrgbAlphaS3TcDxt1Nv = unchecked((uint)0x8C4D),
		CompressedSrgbAlphaS3TcDxt3Ext = unchecked((uint)0x8C4E),
		CompressedSrgbAlphaS3TcDxt3Nv = unchecked((uint)0x8C4E),
		CompressedSrgbAlphaS3TcDxt5Ext = unchecked((uint)0x8C4F),
		CompressedSrgbAlphaS3TcDxt5Nv = unchecked((uint)0x8C4F),
		DepthComponent32F = unchecked((uint)0x8CAC),
		Depth32FStencil8 = unchecked((uint)0x8CAD),
		StencilIndex1 = unchecked((uint)0x8D46),
		StencilIndex1Ext = unchecked((uint)0x8D46),
		StencilIndex1Oes = unchecked((uint)0x8D46),
		StencilIndex4 = unchecked((uint)0x8D47),
		StencilIndex4Ext = unchecked((uint)0x8D47),
		StencilIndex4Oes = unchecked((uint)0x8D47),
		StencilIndex8 = unchecked((uint)0x8D48),
		StencilIndex8Ext = unchecked((uint)0x8D48),
		StencilIndex8Oes = unchecked((uint)0x8D48),
		StencilIndex16 = unchecked((uint)0x8D49),
		StencilIndex16Ext = unchecked((uint)0x8D49),
		Rgb565Oes = unchecked((uint)0x8D62),
		Rgb565 = unchecked((uint)0x8D62),
		Etc1Rgb8Oes = unchecked((uint)0x8D64),
		Rgba32Ui = unchecked((uint)0x8D70),
		Rgba32UiExt = unchecked((uint)0x8D70),
		Rgb32Ui = unchecked((uint)0x8D71),
		Rgb32UiExt = unchecked((uint)0x8D71),
		Alpha32UiExt = unchecked((uint)0x8D72),
		Intensity32UiExt = unchecked((uint)0x8D73),
		Luminance32UiExt = unchecked((uint)0x8D74),
		LuminanceAlpha32UiExt = unchecked((uint)0x8D75),
		Rgba16Ui = unchecked((uint)0x8D76),
		Rgba16UiExt = unchecked((uint)0x8D76),
		Rgb16Ui = unchecked((uint)0x8D77),
		Rgb16UiExt = unchecked((uint)0x8D77),
		Alpha16UiExt = unchecked((uint)0x8D78),
		Intensity16UiExt = unchecked((uint)0x8D79),
		Luminance16UiExt = unchecked((uint)0x8D7A),
		LuminanceAlpha16UiExt = unchecked((uint)0x8D7B),
		Rgba8Ui = unchecked((uint)0x8D7C),
		Rgba8UiExt = unchecked((uint)0x8D7C),
		Rgb8Ui = unchecked((uint)0x8D7D),
		Rgb8UiExt = unchecked((uint)0x8D7D),
		Alpha8UiExt = unchecked((uint)0x8D7E),
		Intensity8UiExt = unchecked((uint)0x8D7F),
		Luminance8UiExt = unchecked((uint)0x8D80),
		LuminanceAlpha8UiExt = unchecked((uint)0x8D81),
		Rgba32I = unchecked((uint)0x8D82),
		Rgba32IExt = unchecked((uint)0x8D82),
		Rgb32I = unchecked((uint)0x8D83),
		Rgb32IExt = unchecked((uint)0x8D83),
		Alpha32IExt = unchecked((uint)0x8D84),
		Intensity32IExt = unchecked((uint)0x8D85),
		Luminance32IExt = unchecked((uint)0x8D86),
		LuminanceAlpha32IExt = unchecked((uint)0x8D87),
		Rgba16I = unchecked((uint)0x8D88),
		Rgba16IExt = unchecked((uint)0x8D88),
		Rgb16I = unchecked((uint)0x8D89),
		Rgb16IExt = unchecked((uint)0x8D89),
		Alpha16IExt = unchecked((uint)0x8D8A),
		Intensity16IExt = unchecked((uint)0x8D8B),
		Luminance16IExt = unchecked((uint)0x8D8C),
		LuminanceAlpha16IExt = unchecked((uint)0x8D8D),
		Rgba8I = unchecked((uint)0x8D8E),
		Rgba8IExt = unchecked((uint)0x8D8E),
		Rgb8I = unchecked((uint)0x8D8F),
		Rgb8IExt = unchecked((uint)0x8D8F),
		Alpha8IExt = unchecked((uint)0x8D90),
		Intensity8IExt = unchecked((uint)0x8D91),
		Luminance8IExt = unchecked((uint)0x8D92),
		LuminanceAlpha8IExt = unchecked((uint)0x8D93),
		DepthComponent32FNv = unchecked((uint)0x8DAB),
		Depth32FStencil8Nv = unchecked((uint)0x8DAC),
		CompressedRedRgtc1 = unchecked((uint)0x8DBB),
		CompressedRedRgtc1Ext = unchecked((uint)0x8DBB),
		CompressedSignedRedRgtc1 = unchecked((uint)0x8DBC),
		CompressedSignedRedRgtc1Ext = unchecked((uint)0x8DBC),
		CompressedRedGreenRgtc2Ext = unchecked((uint)0x8DBD),
		CompressedRgRgtc2 = unchecked((uint)0x8DBD),
		CompressedSignedRedGreenRgtc2Ext = unchecked((uint)0x8DBE),
		CompressedSignedRgRgtc2 = unchecked((uint)0x8DBE),
		CompressedRgbaBptcUnorm = unchecked((uint)0x8E8C),
		CompressedRgbaBptcUnormArb = unchecked((uint)0x8E8C),
		CompressedRgbaBptcUnormExt = unchecked((uint)0x8E8C),
		CompressedSrgbAlphaBptcUnorm = unchecked((uint)0x8E8D),
		CompressedSrgbAlphaBptcUnormArb = unchecked((uint)0x8E8D),
		CompressedSrgbAlphaBptcUnormExt = unchecked((uint)0x8E8D),
		CompressedRgbBptcSignedFloat = unchecked((uint)0x8E8E),
		CompressedRgbBptcSignedFloatArb = unchecked((uint)0x8E8E),
		CompressedRgbBptcSignedFloatExt = unchecked((uint)0x8E8E),
		CompressedRgbBptcUnsignedFloat = unchecked((uint)0x8E8F),
		CompressedRgbBptcUnsignedFloatArb = unchecked((uint)0x8E8F),
		CompressedRgbBptcUnsignedFloatExt = unchecked((uint)0x8E8F),
		R8Snorm = unchecked((uint)0x8F94),
		Rg8Snorm = unchecked((uint)0x8F95),
		Rgb8Snorm = unchecked((uint)0x8F96),
		Rgba8Snorm = unchecked((uint)0x8F97),
		R16Snorm = unchecked((uint)0x8F98),
		R16SnormExt = unchecked((uint)0x8F98),
		Rg16Snorm = unchecked((uint)0x8F99),
		Rg16SnormExt = unchecked((uint)0x8F99),
		Rgb16Snorm = unchecked((uint)0x8F9A),
		Rgb16SnormExt = unchecked((uint)0x8F9A),
		Rgba16Snorm = unchecked((uint)0x8F9B),
		Rgba16SnormExt = unchecked((uint)0x8F9B),
		Sr8Ext = unchecked((uint)0x8FBD),
		Srg8Ext = unchecked((uint)0x8FBE),
		Rgb10A2Ui = unchecked((uint)0x906F),
		CompressedR11Eac = unchecked((uint)0x9270),
		CompressedR11EacOes = unchecked((uint)0x9270),
		CompressedSignedR11Eac = unchecked((uint)0x9271),
		CompressedSignedR11EacOes = unchecked((uint)0x9271),
		CompressedRg11Eac = unchecked((uint)0x9272),
		CompressedRg11EacOes = unchecked((uint)0x9272),
		CompressedSignedRg11Eac = unchecked((uint)0x9273),
		CompressedSignedRg11EacOes = unchecked((uint)0x9273),
		CompressedRgb8Etc2 = unchecked((uint)0x9274),
		CompressedRgb8Etc2Oes = unchecked((uint)0x9274),
		CompressedSrgb8Etc2 = unchecked((uint)0x9275),
		CompressedSrgb8Etc2Oes = unchecked((uint)0x9275),
		CompressedRgb8PunchthroughAlpha1Etc2 = unchecked((uint)0x9276),
		CompressedRgb8PunchthroughAlpha1Etc2Oes = unchecked((uint)0x9276),
		CompressedSrgb8PunchthroughAlpha1Etc2 = unchecked((uint)0x9277),
		CompressedSrgb8PunchthroughAlpha1Etc2Oes = unchecked((uint)0x9277),
		CompressedRgba8Etc2Eac = unchecked((uint)0x9278),
		CompressedRgba8Etc2EacOes = unchecked((uint)0x9278),
		CompressedSrgb8Alpha8Etc2Eac = unchecked((uint)0x9279),
		CompressedSrgb8Alpha8Etc2EacOes = unchecked((uint)0x9279),
		CompressedRgbaAstc4X4 = unchecked((uint)0x93B0),
		CompressedRgbaAstc4X4Khr = unchecked((uint)0x93B0),
		CompressedRgbaAstc5X4 = unchecked((uint)0x93B1),
		CompressedRgbaAstc5X4Khr = unchecked((uint)0x93B1),
		CompressedRgbaAstc5X5 = unchecked((uint)0x93B2),
		CompressedRgbaAstc5X5Khr = unchecked((uint)0x93B2),
		CompressedRgbaAstc6X5 = unchecked((uint)0x93B3),
		CompressedRgbaAstc6X5Khr = unchecked((uint)0x93B3),
		CompressedRgbaAstc6X6 = unchecked((uint)0x93B4),
		CompressedRgbaAstc6X6Khr = unchecked((uint)0x93B4),
		CompressedRgbaAstc8X5 = unchecked((uint)0x93B5),
		CompressedRgbaAstc8X5Khr = unchecked((uint)0x93B5),
		CompressedRgbaAstc8X6 = unchecked((uint)0x93B6),
		CompressedRgbaAstc8X6Khr = unchecked((uint)0x93B6),
		CompressedRgbaAstc8X8 = unchecked((uint)0x93B7),
		CompressedRgbaAstc8X8Khr = unchecked((uint)0x93B7),
		CompressedRgbaAstc10X5 = unchecked((uint)0x93B8),
		CompressedRgbaAstc10X5Khr = unchecked((uint)0x93B8),
		CompressedRgbaAstc10X6 = unchecked((uint)0x93B9),
		CompressedRgbaAstc10X6Khr = unchecked((uint)0x93B9),
		CompressedRgbaAstc10X8 = unchecked((uint)0x93BA),
		CompressedRgbaAstc10X8Khr = unchecked((uint)0x93BA),
		CompressedRgbaAstc10X10 = unchecked((uint)0x93BB),
		CompressedRgbaAstc10X10Khr = unchecked((uint)0x93BB),
		CompressedRgbaAstc12X10 = unchecked((uint)0x93BC),
		CompressedRgbaAstc12X10Khr = unchecked((uint)0x93BC),
		CompressedRgbaAstc12X12 = unchecked((uint)0x93BD),
		CompressedRgbaAstc12X12Khr = unchecked((uint)0x93BD),
		CompressedRgbaAstc3X3X3Oes = unchecked((uint)0x93C0),
		CompressedRgbaAstc4X3X3Oes = unchecked((uint)0x93C1),
		CompressedRgbaAstc4X4X3Oes = unchecked((uint)0x93C2),
		CompressedRgbaAstc4X4X4Oes = unchecked((uint)0x93C3),
		CompressedRgbaAstc5X4X4Oes = unchecked((uint)0x93C4),
		CompressedRgbaAstc5X5X4Oes = unchecked((uint)0x93C5),
		CompressedRgbaAstc5X5X5Oes = unchecked((uint)0x93C6),
		CompressedRgbaAstc6X5X5Oes = unchecked((uint)0x93C7),
		CompressedRgbaAstc6X6X5Oes = unchecked((uint)0x93C8),
		CompressedRgbaAstc6X6X6Oes = unchecked((uint)0x93C9),
		CompressedSrgb8Alpha8Astc4X4 = unchecked((uint)0x93D0),
		CompressedSrgb8Alpha8Astc4X4Khr = unchecked((uint)0x93D0),
		CompressedSrgb8Alpha8Astc5X4 = unchecked((uint)0x93D1),
		CompressedSrgb8Alpha8Astc5X4Khr = unchecked((uint)0x93D1),
		CompressedSrgb8Alpha8Astc5X5 = unchecked((uint)0x93D2),
		CompressedSrgb8Alpha8Astc5X5Khr = unchecked((uint)0x93D2),
		CompressedSrgb8Alpha8Astc6X5 = unchecked((uint)0x93D3),
		CompressedSrgb8Alpha8Astc6X5Khr = unchecked((uint)0x93D3),
		CompressedSrgb8Alpha8Astc6X6 = unchecked((uint)0x93D4),
		CompressedSrgb8Alpha8Astc6X6Khr = unchecked((uint)0x93D4),
		CompressedSrgb8Alpha8Astc8X5 = unchecked((uint)0x93D5),
		CompressedSrgb8Alpha8Astc8X5Khr = unchecked((uint)0x93D5),
		CompressedSrgb8Alpha8Astc8X6 = unchecked((uint)0x93D6),
		CompressedSrgb8Alpha8Astc8X6Khr = unchecked((uint)0x93D6),
		CompressedSrgb8Alpha8Astc8X8 = unchecked((uint)0x93D7),
		CompressedSrgb8Alpha8Astc8X8Khr = unchecked((uint)0x93D7),
		CompressedSrgb8Alpha8Astc10X5 = unchecked((uint)0x93D8),
		CompressedSrgb8Alpha8Astc10X5Khr = unchecked((uint)0x93D8),
		CompressedSrgb8Alpha8Astc10X6 = unchecked((uint)0x93D9),
		CompressedSrgb8Alpha8Astc10X6Khr = unchecked((uint)0x93D9),
		CompressedSrgb8Alpha8Astc10X8 = unchecked((uint)0x93DA),
		CompressedSrgb8Alpha8Astc10X8Khr = unchecked((uint)0x93DA),
		CompressedSrgb8Alpha8Astc10X10 = unchecked((uint)0x93DB),
		CompressedSrgb8Alpha8Astc10X10Khr = unchecked((uint)0x93DB),
		CompressedSrgb8Alpha8Astc12X10 = unchecked((uint)0x93DC),
		CompressedSrgb8Alpha8Astc12X10Khr = unchecked((uint)0x93DC),
		CompressedSrgb8Alpha8Astc12X12 = unchecked((uint)0x93DD),
		CompressedSrgb8Alpha8Astc12X12Khr = unchecked((uint)0x93DD),
		CompressedSrgb8Alpha8Astc3X3X3Oes = unchecked((uint)0x93E0),
		CompressedSrgb8Alpha8Astc4X3X3Oes = unchecked((uint)0x93E1),
		CompressedSrgb8Alpha8Astc4X4X3Oes = unchecked((uint)0x93E2),
		CompressedSrgb8Alpha8Astc4X4X4Oes = unchecked((uint)0x93E3),
		CompressedSrgb8Alpha8Astc5X4X4Oes = unchecked((uint)0x93E4),
		CompressedSrgb8Alpha8Astc5X5X4Oes = unchecked((uint)0x93E5),
		CompressedSrgb8Alpha8Astc5X5X5Oes = unchecked((uint)0x93E6),
		CompressedSrgb8Alpha8Astc6X5X5Oes = unchecked((uint)0x93E7),
		CompressedSrgb8Alpha8Astc6X6X5Oes = unchecked((uint)0x93E8),
		CompressedSrgb8Alpha8Astc6X6X6Oes = unchecked((uint)0x93E9),
	}
}
