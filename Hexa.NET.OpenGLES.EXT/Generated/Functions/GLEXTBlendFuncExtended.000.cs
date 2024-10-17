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
	public static unsafe partial class GLEXTBlendFuncExtended
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindFragDataLocationEXTNative(uint program, uint color, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, byte*, void>)funcTable[0])(program, color, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, nint, void>)funcTable[0])(program, color, (nint)name);
			#endif
		}

		public static void BindFragDataLocationEXT(uint program, uint color, byte* name)
		{
			BindFragDataLocationEXTNative(program, color, name);
		}

		public static void BindFragDataLocationEXT(uint program, uint color, string name)
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
			BindFragDataLocationEXTNative(program, color, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void BindFragDataLocationEXT(uint program, uint color, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				BindFragDataLocationEXTNative(program, color, pname0);
			}
		}

		public static void BindFragDataLocationEXT(uint program, uint color, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				BindFragDataLocationEXTNative(program, color, pname0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindFragDataLocationIndexedEXTNative(uint program, uint colorNumber, uint index, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, byte*, void>)funcTable[1])(program, colorNumber, index, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, nint, void>)funcTable[1])(program, colorNumber, index, (nint)name);
			#endif
		}

		public static void BindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, byte* name)
		{
			BindFragDataLocationIndexedEXTNative(program, colorNumber, index, name);
		}

		public static void BindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, string name)
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
			BindFragDataLocationIndexedEXTNative(program, colorNumber, index, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void BindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				BindFragDataLocationIndexedEXTNative(program, colorNumber, index, pname0);
			}
		}

		public static void BindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				BindFragDataLocationIndexedEXTNative(program, colorNumber, index, pname0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetFragDataIndexEXTNative(uint program, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte*, int>)funcTable[2])(program, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, nint, int>)funcTable[2])(program, (nint)name);
			#endif
		}

		public static int GetFragDataIndexEXT(uint program, byte* name)
		{
			int ret = GetFragDataIndexEXTNative(program, name);
			return ret;
		}

		public static int GetFragDataIndexEXT(uint program, string name)
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
			int ret = GetFragDataIndexEXTNative(program, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static int GetFragDataIndexEXT(uint program, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetFragDataIndexEXTNative(program, pname0);
				return ret;
			}
		}

		public static int GetFragDataIndexEXT(uint program, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetFragDataIndexEXTNative(program, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetProgramResourceLocationIndexEXTNative(uint program, GLProgramInterface programInterface, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, byte*, int>)funcTable[3])(program, programInterface, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, nint, int>)funcTable[3])(program, programInterface, (nint)name);
			#endif
		}

		public static int GetProgramResourceLocationIndexEXT(uint program, GLProgramInterface programInterface, byte* name)
		{
			int ret = GetProgramResourceLocationIndexEXTNative(program, programInterface, name);
			return ret;
		}

		public static int GetProgramResourceLocationIndexEXT(uint program, GLProgramInterface programInterface, string name)
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
			int ret = GetProgramResourceLocationIndexEXTNative(program, programInterface, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static int GetProgramResourceLocationIndexEXT(uint program, GLProgramInterface programInterface, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetProgramResourceLocationIndexEXTNative(program, programInterface, pname0);
				return ret;
			}
		}

		public static int GetProgramResourceLocationIndexEXT(uint program, GLProgramInterface programInterface, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetProgramResourceLocationIndexEXTNative(program, programInterface, pname0);
				return ret;
			}
		}

	}
}
