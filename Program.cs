namespace SessionTwoP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hellllllo Hosnyyyyyyyyyyyyyyyyyyyyyyy;
            //// conctination + 
            //Console.Write("Abdo" + " Saad");
            //Console.WriteLine(1 + 7);// 8 
            //Console.WriteLine("1 + 7");
            //Console.WriteLine("1 + 7" + (1 + 7 ) );
            // string interpolation
            //int x = 9, y = 10;
            //Console.WriteLine("X = " + x + " y = " + y);
            //Console.WriteLine($"x = {x} + y ={y}");

            // string format index  x 0  y 1  z 2
            //Console.WriteLine("x = {0} y = {1}", y , x);

            // string name x , int age y 
            // Hello mr x your age is y
            //string name = "abdo";
            //int age = 25;

            // contcatination
            /*Console.WriteLine("Hello Mr. " + name + "your age is " + age);
            // string interpolation
            Console.WriteLine($"Hello Mr. {name} your age is {age}");
            // string format index
            Console.WriteLine("Hello Mr. {0} your age is {1}", name, age);*/
            // bool ? true : false 
            // bool x = 1 -1 6 7 , 0 ==> false  in c++ 

            /*Console.WriteLine( "bool datatype " + sizeof(bool) );
            // 1 byte = 8 bits 
            // int ? 4 bytes = 32 bits  // 
            // 2 ^ 32 = 4,294,967,296 
            // -2 ^ 31 = -2,147,483,648   
            // ( 2 ^ 31 ) - 1 = 2,147,483,647
            Console.WriteLine("int datatype " + sizeof(int) + " " + int.MinValue + " " + int.MaxValue );
            // byte short float double decimal long 

            Console.WriteLine( sizeof(byte)  + " " + byte.MinValue + " " + byte.MaxValue );
            Console.WriteLine(sizeof(short) + " " + short.MinValue + " " + short.MaxValue);
            Console.WriteLine(sizeof(float) + " " + float.MinValue + " " + float.MaxValue);
            Console.WriteLine(sizeof(double) + " " + double.MinValue + " " + double.MaxValue);
            Console.WriteLine(sizeof(decimal) + " " + decimal.MinValue + " " + decimal.MaxValue);
            Console.WriteLine(sizeof(long) + " " + long.MinValue + " " + long.MaxValue);
*/

            /*float x = 5.5F; // f F 
            double y = 5.5;
            decimal z = 5.5M; // m M
*/

            // int x = 5;
            //int y = 6;
            //int z = x + y;
            //Console.WriteLine(z);
            //Console.WriteLine(x + y);
            //Console.WriteLine(x - y);
            //Console.WriteLine(x * y);
            //Console.WriteLine(x / y);
            //Console.WriteLine(x % y);
            //int x = 5;
            //int y = 6;
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x <= y);
            //int x = 5;
            //int y = 6;
            //Console.WriteLine(x > 4 && y < 7);
            //Console.WriteLine(x > 4 || y < 5);
            //Console.WriteLine(!(x > 4 && y < 7));
            //int x = 5;
            //int y = 6;
            //Console.WriteLine(x & y);
            //Console.WriteLine(x | y);
            //Console.WriteLine(x ^ y);
            //Console.WriteLine(~x);
            //Console.WriteLine(x << 1);
            //Console.WriteLine(x >> 1);
            //int x = 5;
            //int y = 6;
            //Console.WriteLine(x += y);
            //Console.WriteLine(x -= y);
            //Console.WriteLine(x *= y);
            //Console.WriteLine(x /= y);
            //Console.WriteLine(x %= y);
            //Console.WriteLine(x &= y);
            //Console.WriteLine(x |= y);
            //Console.WriteLine(x ^= y);
            //Console.WriteLine(x <<= 1);
            //Console.WriteLine(x >>= 1);
            //int x = 5;
            //int y = 6;
            //Console.WriteLine(x++);
            //Console.WriteLine(x);
            //Console.WriteLine(++x);
            //Console.WriteLine(x);
            //Console.WriteLine(x--);
            //Console.WriteLine(x);
            //Console.WriteLine(--x);
            //Console.WriteLine(x);
            //int x = 5;
            //int y = 6;
            //Console.WriteLine(x > y ? "x is greater than y" : "x is less than y");
            //int x = 5;
            //int y = 6;
            //if (x > y)
            //{
            //    Console.WriteLine("x is greater than

            // casting 
            /*int x = 5;
            double y = x;

            Console.WriteLine(y);*/

            // implicit casting  تلقائي 
            // 1         2       4       8      4         8         16 
            // byte -> short -> int -> long -> float -> double -> decimal
            /*int x = 8;
            double y = x;
            Console.WriteLine(y);
            // explicit casting // يدوي
            // decimal -> double -> float -> long -> int -> short -> byte

            double z = 8.5;
            int w = (int)z;
            Console.WriteLine(w);*/

            /*int x = 100;
            byte y = (byte)x;
            Console.WriteLine(y);

            int xx = 500; //   0001 11110100
            byte yy = (byte)xx;  // xxxxxxxx
            Console.WriteLine(yy);//11110100  // 244 
*/
            //string x = "100";
            //int y = (int)x;

            // Console ? 
            // Convert class  
            /*string x = "100";
            int y  = Convert.ToInt32(x);
            Console.WriteLine(y + 5);*/

            //string x = "100"; 
            //int y = int.Parse(x);

            //double yy = double.Parse(x);

            //Console.WriteLine($"y = {y}  yy = {yy}");

            /*var input = Console.ReadLine(); // string Abdo Saad ? 
            int x = Convert.ToInt32(input);
            int y = int.Parse(input); //?

            // 3 + 6 
            var s1 = Console.ReadLine().Split(' ');
            int x1 = int.Parse(s1[0]);
            int x2 = int.Parse(s1[2]);
            char op = char.Parse(s1[1]);
            // 3+6
            var s2 = Console.ReadLine().Split('+');
            // 3 6
            // 0 1

            // 3 int 
            // + char 
            // 6 int 


*/
            // camelCase 
            // myNameIsAbdoSaad
            // PascalCase
            // MyNameIsAbdoSaad

            // Condition ? true : false 
            // <  >  == != >=  <=  !  && || 
            /*int x = 4, y = 5;
            Console.WriteLine( x < y); // true
            Console.WriteLine(x > y); // false 
            
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);
            Console.WriteLine( !(x < y)  );
*/

            // selection 

            //int x = 4;
            //if (x < 5)
            //{
            //    Console.WriteLine("yes");
            //}

            //
            //if (x >= 5)
            //{
            //    Console.WriteLine("yes");
            //} 
            //else 
            //{
            //    Console.WriteLine("No");
            //}
            // nested if 
            // x = 8
            //char op = '+';
            //if ( op == '-')
            //{

            //}
            //else if( op == '/' )
            //{

            //}
            //else if ( op == '*')
            //{

            //}
            //else // '+'
            //{

            //}

            //if()
            //{
            //    if()
            //    {
            //        if()
            //        {

            //        }
            //    }
            //    else
            //    {

            //    }
            //}

            // 5
            // /
            // 7
            // +  -  / %  * ^ | 

            //  ^ not Power 
            //  ^ Xor 2 ^ 3 = 1
            // 2 10
            // 3 11
            // 1 01

            /*int x1 = 5, y1 = 5;
            char x = '+';
            switch(x)
            {
                case '+':
                    Console.WriteLine( 5 + 8);
                    break;

                case '-':
                    Console.WriteLine("200");
                    break;

                case '*':
                    Console.WriteLine("200");
                    break;

                case '/':
                    Console.WriteLine("200");
                    break;

                case '%':
                    Console.WriteLine("200");
                    break;
                case '^':
                    Console.WriteLine("200");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
*/
            // Loops 
            // for 

            /*int x = Convert.ToInt32(Console.ReadLine()); 
            // 100 99 98 ... 10 0
            for (int i = x; i > 0 ; i /= 2 )
            {
                Console.WriteLine(i);
            }*/

            /*int x = 100; // 100
            int y = x;
            while( y > 0)
            {
                Console.WriteLine(y);
                // code ! 
                y/=2;
            }

            Console.WriteLine( $" x = {x} y = {y}");*/

            /*int x = -4;

            do
            {
                Console.WriteLine(x);
                x--;
            } while (x > 0);
            Console.WriteLine("End." + x);*/

            int x = 7, y = 9;
            int z = x ^ y; // ^ | & << >> ~
            // x = 0000 0111
            // y = 0000 1001

            // z = 0000 0001
            // z = 1 
            Console.WriteLine(z);


        }
    }
}
