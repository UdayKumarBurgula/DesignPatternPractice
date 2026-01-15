

// Readme.md# Design Pattern Practice

mkdir DesignPatternPractice
cd DesignPatternPractice

dotnet new sln -n DesignPatternPractice

dotnet new webapi -n DesignPatternPractice.DesignPatternArchitecturePattern

dotnet sln add DesignPatternPractice.DesignPatternArchitecturePattern.csproj

dotnet new classlib -n DesignPatternPractice.DocxToHtmlConverter

dotnet sln add DesignPatternPractice.DocxToHtmlConverter.csproj