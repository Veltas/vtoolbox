\ Copyright (c) 2021-2022 Christopher Leonard, MIT Licence

\ Namespace functionality, see examples/namespaces.fs

\ Create vocabulary word for namespace
( wl " vocab")
: ns-vocab
	create ,
\ Push namespace's wordlist onto search order
does>
	@ >r ( ) ( R: wl)
	get-order ( wl_n ... wl_1 n)
	1+ r> swap set-order ;

\ Create word for postponing name in namespace's wordlist
( wl " prefix")
: ns-prefix
	create , immediate
\ Run/compile given name in namespace's wordlist
( " name")
does>
	@ ( wl)
	parse-name 2dup 2>r rot ( a u wl) ( R: a u)
	search-wordlist
	?dup if ( xt -1|1)
		2r> 2drop ( R: )
		0< if state @ if compile, exit then then
		execute
	else ( )
		2r> type -1 abort" ?"
	then ;

\ Create namespace, with vocabulary and prefix words, set namespace wordlist to
\ current definitions wordlist, push onto search order, and return previous
\ definitions wordlist
( " vocab" " prefix" - prev-wl)
: namespace
	wordlist ( wl " vocab" " prefix")
	dup ns-vocab ( wl " prefix")
	dup ns-prefix ( wl)
	dup >r get-order ( wl wl_n ... wl_1 n) ( R: wl)
	1+ r> swap set-order ( wl) ( R: )
	get-current swap set-current ;
