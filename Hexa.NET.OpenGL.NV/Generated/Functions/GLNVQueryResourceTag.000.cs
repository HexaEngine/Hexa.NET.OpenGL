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
	public static unsafe partial class GLNVQueryResourceTag
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteQueryResourceTagNVNative(int n, int* tagIds)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int*, void>)funcTable[0])(n, tagIds);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[0])(n, (nint)tagIds);
			#endif
		}

		public static void DeleteQueryResourceTagNV(int n, int* tagIds)
		{
			DeleteQueryResourceTagNVNative(n, tagIds);
		}

		public static void DeleteQueryResourceTagNV(int n, ref int tagIds)
		{
			fixed (int* ptagIds0 = &tagIds)
			{
				DeleteQueryResourceTagNVNative(n, ptagIds0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenQueryResourceTagNVNative(int n, int* tagIds)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int*, void>)funcTable[1])(n, tagIds);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)tagIds);
			#endif
		}

		public static void GenQueryResourceTagNV(int n, int* tagIds)
		{
			GenQueryResourceTagNVNative(n, tagIds);
		}

		public static void GenQueryResourceTagNV(int n, ref int tagIds)
		{
			fixed (int* ptagIds0 = &tagIds)
			{
				GenQueryResourceTagNVNative(n, ptagIds0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void QueryResourceTagNVNative(int tagId, byte* tagString)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, byte*, void>)funcTable[2])(tagId, tagString);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(tagId, (nint)tagString);
			#endif
		}

		public static void QueryResourceTagNV(int tagId, byte* tagString)
		{
			QueryResourceTagNVNative(tagId, tagString);
		}

		public static void QueryResourceTagNV(int tagId, string tagString)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (tagString != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(tagString);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(tagString, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			QueryResourceTagNVNative(tagId, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void QueryResourceTagNV(int tagId, ReadOnlySpan<byte> tagString)
		{
			fixed (byte* ptagString0 = tagString)
			{
				QueryResourceTagNVNative(tagId, ptagString0);
			}
		}

		public static void QueryResourceTagNV(int tagId, ref byte tagString)
		{
			fixed (byte* ptagString0 = &tagString)
			{
				QueryResourceTagNVNative(tagId, ptagString0);
			}
		}

	}
}
