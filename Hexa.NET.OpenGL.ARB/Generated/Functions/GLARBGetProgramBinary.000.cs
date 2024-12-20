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
	public unsafe partial class GLARBGetProgramBinary
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetProgramBinaryNative(uint program, int bufSize, int* length, GLEnum* binaryFormat, void* binary)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, GLEnum*, void*, void>)funcTable[0])(program, bufSize, length, binaryFormat, binary);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, nint, void>)funcTable[0])(program, bufSize, (nint)length, (nint)binaryFormat, (nint)binary);
			#endif
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary(uint program, int bufSize, int* length, GLEnum* binaryFormat, void* binary)
		{
			GetProgramBinaryNative(program, bufSize, length, binaryFormat, binary);
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary(uint program, int bufSize, Span<int> length, GLEnum* binaryFormat, void* binary)
		{
			fixed (int* plength0 = length)
			{
				GetProgramBinaryNative(program, bufSize, plength0, binaryFormat, binary);
			}
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary(uint program, int bufSize, ref int length, GLEnum* binaryFormat, void* binary)
		{
			fixed (int* plength0 = &length)
			{
				GetProgramBinaryNative(program, bufSize, plength0, binaryFormat, binary);
			}
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary(uint program, int bufSize, int* length, Span<GLEnum> binaryFormat, void* binary)
		{
			fixed (GLEnum* pbinaryFormat0 = binaryFormat)
			{
				GetProgramBinaryNative(program, bufSize, length, pbinaryFormat0, binary);
			}
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary(uint program, int bufSize, int* length, ref GLEnum binaryFormat, void* binary)
		{
			fixed (GLEnum* pbinaryFormat0 = &binaryFormat)
			{
				GetProgramBinaryNative(program, bufSize, length, pbinaryFormat0, binary);
			}
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary(uint program, int bufSize, Span<int> length, Span<GLEnum> binaryFormat, void* binary)
		{
			fixed (int* plength0 = length)
			{
				fixed (GLEnum* pbinaryFormat1 = binaryFormat)
				{
					GetProgramBinaryNative(program, bufSize, plength0, pbinaryFormat1, binary);
				}
			}
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary(uint program, int bufSize, ref int length, ref GLEnum binaryFormat, void* binary)
		{
			fixed (int* plength0 = &length)
			{
				fixed (GLEnum* pbinaryFormat1 = &binaryFormat)
				{
					GetProgramBinaryNative(program, bufSize, plength0, pbinaryFormat1, binary);
				}
			}
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary(uint program, int bufSize, int* length, GLEnum* binaryFormat, nint binary)
		{
			GetProgramBinaryNative(program, bufSize, length, binaryFormat, (void*)binary);
		}

		/// <summary>
		/// Return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void GetProgramBinary<TBinary>(uint program, int bufSize, int* length, GLEnum* binaryFormat, Span<TBinary> binary) where TBinary : unmanaged
		{
			fixed (TBinary* pbinary0 = binary)
			{
				GetProgramBinaryNative(program, bufSize, length, binaryFormat, pbinary0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramBinaryNative(uint program, GLEnum binaryFormat, void* binary, int length)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void*, int, void>)funcTable[1])(program, binaryFormat, binary, length);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, nint, int, void>)funcTable[1])(program, binaryFormat, (nint)binary, length);
			#endif
		}

		/// <summary>
		/// Load a program object with a program binary
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void ProgramBinary(uint program, GLEnum binaryFormat, void* binary, int length)
		{
			ProgramBinaryNative(program, binaryFormat, binary, length);
		}

		/// <summary>
		/// Load a program object with a program binary
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void ProgramBinary(uint program, GLEnum binaryFormat, nint binary, int length)
		{
			ProgramBinaryNative(program, binaryFormat, (void*)binary, length);
		}

		/// <summary>
		/// Load a program object with a program binary
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		public void ProgramBinary<TBinary>(uint program, GLEnum binaryFormat, Span<TBinary> binary, int length) where TBinary : unmanaged
		{
			fixed (TBinary* pbinary0 = binary)
			{
				ProgramBinaryNative(program, binaryFormat, pbinary0, length);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramParameteriNative(uint program, GLProgramParameterPName pname, int value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLProgramParameterPName, int, void>)funcTable[2])(program, pname, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLProgramParameterPName, int, void>)funcTable[2])(program, pname, value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary<br/>GL_ARB_separate_shader_objects</remarks>
		public void ProgramParameteri(uint program, GLProgramParameterPName pname, int value)
		{
			ProgramParameteriNative(program, pname, value);
		}

	}
}
