# Why Compiled Languages?

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
_Note: use `mono` on macOS/linux only._
```shell
$ csc csharp.cs
$ mono csharp.exe
```

Python run:
```shell
$ python python.py
```

Ruby run:
```shell
$ ruby ruby.rb
```

Javascript (node) run:
```javascript
$ node javascript.js
```

Go run:
```shell
$ go build go.go
$ ./go
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

$ /usr/bin/time -l java Java
...
22679552  maximum resident set size
```

## Results

Results breakdown:

| Language    | Elapsed Time (second) | Memory (MB) |
| ----------- | --------------------- | ----------- |
| C++         |       0.015           |     7.49    |
| Java        |       0.39            |     23      |
| C#          |       1.172           |    11.88    |
| Ruby        |       21.77           |    13.45    |
| Python      |       17.89           |    4.66     |
| JS (node)   |       0.873           |    22.97    |


Clearly, the way of optimization of this pure calculation logic in compiled versions as we see in static compiled languages outperformed the interperted languages (except `nodeJs`) drastically in terms of speed. Additionally, `Java` and `C#` results show the outstanding optimization made to the compiler and runtime `JVM`/`CLR` to perform nearly identical to the low level languages, for such essential looping computing. 

The two figures below show the comparison between `C++`, `C#`, `Java`, `Ruby`, and `Python` languages in terms of both speed (time) and memory (space).

<image src="https://raw.githubusercontent.com/abarrak/why-compiled-languages/main/output/time.png" width="80%" />

<image src="https://raw.githubusercontent.com/abarrak/why-compiled-languages/main/output/space.png" width="80%" />


## Contribution

All PRs are welcome for other languages or improvements [on Github](https://github.com/abarrak/why-compiled-languages).

## License

MIT.

## Contributors

- Abdullah Barrak [(@abarrak)](https://github.com/abarrak).
- Eliot Akira [(@eliot-akira)](https://github.com/eliot-akira).
