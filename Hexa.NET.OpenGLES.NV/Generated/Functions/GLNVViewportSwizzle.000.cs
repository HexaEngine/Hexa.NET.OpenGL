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

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVViewportSwizzle
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ViewportSwizzleNVNative(uint index, GLEnum swizzlex, GLEnum swizzley, GLEnum swizzlez, GLEnum swizzlew)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, GLEnum, GLEnum, GLEnum, void>)funcTable[0])(index, swizzlex, swizzley, swizzlez, swizzlew);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, GLEnum, GLEnum, GLEnum, void>)funcTable[0])(index, swizzlex, swizzley, swizzlez, swizzlew);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_swizzle</remarks>
		public void ViewportSwizzleNV(uint index, GLEnum swizzlex, GLEnum swizzley, GLEnum swizzlez, GLEnum swizzlew)
		{
			ViewportSwizzleNVNative(index, swizzlex, swizzley, swizzlez, swizzlew);
		}

	}
}
