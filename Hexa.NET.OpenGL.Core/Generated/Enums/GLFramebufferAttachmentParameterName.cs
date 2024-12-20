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
	public enum GLFramebufferAttachmentParameterName : uint
	{
		/// <summary>
		/// Specifies the color encoding for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ColorEncoding = unchecked((uint)0x8210),

		/// <summary>
		/// Specifies the color encoding for framebuffer attachments (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		ColorEncodingExt = unchecked((uint)0x8210),

		/// <summary>
		/// Specifies the component type for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ComponentType = unchecked((uint)0x8211),

		/// <summary>
		/// Specifies the component type for framebuffer attachments (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		ComponentTypeExt = unchecked((uint)0x8211),

		/// <summary>
		/// Specifies the red size for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		RedSize = unchecked((uint)0x8212),

		/// <summary>
		/// Specifies the green size for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		GreenSize = unchecked((uint)0x8213),

		/// <summary>
		/// Specifies the blue size for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		BlueSize = unchecked((uint)0x8214),

		/// <summary>
		/// Specifies the alpha size for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		AlphaSize = unchecked((uint)0x8215),

		/// <summary>
		/// Specifies the depth size for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		DepthSize = unchecked((uint)0x8216),

		/// <summary>
		/// Specifies the stencil size for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		StencilSize = unchecked((uint)0x8217),

		/// <summary>
		/// Specifies the object type for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ObjectType = unchecked((uint)0x8CD0),

		/// <summary>
		/// Specifies the object type for framebuffer attachments (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ObjectTypeExt = unchecked((uint)0x8CD0),

		/// <summary>
		/// Specifies the object type for framebuffer attachments (OES extension).
		/// </summary>
		/// <remarks></remarks>
		ObjectTypeOes = unchecked((uint)0x8CD0),

		/// <summary>
		/// Specifies the object name for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		ObjectName = unchecked((uint)0x8CD1),

		/// <summary>
		/// Specifies the object name for framebuffer attachments (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		ObjectNameExt = unchecked((uint)0x8CD1),

		/// <summary>
		/// Specifies the object name for framebuffer attachments (OES extension).
		/// </summary>
		/// <remarks></remarks>
		ObjectNameOes = unchecked((uint)0x8CD1),

		/// <summary>
		/// Specifies the texture level for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		TextureLevel = unchecked((uint)0x8CD2),

		/// <summary>
		/// Specifies the texture level for framebuffer attachments (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		TextureLevelExt = unchecked((uint)0x8CD2),

		/// <summary>
		/// Specifies the texture level for framebuffer attachments (OES extension).
		/// </summary>
		/// <remarks></remarks>
		TextureLevelOes = unchecked((uint)0x8CD2),

		/// <summary>
		/// Specifies the cube map face for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object</remarks>
		TextureCubeMapFace = unchecked((uint)0x8CD3),

		/// <summary>
		/// Specifies the cube map face for framebuffer attachments (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		TextureCubeMapFaceExt = unchecked((uint)0x8CD3),

		/// <summary>
		/// Specifies the cube map face for framebuffer attachments (OES extension).
		/// </summary>
		/// <remarks></remarks>
		TextureCubeMapFaceOes = unchecked((uint)0x8CD3),

		/// <summary>
		/// Specifies the 3D texture Z-offset for framebuffer attachments (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_object</remarks>
		Texture3DZoffsetExt = unchecked((uint)0x8CD4),

		/// <summary>
		/// Specifies the 3D texture Z-offset for framebuffer attachments (OES extension).
		/// </summary>
		/// <remarks></remarks>
		Texture3DZoffsetOes = unchecked((uint)0x8CD4),

		/// <summary>
		/// Specifies the texture layer for framebuffer attachments.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_object<br/>GL_ARB_geometry_shader4</remarks>
		TextureLayer = unchecked((uint)0x8CD4),

		/// <summary>
		/// Specifies the texture layer for framebuffer attachments (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_geometry_shader4<br/>GL_EXT_texture_array<br/>GL_NV_geometry_program4</remarks>
		TextureLayerExt = unchecked((uint)0x8CD4),

		/// <summary>
		/// Specifies the number of samples of the texture attached to a framebuffer (EXT extension).
		/// </summary>
		/// <remarks></remarks>
		TextureSamplesExt = unchecked((uint)0x8D6C),

		/// <summary>
		/// Indicates that a framebuffer attachment is layered.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X</remarks>
		Layered = unchecked((uint)0x8DA7),

		/// <summary>
		/// Indicates that a framebuffer attachment is layered (ARB extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_geometry_shader4</remarks>
		LayeredArb = unchecked((uint)0x8DA7),

		/// <summary>
		/// Indicates that a framebuffer attachment is layered (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_geometry_shader4<br/>GL_NV_geometry_program4</remarks>
		LayeredExt = unchecked((uint)0x8DA7),

		/// <summary>
		/// Indicates that a framebuffer attachment is layered (OES extension).
		/// </summary>
		/// <remarks></remarks>
		LayeredOes = unchecked((uint)0x8DA7),

		/// <summary>
		/// Specifies the texture scale for framebuffer attachments (IMG extension).
		/// </summary>
		/// <remarks></remarks>
		TextureScaleImg = unchecked((uint)0x913F),

		/// <summary>
		/// Specifies the number of views for a framebuffer texture attachment (OVR extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OVR_multiview</remarks>
		TextureNumViewsOvr = unchecked((uint)0x9630),

		/// <summary>
		/// Specifies the base view index for a framebuffer texture attachment (OVR extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OVR_multiview</remarks>
		TextureBaseViewIndexOvr = unchecked((uint)0x9632),
	}
}
