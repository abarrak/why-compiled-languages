# Why Compiled Languages ?

This is a very simple experiment to demonstrate the importance of compiled languages over dynamic or interpreted languages when it comes to system programming or high degree of efficiency.

## Experiment

A simple loop operation to sum up the numbers from 1 to 1,000,000,000 (one billion).

## Execution

The files are in `/src` directory.

C++ run:

```shell
$ g++ cplusplus.cpp -o cpp -O3
$ ./cpp
```

Java run:

```shell
$ javac java.java
$ java Java
```

C# run:

```shell
$ csc csharp.cs
$ mono csharp.exe
```

Note: use `mono` on macOS/linux only.


Python run:

```shell
$ python python.py
```

Ruby run:

```shell
$ ruby ruby.rb
```

## Results

The two figures below show the comparison between `C++`, `C#`, `Java`, `Ruby`, and `Python` languages in terms of speed (time) and memory.

Clearly, the way of optimization of this pure calculation logic in compiled versions as we see in static compiled languages outperformed the interperted languages drastically. Additionally, `Java` and `C#` results show the outstanding optimization made to the compiler and runtime `JVM`/`CLR` to perform nearly identical to the low level languages, for such essential looping computing.

## Contribution

All PRs are welcome for other languages or improvements [on Github](https://github.com/abarrak/why-compiled-languages).

## License

MIT.

## Author

Abdullah Barrak (@abarrak).
