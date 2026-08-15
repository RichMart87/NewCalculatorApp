# NewCalculatorApp

A simple C# console application that calculates the sum of all integers in a specified range.

## Table of contents

- [About](#about)
- [Features](#features)
- [Requirements](#requirements)
- [Build & Run](#build--run)
- [Usage](#usage)
- [Examples](#examples)
- [Behavior notes](#behavior-notes)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## About

NewCalculatorApp is a small C# learning project that demonstrates reading user input, basic validation, and computing the sum of integers between two endpoints (inclusive). It's suitable as an introductory example for people learning .NET console applications.

## Features

- Compute the sum of all integers between a start and end value (inclusive).
- Handles negative numbers and zero.
- Simple console prompts and clear output.

## Requirements

- .NET SDK 6.0 or later (download: https://dotnet.microsoft.com/download)
- A terminal or command prompt

## Build & Run

1. Clone the repository:

   ```bash
   git clone https://github.com/RichMart87/NewCalculatorApp.git
   cd NewCalculatorApp
   ```

2. Build the project:

   ```bash
   dotnet build
   ```

3. Run the project (from the project directory or specify the .csproj):

   ```bash
   dotnet run --project ./NewCalculatorApp.csproj
   ```

   If the repository contains a single console project at the root, running `dotnet run` from the repository root will also work.

## Usage

The app prompts for two integers: a start value and an end value. It then calculates and prints the sum of all integers from start to end, inclusive.

If the application supports command-line arguments (check the code), you can run it like:

```bash
# Example assuming the app accepts two arguments: start end
dotnet run -- 1 10
# Output: Sum of numbers from 1 to 10 is: 55
```

## Examples

Interactive example:

```
Enter start: 1
Enter end: 10
Sum of numbers from 1 to 10 is: 55
```

Negative-range example:

```
Enter start: -2
Enter end: 2
Sum of numbers from -2 to 2 is: 0
```

## Behavior notes

- If the start value is greater than the end value, the program may either swap the values or return a result based on the implementation. Review the code to see how this case is handled and modify it if you want a specific behavior.
- Very large ranges can produce sums that exceed a 32-bit integer — consider using 64-bit integers (long) if needed.

## Contributing

Contributions are welcome! Please open issues for bugs or feature ideas and send pull requests for changes.

Typical workflow:

1. Fork the repository
2. Create a branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m "Describe your change"`
4. Push and open a pull request

## License

No license specified. If you'd like a license (for example MIT), tell me which one and I can add a LICENSE file.

## Contact

Maintainer: RichMart87 (https://github.com/RichMart87)

If you'd like adjustments (shorter/longer README, add badges, CI instructions, or a LICENSE file), tell me what to include and I'll update it.