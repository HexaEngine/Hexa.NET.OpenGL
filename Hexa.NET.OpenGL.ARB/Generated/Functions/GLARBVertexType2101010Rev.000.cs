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
	public static unsafe partial class GLARBVertexType2101010Rev
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ColorP3uiNative(GLColorPointerType type, uint color)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint, void>)funcTable[0])(type, color);
			#else
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint, void>)funcTable[0])(type, color);
			#endif
		}

		public static void ColorP3ui(GLColorPointerType type, uint color)
		{
			ColorP3uiNative(type, color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ColorP3uivNative(GLColorPointerType type, uint* color)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint*, void>)funcTable[1])(type, color);
			#else
			((delegate* unmanaged[Cdecl]<GLColorPointerType, nint, void>)funcTable[1])(type, (nint)color);
			#endif
		}

		public static void ColorP3uiv(GLColorPointerType type, uint* color)
		{
			ColorP3uivNative(type, color);
		}

		public static void ColorP3uiv(GLColorPointerType type, ref uint color)
		{
			fixed (uint* pcolor0 = &color)
			{
				ColorP3uivNative(type, pcolor0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ColorP4uiNative(GLColorPointerType type, uint color)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint, void>)funcTable[2])(type, color);
			#else
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint, void>)funcTable[2])(type, color);
			#endif
		}

		public static void ColorP4ui(GLColorPointerType type, uint color)
		{
			ColorP4uiNative(type, color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ColorP4uivNative(GLColorPointerType type, uint* color)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint*, void>)funcTable[3])(type, color);
			#else
			((delegate* unmanaged[Cdecl]<GLColorPointerType, nint, void>)funcTable[3])(type, (nint)color);
			#endif
		}

		public static void ColorP4uiv(GLColorPointerType type, uint* color)
		{
			ColorP4uivNative(type, color);
		}

		public static void ColorP4uiv(GLColorPointerType type, ref uint color)
		{
			fixed (uint* pcolor0 = &color)
			{
				ColorP4uivNative(type, pcolor0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiTexCoordP1uiNative(GLTextureUnit texture, GLTexCoordPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint, void>)funcTable[4])(texture, type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint, void>)funcTable[4])(texture, type, coords);
			#endif
		}

		public static void MultiTexCoordP1ui(GLTextureUnit texture, GLTexCoordPointerType type, uint coords)
		{
			MultiTexCoordP1uiNative(texture, type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiTexCoordP1uivNative(GLTextureUnit texture, GLTexCoordPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint*, void>)funcTable[5])(texture, type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, nint, void>)funcTable[5])(texture, type, (nint)coords);
			#endif
		}

		public static void MultiTexCoordP1uiv(GLTextureUnit texture, GLTexCoordPointerType type, uint* coords)
		{
			MultiTexCoordP1uivNative(texture, type, coords);
		}

		public static void MultiTexCoordP1uiv(GLTextureUnit texture, GLTexCoordPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				MultiTexCoordP1uivNative(texture, type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiTexCoordP2uiNative(GLTextureUnit texture, GLTexCoordPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint, void>)funcTable[6])(texture, type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint, void>)funcTable[6])(texture, type, coords);
			#endif
		}

		public static void MultiTexCoordP2ui(GLTextureUnit texture, GLTexCoordPointerType type, uint coords)
		{
			MultiTexCoordP2uiNative(texture, type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiTexCoordP2uivNative(GLTextureUnit texture, GLTexCoordPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint*, void>)funcTable[7])(texture, type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, nint, void>)funcTable[7])(texture, type, (nint)coords);
			#endif
		}

		public static void MultiTexCoordP2uiv(GLTextureUnit texture, GLTexCoordPointerType type, uint* coords)
		{
			MultiTexCoordP2uivNative(texture, type, coords);
		}

		public static void MultiTexCoordP2uiv(GLTextureUnit texture, GLTexCoordPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				MultiTexCoordP2uivNative(texture, type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiTexCoordP3uiNative(GLTextureUnit texture, GLTexCoordPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint, void>)funcTable[8])(texture, type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint, void>)funcTable[8])(texture, type, coords);
			#endif
		}

		public static void MultiTexCoordP3ui(GLTextureUnit texture, GLTexCoordPointerType type, uint coords)
		{
			MultiTexCoordP3uiNative(texture, type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiTexCoordP3uivNative(GLTextureUnit texture, GLTexCoordPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint*, void>)funcTable[9])(texture, type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, nint, void>)funcTable[9])(texture, type, (nint)coords);
			#endif
		}

		public static void MultiTexCoordP3uiv(GLTextureUnit texture, GLTexCoordPointerType type, uint* coords)
		{
			MultiTexCoordP3uivNative(texture, type, coords);
		}

		public static void MultiTexCoordP3uiv(GLTextureUnit texture, GLTexCoordPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				MultiTexCoordP3uivNative(texture, type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiTexCoordP4uiNative(GLTextureUnit texture, GLTexCoordPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint, void>)funcTable[10])(texture, type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint, void>)funcTable[10])(texture, type, coords);
			#endif
		}

		public static void MultiTexCoordP4ui(GLTextureUnit texture, GLTexCoordPointerType type, uint coords)
		{
			MultiTexCoordP4uiNative(texture, type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiTexCoordP4uivNative(GLTextureUnit texture, GLTexCoordPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, uint*, void>)funcTable[11])(texture, type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, GLTexCoordPointerType, nint, void>)funcTable[11])(texture, type, (nint)coords);
			#endif
		}

		public static void MultiTexCoordP4uiv(GLTextureUnit texture, GLTexCoordPointerType type, uint* coords)
		{
			MultiTexCoordP4uivNative(texture, type, coords);
		}

		public static void MultiTexCoordP4uiv(GLTextureUnit texture, GLTexCoordPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				MultiTexCoordP4uivNative(texture, type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void NormalP3uiNative(GLNormalPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLNormalPointerType, uint, void>)funcTable[12])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLNormalPointerType, uint, void>)funcTable[12])(type, coords);
			#endif
		}

		public static void NormalP3ui(GLNormalPointerType type, uint coords)
		{
			NormalP3uiNative(type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void NormalP3uivNative(GLNormalPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLNormalPointerType, uint*, void>)funcTable[13])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLNormalPointerType, nint, void>)funcTable[13])(type, (nint)coords);
			#endif
		}

		public static void NormalP3uiv(GLNormalPointerType type, uint* coords)
		{
			NormalP3uivNative(type, coords);
		}

		public static void NormalP3uiv(GLNormalPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				NormalP3uivNative(type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SecondaryColorP3uiNative(GLColorPointerType type, uint color)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint, void>)funcTable[14])(type, color);
			#else
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint, void>)funcTable[14])(type, color);
			#endif
		}

		public static void SecondaryColorP3ui(GLColorPointerType type, uint color)
		{
			SecondaryColorP3uiNative(type, color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SecondaryColorP3uivNative(GLColorPointerType type, uint* color)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorPointerType, uint*, void>)funcTable[15])(type, color);
			#else
			((delegate* unmanaged[Cdecl]<GLColorPointerType, nint, void>)funcTable[15])(type, (nint)color);
			#endif
		}

		public static void SecondaryColorP3uiv(GLColorPointerType type, uint* color)
		{
			SecondaryColorP3uivNative(type, color);
		}

		public static void SecondaryColorP3uiv(GLColorPointerType type, ref uint color)
		{
			fixed (uint* pcolor0 = &color)
			{
				SecondaryColorP3uivNative(type, pcolor0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordP1uiNative(GLTexCoordPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint, void>)funcTable[16])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint, void>)funcTable[16])(type, coords);
			#endif
		}

		public static void TexCoordP1ui(GLTexCoordPointerType type, uint coords)
		{
			TexCoordP1uiNative(type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordP1uivNative(GLTexCoordPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint*, void>)funcTable[17])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, nint, void>)funcTable[17])(type, (nint)coords);
			#endif
		}

		public static void TexCoordP1uiv(GLTexCoordPointerType type, uint* coords)
		{
			TexCoordP1uivNative(type, coords);
		}

		public static void TexCoordP1uiv(GLTexCoordPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				TexCoordP1uivNative(type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordP2uiNative(GLTexCoordPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint, void>)funcTable[18])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint, void>)funcTable[18])(type, coords);
			#endif
		}

		public static void TexCoordP2ui(GLTexCoordPointerType type, uint coords)
		{
			TexCoordP2uiNative(type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordP2uivNative(GLTexCoordPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint*, void>)funcTable[19])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, nint, void>)funcTable[19])(type, (nint)coords);
			#endif
		}

		public static void TexCoordP2uiv(GLTexCoordPointerType type, uint* coords)
		{
			TexCoordP2uivNative(type, coords);
		}

		public static void TexCoordP2uiv(GLTexCoordPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				TexCoordP2uivNative(type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordP3uiNative(GLTexCoordPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint, void>)funcTable[20])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint, void>)funcTable[20])(type, coords);
			#endif
		}

		public static void TexCoordP3ui(GLTexCoordPointerType type, uint coords)
		{
			TexCoordP3uiNative(type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordP3uivNative(GLTexCoordPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint*, void>)funcTable[21])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, nint, void>)funcTable[21])(type, (nint)coords);
			#endif
		}

		public static void TexCoordP3uiv(GLTexCoordPointerType type, uint* coords)
		{
			TexCoordP3uivNative(type, coords);
		}

		public static void TexCoordP3uiv(GLTexCoordPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				TexCoordP3uivNative(type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordP4uiNative(GLTexCoordPointerType type, uint coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint, void>)funcTable[22])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint, void>)funcTable[22])(type, coords);
			#endif
		}

		public static void TexCoordP4ui(GLTexCoordPointerType type, uint coords)
		{
			TexCoordP4uiNative(type, coords);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordP4uivNative(GLTexCoordPointerType type, uint* coords)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, uint*, void>)funcTable[23])(type, coords);
			#else
			((delegate* unmanaged[Cdecl]<GLTexCoordPointerType, nint, void>)funcTable[23])(type, (nint)coords);
			#endif
		}

		public static void TexCoordP4uiv(GLTexCoordPointerType type, uint* coords)
		{
			TexCoordP4uivNative(type, coords);
		}

		public static void TexCoordP4uiv(GLTexCoordPointerType type, ref uint coords)
		{
			fixed (uint* pcoords0 = &coords)
			{
				TexCoordP4uivNative(type, pcoords0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP1uiNative(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[24])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[24])(index, type, normalized, value);
			#endif
		}

		public static void VertexAttribP1ui(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			VertexAttribP1uiNative(index, type, normalized, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP1uivNative(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint*, void>)funcTable[25])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, nint, void>)funcTable[25])(index, type, normalized, (nint)value);
			#endif
		}

		public static void VertexAttribP1uiv(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			VertexAttribP1uivNative(index, type, normalized, value);
		}

		public static void VertexAttribP1uiv(uint index, GLVertexAttribPointerType type, byte normalized, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexAttribP1uivNative(index, type, normalized, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP2uiNative(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[26])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[26])(index, type, normalized, value);
			#endif
		}

		public static void VertexAttribP2ui(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			VertexAttribP2uiNative(index, type, normalized, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP2uivNative(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint*, void>)funcTable[27])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, nint, void>)funcTable[27])(index, type, normalized, (nint)value);
			#endif
		}

		public static void VertexAttribP2uiv(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			VertexAttribP2uivNative(index, type, normalized, value);
		}

		public static void VertexAttribP2uiv(uint index, GLVertexAttribPointerType type, byte normalized, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexAttribP2uivNative(index, type, normalized, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP3uiNative(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[28])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[28])(index, type, normalized, value);
			#endif
		}

		public static void VertexAttribP3ui(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			VertexAttribP3uiNative(index, type, normalized, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP3uivNative(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint*, void>)funcTable[29])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, nint, void>)funcTable[29])(index, type, normalized, (nint)value);
			#endif
		}

		public static void VertexAttribP3uiv(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			VertexAttribP3uivNative(index, type, normalized, value);
		}

		public static void VertexAttribP3uiv(uint index, GLVertexAttribPointerType type, byte normalized, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexAttribP3uivNative(index, type, normalized, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP4uiNative(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[30])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[30])(index, type, normalized, value);
			#endif
		}

		public static void VertexAttribP4ui(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			VertexAttribP4uiNative(index, type, normalized, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP4uivNative(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint*, void>)funcTable[31])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, nint, void>)funcTable[31])(index, type, normalized, (nint)value);
			#endif
		}

		public static void VertexAttribP4uiv(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			VertexAttribP4uivNative(index, type, normalized, value);
		}

		public static void VertexAttribP4uiv(uint index, GLVertexAttribPointerType type, byte normalized, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexAttribP4uivNative(index, type, normalized, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexP2uiNative(GLVertexPointerType type, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint, void>)funcTable[32])(type, value);
			#else
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint, void>)funcTable[32])(type, value);
			#endif
		}

		public static void VertexP2ui(GLVertexPointerType type, uint value)
		{
			VertexP2uiNative(type, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexP2uivNative(GLVertexPointerType type, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint*, void>)funcTable[33])(type, value);
			#else
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, nint, void>)funcTable[33])(type, (nint)value);
			#endif
		}

		public static void VertexP2uiv(GLVertexPointerType type, uint* value)
		{
			VertexP2uivNative(type, value);
		}

		public static void VertexP2uiv(GLVertexPointerType type, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexP2uivNative(type, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexP3uiNative(GLVertexPointerType type, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint, void>)funcTable[34])(type, value);
			#else
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint, void>)funcTable[34])(type, value);
			#endif
		}

		public static void VertexP3ui(GLVertexPointerType type, uint value)
		{
			VertexP3uiNative(type, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexP3uivNative(GLVertexPointerType type, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint*, void>)funcTable[35])(type, value);
			#else
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, nint, void>)funcTable[35])(type, (nint)value);
			#endif
		}

		public static void VertexP3uiv(GLVertexPointerType type, uint* value)
		{
			VertexP3uivNative(type, value);
		}

		public static void VertexP3uiv(GLVertexPointerType type, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexP3uivNative(type, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexP4uiNative(GLVertexPointerType type, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint, void>)funcTable[36])(type, value);
			#else
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint, void>)funcTable[36])(type, value);
			#endif
		}

		public static void VertexP4ui(GLVertexPointerType type, uint value)
		{
			VertexP4uiNative(type, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexP4uivNative(GLVertexPointerType type, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, uint*, void>)funcTable[37])(type, value);
			#else
			((delegate* unmanaged[Cdecl]<GLVertexPointerType, nint, void>)funcTable[37])(type, (nint)value);
			#endif
		}

		public static void VertexP4uiv(GLVertexPointerType type, uint* value)
		{
			VertexP4uivNative(type, value);
		}

		public static void VertexP4uiv(GLVertexPointerType type, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexP4uivNative(type, pvalue0);
			}
		}

	}
}