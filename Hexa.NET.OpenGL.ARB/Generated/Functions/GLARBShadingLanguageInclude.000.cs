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
	public unsafe partial class GLARBShadingLanguageInclude
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void CompileShaderIncludeARBNative(uint shader, int count, byte** path, int* length)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, byte**, int*, void>)funcTable[0])(shader, count, path, length);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, void>)funcTable[0])(shader, count, (nint)path, (nint)length);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void CompileShaderIncludeARB(uint shader, int count, byte** path, int* length)
		{
			CompileShaderIncludeARBNative(shader, count, path, length);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void CompileShaderIncludeARB(uint shader, int count, byte** path, Span<int> length)
		{
			fixed (int* plength0 = length)
			{
				CompileShaderIncludeARBNative(shader, count, path, plength0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void CompileShaderIncludeARB(uint shader, int count, byte** path, ref int length)
		{
			fixed (int* plength0 = &length)
			{
				CompileShaderIncludeARBNative(shader, count, path, plength0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DeleteNamedStringARBNative(int namelen, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, byte*, void>)funcTable[1])(namelen, name);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(namelen, (nint)name);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void DeleteNamedStringARB(int namelen, byte* name)
		{
			DeleteNamedStringARBNative(namelen, name);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void DeleteNamedStringARB(int namelen, string name)
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
			DeleteNamedStringARBNative(namelen, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void DeleteNamedStringARB(int namelen, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				DeleteNamedStringARBNative(namelen, pname0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void DeleteNamedStringARB(int namelen, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				DeleteNamedStringARBNative(namelen, pname0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetNamedStringARBNative(int namelen, byte* name, int bufSize, int* stringlen, byte* str)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, byte*, int, int*, byte*, void>)funcTable[2])(namelen, name, bufSize, stringlen, str);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, int, nint, nint, void>)funcTable[2])(namelen, (nint)name, bufSize, (nint)stringlen, (nint)str);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, byte* name, int bufSize, int* stringlen, byte* str)
		{
			GetNamedStringARBNative(namelen, name, bufSize, stringlen, str);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, string name, int bufSize, int* stringlen, byte* str)
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
			GetNamedStringARBNative(namelen, pStr0, bufSize, stringlen, str);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, Span<byte> name, int bufSize, int* stringlen, byte* str)
		{
			fixed (byte* pname0 = name)
			{
				GetNamedStringARBNative(namelen, pname0, bufSize, stringlen, str);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, ref byte name, int bufSize, int* stringlen, byte* str)
		{
			fixed (byte* pname0 = &name)
			{
				GetNamedStringARBNative(namelen, pname0, bufSize, stringlen, str);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, byte* name, int bufSize, Span<int> stringlen, byte* str)
		{
			fixed (int* pstringlen0 = stringlen)
			{
				GetNamedStringARBNative(namelen, name, bufSize, pstringlen0, str);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, byte* name, int bufSize, ref int stringlen, byte* str)
		{
			fixed (int* pstringlen0 = &stringlen)
			{
				GetNamedStringARBNative(namelen, name, bufSize, pstringlen0, str);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, Span<byte> name, int bufSize, Span<int> stringlen, byte* str)
		{
			fixed (byte* pname0 = name)
			{
				fixed (int* pstringlen1 = stringlen)
				{
					GetNamedStringARBNative(namelen, pname0, bufSize, pstringlen1, str);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, ref byte name, int bufSize, ref int stringlen, byte* str)
		{
			fixed (byte* pname0 = &name)
			{
				fixed (int* pstringlen1 = &stringlen)
				{
					GetNamedStringARBNative(namelen, pname0, bufSize, pstringlen1, str);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, byte* name, int bufSize, int* stringlen, string str)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (str != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(str);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetNamedStringARBNative(namelen, name, bufSize, stringlen, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, byte* name, int bufSize, int* stringlen, Span<byte> str)
		{
			fixed (byte* pstr0 = str)
			{
				GetNamedStringARBNative(namelen, name, bufSize, stringlen, pstr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, byte* name, int bufSize, int* stringlen, ref byte str)
		{
			fixed (byte* pstr0 = &str)
			{
				GetNamedStringARBNative(namelen, name, bufSize, stringlen, pstr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, string name, int bufSize, int* stringlen, string str)
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
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (str != null)
			{
				pStrSize1 = Utils.GetByteCountUTF8(str);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(str, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			GetNamedStringARBNative(namelen, pStr0, bufSize, stringlen, pStr1);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, Span<byte> name, int bufSize, int* stringlen, Span<byte> str)
		{
			fixed (byte* pname0 = name)
			{
				fixed (byte* pstr1 = str)
				{
					GetNamedStringARBNative(namelen, pname0, bufSize, stringlen, pstr1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, ref byte name, int bufSize, int* stringlen, ref byte str)
		{
			fixed (byte* pname0 = &name)
			{
				fixed (byte* pstr1 = &str)
				{
					GetNamedStringARBNative(namelen, pname0, bufSize, stringlen, pstr1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, byte* name, int bufSize, Span<int> stringlen, Span<byte> str)
		{
			fixed (int* pstringlen0 = stringlen)
			{
				fixed (byte* pstr1 = str)
				{
					GetNamedStringARBNative(namelen, name, bufSize, pstringlen0, pstr1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, byte* name, int bufSize, ref int stringlen, ref byte str)
		{
			fixed (int* pstringlen0 = &stringlen)
			{
				fixed (byte* pstr1 = &str)
				{
					GetNamedStringARBNative(namelen, name, bufSize, pstringlen0, pstr1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, Span<byte> name, int bufSize, Span<int> stringlen, Span<byte> str)
		{
			fixed (byte* pname0 = name)
			{
				fixed (int* pstringlen1 = stringlen)
				{
					fixed (byte* pstr2 = str)
					{
						GetNamedStringARBNative(namelen, pname0, bufSize, pstringlen1, pstr2);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringARB(int namelen, ref byte name, int bufSize, ref int stringlen, ref byte str)
		{
			fixed (byte* pname0 = &name)
			{
				fixed (int* pstringlen1 = &stringlen)
				{
					fixed (byte* pstr2 = &str)
					{
						GetNamedStringARBNative(namelen, pname0, bufSize, pstringlen1, pstr2);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetNamedStringivARBNative(int namelen, byte* name, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, byte*, GLEnum, int*, void>)funcTable[3])(namelen, name, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, GLEnum, nint, void>)funcTable[3])(namelen, (nint)name, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringivARB(int namelen, byte* name, GLEnum pname, int* @params)
		{
			GetNamedStringivARBNative(namelen, name, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringivARB(int namelen, string name, GLEnum pname, int* @params)
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
			GetNamedStringivARBNative(namelen, pStr0, pname, @params);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringivARB(int namelen, Span<byte> name, GLEnum pname, int* @params)
		{
			fixed (byte* pname0 = name)
			{
				GetNamedStringivARBNative(namelen, pname0, pname, @params);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringivARB(int namelen, ref byte name, GLEnum pname, int* @params)
		{
			fixed (byte* pname0 = &name)
			{
				GetNamedStringivARBNative(namelen, pname0, pname, @params);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringivARB(int namelen, byte* name, GLEnum pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetNamedStringivARBNative(namelen, name, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringivARB(int namelen, byte* name, GLEnum pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetNamedStringivARBNative(namelen, name, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringivARB(int namelen, Span<byte> name, GLEnum pname, Span<int> @params)
		{
			fixed (byte* pname0 = name)
			{
				fixed (int* pparams1 = @params)
				{
					GetNamedStringivARBNative(namelen, pname0, pname, pparams1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void GetNamedStringivARB(int namelen, ref byte name, GLEnum pname, ref int @params)
		{
			fixed (byte* pname0 = &name)
			{
				fixed (int* pparams1 = &@params)
				{
					GetNamedStringivARBNative(namelen, pname0, pname, pparams1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal byte IsNamedStringARBNative(int namelen, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<int, byte*, byte>)funcTable[4])(namelen, name);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<int, nint, byte>)funcTable[4])(namelen, (nint)name);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public bool IsNamedStringARB(int namelen, byte* name)
		{
			byte ret = IsNamedStringARBNative(namelen, name);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public bool IsNamedStringARB(int namelen, string name)
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
			byte ret = IsNamedStringARBNative(namelen, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public bool IsNamedStringARB(int namelen, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				byte ret = IsNamedStringARBNative(namelen, pname0);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public bool IsNamedStringARB(int namelen, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				byte ret = IsNamedStringARBNative(namelen, pname0);
				return ret != 0;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void NamedStringARBNative(GLEnum type, int namelen, byte* name, int stringlen, byte* str)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, byte*, int, byte*, void>)funcTable[5])(type, namelen, name, stringlen, str);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, nint, int, nint, void>)funcTable[5])(type, namelen, (nint)name, stringlen, (nint)str);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, byte* name, int stringlen, byte* str)
		{
			NamedStringARBNative(type, namelen, name, stringlen, str);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, string name, int stringlen, byte* str)
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
			NamedStringARBNative(type, namelen, pStr0, stringlen, str);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, Span<byte> name, int stringlen, byte* str)
		{
			fixed (byte* pname0 = name)
			{
				NamedStringARBNative(type, namelen, pname0, stringlen, str);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, ref byte name, int stringlen, byte* str)
		{
			fixed (byte* pname0 = &name)
			{
				NamedStringARBNative(type, namelen, pname0, stringlen, str);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, byte* name, int stringlen, string str)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (str != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(str);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			NamedStringARBNative(type, namelen, name, stringlen, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, byte* name, int stringlen, Span<byte> str)
		{
			fixed (byte* pstr0 = str)
			{
				NamedStringARBNative(type, namelen, name, stringlen, pstr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, byte* name, int stringlen, ref byte str)
		{
			fixed (byte* pstr0 = &str)
			{
				NamedStringARBNative(type, namelen, name, stringlen, pstr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, string name, int stringlen, string str)
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
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (str != null)
			{
				pStrSize1 = Utils.GetByteCountUTF8(str);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(str, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			NamedStringARBNative(type, namelen, pStr0, stringlen, pStr1);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, Span<byte> name, int stringlen, Span<byte> str)
		{
			fixed (byte* pname0 = name)
			{
				fixed (byte* pstr1 = str)
				{
					NamedStringARBNative(type, namelen, pname0, stringlen, pstr1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_shading_language_include</remarks>
		public void NamedStringARB(GLEnum type, int namelen, ref byte name, int stringlen, ref byte str)
		{
			fixed (byte* pname0 = &name)
			{
				fixed (byte* pstr1 = &str)
				{
					NamedStringARBNative(type, namelen, pname0, stringlen, pstr1);
				}
			}
		}

	}
}
