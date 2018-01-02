; Factorial taken from https://github.com/parrt/simple-virtual-machine/blob/add-functions/src/vm/Test.java#L54

; n < 2
load -3
iconst 2
ilt
brf +3
iconst 1
ret

load -3
load -3
iconst 1
isub
call 0 1
imul
ret

iconst 5
call 0 1
print
halt