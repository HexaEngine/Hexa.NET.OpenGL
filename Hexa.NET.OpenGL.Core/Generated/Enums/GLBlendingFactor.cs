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
	public enum GLBlendingFactor : uint
	{
		/// <summary>
		/// Numeric zero value.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_NV_blend_equation_advanced<br/>GL_NV_register_combiners</remarks>
		Zero = unchecked((uint)0),

		/// <summary>
		/// Numeric one value.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		One = unchecked((uint)1),

		/// <summary>
		/// Source color for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		SrcColor = unchecked((uint)0x0300),

		/// <summary>
		/// One minus the source color for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		OneMinusSrcColor = unchecked((uint)0x0301),

		/// <summary>
		/// Source alpha for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		SrcAlpha = unchecked((uint)0x0302),

		/// <summary>
		/// One minus the source alpha for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		OneMinusSrcAlpha = unchecked((uint)0x0303),

		/// <summary>
		/// Destination alpha for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		DstAlpha = unchecked((uint)0x0304),

		/// <summary>
		/// One minus the destination alpha for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		OneMinusDstAlpha = unchecked((uint)0x0305),

		/// <summary>
		/// Destination color for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		DstColor = unchecked((uint)0x0306),

		/// <summary>
		/// One minus the destination color for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		OneMinusDstColor = unchecked((uint)0x0307),

		/// <summary>
		/// Source alpha saturate for blending operations.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.</remarks>
		SrcAlphaSaturate = unchecked((uint)0x0308),

		/// <summary>
		/// Specifies a constant color for blending.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.4 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_imaging</remarks>
		ConstantColor = unchecked((uint)0x8001),

		/// <summary>
		/// Specifies one minus the constant color for blending.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.4 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_imaging</remarks>
		OneMinusConstantColor = unchecked((uint)0x8002),

		/// <summary>
		/// Specifies a constant alpha value for blending.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.4 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_imaging</remarks>
		ConstantAlpha = unchecked((uint)0x8003),

		/// <summary>
		/// Specifies one minus the constant alpha for blending.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.4 - GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_imaging</remarks>
		OneMinusConstantAlpha = unchecked((uint)0x8004),

		/// <summary>
		/// Specifies the second alpha source input.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 1.5<br/>GL 2.X<br/>GL 3.X<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		Src1Alpha = unchecked((uint)0x8589),

		/// <summary>
		/// Specifies the second source color for blending.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		Src1Color = unchecked((uint)0x88F9),

		/// <summary>
		/// Specifies the one minus second source color for blending.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		OneMinusSrc1Color = unchecked((uint)0x88FA),

		/// <summary>
		/// Specifies the one minus second source alpha for blending.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		OneMinusSrc1Alpha = unchecked((uint)0x88FB),
	}
}
