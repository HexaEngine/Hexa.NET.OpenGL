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
	public static unsafe partial class GLEXTProvokingVertex
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProvokingVertexEXTNative(GLVertexProvokingMode mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLVertexProvokingMode, void>)funcTable[0])(mode);
			#else
			((delegate* unmanaged[Cdecl]<GLVertexProvokingMode, void>)funcTable[0])(mode);
			#endif
		}

		public static void ProvokingVertexEXT(GLVertexProvokingMode mode)
		{
			ProvokingVertexEXTNative(mode);
		}

	}
}