# A Branch a day

#### benchmarking collections

Simple sandbox project for testing assumptions about collection performances.

- I tried using benchmarkdotnet but the documentation didn't seem to show a simple way to benchmark against mutable collections.
- Might come back and redo this using BenchmarkDotnet later, but I needed something that I could very quickly run. 


### Test results

**`TestDictionaryVsList_Add_ReturnRatio()`**

```
Testing .Add() on large collections of classes.

coll size | LIST     | DICT     | L/D     | D/L       
------------------------------------------------------
small collections
100       |1602.00   |102.00    |15.71     |0.06      
1000      |58.00     |17.00     |3.41      |0.29      

large collections
100000    |12.00     |29.00     |0.41      |2.42      
1000000   |11.00     |27.00     |0.41      |2.45      

small collections dictionary is faster
large collections List is faster
Units are ticks per 100 invocations.```