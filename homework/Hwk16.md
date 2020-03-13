# Ryan Manchanthasouk
## C# Chapter 16 Homework
## March 2nd, 2020
1. Give examples (using valid C# code) of the five bitwise operators listed in the text.
  - ~ = not operator; performs bitwise complement.  Makes all 1s become 0s and 0s become 1s in a value
  - << = left shift operator; >> right shift operator; performs left shift, far left bits are discarded, and zeros are introduced from the right.  Vice versa for right shift operator.
  - OR | operator; binary operator that performs bitwise OR operation.  returns value containing 1 in each position in which either of the operands ha a 1.  
  - AND &; similar to bitwise or, returns value containing 1 in each position where both operands have a 1.
  - XOR ^; performs bitwise exclusive OR operation, returning 1 in each bit where there is a 1 in one operand or the other but not both.
1. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using value C# code.
  - Yes, if you have a bit of 00000001 and you use >>, you will get rid of the rightmost bit and insert a 0 at the left side.
1. Explain in detail this code: bits & (1 << index);.
  - Returns 1 in each bit where there is a 1 in each position where both operands have 1, also moves index left once.
1. Explain in detail this code: bits |= (1 << index);.
  - OR which is perform a left shift on the binary code one place, which will remove the left-most bit and place a 0 in the far right, also returns a value containing 1 in each position in which either of the operands has a 1 in it.
1. Explain in detail this code: bits &= (1 << index);.
  - Returns 1 in each bit where there is a 1 in each position where both operands have 1, then sets the left hand operand to the value of the right hand operand.
1. How does C# interpret this? bool peek = bits[n];
  - Retrieves the bool at the index n, which should be true.  Compiler translates this specific code into a call to the get accessor of that indexer, where the index argument is set to 'n.'
1. How does C# interpret this? bits[n] = true;
  - Sets the accessor of the indexer, which sets the index argument to the value enclosed in the square brackets to true.
1. How does C# interpret this? bits[n] ^= true;
  - Both get and set accessors are used, which inverts the value of the bit at index 'n' in the bits variable, which is equivalent to bits = bits[n] ^ true
1. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
- (a) permission = 0 no permissions
- (b) permission = 1 read
- (c) permission = 2 read and read
- (d) permission = 3 read and write
- (e) permission = 4 execute
- (f) permission = 5 read and execute
- (g) permission = 6 write and execute
- (h) permission = 7 read, write, and execute
1. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?
- (a) = 00000000
- (b) = 00000001
- (c) = 00000010
- (d) = 00000011
- (f) = 00000100
- (g) = 00000110
- (h) = 00000111
- This tells me that permissions are based off the binary position of a number, which the computer can read.  I.e. the computer will convert decimal to binary, which it can read.
