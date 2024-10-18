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
using System.Runtime.CompilerServices;
using System.Numerics;

namespace Hexa.NET.OpenGL.EXT
{
	public static unsafe partial class GLEXTStencilTwoSide
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ActiveStencilFaceEXTNative(GLTriangleFace face)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTriangleFace, void>)funcTable[0])(face);
			#else
			((delegate* unmanaged[Cdecl]<GLTriangleFace, void>)funcTable[0])(face);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_stencil_two_side</remarks>
		public static void ActiveStencilFaceEXT(GLTriangleFace face)
		{
			ActiveStencilFaceEXTNative(face);
		}

	}
}
