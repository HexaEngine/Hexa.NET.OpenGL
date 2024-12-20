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

namespace Hexa.NET.OpenGLES.EXT
{
	public unsafe partial class GLEXTDisjointTimerQuery : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_disjoint_timer_query";

		public GLEXTDisjointTimerQuery() : base(12)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glBeginQueryEXT");
			funcTable.Load(1, "glDeleteQueriesEXT");
			funcTable.Load(2, "glEndQueryEXT");
			funcTable.Load(3, "glGenQueriesEXT");
			funcTable.Load(4, "glGetInteger64vEXT");
			funcTable.Load(5, "glGetQueryObjecti64vEXT");
			funcTable.Load(6, "glGetQueryObjectivEXT");
			funcTable.Load(7, "glGetQueryObjectui64vEXT");
			funcTable.Load(8, "glGetQueryObjectuivEXT");
			funcTable.Load(9, "glGetQueryivEXT");
			funcTable.Load(10, "glIsQueryEXT");
			funcTable.Load(11, "glQueryCounterEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
