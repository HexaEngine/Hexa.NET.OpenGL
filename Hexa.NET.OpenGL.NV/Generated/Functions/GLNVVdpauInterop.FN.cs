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
using System.Numerics;
using Hexa.NET.OpenGL;

namespace Hexa.NET.OpenGL.NV
{
	public unsafe partial class GLNVVdpauInterop
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_NV_vdpau_interop";

		/// <summary>
		/// Tries to initialize the function table of the extension, call before you access any function.
		/// </summary>
		/// <returns>Returns <c>true</c> if successful, <c>false</c> if extension is not supported.</returns>
		public static bool TryInitExtension()
		{
			if (!IsSupported) return false;
			InitExtension();
			return true;
		}

		/// <summary>
		/// Initializes the function table of the extension, call before you access any function.
		/// </summary>
		public static void InitExtension()
		{
			if (funcTable != null) return;
			if (GLBase.NativeContext == null) throw new InvalidOperationException("OpenGL is not initialized, call GL.InitApi.");
			funcTable = new FunctionTable(GLBase.NativeContext, 10);
			funcTable.Load(0, "glVDPAUFiniNV");
			funcTable.Load(1, "glVDPAUGetSurfaceivNV");
			funcTable.Load(2, "glVDPAUInitNV");
			funcTable.Load(3, "glVDPAUIsSurfaceNV");
			funcTable.Load(4, "glVDPAUMapSurfacesNV");
			funcTable.Load(5, "glVDPAURegisterOutputSurfaceNV");
			funcTable.Load(6, "glVDPAURegisterVideoSurfaceNV");
			funcTable.Load(7, "glVDPAUSurfaceAccessNV");
			funcTable.Load(8, "glVDPAUUnmapSurfacesNV");
			funcTable.Load(9, "glVDPAUUnregisterSurfaceNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}