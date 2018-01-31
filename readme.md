# A Branch a day

#### benchmarking collections

Simple sandbox project for testing assumptions about collection performances.

- I tried using benchmarkdotnet but the documentation didn't seem to show a simple way to benchmark against mutable collections.
- Might come back and redo this using BenchmarkDotnet later, but I needed something that I could very quickly run. 


### Test results

**`TestDictionaryVsList_Add()`**

```
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of ClassThing.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |15.00     |26.00     |0.58      |1.73      |Faster
1000      |89.00     |28.00     |3.18      |0.31      |Slower
100000    |23.00     |35.00     |0.66      |1.52      |Faster
1000000   |20.00     |36.00     |0.56      |1.80      |Faster
```