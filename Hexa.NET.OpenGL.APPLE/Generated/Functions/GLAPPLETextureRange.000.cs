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

namespace Hexa.NET.OpenGL.APPLE
{
	public static unsafe partial class GLAPPLETextureRange
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetTexParameterPointervAPPLENative(GLEnum target, GLEnum pname, void** @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, void**, void>)funcTable[0])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, nint, void>)funcTable[0])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_texture_range</remarks>
		public static void GetTexParameterPointervAPPLE(GLEnum target, GLEnum pname, void** @params)
		{
			GetTexParameterPointervAPPLENative(target, pname, @params);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureRangeAPPLENative(GLEnum target, int length, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, void*, void>)funcTable[1])(target, length, pointer);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, nint, void>)funcTable[1])(target, length, (nint)pointer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_texture_range</remarks>
		public static void TextureRangeAPPLE(GLEnum target, int length, void* pointer)
		{
			TextureRangeAPPLENative(target, length, pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_texture_range</remarks>
		public static void TextureRangeAPPLE(GLEnum target, int length, nint pointer)
		{
			TextureRangeAPPLENative(target, length, (void*)pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_texture_range</remarks>
		public static void TextureRangeAPPLE<TPointer>(GLEnum target, int length, Span<TPointer> pointer) where TPointer : unmanaged
		{
			fixed (TPointer* ppointer0 = pointer)
			{
				TextureRangeAPPLENative(target, length, ppointer0);
			}
		}

	}
}
