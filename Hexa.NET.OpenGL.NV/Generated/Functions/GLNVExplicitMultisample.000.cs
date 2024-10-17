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
	public static unsafe partial class GLNVExplicitMultisample
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetMultisamplefvNVNative(GLGetMultisamplePNameNV pname, uint index, float* val)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLGetMultisamplePNameNV, uint, float*, void>)funcTable[0])(pname, index, val);
			#else
			((delegate* unmanaged[Cdecl]<GLGetMultisamplePNameNV, uint, nint, void>)funcTable[0])(pname, index, (nint)val);
			#endif
		}

		public static void GetMultisamplefvNV(GLGetMultisamplePNameNV pname, uint index, float* val)
		{
			GetMultisamplefvNVNative(pname, index, val);
		}

		public static void GetMultisamplefvNV(GLGetMultisamplePNameNV pname, uint index, Span<float> val)
		{
			fixed (float* pval0 = val)
			{
				GetMultisamplefvNVNative(pname, index, pval0);
			}
		}

		public static void GetMultisamplefvNV(GLGetMultisamplePNameNV pname, uint index, ref float val)
		{
			fixed (float* pval0 = &val)
			{
				GetMultisamplefvNVNative(pname, index, pval0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SampleMaskIndexedNVNative(uint index, uint mask)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[1])(index, mask);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[1])(index, mask);
			#endif
		}

		public static void SampleMaskIndexedNV(uint index, uint mask)
		{
			SampleMaskIndexedNVNative(index, mask);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexRenderbufferNVNative(GLTextureTarget target, uint renderbuffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, uint, void>)funcTable[2])(target, renderbuffer);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, uint, void>)funcTable[2])(target, renderbuffer);
			#endif
		}

		public static void TexRenderbufferNV(GLTextureTarget target, uint renderbuffer)
		{
			TexRenderbufferNVNative(target, renderbuffer);
		}

	}
}
