\ Copyright (c) 2021-2022 Christopher Leonard, MIT Licence

\ Working with floats in the dictionary, see examples/fdict.fs

\ Add a float to dictionary
: f, ( F: f)  here  1 floats allot  f! ;

[defined] dfloats [if]
\ Add a double-float to dictionary
: df, ( F: df)  here  1 dfloats allot  f! ;
[endif]

[defined] sfloats [if]
\ Add a single-float to dictionary
: sf, ( F: sf)  here  1 sfloats allot  f! ;
[endif]
