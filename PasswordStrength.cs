using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecking
{
    internal class PasswordStrength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Password");
            string password = Console.ReadLine();
            bool res = false;
           res = NumberCheck(password);
           res = CharacterCheck(password);
            res = Symbolcheck(password);
            res = LengthCheck(password);

            if (res == true)
            {
                Login();
            }
            else
            {
                Console.WriteLine("Please set password as per requirements");
            }

            Console.ReadLine();
        }
        public static bool NumberCheck(string password)
        {
            char[] ch = password.ToCharArray();

            for(int i=0; i<ch.Length; i++)
            {
                if (ch[i]>='0' && ch[i]<='9')
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CharacterCheck(string password)
        {
            char[] ch = password.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'z')
                {
                    return true;
                    
                }
            }
            return false;
        }

        public static bool Symbolcheck(string password)
        {
            char[] ch = password.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '&' || ch[i] == '$' || ch[i] == '#' || ch[i]=='@')
                {
                    return true;
                }
            }
            return false;
        }

        public static bool LengthCheck(string password)
        {
            char[] ch = password.ToCharArray();

            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                count++;
            }
            if (count >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Login()
        {
            Console.WriteLine("Your Password is powerful");
        }
    }
}
