\ Copyright (c) 2021 Christopher Leonard, MIT Licence

\ Working with floats in the dictionary, see examples/fdict.fs

\ Add a float to dictionary
: F, ( F: f -- )  HERE  1 FLOATS ALLOT  F! ;

[DEFINED] DFLOATS [IF]
\ Add a double-float to dictionary
: DF, ( F: df -- )  HERE  1 DFLOATS ALLOT  F! ;
[ENDIF]

[DEFINED] SFLOATS [IF]
\ Add a single-float to dictionary
: SF, ( F: sf -- )  HERE  1 SFLOATS ALLOT  F! ;
[ENDIF]
