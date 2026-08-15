# NewCalculatorApp

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)

A simple C# console application that calculates the sum of a specified quantity of numbers entered by the user.

## Table of contents

- [About](#about)
- [Features](#features)
- [Requirements](#requirements)
- [Build & Run](#build--run)
- [Usage](#usage)
- [Interactive example](#interactive-example)
- [Behavior notes](#behavior-notes)
- [License](#license)
- [Contributing](#contributing)
- [Contact](#contact)

## About

NewCalculatorApp is a small C# learning project that demonstrates reading user input, basic validation, and computing the sum of a set of numbers entered by the user.

## Features

- Ask the user how many numbers they want to add (between 2 and 12).
- Prompt the user to enter each number (each must be between -1000 and 1000).
- Compute and print the total sum.

## Requirements

- .NET SDK 6.0 or later (download: https://dotnet.microsoft.com/download)
- A terminal or command prompt

## Build & Run

From the repository root run:

```bash
# build the solution
dotnet build

# run the console app using the project file
dotnet run --project NewCalculatorApp/NewCalculatorApp.csproj
```

Running `dotnet run` from the repository root without the `--project` option may not work because the project lives in the `NewCalculatorApp/` subfolder.

## Usage

This application is interactive and does not accept command-line arguments. When you run it, it:

1. Prints a small header "Calculator App".
2. Prompts: "How many numbers do you want to add together? (Enter a value between 2 and 12):" — enter an integer between 2 and 12.
3. Repeatedly prompts: "Enter a number value:" for the specified quantity. Each number must be between -1000 and 1000.
4. After all values are entered the program prints the total as: "Total: {sum}" and waits for you to press ENTER to end the program.

If you enter a quantity outside 2..12 the program prints an error like:

```
Quantity, <value>, is not within range of 2 and 12. Re-enter the value.
```

If you enter a number outside -1000..1000 the program prints an error like:

```
Input number, <value>, is not within range of -1000 and 1000. Re-enter value.
```

## Interactive example

Here is an example session showing the exact prompts the program prints (user input shown after each prompt):

```
Calculator App

How many numbers do you want to add together? (Enter a value between 2 and 12): 3

Enter a number value: 10

Enter a number value: 20

Enter a number value: 5

Total: 35

Press ENTER end program.
```

## Behavior notes

- Quantity limits: the program requires the number of values to be between 2 and 12.
- Value limits: each entered value must be between -1000 and 1000.
- The program uses double precision for input and summation; for extremely large inputs you may want to adjust types or add overflow checks.

## License

This project is licensed under the MIT License — see the [LICENSE](./LICENSE) file for details.

## Contributing

Contributions are welcome! Please open issues for bugs or feature ideas and send pull requests for changes.

Typical workflow:

1. Fork the repository
2. Create a branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m "Describe your change"`
4. Push and open a pull request

## Contact

Maintainer: RichMart87 (https://github.com/RichMart87)

If you'd like further changes (add CI, more examples, or a shorter README), tell me what to include and I'll update it.
