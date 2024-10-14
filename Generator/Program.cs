using HexaGen;
using HexaGen.Patching;

CsCodeGeneratorConfig settings = CsCodeGeneratorConfig.Load("generator.json");
string headerFile = "include/main.h";

CsCodeGenerator generator = new(settings);
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["Gl"], NamingPatchOptions.None));
generator.LogEvent += (s, m) => Console.WriteLine($"{s}: {m}");
generator.Generate(headerFile, "../../../../Hexa.NET.OpenGL/Generated");