\ Copyright (c) 2021 Christopher Leonard, MIT Licence

INCLUDE forth-lib/fdict.fs

DECIMAL

\ Size of 3x3 matrix
3 3 * FLOATS CONSTANT 3X3

\ Print representation of a 3x3 matrix
: 3X3. ( mat -- )
	3 0 DO  3 0 DO
		DUP  J 3 * FLOATS +  I FLOATS +  F@ F.
	LOOP CR  LOOP DROP ;

\ Create a couple of 3x3 matrices
FALIGN HERE
	1E F, 0E F, 0E F,
	0E F, 1E F, 0E F,
	0E F, 0E F, 1E F,

	2E F, 0E F, 0E F,
	1E F, 1E F, 0E F,
	1E F, 0E F, 1E F,
CONSTANT MATRICES

\ Print them out
MATRICES       3X3. CR
MATRICES 3X3 + 3X3. CR
