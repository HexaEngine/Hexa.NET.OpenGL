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
	public static unsafe partial class GLEXTPolygonOffsetClamp
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PolygonOffsetClampEXTNative(float factor, float units, float clamp)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[0])(factor, units, clamp);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[0])(factor, units, clamp);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_polygon_offset_clamp</remarks>
		public static void PolygonOffsetClampEXT(float factor, float units, float clamp)
		{
			PolygonOffsetClampEXTNative(factor, units, clamp);
		}

	}
}
