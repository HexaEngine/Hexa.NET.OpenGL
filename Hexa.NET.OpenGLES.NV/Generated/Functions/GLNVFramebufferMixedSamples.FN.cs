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

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVFramebufferMixedSamples : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_NV_framebuffer_mixed_samples";

		public GLNVFramebufferMixedSamples() : base(4)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glCoverageModulationNV");
			funcTable.Load(1, "glCoverageModulationTableNV");
			funcTable.Load(2, "glGetCoverageModulationTableNV");
			funcTable.Load(3, "glRasterSamplesEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
