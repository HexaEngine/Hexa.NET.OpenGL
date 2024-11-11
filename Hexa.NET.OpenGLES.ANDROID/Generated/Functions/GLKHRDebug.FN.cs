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
using Hexa.NET.OpenGLES;

namespace Hexa.NET.OpenGLES.ANDROID
{
	public unsafe partial class GLKHRDebug : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_KHR_debug";

		public GLKHRDebug() : base(22)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glDebugMessageCallback");
			funcTable.Load(1, "glDebugMessageCallbackKHR");
			funcTable.Load(2, "glDebugMessageControl");
			funcTable.Load(3, "glDebugMessageControlKHR");
			funcTable.Load(4, "glDebugMessageInsert");
			funcTable.Load(5, "glDebugMessageInsertKHR");
			funcTable.Load(6, "glGetDebugMessageLog");
			funcTable.Load(7, "glGetDebugMessageLogKHR");
			funcTable.Load(8, "glGetObjectLabel");
			funcTable.Load(9, "glGetObjectLabelKHR");
			funcTable.Load(10, "glGetObjectPtrLabel");
			funcTable.Load(11, "glGetObjectPtrLabelKHR");
			funcTable.Load(12, "glGetPointerv");
			funcTable.Load(13, "glGetPointervKHR");
			funcTable.Load(14, "glObjectLabel");
			funcTable.Load(15, "glObjectLabelKHR");
			funcTable.Load(16, "glObjectPtrLabel");
			funcTable.Load(17, "glObjectPtrLabelKHR");
			funcTable.Load(18, "glPopDebugGroup");
			funcTable.Load(19, "glPopDebugGroupKHR");
			funcTable.Load(20, "glPushDebugGroup");
			funcTable.Load(21, "glPushDebugGroupKHR");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
