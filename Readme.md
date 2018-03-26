# Features
- All project templates based on new project system (dotnet/project-system)
- Common project settings separated in a set of `.props` files
- Templates for several project types
  - .NET Core 2
  - .NET 4.7.1
    - WPF App
- Code Analysis with predefined rulesets (configured in `CodeAnalysis.props`).
  - FxCop
  - StyleCop
  - Invoked on a per-project basis
  - Separate rulesets for production code and unit test
  - Generally NoWarning policy
- Unit Test Templates for xUnit and MSTest 2
- Unit Tests preconfigured to use 
  - FluentAssertions
  - NSubstitute
- Unit Tests working with TDD tools:
  - VS Live Unit Testing (__not__ in combination with PostSharp!, see _„Known Issues”_)
  - ReSharper Ultimate
  - NCrunch
- ReSharper configuration to support CCD rules.
- All 3rd party libraries imported via NuGet

# Known Issues
## Project System/WPF
As of April 2018, the new project system is not feature-complete compared to the classic project system (planned for VS 16.0).
WPF is not officially supported. The `WPF.props` file should provide everything to build WPF projects. Anyway, it lacks IntelliSense in the XAML designer and Blend does not work.

## PostSharp/VS Live Unit Testing
PostSharp is incompatible with Visual Studio Live Unit Testing
