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

namespace Hexa.NET.OpenGL.NV
{
	public static unsafe partial class GLNVTextureBarrier
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureBarrierNVNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[0])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[0])();
			#endif
		}

		public static void TextureBarrierNV()
		{
			TextureBarrierNVNative();
		}

	}
}
