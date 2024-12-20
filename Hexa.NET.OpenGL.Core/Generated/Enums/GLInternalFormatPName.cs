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
	public enum GLInternalFormatPName : uint
	{
		/// <summary>
		/// Specifies the number of samples in a sample buffer.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.3 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		Samples = unchecked((uint)0x80A9),

		/// <summary>
		/// Specifies the generation of mipmaps.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.4 - GL 1.5<br/>GL 2.X<br/>GL 3.0 - GL 3.1<br/>GL 3.2 Compat - GL 3.3 Compat<br/>GL 4.X Compat</remarks>
		GenerateMipmap = unchecked((uint)0x8191),

		/// <summary>
		/// Specifies if a given internal format is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		Supported = unchecked((uint)0x826F),

		/// <summary>
		/// Specifies the preferred internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		Preferred = unchecked((uint)0x8270),

		/// <summary>
		/// Specifies the size of the red component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		RedSize = unchecked((uint)0x8271),

		/// <summary>
		/// Specifies the size of the green component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		GreenSize = unchecked((uint)0x8272),

		/// <summary>
		/// Specifies the size of the blue component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		BlueSize = unchecked((uint)0x8273),

		/// <summary>
		/// Specifies the size of the alpha component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		AlphaSize = unchecked((uint)0x8274),

		/// <summary>
		/// Specifies the size of the depth component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		DepthSize = unchecked((uint)0x8275),

		/// <summary>
		/// Specifies the size of the stencil component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		StencilSize = unchecked((uint)0x8276),

		/// <summary>
		/// Specifies the size of shared components in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		SharedSize = unchecked((uint)0x8277),

		/// <summary>
		/// Specifies the type of the red component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		RedType = unchecked((uint)0x8278),

		/// <summary>
		/// Specifies the type of the green component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		GreenType = unchecked((uint)0x8279),

		/// <summary>
		/// Specifies the type of the blue component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		BlueType = unchecked((uint)0x827A),

		/// <summary>
		/// Specifies the type of the alpha component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		AlphaType = unchecked((uint)0x827B),

		/// <summary>
		/// Specifies the type of the depth component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		DepthType = unchecked((uint)0x827C),

		/// <summary>
		/// Specifies the type of the stencil component in an internal format.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		StencilType = unchecked((uint)0x827D),

		/// <summary>
		/// Specifies the maximum width of textures.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		MaxWidth = unchecked((uint)0x827E),

		/// <summary>
		/// Specifies the maximum height of textures.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		MaxHeight = unchecked((uint)0x827F),

		/// <summary>
		/// Specifies the maximum depth of textures.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		MaxDepth = unchecked((uint)0x8280),

		/// <summary>
		/// Specifies the maximum number of layers in 3D textures.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		MaxLayers = unchecked((uint)0x8281),

		/// <summary>
		/// Specifies the number of color components.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ColorComponents = unchecked((uint)0x8283),

		/// <summary>
		/// Specifies if color rendering is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ColorRenderable = unchecked((uint)0x8286),

		/// <summary>
		/// Specifies if depth rendering is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		DepthRenderable = unchecked((uint)0x8287),

		/// <summary>
		/// Specifies if stencil rendering is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		StencilRenderable = unchecked((uint)0x8288),

		/// <summary>
		/// Specifies if the framebuffer is renderable.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		FramebufferRenderable = unchecked((uint)0x8289),

		/// <summary>
		/// Specifies if the framebuffer is renderable and layered.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		FramebufferRenderableLayered = unchecked((uint)0x828A),

		/// <summary>
		/// Specifies if framebuffer blending is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		FramebufferBlend = unchecked((uint)0x828B),

		/// <summary>
		/// Specifies the read pixels operation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ReadPixels = unchecked((uint)0x828C),

		/// <summary>
		/// Specifies the format for reading pixels.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ReadPixelsFormat = unchecked((uint)0x828D),

		/// <summary>
		/// Specifies the data type for reading pixels.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ReadPixelsType = unchecked((uint)0x828E),

		/// <summary>
		/// Specifies the format of a texture image.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureImageFormat = unchecked((uint)0x828F),

		/// <summary>
		/// Specifies the data type of a texture image.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureImageType = unchecked((uint)0x8290),

		/// <summary>
		/// Specifies the format for getting a texture image.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		GetTextureImageFormat = unchecked((uint)0x8291),

		/// <summary>
		/// Specifies the data type for getting a texture image.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		GetTextureImageType = unchecked((uint)0x8292),

		/// <summary>
		/// Specifies the mipmap generation behavior.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		Mipmap = unchecked((uint)0x8293),

		/// <summary>
		/// Specifies automatic mipmap generation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		AutoGenerateMipmap = unchecked((uint)0x8295),

		/// <summary>
		/// Specifies the color encoding method.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ColorEncoding = unchecked((uint)0x8296),

		/// <summary>
		/// Specifies if sRGB read is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		SrgbRead = unchecked((uint)0x8297),

		/// <summary>
		/// Specifies if sRGB write is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		SrgbWrite = unchecked((uint)0x8298),

		/// <summary>
		/// Specifies the filtering method for textures.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		Filter = unchecked((uint)0x829A),

		/// <summary>
		/// Specifies if vertex textures are supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		VertexTexture = unchecked((uint)0x829B),

		/// <summary>
		/// Specifies if tessellation control textures are supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TessControlTexture = unchecked((uint)0x829C),

		/// <summary>
		/// Specifies if tessellation evaluation textures are supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TessEvaluationTexture = unchecked((uint)0x829D),

		/// <summary>
		/// Specifies if geometry textures are supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		GeometryTexture = unchecked((uint)0x829E),

		/// <summary>
		/// Specifies if fragment textures are supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		FragmentTexture = unchecked((uint)0x829F),

		/// <summary>
		/// Specifies if compute textures are supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ComputeTexture = unchecked((uint)0x82A0),

		/// <summary>
		/// Specifies if shadow textures are supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureShadow = unchecked((uint)0x82A1),

		/// <summary>
		/// Specifies if texture gathering is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureGather = unchecked((uint)0x82A2),

		/// <summary>
		/// Specifies if shadow texture gathering is supported.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureGatherShadow = unchecked((uint)0x82A3),

		/// <summary>
		/// Specifies the shader image load operation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ShaderImageLoad = unchecked((uint)0x82A4),

		/// <summary>
		/// Specifies the shader image store operation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ShaderImageStore = unchecked((uint)0x82A5),

		/// <summary>
		/// Specifies atomic operations on shader images.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ShaderImageAtomic = unchecked((uint)0x82A6),

		/// <summary>
		/// Specifies the size of texels in images.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ImageTexelSize = unchecked((uint)0x82A7),

		/// <summary>
		/// Specifies the compatibility class for images.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ImageCompatibilityClass = unchecked((uint)0x82A8),

		/// <summary>
		/// Specifies the pixel format of an image.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ImagePixelFormat = unchecked((uint)0x82A9),

		/// <summary>
		/// Specifies the pixel type of an image.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ImagePixelType = unchecked((uint)0x82AA),

		/// <summary>
		/// Specifies simultaneous texture and depth testing behavior.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		SimultaneousTextureAndDepthTest = unchecked((uint)0x82AC),

		/// <summary>
		/// Specifies simultaneous texture and stencil testing behavior.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		SimultaneousTextureAndStencilTest = unchecked((uint)0x82AD),

		/// <summary>
		/// Specifies simultaneous texture and depth writing behavior.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		SimultaneousTextureAndDepthWrite = unchecked((uint)0x82AE),

		/// <summary>
		/// Specifies simultaneous texture and stencil writing behavior.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		SimultaneousTextureAndStencilWrite = unchecked((uint)0x82AF),

		/// <summary>
		/// Specifies the width of a compressed texture block.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureCompressedBlockWidth = unchecked((uint)0x82B1),

		/// <summary>
		/// Specifies the height of a compressed texture block.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureCompressedBlockHeight = unchecked((uint)0x82B2),

		/// <summary>
		/// Specifies the size of a compressed texture block.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureCompressedBlockSize = unchecked((uint)0x82B3),

		/// <summary>
		/// Specifies the clear buffer operation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ClearBuffer = unchecked((uint)0x82B4),

		/// <summary>
		/// Specifies the texture view operation.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureView = unchecked((uint)0x82B5),

		/// <summary>
		/// Specifies the compatibility class for views.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		ViewCompatibilityClass = unchecked((uint)0x82B6),

		/// <summary>
		/// Indicates if a texture is compressed.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.3 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		TextureCompressed = unchecked((uint)0x86A1),

		/// <summary>
		/// Specifies the number of fixed rates for surface compression (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		NumSurfaceCompressionFixedRatesExt = unchecked((uint)0x8F6E),

		/// <summary>
		/// Specifies the compatibility type for image formats.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2<br/>GL_ARB_shader_image_load_store</remarks>
		ImageFormatCompatibilityType = unchecked((uint)0x90C7),

		/// <summary>
		/// Clears a texture to a specified value.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.4 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_clear_texture</remarks>
		ClearTexture = unchecked((uint)0x9365),

		/// <summary>
		/// Specifies the number of supported sample counts.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query<br/>GL_ARB_internalformat_query2</remarks>
		NumSampleCounts = unchecked((uint)0x9380),
	}
}
