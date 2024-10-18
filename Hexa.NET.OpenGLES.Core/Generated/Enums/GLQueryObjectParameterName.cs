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
	public enum GLQueryObjectParameterName : uint
	{
		/// <summary>
		/// Specifies the target for queries.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_direct_state_access</remarks>
		Target = unchecked((uint)0x82EA),

		/// <summary>
		/// Specifies the result of the query.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		Result = unchecked((uint)0x8866),

		/// <summary>
		/// Specifies if the query result is available.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ResultAvailable = unchecked((uint)0x8867),

		/// <summary>
		/// Specifies that query results are returned without waiting.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_query_buffer_object</remarks>
		ResultNoWait = unchecked((uint)0x9194),
	}
}
