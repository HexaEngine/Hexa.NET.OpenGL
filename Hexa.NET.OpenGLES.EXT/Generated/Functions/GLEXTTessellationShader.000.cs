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

namespace Hexa.NET.OpenGLES.EXT
{
	public static unsafe partial class GLEXTTessellationShader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PatchParameteriEXTNative(GLPatchParameterName pname, int value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPatchParameterName, int, void>)funcTable[0])(pname, value);
			#else
			((delegate* unmanaged[Cdecl]<GLPatchParameterName, int, void>)funcTable[0])(pname, value);
			#endif
		}

		public static void PatchParameteriEXT(GLPatchParameterName pname, int value)
		{
			PatchParameteriEXTNative(pname, value);
		}

	}
}
