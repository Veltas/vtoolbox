\ Copyright (c) 2021 Christopher Leonard, MIT Licence

\ Namespace functionality, see examples/namespaces.fs

\ Create vocabulary word for namespace
( wl " vocab" --)
: NS-VOCAB
	CREATE ,
\ First search order wordlist set to namespace's
( --)
DOES>
	@ >R
	( ) ( R: wl)
	GET-ORDER
	( wl_n ... wl_1 n)
	NIP R> SWAP SET-ORDER ;

\ Create word for postponing name in namespace's wordlist
( wl " prefix" --)
: NS-PREFIX
	CREATE , IMMEDIATE
\ Run/compile given name in namespace's wordlist
( " name" --)
DOES>
	@
	( wl)
	PARSE-NAME 2DUP 2>R ROT
	( a u wl) ( R: a u)
	SEARCH-WORDLIST
	?DUP IF
		( xt -1|1)
		2R> 2DROP
		( R: )
		0< IF STATE @ IF COMPILE, EXIT THEN THEN
		EXECUTE
	ELSE
		( )
		2R> TYPE -1 ABORT" ?"
	THEN ;

\ Create namespace, with vocabulary and prefix words, set namespace wordlist to
\ current definitions wordlist, return previous definitions wordlist
( " vocab" " prefix" -- prev-wl)
: NAMESPACE
	WORDLIST
	( wl " vocab" " prefix")
	DUP NS-VOCAB
	( wl " prefix")
	DUP NS-PREFIX
	( wl)
	GET-CURRENT SWAP SET-CURRENT ;
