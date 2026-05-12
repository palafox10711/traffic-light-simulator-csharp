# Traffic Light Simulator — C#

A console-based traffic light management system built in C#.  
Adapted from the [Hyperskill](https://hyperskill.org) Java project as a C# learning exercise.

## What it does

- Add and remove traffic lights identified by unique ids
- Traffic lights automatically cycle through Red → Green → Yellow in a background thread
- Interactive menu running concurrently with the light system

## Concepts covered

- Object-Oriented Programming — classes, encapsulation, enums
- Multithreading — `Thread`, `lock`, race condition prevention
- Collections — `List<T>`, LINQ `FirstOrDefault`
- Input validation — `int.TryParse`, null checking

## How to run

```bash
dotnet run
```

## Tech stack

- C# 12
- .NET 8
