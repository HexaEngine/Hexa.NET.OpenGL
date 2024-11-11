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

namespace Hexa.NET.OpenGL.AMD
{
	public unsafe partial class GLAMDOcclusionQueryEvent
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void QueryObjectParameteruiAMDNative(GLQueryTarget target, uint id, GLEnum pname, GLOcclusionQueryEventMaskAMD param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLQueryTarget, uint, GLEnum, GLOcclusionQueryEventMaskAMD, void>)funcTable[0])(target, id, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLQueryTarget, uint, GLEnum, GLOcclusionQueryEventMaskAMD, void>)funcTable[0])(target, id, pname, param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_occlusion_query_event</remarks>
		public void QueryObjectParameteruiAMD(GLQueryTarget target, uint id, GLEnum pname, GLOcclusionQueryEventMaskAMD param)
		{
			QueryObjectParameteruiAMDNative(target, id, pname, param);
		}

	}
}
