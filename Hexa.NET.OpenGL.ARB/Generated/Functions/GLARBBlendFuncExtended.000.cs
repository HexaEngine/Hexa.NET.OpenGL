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
	public static unsafe partial class GLARBBlendFuncExtended
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindFragDataLocationIndexedNative(uint program, uint colorNumber, uint index, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, byte*, void>)funcTable[0])(program, colorNumber, index, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, nint, void>)funcTable[0])(program, colorNumber, index, (nint)name);
			#endif
		}

		/// <summary>
		/// Bind a user-defined varying out variable to a fragment shader color number and index
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, byte* name)
		{
			BindFragDataLocationIndexedNative(program, colorNumber, index, name);
		}

		/// <summary>
		/// Bind a user-defined varying out variable to a fragment shader color number and index
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name)
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
			BindFragDataLocationIndexedNative(program, colorNumber, index, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// Bind a user-defined varying out variable to a fragment shader color number and index
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				BindFragDataLocationIndexedNative(program, colorNumber, index, pname0);
			}
		}

		/// <summary>
		/// Bind a user-defined varying out variable to a fragment shader color number and index
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				BindFragDataLocationIndexedNative(program, colorNumber, index, pname0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetFragDataIndexNative(uint program, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte*, int>)funcTable[1])(program, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, nint, int>)funcTable[1])(program, (nint)name);
			#endif
		}

		/// <summary>
		/// Query the bindings of color indices to user-defined varying out variables
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		public static int GetFragDataIndex(uint program, byte* name)
		{
			int ret = GetFragDataIndexNative(program, name);
			return ret;
		}

		/// <summary>
		/// Query the bindings of color indices to user-defined varying out variables
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		public static int GetFragDataIndex(uint program, string name)
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
			int ret = GetFragDataIndexNative(program, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// Query the bindings of color indices to user-defined varying out variables
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		public static int GetFragDataIndex(uint program, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetFragDataIndexNative(program, pname0);
				return ret;
			}
		}

		/// <summary>
		/// Query the bindings of color indices to user-defined varying out variables
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_blend_func_extended</remarks>
		public static int GetFragDataIndex(uint program, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetFragDataIndexNative(program, pname0);
				return ret;
			}
		}

	}
}
