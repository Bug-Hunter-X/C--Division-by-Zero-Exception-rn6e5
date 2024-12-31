# C# Division by Zero Exception

This repository demonstrates a common error in C#: division by zero. The `BuggyCode.cs` file contains code that can throw a `DivideByZeroException`. The `FixedCode.cs` file shows how to handle this exception gracefully.

## How to Reproduce

1. Clone the repository.
2. Compile and run `BuggyCode.cs`. Observe the exception.
3. Compile and run `FixedCode.cs`. Note that the exception is handled.

## Solution

The solution involves checking for the possibility of division by zero before performing the division.  This can be done with a simple conditional statement.  Additional considerations include input validation to prevent zero values from reaching the division operation.