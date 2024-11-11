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
	public unsafe partial class GLNVSampleLocations : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_NV_sample_locations";

		public GLNVSampleLocations() : base(3)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glFramebufferSampleLocationsfvNV");
			funcTable.Load(1, "glNamedFramebufferSampleLocationsfvNV");
			funcTable.Load(2, "glResolveDepthValuesNV");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
