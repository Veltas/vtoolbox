\ Copyright (c) 2021-2022 Christopher Leonard, MIT Licence

require vtoolbox/namespace.fs

namespace local local::
	0 value x
	0 value y
set-current previous

\ Add LOCAL:: X and LOCAL:: Y
: test  local:: x  local:: y  + . ;

\ Set LOCAL:: X to 5 and LOCAL:: Y to 7
local
	: test2  5 to x  7 to y ;
previous

test2 test cr \ Prints 12

local:: x  local:: y  * .  cr  \ Prints 35
