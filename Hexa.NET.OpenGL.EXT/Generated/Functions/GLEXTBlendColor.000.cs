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
	public static unsafe partial class GLEXTBlendColor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BlendColorEXTNative(float red, float green, float blue, float alpha)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, float, void>)funcTable[0])(red, green, blue, alpha);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, float, void>)funcTable[0])(red, green, blue, alpha);
			#endif
		}

		public static void BlendColorEXT(float red, float green, float blue, float alpha)
		{
			BlendColorEXTNative(red, green, blue, alpha);
		}

	}
}
