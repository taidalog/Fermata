# Fermata

An F# helper library for working with values of basic types in F#. Compatible with Fable.

Version 1.0.0

## Features

- Provides functions for working with values of basic types in F#.
- Works in a Fable project.

## Target Frameworks

- .NET Standard 2.0
- .NET 6
- .NET 7
- .NET 8

## Modules

- Array  
   Contains helper functions for working with values of type array.
- Bool  
   Contains helper functions for working with values of type bool.
- Bound  
   Contains helper functions for working with values of number types such as int or float, and lower and upper bounds.
- Int32  
   Contains helper functions for working with values of type int (.NET wrapper functions).
- List  
   Contains helper functions for working with values of type list.
- Regex  
   Contains wrapper functions for .Net System.Text.RegularExpressions.
- Result  
   Contains helper functions for working with values of type Result.
- Seq  
   Contains helper functions for working with values of type seq.
- String  
   Contains helper functions for working with values of type string.
- Tuple  
   Contains helper functions for working with values of tuples.
- Validators  
   Contains helper functions for validation which return values of type Result.

For more information, see each signature file (`.fsi`).

## Installation

.NET CLI,

```
dotnet add package Fermata --version 1.0.0
```

F# Intaractive,

```
#r "nuget: Fermata, 1.0.0"
```

For more information, please see [Fermata on NuGet Gallery](https://www.nuget.org/packages/Fermata).

## Notes

- Don't forget `npm start` before using Fermata in a Fable project. I forgot!

## Known Issue

-

## Release Notes

[Releases on GitHub](https://github.com/taidalog/Fermata/releases)

## Breaking Changes

### 1.0.0

- Removed `RadixConversion` module from Fermata. The module is now separated as a single module [Fermata.RadixConversion](https://github.com/taidalog/Fermata.RadixConversion).
- Function are renamed.
  - `Array.countWith` -> `Array.count`
  - `Array.filterIndexPair` -> `Array.filterIndexed`
  - `Array.splits` -> `Array.splitWith`
  - `Array.splitWith` -> `Array.splitFind`
  - `List.countWith` -> `List.count`
  - `List.filterIndexPair` -> `List.filterIndexed`
  - `List.splits` -> `List.splitWith`
  - `List.splitWith` -> `List.splitFind`
  - `Seq.countWith` -> `Seq.count`
  - `Seq.filterIndexPair` -> `Seq.filterIndexed`
  - `Seq.splits` -> `Seq.splitWith`
  - `Seq.splitWith` -> `Seq.splitFind`
  - `String.splitWith` -> `String.splitFind`

### 0.6.0

- Functions in `Dec` module return values of type `Dec`, a discrinimated union to represent a decimal number. Those functions used to return values of type `string`, `string option` or `Result<int, exn>`.
- Functions in `Bin` module return values of type `Bin`, a discrinimated union to represent a binary number. Those functions used to return values of type `int`, `int option` or `Result<string, exn>`.
- Functions in `Hex` module return values of type `Hex`, a discrinimated union to represent a hexadecimal number. Those functions used to return values of type `int`, `int option` or `Result<string, exn>`.

## Links

- [Repository on GitHub](https://github.com/taidalog/Fermata)
- [NuGet Gallery](https://www.nuget.org/packages/Fermata)

## License

This product is licensed under the [MIT license](https://github.com/taidalog/Fermata/blob/main/LICENSE).
