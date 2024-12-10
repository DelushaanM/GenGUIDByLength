# GUID Generator Plugin

This NuGet package plugin is a simple and efficient solution for generating GUIDs (Globally Unique Identifiers) of customizable lengths. By providing a length parameter, the plugin generates GUIDs tailored to your specific needs, offering flexibility and control over the output.

## Features

- **Custom Length Generation**: Generate GUIDs with a length specified by the user.
- **Easy Integration**: Seamlessly integrate into any .NET project with minimal setup.
- **Lightweight**: Designed to be fast and efficient, ensuring high performance without adding unnecessary overhead.
- **Cross-Platform Compatibility**: Compatible with .NET Standard, making it usable across various .NET platforms like .NET Framework, .NET Core, and .NET 6+.

## Installation

Install the package via NuGet Package Manager:

```bash
Install-Package Gen.GUID.By.Length --version 1.0.0
```

Or via the .NET CLI:

```bash
dotnet add package Gen.GUID.By.Length --version 1.0.0
```

## Usage

Here's how you can use the plugin in your project:

```csharp
using GuidGeneratorPlugin;

class Program
{
    static void Main(string[] args)
    {
        int length = 16; // Desired length of the GUID
        string customGuid = GuidGenerator.Generate(length);

        Console.WriteLine($"Generated GUID: {customGuid}");
    }
}
```

### Parameters

- **length** (int): The desired length of the GUID. Must be a positive integer.

### Output

The generated GUID will be a string of the specified length, containing alphanumeric characters.

## Advantages

1. **Flexibility**: The ability to specify GUID length provides greater control over the identifier format, making it suitable for various use cases.
2. **Simplified Development**: Eliminates the need for custom GUID generation logic, saving time and reducing errors.
3. **Consistency**: Ensures that GUIDs are consistently generated based on your specified parameters.
4. **Enhanced Performance**: The lightweight nature of the plugin ensures quick GUID generation without affecting application performance.
5. **Cross-Platform Usability**: Works seamlessly across different .NET platforms, increasing the scope of its applicability.

## Contributing

Contributions are welcome! If you have ideas for improvement or encounter any issues, feel free to open an issue or submit a pull request on the [GitHub repository](#).

## License

This project is licensed under the MIT License. See the LICENSE file for more details.

---

Let me know if you'd like to refine or expand this README further!
