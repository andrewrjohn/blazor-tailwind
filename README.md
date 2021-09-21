
# Blazor + Tailwind

A match made in heaven, maybe. BUnit included.

## Run Locally

Clone the project:

```bash
  # HTTPS
  git clone https://github.com/andrewrjohn/blazor-tailwind.git

  or

  # SSH
  git clone git@github.com:andrewrjohn/blazor-tailwind.git
```

Go to the project directory:

```bash
  cd blazor-tailwind
```

Install dependencies:

```bash
  dotnet restore
  cd BlazorTailwind && yarn install
```

Start the server:

```bash
  # /blazor-tailwind
  dotnet watch run --project BlazorTailwind
  
  or

  # /blazor-tailwind/BlazorTailwind
  dotnet watch run
```
View app at https://localhost:5001 🎉


## Running Tests

To run tests, run the following command from the solution root directory:

```bash
  dotnet test BlazorTailwind.Tests
```
or to run from the test project directory:
```bash
  cd BlazorTailwind.Tests
  dotnet test
```