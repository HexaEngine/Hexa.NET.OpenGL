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
	public unsafe partial class GLARBProgramInterfaceQuery
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetProgramInterfaceivNative(uint program, GLProgramInterface programInterface, GLProgramInterfacePName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, GLProgramInterfacePName, int*, void>)funcTable[0])(program, programInterface, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, GLProgramInterfacePName, nint, void>)funcTable[0])(program, programInterface, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramInterfaceiv(uint program, GLProgramInterface programInterface, GLProgramInterfacePName pname, int* @params)
		{
			GetProgramInterfaceivNative(program, programInterface, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramInterfaceiv(uint program, GLProgramInterface programInterface, GLProgramInterfacePName pname, out int @params)
		{
			int pparam;
			GetProgramInterfaceivNative(program, programInterface, pname, &pparam);
			@params = pparam;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramInterfaceiv(uint program, GLProgramInterface programInterface, GLProgramInterfacePName pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetProgramInterfaceivNative(program, programInterface, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal uint GetProgramResourceIndexNative(uint program, GLProgramInterface programInterface, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, byte*, uint>)funcTable[1])(program, programInterface, name);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, nint, uint>)funcTable[1])(program, programInterface, (nint)name);
			#endif
		}

		/// <summary>
		/// Query the index of a named resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public uint GetProgramResourceIndex(uint program, GLProgramInterface programInterface, byte* name)
		{
			uint ret = GetProgramResourceIndexNative(program, programInterface, name);
			return ret;
		}

		/// <summary>
		/// Query the index of a named resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public uint GetProgramResourceIndex(uint program, GLProgramInterface programInterface, string name)
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

		/// <summary>
		/// Query the index of a named resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public uint GetProgramResourceIndex(uint program, GLProgramInterface programInterface, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				uint ret = GetProgramResourceIndexNative(program, programInterface, pname0);
				return ret;
			}
		}

		/// <summary>
		/// Query the index of a named resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public uint GetProgramResourceIndex(uint program, GLProgramInterface programInterface, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				uint ret = GetProgramResourceIndexNative(program, programInterface, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal int GetProgramResourceLocationNative(uint program, GLProgramInterface programInterface, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, byte*, int>)funcTable[2])(program, programInterface, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, nint, int>)funcTable[2])(program, programInterface, (nint)name);
			#endif
		}

		/// <summary>
		/// Query the location of a named resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public int GetProgramResourceLocation(uint program, GLProgramInterface programInterface, byte* name)
		{
			int ret = GetProgramResourceLocationNative(program, programInterface, name);
			return ret;
		}

		/// <summary>
		/// Query the location of a named resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public int GetProgramResourceLocation(uint program, GLProgramInterface programInterface, string name)
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

		/// <summary>
		/// Query the location of a named resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public int GetProgramResourceLocation(uint program, GLProgramInterface programInterface, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetProgramResourceLocationNative(program, programInterface, pname0);
				return ret;
			}
		}

		/// <summary>
		/// Query the location of a named resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public int GetProgramResourceLocation(uint program, GLProgramInterface programInterface, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetProgramResourceLocationNative(program, programInterface, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal int GetProgramResourceLocationIndexNative(uint program, GLProgramInterface programInterface, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, byte*, int>)funcTable[3])(program, programInterface, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, nint, int>)funcTable[3])(program, programInterface, (nint)name);
			#endif
		}

		/// <summary>
		/// Query the fragment color index of a named variable within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public int GetProgramResourceLocationIndex(uint program, GLProgramInterface programInterface, byte* name)
		{
			int ret = GetProgramResourceLocationIndexNative(program, programInterface, name);
			return ret;
		}

		/// <summary>
		/// Query the fragment color index of a named variable within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public int GetProgramResourceLocationIndex(uint program, GLProgramInterface programInterface, string name)
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

		/// <summary>
		/// Query the fragment color index of a named variable within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public int GetProgramResourceLocationIndex(uint program, GLProgramInterface programInterface, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetProgramResourceLocationIndexNative(program, programInterface, pname0);
				return ret;
			}
		}

		/// <summary>
		/// Query the fragment color index of a named variable within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public int GetProgramResourceLocationIndex(uint program, GLProgramInterface programInterface, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetProgramResourceLocationIndexNative(program, programInterface, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetProgramResourceNameNative(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, uint, int, int*, byte*, void>)funcTable[4])(program, programInterface, index, bufSize, length, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, uint, int, nint, nint, void>)funcTable[4])(program, programInterface, index, bufSize, (nint)length, (nint)name);
			#endif
		}

		/// <summary>
		/// Query the name of an indexed resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, byte* name)
		{
			GetProgramResourceNameNative(program, programInterface, index, bufSize, length, name);
		}

		/// <summary>
		/// Query the name of an indexed resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, Span<int> length, byte* name)
		{
			fixed (int* plength0 = length)
			{
				GetProgramResourceNameNative(program, programInterface, index, bufSize, plength0, name);
			}
		}

		/// <summary>
		/// Query the name of an indexed resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, ref int length, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				GetProgramResourceNameNative(program, programInterface, index, bufSize, plength0, name);
			}
		}

		/// <summary>
		/// Query the name of an indexed resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, string name)
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

		/// <summary>
		/// Query the name of an indexed resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				GetProgramResourceNameNative(program, programInterface, index, bufSize, length, pname0);
			}
		}

		/// <summary>
		/// Query the name of an indexed resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, int* length, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				GetProgramResourceNameNative(program, programInterface, index, bufSize, length, pname0);
			}
		}

		/// <summary>
		/// Query the name of an indexed resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, Span<int> length, Span<byte> name)
		{
			fixed (int* plength0 = length)
			{
				fixed (byte* pname1 = name)
				{
					GetProgramResourceNameNative(program, programInterface, index, bufSize, plength0, pname1);
				}
			}
		}

		/// <summary>
		/// Query the name of an indexed resource within a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceName(uint program, GLProgramInterface programInterface, uint index, int bufSize, ref int length, ref byte name)
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
		internal void GetProgramResourceivNative(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, int* length, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, uint, int, GLProgramResourceProperty, int, int*, int*, void>)funcTable[5])(program, programInterface, index, propCount, props, count, length, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLProgramInterface, uint, int, GLProgramResourceProperty, int, nint, nint, void>)funcTable[5])(program, programInterface, index, propCount, props, count, (nint)length, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, int* length, int* @params)
		{
			GetProgramResourceivNative(program, programInterface, index, propCount, props, count, length, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, int* length, out int @params)
		{
			int pparam;
			GetProgramResourceivNative(program, programInterface, index, propCount, props, count, length, &pparam);
			@params = pparam;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, int* length, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetProgramResourceivNative(program, programInterface, index, propCount, props, count, length, pparams);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, Span<int> length, int* @params)
		{
			fixed (int* plength0 = length)
			{
				GetProgramResourceivNative(program, programInterface, index, propCount, props, count, plength0, @params);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		public void GetProgramResourceiv(uint program, GLProgramInterface programInterface, uint index, int propCount, GLProgramResourceProperty props, int count, ref int length, int* @params)
		{
			fixed (int* plength0 = &length)
			{
				GetProgramResourceivNative(program, programInterface, index, propCount, props, count, plength0, @params);
			}
		}

	}
}
