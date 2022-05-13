\ Copyright (c) 2021-2022 Christopher Leonard, MIT Licence

require vtoolbox/fdict.fs

\ Size of 3x3 matrix
3 3 * floats constant 3x3

\ Print representation of a 3x3 matrix
: 3X3. ( mat -- )
	3 0 do  3 0 do
		dup  j 3 * floats +  i floats +  f@ f.
	loop cr  loop drop ;

\ Create a couple of 3x3 matrices
falign here
	1e f, 0e f, 0e f,
	0e f, 1e f, 0e f,
	0e f, 0e f, 1e f,

	2e f, 0e f, 0e f,
	1e f, 1e f, 0e f,
	1e f, 0e f, 1e f,
constant matrices

\ Print them out
matrices       3x3. cr
matrices 3x3 + 3x3. cr
