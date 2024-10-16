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
	public static unsafe partial class GLEXTTextureObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte AreTexturesResidentEXTNative(int n, uint* textures, byte* residences)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<int, uint*, byte*, byte>)funcTable[0])(n, textures, residences);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<int, nint, nint, byte>)funcTable[0])(n, (nint)textures, (nint)residences);
			#endif
		}

		public static bool AreTexturesResidentEXT(int n, uint* textures, byte* residences)
		{
			byte ret = AreTexturesResidentEXTNative(n, textures, residences);
			return ret != 0;
		}

		public static bool AreTexturesResidentEXT(int n, ref uint textures, byte* residences)
		{
			fixed (uint* ptextures0 = &textures)
			{
				byte ret = AreTexturesResidentEXTNative(n, ptextures0, residences);
				return ret != 0;
			}
		}

		public static bool AreTexturesResidentEXT(int n, uint* textures, string residences)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (residences != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(residences);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(residences, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte ret = AreTexturesResidentEXTNative(n, textures, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		public static bool AreTexturesResidentEXT(int n, uint* textures, ReadOnlySpan<byte> residences)
		{
			fixed (byte* presidences0 = residences)
			{
				byte ret = AreTexturesResidentEXTNative(n, textures, presidences0);
				return ret != 0;
			}
		}

		public static bool AreTexturesResidentEXT(int n, uint* textures, ref byte residences)
		{
			fixed (byte* presidences0 = &residences)
			{
				byte ret = AreTexturesResidentEXTNative(n, textures, presidences0);
				return ret != 0;
			}
		}

		public static bool AreTexturesResidentEXT(int n, ref uint textures, ref byte residences)
		{
			fixed (uint* ptextures0 = &textures)
			{
				fixed (byte* presidences1 = &residences)
				{
					byte ret = AreTexturesResidentEXTNative(n, ptextures0, presidences1);
					return ret != 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindTextureEXTNative(GLTextureTarget target, uint texture)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, uint, void>)funcTable[1])(target, texture);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, uint, void>)funcTable[1])(target, texture);
			#endif
		}

		public static void BindTextureEXT(GLTextureTarget target, uint texture)
		{
			BindTextureEXTNative(target, texture);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteTexturesEXTNative(int n, uint* textures)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[2])(n, textures);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(n, (nint)textures);
			#endif
		}

		public static void DeleteTexturesEXT(int n, uint* textures)
		{
			DeleteTexturesEXTNative(n, textures);
		}

		public static void DeleteTexturesEXT(int n, ref uint textures)
		{
			fixed (uint* ptextures0 = &textures)
			{
				DeleteTexturesEXTNative(n, ptextures0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenTexturesEXTNative(int n, uint* textures)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[3])(n, textures);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[3])(n, (nint)textures);
			#endif
		}

		public static void GenTexturesEXT(int n, uint* textures)
		{
			GenTexturesEXTNative(n, textures);
		}

		public static void GenTexturesEXT(int n, ref uint textures)
		{
			fixed (uint* ptextures0 = &textures)
			{
				GenTexturesEXTNative(n, ptextures0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsTextureEXTNative(uint texture)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[4])(texture);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[4])(texture);
			#endif
		}

		public static bool IsTextureEXT(uint texture)
		{
			byte ret = IsTextureEXTNative(texture);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PrioritizeTexturesEXTNative(int n, uint* textures, float* priorities)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, float*, void>)funcTable[5])(n, textures, priorities);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, nint, void>)funcTable[5])(n, (nint)textures, (nint)priorities);
			#endif
		}

		public static void PrioritizeTexturesEXT(int n, uint* textures, float* priorities)
		{
			PrioritizeTexturesEXTNative(n, textures, priorities);
		}

		public static void PrioritizeTexturesEXT(int n, ref uint textures, float* priorities)
		{
			fixed (uint* ptextures0 = &textures)
			{
				PrioritizeTexturesEXTNative(n, ptextures0, priorities);
			}
		}

		public static void PrioritizeTexturesEXT(int n, uint* textures, ref float priorities)
		{
			fixed (float* ppriorities0 = &priorities)
			{
				PrioritizeTexturesEXTNative(n, textures, ppriorities0);
			}
		}

		public static void PrioritizeTexturesEXT(int n, ref uint textures, ref float priorities)
		{
			fixed (uint* ptextures0 = &textures)
			{
				fixed (float* ppriorities1 = &priorities)
				{
					PrioritizeTexturesEXTNative(n, ptextures0, ppriorities1);
				}
			}
		}

	}
}