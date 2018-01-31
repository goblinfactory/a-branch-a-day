# A Branch a day

Sandbox solution that I can quickly test out code with, plus a simple way to keep a reference to any spikes that I want to refer to.

Idea: 

- add a new branch for each new 'thing' I want to test.
- setup the project on Azure so I have automatic builds.
- write a build script that reads all the branches and updates the readme.md on master with a link to all the branches, sortof a poor mans blog, so that I can easily navigate each.
- have a readme.md.template that has the main readme template, with a few simple tokens that can be updated.
- for now, I'll manually update the readme for a few days, and then create the ops scripts at a later stage. 

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