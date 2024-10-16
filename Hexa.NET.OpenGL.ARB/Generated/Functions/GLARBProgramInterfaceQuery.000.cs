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

namespace Hexa.NET.OpenGL.ARB
{
	public static unsafe partial class GLARBProgramInterfaceQuery
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramInterfaceivNative(uint program, GLProgramInterface programInterface, GLProgramInterfacePName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, GLProgramInterfacePName, int*, void>)funcTable[0])(program, programInterface, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, GLProgramInterfacePName, nint, void>)funcTable[0])(program, programInterface, pname, (nint)@params);
			#endif
		}

		public static void GetProgramInterfaceiv(uint program, GLProgramInterface programInterface, GLProgramInterfacePName pname, int* @params)
		{
			GetProgramInterfaceivNative(program, programInterface, pname, @params);
		}

		public static void GetProgramInterfaceiv(uint program, GLProgramInterface programInterface, GLProgramInterfacePName pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetProgramInterfaceivNative(program, programInterface, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint GetProgramResourceIndexNative(uint program, GLProgramInterface programInterface, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, byte*, uint>)funcTable[1])(program, programInterface, name);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, nint, uint>)funcTable[1])(program, programInterface, (nint)name);
			#endif
		}

		public static uint GetProgramResourceIndex(uint program, GLProgramInterface programInterface, byte* name)
		{
			uint ret = GetProgramResourceIndexNative(program, programInterface, name);
			return ret;
		}

		public static uint GetProgramResourceIndex(uint program, GLProgramInterface programInterface, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			uint ret = GetProgramResourceIndexNative(program, programInterface, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static uint GetProgramResourceIndex(uint program, GLProgramInterface programInterface, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				uint ret = GetProgramResourceIndexNative(program, programInterface, pname0);
				return ret;
			}
		}

		public static uint GetProgramResourceIndex(uint program, GLProgramInterface programInterface, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				uint ret = GetProgramResourceIndexNative(program, programInterface, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetProgramResourceLocationNative(uint program, GLProgramInterface programInterface, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, byte*, int>)funcTable[2])(program, programInterface, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, nint, int>)funcTable[2])(program, programInterface, (nint)name);
			#endif
		}

		public static int GetProgramResourceLocation(uint program, GLProgramInterface programInterface, byte* name)
		{
			int ret = GetProgramResourceLocationNative(program, programInterface, name);
			return ret;
		}

		public static int GetProgramResourceLocation(uint program, GLProgramInterface programInterface, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = GetProgramResourceLocationNative(program, programInterface, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static int GetProgramResourceLocation(uint program, GLProgramInterface programInterface, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetProgramResourceLocationNative(program, programInterface, pname0);
				return ret;
			}
		}

		public static int GetProgramResourceLocation(uint program, GLProgramInterface programInterface, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetProgramResourceLocationNative(program, programInterface, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetProgramResourceLocationIndexNative(uint program, GLProgramInterface programInterface, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, byte*, int>)funcTable[3])(program, programInterface, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, nint, int>)funcTable[3])(program, programInterface, (nint)name);
			#endif
		}

		public static int GetProgramResourceLocationIndex(uint program, GLProgramInterface programInterface, byte* name)
		{
			int ret = GetProgramResourceLocationIndexNative(program, programInterface, name);
			return ret;
		}

		public static int GetProgramResourceLocationIndex(uint program, GLProgramInterface programInterface, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = GetProgramResourceLocationIndexNative(program, programInterface, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static int GetProgramResourceLocationIndex(uint program, GLProgramInterface programInterface, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetProgramResourceLocationIndexNative(program, programInterface, pname0);
				return ret;
			}
		}

		public static int GetProgramResourceLocationIndex(uint program, GLProgramInterface programInterface, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetProgramResourceLocationIndexNative(program, programInterface, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramResourceNameNative(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, uint, int, int*, byte*, void>)funcTable[4])(program, programInterface, index, bufSize, length, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, uint, int, nint, nint, void>)funcTable[4])(program, programInterface, index, bufSize, (nint)length, (nint)name);
			#endif
		}

		public static void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, byte* name)
		{
			GetProgramResourceNameNative(program, programInterface, index, bufSize, length, name);
		}

		public static void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, ref int length, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				GetProgramResourceNameNative(program, programInterface, index, bufSize, plength0, name);
			}
		}

		public static void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetProgramResourceNameNative(program, programInterface, index, bufSize, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				GetProgramResourceNameNative(program, programInterface, index, bufSize, length, pname0);
			}
		}

		public static void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				GetProgramResourceNameNative(program, programInterface, index, bufSize, length, pname0);
			}
		}

		public static void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, ref int length, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pname1 = &name)
				{
					GetProgramResourceNameNative(program, programInterface, index, bufSize, plength0, pname1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramResourceivNative(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, int* length, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, uint, int, GLProgramResourceProperty, int, int*, int*, void>)funcTable[5])(program, programInterface, index, propCount, props, count, length, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, uint, int, GLProgramResourceProperty, int, nint, nint, void>)funcTable[5])(program, programInterface, index, propCount, props, count, (nint)length, (nint)@params);
			#endif
		}

		public static void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, int* length, int* @params)
		{
			GetProgramResourceivNative(program, programInterface, index, propCount, props, count, length, @params);
		}

		public static void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, ref int length, int* @params)
		{
			fixed (int* plength0 = &length)
			{
				GetProgramResourceivNative(program, programInterface, index, propCount, props, count, plength0, @params);
			}
		}

		public static void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, int* length, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetProgramResourceivNative(program, programInterface, index, propCount, props, count, length, pparams0);
			}
		}

		public static void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, ref int length, ref int @params)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* pparams1 = &@params)
				{
					GetProgramResourceivNative(program, programInterface, index, propCount, props, count, plength0, pparams1);
				}
			}
		}

	}
}
