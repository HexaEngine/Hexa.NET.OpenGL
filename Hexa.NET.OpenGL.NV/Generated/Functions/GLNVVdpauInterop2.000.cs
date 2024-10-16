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
	public static unsafe partial class GLNVVdpauInterop2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNVNative(void* vdpSurface, GLEnum target, int numTextureNames, uint* textureNames, byte isFrameStructure)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, GLEnum, int, uint*, byte, GLvdpauSurfaceNV>)funcTable[0])(vdpSurface, target, numTextureNames, textureNames, isFrameStructure);
			#else
			return (GLvdpauSurfaceNV)((delegate* unmanaged[Cdecl]<nint, GLEnum, int, nint, byte, GLvdpauSurfaceNV>)funcTable[0])((nint)vdpSurface, target, numTextureNames, (nint)textureNames, isFrameStructure);
			#endif
		}

		public static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface, GLEnum target, int numTextureNames, uint* textureNames, byte isFrameStructure)
		{
			GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceWithPictureStructureNVNative(vdpSurface, target, numTextureNames, textureNames, isFrameStructure);
			return ret;
		}

		public static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface, GLEnum target, int numTextureNames, ref uint textureNames, byte isFrameStructure)
		{
			fixed (uint* ptextureNames0 = &textureNames)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceWithPictureStructureNVNative(vdpSurface, target, numTextureNames, ptextureNames0, isFrameStructure);
				return ret;
			}
		}

	}
}
