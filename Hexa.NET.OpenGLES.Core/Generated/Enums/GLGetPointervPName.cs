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
	public enum GLGetPointervPName : uint
	{
		/// <summary>
		/// Specifies the pointer to the feedback buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		FeedbackBufferPointer = unchecked((uint)0x0DF0),

		/// <summary>
		/// Specifies the pointer to the selection buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		SelectionBufferPointer = unchecked((uint)0x0DF3),

		/// <summary>
		/// Specifies the pointer to the vertex array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		VertexArrayPointer = unchecked((uint)0x808E),

		/// <summary>
		/// Specifies the pointer to the vertex array for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_vertex_array</remarks>
		VertexArrayPointerExt = unchecked((uint)0x808E),

		/// <summary>
		/// Specifies the pointer to the normal array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		NormalArrayPointer = unchecked((uint)0x808F),

		/// <summary>
		/// Specifies the pointer to the normal array for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_vertex_array</remarks>
		NormalArrayPointerExt = unchecked((uint)0x808F),

		/// <summary>
		/// Specifies the pointer to the color array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ColorArrayPointer = unchecked((uint)0x8090),

		/// <summary>
		/// Specifies the pointer to the color array for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_vertex_array</remarks>
		ColorArrayPointerExt = unchecked((uint)0x8090),

		/// <summary>
		/// Specifies the pointer to the index array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		IndexArrayPointer = unchecked((uint)0x8091),

		/// <summary>
		/// Specifies the pointer to the index array for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_vertex_array</remarks>
		IndexArrayPointerExt = unchecked((uint)0x8091),

		/// <summary>
		/// Specifies the pointer to the texture coordinate array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TextureCoordArrayPointer = unchecked((uint)0x8092),

		/// <summary>
		/// Specifies the pointer to the texture coordinate array for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_vertex_array</remarks>
		TextureCoordArrayPointerExt = unchecked((uint)0x8092),

		/// <summary>
		/// Specifies the pointer to the edge flag array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		EdgeFlagArrayPointer = unchecked((uint)0x8093),

		/// <summary>
		/// Specifies the pointer to the edge flag array for EXT extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_vertex_array</remarks>
		EdgeFlagArrayPointerExt = unchecked((uint)0x8093),

		/// <summary>
		/// Specifies the pointer to the instrument buffer (SGIX extension).
		/// </summary>
		/// <remarks></remarks>
		InstrumentBufferPointerSgix = unchecked((uint)0x8180),

		/// <summary>
		/// Specifies the function to call for debug messages.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		DebugCallbackFunction = unchecked((uint)0x8244),

		/// <summary>
		/// Specifies user parameter for the debug callback function.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_KHR_debug</remarks>
		DebugCallbackUserParam = unchecked((uint)0x8245),
	}
}
