# TechTask

Task:

write a console application; Input of application (via keyboard):
coordinates of 3 points in 2-dimensional coordinate system;
Output of application (to console):

the length of triangle sides;
is it equilateral triangle?
is it isosceles triangle?
is it right triangle?
the perimeter of the triangle;
even numbers from 0 to value of triangle perimeter.
The source code of the application should be uploaded to a public github repository (see instruction in separated file). Note:

input values can be with fractional part;
output values can be rounded;
you can choose you own precision during calculations: For example, for a triangle А(0,0), В(0,4), С(0,4) sides length will be 4, 5,656854249492381, 4. It is the right triangle, because АВ2 + АС2 = ВС2. But 42 + 42 != 5,6568542494923812 (due to a precision of double variable type). To solve this problem, you can say that the triangle is right if ВС2 – (АВ2 + АС2) <= delta, where delta – you own precision.
RESULT SCREEN

![image](https://user-images.githubusercontent.com/95295383/227214865-71d299ca-2fc9-4704-ad3d-b6f95c4dbdd0.png)
