# A Branch a day

#### benchmarking collections

Simple sandbox project for testing assumptions about collection performances.

- I tried using benchmarkdotnet but the documentation didn't seem to show a simple way to benchmark against mutable collections.
- Might come back and redo this using BenchmarkDotnet later, but I needed something that I could very quickly run. 


### Test results

**`Add_is_similar_and_eratic_for_dictionary_and_list_across_small_or_large_datasets()`**

```


Mostly similar, but occasionally both List or Dictionary will be faster, maybe due to GC or fecking windows updates?

running batch 1
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |16.00     |27.00     |0.59      |1.69      |Similar
1000      |67.00     |24.00     |2.79      |0.36      |Similar
100000    |44.00     |52.00     |0.85      |1.18      |Similar
500000    |20.00     |35.00     |0.57      |1.75      |Similar

running batch 2
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |13.00     |24.00     |0.54      |1.85      |Similar
1000      |64.00     |27.00     |2.37      |0.42      |Similar
100000    |18.00     |38.00     |0.47      |2.11      |Similar
500000    |40.00     |29.00     |1.38      |0.73      |Similar

running batch 3
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |14.00     |43.00     |0.33      |3.07      |Faster
1000      |110.00    |30.00     |3.67      |0.27      |Slower
100000    |16.00     |33.00     |0.48      |2.06      |Similar
500000    |17.00     |28.00     |0.61      |1.65      |Similar

running batch 4
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |15.00     |28.00     |0.54      |1.87      |Similar
1000      |130.00    |48.00     |2.71      |0.37      |Similar
100000    |29.00     |58.00     |0.50      |2.00      |Similar
500000    |18.00     |28.00     |0.64      |1.56      |Similar

running batch 5
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |14.00     |30.00     |0.47      |2.14      |Similar
1000      |67.00     |23.00     |2.91      |0.34      |Similar
100000    |26.00     |56.00     |0.46      |2.15      |Similar
500000    |16.00     |27.00     |0.59      |1.69      |Similar

running batch 6
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |15.00     |23.00     |0.65      |1.53      |Similar
1000      |62.00     |30.00     |2.07      |0.48      |Similar
100000    |17.00     |26.00     |0.65      |1.53      |Similar
500000    |26.00     |34.00     |0.76      |1.31      |Similar

running batch 7
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |14.00     |23.00     |0.61      |1.64      |Similar
1000      |67.00     |27.00     |2.48      |0.40      |Similar
100000    |28.00     |53.00     |0.53      |1.89      |Similar
500000    |20.00     |50.00     |0.40      |2.50      |Similar

running batch 8
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |21.00     |36.00     |0.58      |1.71      |Similar
1000      |63.00     |29.00     |2.17      |0.46      |Similar
100000    |26.00     |43.00     |0.60      |1.65      |Similar
500000    |28.00     |54.00     |0.52      |1.93      |Similar

running batch 9
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |23.00     |40.00     |0.58      |1.74      |Similar
1000      |75.00     |26.00     |2.88      |0.35      |Similar
100000    |84.00     |32.00     |2.62      |0.38      |Similar
500000    |16.00     |29.00     |0.55      |1.81      |Similar

running batch 10
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |14.00     |30.00     |0.47      |2.14      |Similar
1000      |84.00     |25.00     |3.36      |0.30      |Slower
100000    |28.00     |64.00     |0.44      |2.29      |Similar
500000    |40.00     |48.00     |0.83      |1.20      |Similar

running batch 11
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |13.00     |26.00     |0.50      |2.00      |Similar
1000      |62.00     |29.00     |2.14      |0.47      |Similar
100000    |20.00     |54.00     |0.37      |2.70      |Similar
500000    |17.00     |29.00     |0.59      |1.71      |Similar

running batch 12
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |15.00     |23.00     |0.65      |1.53      |Similar
1000      |63.00     |28.00     |2.25      |0.44      |Similar
100000    |16.00     |41.00     |0.39      |2.56      |Similar
500000    |30.00     |65.00     |0.46      |2.17      |Similar

running batch 13
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |23.00     |41.00     |0.56      |1.78      |Similar
1000      |97.00     |37.00     |2.62      |0.38      |Similar
100000    |32.00     |48.00     |0.67      |1.50      |Similar
500000    |19.00     |40.00     |0.48      |2.11      |Similar

running batch 14
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |14.00     |24.00     |0.58      |1.71      |Similar
1000      |64.00     |40.00     |1.60      |0.63      |Similar
100000    |42.00     |98.00     |0.43      |2.33      |Similar
500000    |91.00     |113.00    |0.81      |1.24      |Similar

running batch 15
Units are ticks per 100 invocations.
Testing DICT.Add() vs LIST.Add() on small and large collections of Person.

coll size |DICT      |LIST      | D/L     | L/D      | DICT.Add() is
----------------------------------------------------------------
100       |18.00     |33.00     |0.55      |1.83      |Similar
1000      |6713.00   |55.00     |122.05    |0.01      |Slower
100000    |26.00     |65.00     |0.40      |2.50      |Similar
500000    |27.00     |28.00     |0.96      |1.04      |Similar

Asserting that up to the 90th percentile are all similar

Observe that consistently when the list size is around 1000 elements, that List performance around 2 to 3 times faster than dictionary.
 1000, Similar, 2.79      
 1000, Similar, 2.37      
 1000, Slower, 3.67      
 1000, Similar, 2.71      
 1000, Similar, 2.91      
 1000, Similar, 2.07      
 1000, Similar, 2.48      
 1000, Similar, 2.17      
 1000, Similar, 2.88      
 1000, Slower, 3.36      
 1000, Similar, 2.14      
 1000, Similar, 2.25      
 1000, Similar, 2.62      
 1000, Similar, 1.60      
 1000, Slower, 122.05    



```