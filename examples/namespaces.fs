\ Copyright (c) 2021 Christopher Leonard, MIT Licence

INCLUDE forth-lib/namespace.fs

DECIMAL

NAMESPACE LOCAL LOCAL:
	0 VALUE X
	0 VALUE Y
SET-CURRENT

\ Add LOCAL:X and LOCAL:Y
: TEST  LOCAL: X  LOCAL: Y  + . ;

\ Set LOCAL:X to 5 and LOCAL:Y to 7
ALSO LOCAL
	: TEST2  5 TO X  7 TO Y ;
PREVIOUS

TEST2 TEST CR \ Prints 12
