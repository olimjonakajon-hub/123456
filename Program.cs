// taski 1

// int FindMid(int a, int b, int c)
// {
//     int min=Math.Max(a, Math.Max(a,b));
//     int max=Math.Min(a,Math.Min(b,c));
//     return a+b+c-max-min;
// }
// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());
// int c=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindMid(a,b,c));


// taski 2

// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());
// if((a>0 && b>0) || (a<0 && b < 0))
// {
//     System.Console.WriteLine("True");
// }
// else
// {
//     System.Console.WriteLine("Folse");
// }
 

//  taski 3
 
//  int a =Convert.ToInt32(Console.ReadLine());
//  int cnt=0;
//  for (int i = a; i >0; i/=10)
//  {
//     cnt++;
//  }
//  for (int i = 0; i <(cnt-1)/2; i++)
//  {
//    a/=10;    
//  }
//  System.Console.WriteLine(a%10);

// // taski 4
// string a=Console.ReadLine()!;
// int cnt=0;
// for (int i = 0; i <a.Length/2; i++)
// {
//     if(a[i] != a[a.Length - 1 - i])
//     {
//         cnt++;
//     }
// }
// if (cnt == 0)
// {
//     System.Console.WriteLine("The string is Palindrome.");
// }
// else
// {
//     Console.WriteLine("The string is not Palindrome.");
// }
