using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Passes;

ConsoleDriver.Run(new ExampleLibrary());


public class ExampleLibrary : ILibrary
{
    public void Postprocess(Driver driver, ASTContext ctx)
    {
    }

    public void Preprocess(Driver driver, ASTContext ctx)
    {
    }

    public void Setup(Driver driver)
    {
        var dir = @$"{Directory.GetCurrentDirectory()}\..\..\..\..";

        var options = driver.Options;
        options.GeneratorKind = GeneratorKind.CSharp;
        options.OutputDir = Path.Combine(dir, "CppSharpExampleNET");
        var module = options.AddModule("CppLibrary");
        module.IncludeDirs.Add(Path.Combine(dir, "CppLibrary"));
        module.Headers.Add("Example.h");
    }

    public void SetupPasses(Driver driver)
    {
        driver.Context.TranslationUnitPasses.RenameDeclsUpperCase(RenameTargets.Any);
    }
}