![Nuget](https://img.shields.io/nuget/v/Blazor.TailwindCSS.BUnit?style=flat-square) ![Nuget](https://img.shields.io/nuget/dt/Blazor.TailwindCSS.BUnit?style=flat-square)

# Blazor + Tailwind

A match made in heaven, maybe. BUnit included.

## Getting Started

The easiest way to start using this is to install the dotnet template:

```bash
dotnet new -i Blazor.TailwindCSS.BUnit
```

Then you can bootstrap a new app using the installed template:

```bash
dotnet new blazortailwind -o my-app --name MyApp
```

There you have it! You now have a brand-new Blazor server app that's using TailwindCSS and BUnit 🎉

## Running the App

Go to the project directory:

```bash
  cd my-app
```

Install dependencies:

```bash
  dotnet restore
  cd MyApp
  yarn # or you can use 'npm install'
```

Start the server:

```bash
  dotnet watch run --project MyApp
```

View app at https://localhost:5001 🎉

## Running Tests

To run tests, run the following command from the solution root directory:

```bash
  dotnet test MyApp.Tests
```

or to run from the test project directory:

```bash
  cd MyApp.Tests
  dotnet test
```

_Included are two test examples: `CounterTest.razor` and `CounterTest.cs`. Both accomplish the same thing, but do it in a slightly different manner. Read more about differences trade-offs [here](https://bunit.dev/docs/getting-started/writing-tests.html#write-tests-in-cs-or-razor-files)._

## Documentation

- [Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/)
- [TailwindCSS](https://tailwindcss.com/)
- [BUnit](https://bunit.dev/)
