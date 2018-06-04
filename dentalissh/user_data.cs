using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dentalissh
{
    class user_data
    {
        int i, n;
        string[] names;
        string[] address;
        string[] gender ;
        string[] contact;
        int[] userid;
        double[] bills;
        public void surface ()
        {
            Console.WriteLine("Input number of patients to be inputed (<10):\n");
            int n = Convert.ToInt32(Console.ReadLine());
            names = new string[n];
            address = new string[n];
            gender = new string[n];
            contact = new string[n];
            userid = new int[n];
            bills = new double[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Input data for patient {0}\n", i+1);
                Console.WriteLine("Input name");
                names[i] = Console.ReadLine();
                Console.WriteLine("Input address");
                address[i] = Console.ReadLine();
                Console.WriteLine("Input gender");
                gender[i] = Console.ReadLine();
                Console.WriteLine("Input contact");
                contact[i] = Console.ReadLine();
                Random generator = new Random();
                userid[i] = generator.Next(00000001, 10000000);
                bills[i] = 0;
                Console.WriteLine("User ID = {0}\n", userid[i]);

            }
            Options1();
        }
        
        public void display_data()
        {
            Console.WriteLine("Number of Clinic Patients --- {0} patient(s)",n+1);
            Console.WriteLine("Input patient id to display data:\n");
            int ud = Convert.ToInt32(Console.ReadLine());
            int udindex;
            for (int i = 0; i < userid.Length; i++)
            {
                if (ud == userid[i])
                {
                    udindex = i;
                    Console.WriteLine("\nNAME       --- {0}\nADDRESS    --- {1}\nGENDER     --- {2}\nCONTACT    --- {3}\nUSER ID    --- {4}\nBILL        --- N {5}\n", names[udindex], address[udindex], gender[udindex], contact[udindex], userid[udindex],bills[udindex]);
                }
            }
            Options1();
        }

        public void billings()
        {
            Console.WriteLine("Input id of patient to be billed:\n");
            int ud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input bill:\n");
            double bill = Convert.ToInt32(Console.ReadLine());
            int udindex;
            for (int i = 0; i < userid.Length; i++)
            {
                if (ud == userid[i])
                {
                    udindex = i;
                    bills[udindex] = bill;
                }
            }
            Options1();
        }
        public void Options()
        {
            Console.WriteLine("\nWelcome to the automated dental care system.\nPlease select operation to be performed:\n1.   View patient details.\n2.   Input patient details.\n3.   Post appointment billing\n");
            int result = Int32.Parse(Console.ReadLine());
            switch (result)
            {
                case 1:
                    display_data();
                    break;
                case 2:
                    surface();
                    break;
                case 3:
                    billings();
                    break;
            }
        }
        public void Options1()
        {
            Console.WriteLine("Perform another operation:\n1. Yes\n2. No");
            int result1 = Int32.Parse(Console.ReadLine());
            switch (result1)
            {
                case 1:
                    Options();
                    break;
                case 2:
                    Console.Beep();
                    break;
            }
        }
    }
}
