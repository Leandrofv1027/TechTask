

            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0; int num3 = 0; int num4 = 0; int num5 = 0; int num6 = 0; double ab = 0; double db1 = 0; double db2 = 0;
            double ac1 = 0; double ac2 = 0; double ac = 0; double bc;
            double bc1 = 0; double bc2 = 0;

            Console.WriteLine();

            // Ask the user to type the coordinate X of Dot A.
            Console.WriteLine("Enter coordinate of x dot A");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the coordinate y of Dot A.
            Console.WriteLine("Enter coordinate of y dot A");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the coordinate X of Dot B.
            Console.WriteLine("Enter coordinate of x dot B");
            num3 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the coordinate y of Dot B.
            Console.WriteLine("Enter coordinate of y dot B");
            num4 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the coordinate X of Dot c.
            Console.WriteLine("Enter coordinate of x dot C");
            num5 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the coordinate y of Dot c.
            Console.WriteLine("Enter coordinate of y dot C");
            num6 = Convert.ToInt32(Console.ReadLine());

            //formula of perimeter
            //raiz(x2-x1)^2+(y2-y1)^2
            //ab=Distance Between a & b
            //ac=Distance Between a & c

            Console.WriteLine();


            ///DISTANCE Between A & b 

            db1 = (num3 - num1);
            double edb1 = Math.Pow(db1, 2); // Elevarlo a la potencia 2
           //Console.WriteLine(string.Format("{0} elevado al cubo es {1}", db1, edb1));

            db2 = (num4 - num2);
            double edb2 = Math.Pow(db2, 2); // Elevarlo a la potencia 2
           //Console.WriteLine(string.Format("{0} elevado al cubo es {1}", db2, edb2));
                                            

            ab = edb1 + edb2;
            //Console.WriteLine(string.Format("Resultado {0} ", ab));

            double result = Math.Sqrt(ab);
            Console.WriteLine("Length of AB is: {0}", result);


            //DISTANCE Between B & C 

            bc1 = (num5 - num3);
            double ebc1 = Math.Pow(bc1, 2); // Elevarlo a la potencia 2
           //Console.WriteLine(string.Format("{0} elevado al cubo es {1}", bc1, ebc1));

            bc2 = (num6 - num4);
            double ebc2 = Math.Pow(bc2, 2); // Elevarlo a la potencia 2
             //Console.WriteLine(string.Format("{0} elevado al cubo es {1}", bc2, ebc2));


            bc = ebc1 + ebc2;
            //Console.WriteLine(string.Format("Resultado {0} ", bc));
            double result3 = Math.Sqrt(bc);
            Console.WriteLine("Length of BC is: {0}", result3);


            ///DISTANCE Between A & C 

            ac1 = (num5 - num1);
            double eac1 = Math.Pow(ac1, 2); // Elevarlo a la potencia 2
             //Console.WriteLine(string.Format("{0} elevado al cubo es {1}", ac1, eac1));

            ac2 = (num6 - num2);
            double eac2 = Math.Pow(ac2, 2); // Elevarlo a la potencia 2
                //Console.WriteLine(string.Format("{0} elevado al cubo es {1}", ac2, eac2));
                  

            ac = eac1 + eac2;
            //Console.WriteLine(string.Format("Resultado {0} ", ac));
            double result2 = Math.Sqrt(ac);
            Console.WriteLine("Length of AC is: {0}", result2);

            Console.WriteLine();
            Console.WriteLine();

            //ROUNDING

            decimal dresult = Convert.ToDecimal(result);
            decimal dresult2 = Convert.ToDecimal(result2);
            decimal dresult3 = Convert.ToDecimal(result3);
            //Console.WriteLine("{0} --> {1}", result, Decimal.Round(dresult));
            //Console.WriteLine("{0} --> {1}", result2, Decimal.Round(dresult2));
            //Console.WriteLine("{0} --> {1}", result3, Decimal.Round(dresult3));
            decimal t1 = (decimal)Math.Pow((double)dresult, 2);
            decimal t2 = (decimal)Math.Pow((double)dresult2, 2);
            decimal t3 = (decimal)Math.Pow((double)dresult3, 2);


            //EQUILATERAL
            if (t3 == t2 && t2 == t1)
            {
                Console.WriteLine("Triangle is 'Equilateral'.");
            }
            else
            {
                Console.WriteLine("Triangle is 'NOT Equilateral'");
            }

            //ISOSCELES

            if (t3 == t2 || t2 == t1 || t3 == t1)
            {
                Console.WriteLine("Triangle is 'Isosceles'.");
            }
            else
            {
                Console.WriteLine("Triangle is 'NOT Isosceles'");
            }

            //RIGHT TRIANGLE

            if (t3 == (t2 + t1))
            {
                Console.WriteLine("Triangle is 'Right'.");
            }
            else
            {
                Console.WriteLine("Triangle is 'NOT Right'");
            }

            //RESULT OF PERIMETER
            Console.WriteLine();
            Console.WriteLine();


            double resultadoP = result + result2 + result3;

            Console.WriteLine("Perimeter is '{0}'", resultadoP);
            Console.WriteLine();
            Console.WriteLine();

            //Parity numbers 
            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter");

            int n = 0;
            while (n < resultadoP)
            {
                Console.WriteLine(n);
                n = n + 2;
            }
    
