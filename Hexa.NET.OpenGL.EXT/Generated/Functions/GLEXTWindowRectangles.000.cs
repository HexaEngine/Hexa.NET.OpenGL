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
	public static unsafe partial class GLEXTWindowRectangles
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowRectanglesEXTNative(GLEnum mode, int count, int* box)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, int*, void>)funcTable[0])(mode, count, box);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, nint, void>)funcTable[0])(mode, count, (nint)box);
			#endif
		}

		public static void WindowRectanglesEXT(GLEnum mode, int count, int* box)
		{
			WindowRectanglesEXTNative(mode, count, box);
		}

		public static void WindowRectanglesEXT(GLEnum mode, int count, ref int box)
		{
			fixed (int* pbox0 = &box)
			{
				WindowRectanglesEXTNative(mode, count, pbox0);
			}
		}

	}
}
