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

namespace Hexa.NET.OpenGL
{
	public static unsafe partial class GL
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WindowPos3svNative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[723])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[723])((nint)v);
			#endif
		}

		public static void WindowPos3sv(short* v)
		{
			WindowPos3svNative(v);
		}

		public static void WindowPos3sv(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				WindowPos3svNative(pv0);
			}
		}

	}
}