# A Branch a day

#### benchmarking collections

Simple sandbox project for testing assumptions about collection performances.

- I tried using benchmarkdotnet but the documentation didn't seem to show a simple way to benchmark against mutable collections.
- Might come back and redo this using BenchmarkDotnet later, but I needed something that I could very quickly run. 


### Test results

**`Add_is_similar_and_eratic_for_dictionary_and_list_across_small_or_large_datasets()`**

```


Mostly similar, but occasionally both List or Dictionary will be faster, maybe due to GC or fecking windows updates?
When the list size is around 1000 elements then list performance is around 2 to 3 times slower than dictionary. See the bottom of the test output. Test up to 90% percentile across a small sample.

running batch 1
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |10.00     |19.00     |0.53      |1.90      |Similar
1000      |81.00     |18.00     |4.50      |0.22      |Slower
100000    |28.00     |22.00     |1.27      |0.79      |Similar
500000    |12.00     |159.00    |0.08      |13.25     |Faster

running batch 2
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |8.00      |18.00     |0.44      |2.25      |Faster
1000      |135.00    |29.00     |4.66      |0.21      |Slower
100000    |14.00     |147.00    |0.10      |10.50     |Faster
500000    |19.00     |250.00    |0.08      |13.16     |Faster

running batch 3
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |12.00     |28.00     |0.43      |2.33      |Faster
1000      |61.00     |20.00     |3.05      |0.33      |Slower
100000    |12.00     |49.00     |0.24      |4.08      |Faster
500000    |14.00     |43.00     |0.33      |3.07      |Faster

running batch 4
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |8.00      |19.00     |0.42      |2.37      |Faster
1000      |87.00     |33.00     |2.64      |0.38      |Slower
100000    |14.00     |47.00     |0.30      |3.36      |Faster
500000    |12.00     |51.00     |0.24      |4.25      |Faster

running batch 5
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |9.00      |20.00     |0.45      |2.22      |Faster
1000      |96.00     |19.00     |5.05      |0.20      |Slower
100000    |14.00     |25.00     |0.56      |1.79      |Similar
500000    |22.00     |56.00     |0.39      |2.55      |Faster

running batch 6
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |13.00     |31.00     |0.42      |2.38      |Faster
1000      |155.00    |31.00     |5.00      |0.20      |Slower
100000    |18.00     |27.00     |0.67      |1.50      |Similar
500000    |16.00     |67.00     |0.24      |4.19      |Faster

running batch 7
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |8.00      |18.00     |0.44      |2.25      |Faster
1000      |158.00    |34.00     |4.65      |0.22      |Slower
100000    |12.00     |25.00     |0.48      |2.08      |Faster
500000    |17.00     |30.00     |0.57      |1.76      |Similar

running batch 8
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |13.00     |25.00     |0.52      |1.92      |Similar
1000      |80.00     |32.00     |2.50      |0.40      |Slower
100000    |15.00     |35.00     |0.43      |2.33      |Faster
500000    |12.00     |22.00     |0.55      |1.83      |Similar

running batch 9
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |7.00      |18.00     |0.39      |2.57      |Faster
1000      |25.00     |18.00     |1.39      |0.72      |Similar
100000    |18.00     |53.00     |0.34      |2.94      |Faster
500000    |12.00     |56.00     |0.21      |4.67      |Faster

running batch 10
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |8.00      |19.00     |0.42      |2.37      |Faster
1000      |54.00     |22.00     |2.45      |0.41      |Slower
100000    |11.00     |65.00     |0.17      |5.91      |Faster
500000    |12.00     |256.00    |0.05      |21.33     |Faster

running batch 11
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |8.00      |20.00     |0.40      |2.50      |Faster
1000      |67.00     |20.00     |3.35      |0.30      |Slower
100000    |11.00     |24.00     |0.46      |2.18      |Faster
500000    |13.00     |35.00     |0.37      |2.69      |Faster

running batch 12
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |12.00     |30.00     |0.40      |2.50      |Faster
1000      |28.00     |20.00     |1.40      |0.71      |Similar
100000    |14.00     |36.00     |0.39      |2.57      |Faster
500000    |17.00     |40.00     |0.43      |2.35      |Faster

running batch 13
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |13.00     |30.00     |0.43      |2.31      |Faster
1000      |73.00     |20.00     |3.65      |0.27      |Slower
100000    |12.00     |36.00     |0.33      |3.00      |Faster
500000    |17.00     |53.00     |0.32      |3.12      |Faster

running batch 14
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |21.00     |55.00     |0.38      |2.62      |Faster
1000      |92.00     |37.00     |2.49      |0.40      |Slower
100000    |11.00     |38.00     |0.29      |3.45      |Faster
500000    |14.00     |22.00     |0.64      |1.57      |Similar

running batch 15
Units are ticks per 100 invocations.
Testing List.Add() vs Dictionary.Add() on small and large collections of Person.

coll size |List      |Dictionary| L/D     | D/L      | List.Add() is
----------------------------------------------------------------
100       |8.00      |18.00     |0.44      |2.25      |Faster
1000      |25.00     |19.00     |1.32      |0.76      |Similar
100000    |10.00     |35.00     |0.29      |3.50      |Faster
500000    |24.00     |58.00     |0.41      |2.42      |Faster

Observe that consistently when the list size is around 1000 elements, that List performance around 2 to 3 times slower than dictionary.
 1000, Slower, 4.50      
 1000, Slower, 4.66      
 1000, Slower, 3.05      
 1000, Slower, 2.64      
 1000, Slower, 5.05      
 1000, Slower, 5.00      
 1000, Slower, 4.65      
 1000, Slower, 2.50      
 1000, Similar, 1.39      
 1000, Slower, 2.45      
 1000, Slower, 3.35      
 1000, Similar, 1.40      
 1000, Slower, 3.65      
 1000, Slower, 2.49      
 1000, Similar, 1.32      
Asserting that up to the 90th percentile are all Slower

```