# Fermata

An F# helper library for working with values of basic types in F#. Compatible with Fable.

Version 0.6.0

## Features

- Provides functions for working with values of basic types in F#.
- Works in a Fable project.

## Modules

- Array  
   Contains helper functions for working with values of type array.
- Bool  
   Contains helper functions for working with values of type bool.
- Bound  
   Contains helper functions for working with values of number types such as int or float, and lower and upper bounds.
- List  
   Contains helper functions for working with values of type list.
- Int32  
   Contains helper functions for working with values of type int (.NET wrapper functions).
- RadixConversion  
   Contains modules for radix conversion.
  - Dec  
     Contains helper functions for base 10 radix conversion (.NET wrapper functions).
  - Bin  
     Contains helper functions for base 2 radix conversion (.NET wrapper functions).
  - Hex  
     Contains helper functions for base 16 radix conversion (.NET wrapper functions).
  - Arb  
     Contains helper functions for radix conversion with an **Arb**itrary base.
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
dotnet add package Fermata --version 0.6.0
```

F# Intaractive,

```
#r "nuget: Fermata, 0.6.0"
```

For more information, please see [Fermata on NuGet Gallery](https://www.nuget.org/packages/Fermata).

## Notes

- Don't forget `npm start` before using Fermata in a Fable project. I forgot!

## Known Issue

-

## Release Notes

[Releases on GitHub](https://github.com/taidalog/Fermata/releases)

## Links

- [Repository on GitHub](https://github.com/taidalog/Fermata)
- [NuGet Gallery](https://www.nuget.org/packages/Fermata)

## License

This product is licensed under the [MIT license](https://github.com/taidalog/Fermata/blob/main/LICENSE).
