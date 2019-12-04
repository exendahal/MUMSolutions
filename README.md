# MUM Solutions for:

1) An integer is defined to be an even subset of another integer n if every even factor of m is also afactor of n. For example 18 is an even subset of 12 because the even factors of 18 are 2 and 6 andthese are both factors of 12. But 18 is not an even subset of 32 because 6 is not a factor of 32.Write a function with signature int isEvenSubset(int m, int n) that returns 1 if m is an even subsetof n, otherwise it returns 0.<br/>
2) Given a positive integer k, another positive integer n is said to have k-small factors if n can bewritten as a product u*v where u and v are both less than k. For instance, 20 has 10-small factorssince both 4 and 5 are less than 10 and 4*5 = 20. (For the same reason, it is also true to say that 20has 6-small factors, 7-small factors, 8-small factors, etc). However, 22 does not have 10-smallfactors since the only way to factor 22 is as 22 = 2 * 11, and 11 is not less than 10.Write a function hasKSmallFactors with signatuareboolean hasKSmallFactors(int k, int n)which returns true if n has k-small factors. The function should return false if either k or n is notpositive.Examples:hasKSmallFactors(7, 30) is true (since 5*6 = 30 and 5 &lt; 7, 6 &lt; 7).hasKSmallFactors(6, 14) is false (since the only way to factor 14 is 2*7 = 14 and 7 not less than 6)hasKSmallFactors(6, 30) is false (since 5*6 = 30, 6 not less than 6; 3 * 10 = 30, 10 not less than 6; 2 *15 = 30, 15 not less than 6).<br/>
3) A twinoid is defined to be an array that has exactly two even values that are adjacent to oneanother. For example {3, 3, 2, 6, 7} is a twinoid array because it has exactly two even values (2 and6) and they are adjacent to one another. The following arrays are not twinoid arrays.{3, 3, 2, 6, 6, 7} because it has three even values.{3, 3, 2, 7, 6, 7} because the even values are not adjacent to one another{3, 8, 5, 7, 3} because it has only one even value.Write a function named isTwinoid that returns 1 if its array argument is a twinoid array. Otherwiseit returns 0.If you are programming in Java or C#, the function signature isint isTwinoid (int [ ] a);If you are programming in C or C++, the function signature isint isTwinoid(int a[ ], int len) where len is the number of elements in the array.<br/>
4) A balanced array is defined to be an array where for every value n in the array, -n also is in thearray. For example {-2, 3, 2, -3} is a balanced array. So is {-2, 2, 2, 2}. But {-5, 2, -2} is notbecause 5 is not in the array.Write a function named isBalanced that returns 1 if its array argument is a balanced array.Otherwise it returns 0.If you are programming in Java or C#, the function signature isint isBalanced (int [ ] a);If you are programming in C or C++, the function signature isint isBalanced(int a[ ], int len) where len is the number of elements in the array.<br/>
5) Write a function fill with signatureint[ ] fill(int[ ] arr, int k, int n)which does the following: It returns an integer array arr2 of length n whose first k elementsare the same as the first k elements of arr, and whose remaining elements consist ofrepeating blocks of the first k elements.  You can assume array arr has at least kelements. The function should return null if either k or n is not positive.Examples:fill({1,2,3,5, 9, 12,-2,-1}, 3, 10) returns {1,2,3,1,2,3,1,2,3,1}.fill({4, 2, -3, 12}, 1, 5)  returns {4, 4, 4, 4, 4}.fill({2, 6, 9, 0, -3}, 0, 4) returns null.<br/>
6) An array is said to be hollow if it contains 3 or more zeroes in the middle that arepreceded and followed by the same number of non-zero elements. Write a functionnamed isHollow that  accepts an integer array and returns 1 if it is a hollow array,otherwise it returns 0Examples:  isHollow({1,2,4,0,0,0,3,4,5}) returns 1.  isHollow ({1,2,0,0,0,3,4,5})returns 0. isHollow ({1,2,4,9, 0,0,0,3,4, 5}) returns 0.  isHollow ({1,2, 0,0, 3,4}) returns 0.If you are programming in Java or C#, the function signature isint isHollow(int[ ] a).If you are C or C++ programmerint isHollow(int[ ] a, int len)where len is the number of elements in the array. <br/>
7) An array is said to be hollow if it contains 3 or more zeroes in the middle that arepreceded and followed by the same number of non-zero elements. Write a functionnamed isHollow that  accepts an integer array and returns 1 if it is a hollow array,otherwise it returns 0Examples:  isHollow({1,2,4,0,0,0,3,4,5}) returns 1.  isHollow ({1,2,0,0,0,3,4,5})returns 0. isHollow ({1,2,4,9, 0,0,0,3,4, 5}) returns 0.  isHollow ({1,2, 0,0, 3,4}) returns 0.If you are programming in Java or C#, the function signature isint isHollow(int[ ] a).If you are C or C++ programmerint isHollow(int[ ] a, int len)where len is the number of elements in the array. <br/>
8) An Sub array is defined to be an array in which each element is greater than sum of allelements after that. See examples below:{13, 6, 3, 2} is a Sub array. Note that 13 &gt; 2 + 3 + 6, 6 &gt; 3 + 2, 3 &gt; 2.{11, 5, 3, 2} is a NOT a Sub array. Note that 5 is not greater than 3 + 2.Write a function named isSub that returns 1 if its array argument is a Sub array, otherwiseit returns 0.If you are programming in Java or C#, the function signature is:int isSub (int [ ] a)If you are programming in C or C++, the function signature is:int isSub (int a[ ], int len) where len is the number of elements in the array.<br/>
9) An isSym (even/odd Symmetric) array is defined to be an array in which even numbersand odd numbers appear in the same order from “both directions”. You can assume arrayhas at least one element. See examples below:{2, 7, 9, 10, 11, 5, 8} is a isSym array.Note that from left to right or right to left we have even, odd, odd, even, odd, odd, even.{9, 8, 7, 13, 14, 17} is a isSym array.Note that from left to right or right to left we have {odd, even, odd, odd, even, odd}.However, {2, 7, 8, 9, 11, 13, 10} is not a isSym array.From left to right we have {even, odd, even, odd,  odd, odd, even}.From right to left we have {even, odd,  odd, odd, even, odd, even},whichis not the same.Write a function named isSym that returns 1 if its array argument is a isSym array,otherwise it returns 0.If you are programming in Java or C#, the function signature is:int isSym (int [ ] a)If you are programming in C or C++, the function signature is:int isSym (int a[ ], int len) where len is the number of elements in the array.<br/>
10) Write a function named minDistance that returns the smallest distance between two factors of a number. Forexample, consider 1001 = 1*7*11*13. Its factors are 1, 7, 11, 13, 77, 91, 143 and 1001. minDistance(1001)would return 2 because the smallest distance between any two factors is 2 (13 - 11 = 2). As anotherexample, minDistance(8) would return 1 because the factors of 8 are 1, 2, 4, 8 and the smallest distancebetween any two factors is 1 (2 - 1 = 1). Also, minDistance (15) would return 2 since the factors of 15 are 1, 3, 5,15 and the smallest distance between any two factors is 2 (5 - 3 = 2).The function signature isint minDistance(int n).<br/>
11) A Meera array is defined to be an array such that for all values n in the array, the value2*n is not in the array. So {3, 5, -2} is a Meera array because 3*2, 5*2 and -2*2 are not inthe array. But {8, 3, 4} is not a Meera array because for n=4, 2*n=8 is in the array.Write a function named isMeera that returns 1 if its array argument is a Meera array.Otherwise it returns 0.If you are programming in Java or C#, the function signature isint isMeera(int [ ] a)If you are programming in C or C++, the function signature isint isMeera(int a[ ], int len) where len is the number of elements in the array.<br/>
12) Write a function named factorTwoCount that returns the number of times that 2 dividesthe argument.For example, factorTwoCount(48) returns 4 because48/2 = 2424/2 = 1212/2 = 66/2 = 32 does not divide 3 evenly.Another example: factorTwoCount(27) returns 0 because 2 does not divide 27.The function signature isint factorTwoCount(int n);<br/>
13) Write a function sumIsPower with signatuareboolean sumIsPower(int[] arr)which outputs true if the sum of the elements in the input array arr is a power of 2, false otherwise.Recall that the powers of 2 are 1, 2, 4, 8, 16, and so on. In general a number is a power of 2 if andonly if it is of the form 2 n  for some nonnegative integer n. You may assume (without verifying inyour code) that all elements in the array are positive integers. If the input array arr is null, the returnvalue should be false.Examples:  sumIsPower({8,8,8,8}) is true since 8 + 8 + 8 + 8 = 32 = 2 5 .  sumIsPower({8,8,8})  isfalse, since 8 + 8 +8 = 24, not a power of 2.<br/>
14) A Meera number is a number such that the number of nontrivial factors is a factor ofthe number. For example, 6 is a Meera number because 6 has two nontrivial factors : 2and 3. (A nontrivial factor is a factor other than 1 and the number). Thus 6 has twonontrivial factors. Now, 2 is a factor of 6. Thus the number of nontrivial factors is a factorof 6. Hence 6 is a Meera number. Another Meera number is 30 because 30 has 2, 3, 5, 6,10, 15 as nontrivial factors. Thus 30 has 6 nontrivial factors. Note that 6 is a factor of 30.So 30 is a Meera Number. However 21 is not a Meera number. The nontrivial factors of21 are 3 and 7. Thus the number of nontrivial factors is 2. Note that 2 is not a factor of 21.Therefore, 21 is not a Meera number.Write a function named isMeera that returns 1 if its integer argument is a Meera number,otherwise it returns 0.The signature of the function isint isMeera(int n).<br/>
15) A Nice array is defined to be an array where for every value n in the array, there is alsoan element n-1 or n+1 in the array.For example, {2, 10, 9, 3} is a Nice array because2 = 3-110 = 9+13 = 2 + 19 = 10 -1Other Nice arrays include {2, 2, 3, 3, 3}, {1, 1, 1, 2, 1, 1} and {0, -1, 1}.The array {3, 4, 5, 7} is not a Nice array because of the value 7 which requires that thearray contains either the value 6 (7-1) or 8 (7+1) but neither of these values are in thearray.Write a function named isNice that returns 1 if its array argument is a Nice array.Otherwise it returns a 0.If you are programming in Java or C#, the function signature isint isNice(int[ ] a)If you are programming in C or C++, the function signature isint isNice(int a[ ], int len) where len is the number of elements in the array.<br/>
16) A wave array is defined to an array which does not contain two even numbers or two odd numbers in adjacentlocations. So {7, 2, 9, 10, 5}, {4, 11, 12, 1, 6}, {1, 0, 5} and {2} are all wave arrays. But {2, 6, 3, 4} is not a wave arraybecause the even numbers 2 and 6 are adjacent to each other. Also {3, 4, 9, 11, 8} is not a wave array becausethe odd numbers 9 and 11 are adjacent to each other. You can assume array has at least one element.Write a function named isWave that returns 1 if its array argument is a Wave array, otherwise it returns 0.If you are programming in Java or C#, the function signature isint isWave (int [ ] a)If you are programming in C or C++, the function signature isint isWave (int a[ ], int len) where len is the number of elements in the array.<br/>
17) Write a function named countDigit that returns the number of times that a given digit appears in apositive number. For example countDigit(32121, 1) would return 2 because there are two 1s in 32121.Other examples:countDigit(33331, 3) returns 4countDigit(33331, 6) returns 0countDigit(3, 3) returns 1The function should return -1 if either argument is negative, socountDigit(-543, 3) returns -1.The function signature isint countDigit(int n, int digit)Hint: Use modulo base 10 and integer arithmetic to isolate the digits of the number.<br/>

