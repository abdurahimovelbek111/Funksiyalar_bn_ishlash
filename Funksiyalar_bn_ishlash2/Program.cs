using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funksiyalar_bn_ishlash2
{
    class Program
    {
        //-------1----------////
        /*
        public static void Hisobla(double a, double b)
        {
            double e = 0.00000000000001;
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] x = new double[n];
            double[] y = new double[n];

            if (a > b && b > 0 && e > 0)
            {
                x[0] = a; y[0] = b;
                for (int i = 1; i < n; i++)
                {
                    y[i] = Math.Sqrt(x[i - 1] * y[i - 1]);
                    x[i] = 1.0 / 2 * (x[i - 1] + y[i - 1]);
                    if (Math.Abs(x[i - 1] - y[i - 1]) < e)
                    {
                        Console.WriteLine("x[" + i + "]=" + x[i]);
                    }
                    else
                    {
                        Console.WriteLine("Afsus exx xato !!!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Quyidagi shartni qanoatlantirmaydii Afsus exxx!!!!!!");
            }
        }*/
        //------2-----//
        /*
        static int[] summ(int n)
        {
            int s = 0;
            int[] a = new int[n];
            Random rand=new Random();
            for(int i=0;i<n;i++)
            {
                a[i] = rand.Next() % 10 + 2;
                Console.Write(a[i]+"   ");
            } 
            Console.WriteLine();
            for(int i=0;i<n;i++)
            {
                s += a[i];
            }
            Console.WriteLine("s="+s);
            return a;
        }*/
        //------3----//
        /*
        static int[] summ(int n)
        {
       
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next() % 10 + 2;
                Console.Write(a[i] + "   ");
            }
            Console.WriteLine();
            int max = a[0];
            for (int i = 0; i < n;i++ )
            {
                if(max<a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("maxsimumi="+max);
                return a;
        }
        */
        //----------4-----//
        /*
        static void Uchburchak(int x1,int x2,int x3,int x4,int x5,int x6,int y1,int y2,int y3,int y4,int y5,int y6)
        {
            int a1, b1, c1, a2, b2, c2;
            a1 = (int)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            a2 = (int)Math.Sqrt(Math.Pow(x5- x4, 2) + Math.Pow(y5 - y4, 2));
            b1 = (int)Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            b2 = (int)Math.Sqrt(Math.Pow(x6 - x5, 2) + Math.Pow(y6 - y5, 2));
            c1 = (int)Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            c2 = (int)Math.Sqrt(Math.Pow(x4- x6, 2) + Math.Pow(y4 - y6, 2));
            double p1=(a1+b1+c1)/2,p2=(a2+b2+c2)/2,s1,s2;
            s1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            s2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
            if(s1>s2)
            {
                Console.WriteLine("Birinchi uchburchak yuzasi:"+s1);
            }
            else
            {
                Console.WriteLine("Ikkinchi uchburchak yuzasi:"+s2);
            }
            
        }*/
        //---------5-----//
        /*
        static int[] ishora(int n)
        {
          
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                //Console.Write(a[i] + "   ");
            }
            Console.WriteLine();
            int l = 0;
            for (int i = 1; i < n; i++)
            {
               if(a[i]<0  &&  a[i-1]>=0)
               {
                   l++;
               }
               else 
               if(a[i-1]<0 && a[i]>=0)
               {
                   l++;
               }
            }
            Console.WriteLine("l="+l);
            
            return a;
        }*/
        //---------6----//
        /*
        static int faktaral(int n,int m)
        {
            int p1 = 1,p2=1,p3=1;
            
            for(int i=0;i<n;i++)
            {
                p1 = p1 * (i + 1);
            }
            Console.WriteLine("p1=" + p1);
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                p2 = p2* (i + 1);
            }
            Console.WriteLine("p2=" + p2);
            Console.WriteLine();
            if(n>=m)
            {
                for (int i = 0; i < n - m; i++)
                {
                    p3 = p3 * (i + 1);
                }
                Console.WriteLine("p3="+p3);
            }
            Console.WriteLine();
            int N = p1 / (p2 * p3);
            return N;
           
        }*/
        //----------7-----//
        //static void  Kompelkssonlar(int a1,int a2,int b1,int b2,)
        //{
        //    string a = "a1 + i * b1"; 
        //    string b="a2+i*b2";
            

        //}
        //-------8-----------//
        /*
        static void Uchburchak(double a,double b,double c,double d)
        {
            if(a+b>c && b+c>a && c+a>b)
            {
                Console.WriteLine("a,b va c tomonlardan  Uchburchak yasash mumkin ");
            }
            else if (a + b <=c && b + c <= a && c + a <=b)
            {
                Console.WriteLine("a,b va c tomonlardan uchburchak yasab bulmaydi");
            }
            if(a+b>d && a+d>b && d+b>a)
            {
                Console.WriteLine("a,b va d tomonlardan  Uchburchak yasash mumkin ");
            }
            else if (a + b <= d && a + d <= b && d + b <= a)
            {
                Console.WriteLine("a,b va d tomonlardan uchburchak yasab bulmaydi ");
            }
            if(a+c>d &&  a+d>c && d+c>a)
            {
                Console.WriteLine("a,c va d tomonlardan  Uchburchak yasash mumkin ");
            }
            else if (a + c <= d && a + d <= c && d + c <= a)
            {
                Console.WriteLine("a,c va d tomonlardan  Uchburchak yasab bulmaydi ");
            }
            if(b+d>c && b+c>d && c+d>b)
            {
                Console.WriteLine("b,c va d tomonlardan  Uchburchak yasash mumkin ");
            }
            else if(b+d<=c && b+c<=d && c+d<=b)
            {
                Console.WriteLine("b,c va d tomonlardan  Uchburchak yasab  bulmaydi ");
            }            
        }
        */
        //-------9--------//
        //static void qisqart(int a,int b)
        //{
        //    double s = 0;
        //    for(int i=0;i<20;i++)
        //    {
        //        s += 1 / (i + 1);
        //    }
        //   int t=0;
        //    while(a!=0)
        //    {
        //        t = a - b;
        //        a /= b;
        //    }
        //    Console.WriteLine(Math.Abs(t)) ;

        //}
        //--------10------------//
        /*
        static double Hisobla(double x)
        {
            double s=0;
            for (double i = 0; i < x;i++)
            {
                if (Math.E * i* 3 - Math.PI * i* 2 - (2 * Math.E + 1) * i + Math.PI * 2 == 0)
                {                 
                    s = s + i;
                }
               
            }
          
            return s;              
        }
         * */
        //--------11----------//
        /*
        static void Mediana_Uchburchak(double a,double b,double c)
        {
            double ma = 1.0/2 * Math.Sqrt(2 * (b * b + c * c) - a * a);
            double mb = 1.0 / 2 * Math.Sqrt(2 * (a * a + c* c) - b * b);
            double mc = 1.0 / 2 * Math.Sqrt(2 * (a * a + b * b) - c * c);
            double m1a = 1.0 / 2 * Math.Sqrt(2 * (mb * mb + mc * mc) - ma * ma);
            double m1b = 1.0 / 2 * Math.Sqrt(2 * (ma * ma + mc * mc) - mb * mb);
            double m1c = 1.0 / 2 * Math.Sqrt(2 * (ma * ma + mb * mb) - mc * mc);
            Console.WriteLine("ma=" + ma + " " + "mb=" + mb + " " + "mc=" + mc);
            Console.WriteLine("m1a="+m1a+" "+"m1b="+m1b+" "+"m1c="+m1c);
        } */
        //--------12--------//
        /*
        static void Integral(int a, int b)
        {
            if (b > a)
            {
                double n1 = 20;
                double h1 = (b - a) / n1;
                double fa1 = Math.Pow(Math.Atan(a), 2);
                double fb1 = Math.Pow(Math.Atan(b), 2);
                double sah1 = 0, s1;
                for (int i = 1; i < n1; i++)
                {
                    sah1 += Math.Pow(Math.Atan(a + i * h1), 2);
                }
                s1 = h1 * (fa1 / 2 + sah1 + fb1 / 2);

                //+++++++++++++++++++++++++++++++
                double n2 = 100;
                double h2 = (Math.PI - 0) / n2;
                double f0 = Math.Sin(Math.Pow(Math.E, 10 * 0));
                double fpi = Math.Sin(Math.Pow(Math.E, 10 * Math.PI));
                double sah2 = 0, s2;
                for (int i = 1; i < n2; i++)
                {
                    sah2 += Math.Sin(Math.Pow(Math.E,10*(0 + i * h2)));
                }
                s2 = h2 * (f0 / 2 + sah2 + fpi / 2);
                double s = s1 + s2;
                Console.WriteLine("s="+s);
            }
        }*/
        //--------13-------//
        /*
        static double[] Kopaytma(int n)
        {
            double[] x = new double[n];
            double[] y = new double[n];
            double[] z = new double[n];
            Random rand = new Random();
            for(int i=0;i<n;i++)
            {
                x[i] = rand.Next() % 10+1 ;
                y[i] = rand.Next() % 10+1;
                z[i] = rand.Next() % 10+1;
            }
            Console.WriteLine();
            for(int i=0;i<n;i++)
            {
                Console.Write(x[i]+"   ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(y[i] + "   ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(z[i] + "   ");
            }
            Console.WriteLine();
            double p1 = 1;
            for(int i=0;i<n;i++)
            {
                p1 = p1 * (1 - Math.Pow(y[i], 2));
            }
            double p2 = 1;
            if(p1>0.5)
            {            
                for(int i=0;i<n;i++)
                {
                    p2 = p2 * (Math.Sin(x[i]) + 2);
                }
                Console.WriteLine("p2="+p2);
            }
            else
            {                
                for(int i=0;i<n;i++)
                {
                    p2 = p2 * (1 - Math.Pow(z[i], 2));
                }
                Console.WriteLine("p2="+p2);
            }
            return x;
        }
        */
        //--------14------//
        //static double[] ifoda(double n)
        //{
        //    double[] a = new double[3];
        //    double e=0.0000001;
        //     if(e>0)
        //        {
        //            double l1 = 0,l2=0,l3=0;
        //            for (double i = 0; i < n; i++)
        //            {
        //                if(Math.Pow(i,3)+i-1==0)
        //                {
        //                    l1++;
        //                    Console.WriteLine("l1=" + l1);
        //                }
        //                //else
        //                //{
        //                //    continue;
        //                //}
        //                if(3*Math.Pow(Math.E,i)+i==0)
        //                {
        //                    l2++;
        //                    Console.WriteLine("l2=" + l2);
        //                }
        //                //else
        //                //{
        //                //    continue;
        //                //}
        //                if(2*i*Math.Log(1+i)==1)
        //                {
        //                    l3++;
        //                    Console.WriteLine("l3=" + l3);
        //                }
        //                //else
        //                //{
        //                //    continue;
        //                //}
        //            }
        //            //double t = Math.Max(l1, Math.Max(l2, l3));
        //            //double k = Math.Min(l1, Math.Min(l2, l3));
        //            //Console.WriteLine(k+"  "+""+t);

        //       }
        //     return a;
        //}

        //----------16-----//
        /*
        static void Uchburchak_nuqta(double x1,double y1,double x2,double y2,double x3,double y3,double x,double y)
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double aa = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));
            double bb = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
            double cc = Math.Sqrt(Math.Pow(x - x3, 2) + Math.Pow(y - y3, 2));
            double p1 = (a + aa + bb) / 2 , p2=(b+bb+cc)/2 , p3=(c+cc+aa)/2;
            double s1=Math.Sqrt(p1*(p1-a)*(p1-aa)*(p1-bb));
            double s2 = Math.Sqrt(p2 * (p2 - b) * (p2 - bb) * (p2 - cc));
            double s3 = Math.Sqrt(p3 * (p3 - c) * (p3 - cc) * (p3 - aa));
            double h1 = 2 * s1 / a , h2=2*s2/b , h3=2*s3/c;
            Console.WriteLine("h1 :"+h1+"  "+"h2 :"+h2+"  "+"h3 :"+h3);
        }
        */
        //----------17----//
        /*
        static void Togri_chiz_uchburchak(double a1,double a2,double a3, double b1,double b2,double b3,double c1,double c2, double c3)
        {
           
            double Ax1=0,Ay1=0,Bx2=0,By2=0,Cx3=0,Cy3=0;
            if((a1*b2-a2*b1)!=0 && b1!=0)
            {
                 Ax1 = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
                 Ay1 = (c1 - a1 * Ax1) / b1;
            }           
            if((a1*b3-a3*b1)!=0 && b1!=0)
            {
               Bx2 = (c1 * b3 - c3 * b1) / (a1 * b3 - a3 * b1);
               By2 = (c1 - a1 * Bx2) / b1;
            }
            if((a2*b3-a3*b2)!=0 && b2!=0)
            {
                Cx3 = (c2 * b3 - c3 * b2) / (a2 * b3 - a3 * b2);
                Cy3 = (c2 - a2 * Cx3) / b2;
            }
            Console.WriteLine("Ax1="+Ax1+"  "+"Ay1="+Ay1+" "+"Bx2="+Bx2+"  "+"By2="+By2+"  "+"Cx3="+Cx3+"  "+"Cy3="+Cy3);
            double a = Math.Sqrt(Math.Pow(Bx2 - Ax1, 2) + Math.Pow(By2 - Ay1, 2));
            double b = Math.Sqrt(Math.Pow(Cx3 - Bx2, 2) + Math.Pow(Cy3 - By2, 2));
            double c = Math.Sqrt(Math.Pow(Cx3 - Ax1, 2) + Math.Pow(Cy3 - Ay1, 2));
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("a="+a+"  "+"b="+b+"  "+"c="+c);
                Console.WriteLine("Uchburchak yasab buladi!!");
            }
            else
            {
                Console.WriteLine("Afsus bu to'g'ri chiziqlardan Uchburchak yasab bulmaydi ");
            }
        }*/
        //----------18-----//
        //static void Ekuk(int a,int b)
        //{

        //}
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(0, 9);
                    Console.Write("a[" + i + "," + j + "]=" + a[i, j] + "     ");
                }
                Console.WriteLine('\n');
            }
            Console.WriteLine('\n');
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = rand.Next(0, 9);
                Console.WriteLine("x[" + i + "]=" + x[i]);
            }
            Console.WriteLine('\n');
            int s = 0, l = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s= s + a[l, j] * x[j];                               
                }
                Console.Write("s[" + i + "," + 0 + "]=" + s + "     ");
                 s = 0;
                l++;
                Console.WriteLine('\n');
            }



            Console.ReadKey();



















           //------------------
           // Console.Write("n=");
           // int n=int.Parse(Console.ReadLine());
           // int[] x = new int[n];
           //// Console.Write("a=");
           // //int a = int.Parse(Console.ReadLine());
           // //Console.Write("b=");
           // //int b = int.Parse(Console.ReadLine());
           // for(int i=0;i<n;i++)
           // {
           //     x[i]=int.Parse(Console.ReadLine());
           // }
           // Console.WriteLine('\t');
           // int k=0,l=0;
           //  while(n!=0)
           // {
           //     while (x[k]!=x[l])
           //     {
           //        if(x[k]>x[l])
           //        {
           //            x[k] = x[k] % x[l];
           //        }
           //        else
           //        {
           //            x[l] = x[l] % x[k];
           //        }
           //        if (x[k] == 0)
           //        {
           //            x[k] = x[l];
           //            Console.Write(x[k] + "    ");
           //        }
           //        if (x[l] == 0)
           //        {                       
           //            x[l] = x[k];
           //            Console.Write(x[l] + "   ");
           //        }            
           //     } 
               
           //     k++;
           //     n--;
           // }

           



                //----------17-----------//
                //Console.Write("a1=");
                //double a1 = double.Parse(Console.ReadLine());
                //Console.Write("a2=");
                //double a2 = double.Parse(Console.ReadLine());
                //Console.Write("a3=");
                //double a3 = double.Parse(Console.ReadLine());
                //Console.Write("b1=");
                //double b1 = double.Parse(Console.ReadLine());
                //Console.Write("b2=");
                //double b2 = double.Parse(Console.ReadLine());
                //Console.Write("b3=");
                //double b3 = double.Parse(Console.ReadLine());
                //Console.Write("c1=");
                //double c1 = double.Parse(Console.ReadLine());
                //Console.Write("c2=");
                //double c2 = double.Parse(Console.ReadLine());
                //Console.Write("c3=");
                //double c3 = double.Parse(Console.ReadLine());
                //Togri_chiz_uchburchak(a1, a2, a3, b1, b2, b3, c1, c2, c3);


                //----------16-----------//
                //Console.Write("x1 :");
                //double x1 = double.Parse(Console.ReadLine());
                //Console.Write("y1 :");
                //double y1 = double.Parse(Console.ReadLine());
                //Console.Write("x2 :");
                //double x2 = double.Parse(Console.ReadLine());
                //Console.Write("y2 :");
                //double y2 = double.Parse(Console.ReadLine());
                //Console.Write("x3 :");
                //double x3 = double.Parse(Console.ReadLine());
                //Console.Write("y3 :");
                //double y3 = double.Parse(Console.ReadLine());
                //Console.Write("x :");
                //double x = double.Parse(Console.ReadLine());
                //Console.Write("y :");
                //double y = double.Parse(Console.ReadLine());
                //Uchburchak_nuqta(x1, x2, x3, x, y1, y2, y3, y);
                //---------14-------//
                //Console.Write("n=");
                //double n = double.Parse(Console.ReadLine());
                //Console.WriteLine(ifoda(n));
                //--------13------//
                //Console.Write("n=");
                //int n = int.Parse(Console.ReadLine());
                //Console.WriteLine(Kopaytma(n));
                //----------12---------//
                //Console.Write("a=");
                //int a = int.Parse(Console.ReadLine());
                //Console.Write("b=");
                //int b = int.Parse(Console.ReadLine());
                //Integral(a, b);
                //----------11--------//
                //Console.Write("a=");
                //double a = double.Parse(Console.ReadLine());
                //Console.Write("b=");
                //double b = double.Parse(Console.ReadLine());
                //Console.Write("c=");
                //double c = double.Parse(Console.ReadLine());
                //Mediana_Uchburchak(a, b, c);
                //----------10---------//
                //   Console.Write("x=");
                //   double x = double.Parse(Console.ReadLine());
                //Console.WriteLine(Hisobla(x)); 
                ////--------9--------//
                //Console.Write("a=");
                //int a = int.Parse(Console.ReadLine());
                //Console.Write("b=");
                //int b = int.Parse(Console.ReadLine());
                //qisqart(a, b);



                //-------------8-------------//
                //Console.Write("a=");
                //double a = double.Parse(Console.ReadLine());
                //Console.Write("b=");
                //double b = double.Parse(Console.ReadLine());
                //Console.Write("c=");
                //double c = double.Parse(Console.ReadLine());
                //Console.Write("d=");
                //double d = double.Parse(Console.ReadLine());
                //Uchburchak(a, b, c, d);

                //--------------6---------//
                //Console.Write("n=");
                //int n = int.Parse(Console.ReadLine());
                //Console.Write("m=");
                //int m = int.Parse(Console.ReadLine());
                //Console.WriteLine(faktaral(n,m));
                //----------------5--------//
                //Console.Write("n=");
                //int n = int.Parse(Console.ReadLine());
                //Console.WriteLine(ishora(n));

                //---------4------//
                //int x1 = int.Parse(Console.ReadLine());
                //int x2 = int.Parse(Console.ReadLine());
                //int x3 = int.Parse(Console.ReadLine());
                //int x4 = int.Parse(Console.ReadLine());
                //int x5 = int.Parse(Console.ReadLine());
                //int x6 = int.Parse(Console.ReadLine());
                //int y1 = int.Parse(Console.ReadLine());
                //int y2 = int.Parse(Console.ReadLine());
                //int y3 = int.Parse(Console.ReadLine());
                //int y4 = int.Parse(Console.ReadLine());
                //int y5 = int.Parse(Console.ReadLine());
                //int y6 = int.Parse(Console.ReadLine());
                //Uchburchak(x1, x2, x3, x4, x5, x6, y1, y2, y3, y4, y5, y6);
                //----------3-----//
                //Console.Write("n=");
                //int n = int.Parse(Console.ReadLine());
                //Console.WriteLine(summ(n));

                //----------2-------//
                //Console.Write("n=");
                //int n = int.Parse(Console.ReadLine());
                //Console.WriteLine(summ(n));
                //--------1--------////
                //Console.Write("a=");
                //double a = double.Parse(Console.ReadLine());
                //Console.Write("b=");
                //double b = double.Parse(Console.ReadLine());
                //Hisobla(a, b);
               
        }
    }
}
