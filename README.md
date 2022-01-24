# Why Compiled Languages ?

This is a very simple experiment to demonstrate the importance of compiled languages over dynamic or interpreted languages when it comes to system programming or high degree of efficiency.

## Experiment

A simple loop operation to sum up the numbers from 1 to 1,000,000,000 (one billion).

## Execution

Clone the repo, then open `src/` directory.

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

## Evaluation

To obtain the time spent on execution, measure the last line of each run with `time` multiple times and get the average.

For example:

```shell
$ time java Java
...
real	0m0.395s
user	0m0.361s
sys	0m0.028s

$ usr/bin/time -l java Java
...
22679552  maximum resident set size
```

## Results

The two figures below show the comparison between `C++`, `C#`, `Java`, `Ruby`, and `Python` languages in terms of both speed (time) and memory (space).

![1](https://github.com/abarrak/why-compiled-languages/blob/main/output/time.png?raw=true)

![2](https://github.com/abarrak/why-compiled-languages/blob/main/output/space.png?raw=true)

Clearly, the way of optimization of this pure calculation logic in compiled versions as we see in static compiled languages outperformed the interperted languages drastically in terms of speed. Additionally, `Java` and `C#` results show the outstanding optimization made to the compiler and runtime `JVM`/`CLR` to perform nearly identical to the low level languages, for such essential looping computing.

## Contribution

All PRs are welcome for other languages or improvements [on Github](https://github.com/abarrak/why-compiled-languages).

## License

MIT.

## Author

Abdullah Barrak (@abarrak).
