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

namespace Hexa.NET.OpenGL.AMD
{
	public unsafe partial class GLAMDStencilOperationExtended
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void StencilOpValueAMDNative(GLTriangleFace face, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTriangleFace, uint, void>)funcTable[0])(face, value);
			#else
			((delegate* unmanaged[Cdecl]<GLTriangleFace, uint, void>)funcTable[0])(face, value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_stencil_operation_extended</remarks>
		public void StencilOpValueAMD(GLTriangleFace face, uint value)
		{
			StencilOpValueAMDNative(face, value);
		}

	}
}
