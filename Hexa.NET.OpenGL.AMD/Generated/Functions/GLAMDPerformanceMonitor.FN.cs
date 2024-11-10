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

namespace Hexa.NET.OpenGL.AMD
{
	public unsafe partial class GLAMDPerformanceMonitor
	{
		[ThreadStatic]
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_AMD_performance_monitor";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 11);
			funcTable.Load(0, "glBeginPerfMonitorAMD");
			funcTable.Load(1, "glDeletePerfMonitorsAMD");
			funcTable.Load(2, "glEndPerfMonitorAMD");
			funcTable.Load(3, "glGenPerfMonitorsAMD");
			funcTable.Load(4, "glGetPerfMonitorCounterDataAMD");
			funcTable.Load(5, "glGetPerfMonitorCounterInfoAMD");
			funcTable.Load(6, "glGetPerfMonitorCounterStringAMD");
			funcTable.Load(7, "glGetPerfMonitorCountersAMD");
			funcTable.Load(8, "glGetPerfMonitorGroupStringAMD");
			funcTable.Load(9, "glGetPerfMonitorGroupsAMD");
			funcTable.Load(10, "glSelectPerfMonitorCountersAMD");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
