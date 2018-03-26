# Template solution for C# based Visual Studio projects
This is a template of which I think acts as a good starting point for a new solution.
My goals of this template are:
 - Having a template which provides as much configuration as possible to reflect my personal development tools and coding styles.
 - Act as a playground and test environment for latest development tools.

## Features
- All project templates based on new project system ([dotnet/project-system](https://github.com/dotnet/project-system))
- Common project settings separated in a set of `.props` files
- Templates for several project types
  - .NET Core 2 Class Library
  - .NET 4.7.1 WPF App
- Code Analysis with predefined rulesets (configured in `CodeAnalysis.props`).
  - [FxCop](https://github.com/dotnet/roslyn-analyzers)
  - [StyleCop](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)
  - Invoked on a per-project basis using NuGet packages
  - Separate rulesets for production code and unit test
  - General no warning policy! That is, every message breaks the build, with no excuse. To get rid of a message, it must be fixed, suppressed in code (with proper justification) or disabled in the ruleset.
- Unit Test templates for xUnit and MSTest 2
- Unit Tests preconfigured to use 
  - [FluentAssertions](https://github.com/fluentassertions/fluentassertions)
  - [NSubstitute](https://github.com/nsubstitute/NSubstitute)
- Unit Tests working with TDD tools:
  - VS Live Unit Testing (__not__ in combination with PostSharp!, see _„Known Issues”_)
  - ReSharper Ultimate
  - NCrunch
- ReSharper configuration to support coding rules.
- All 3rd party libraries imported via NuGet

## Known Issues
### Project System/WPF
As of March 2018, the new project system is not feature-complete compared to the classic project system (planned for VS 16.0, see [missing features of the .NET project system](https://github.com/dotnet/project-system/issues?q=is%3Aissue+is%3Aopen+label%3AParity-VSLangProj)).
WPF is not officially supported. The `WPF.props` file should provide everything to build WPF projects. Anyway, it lacks IntelliSense in the XAML designer and Blend does not work.

### PostSharp/VS Live Unit Testing
PostSharp is incompatible with Visual Studio Live Unit Testing
