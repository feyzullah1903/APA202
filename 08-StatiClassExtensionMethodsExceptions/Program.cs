namespace _08_StatiClassExtensionMethodsExceptions
{
    using _08_StatiClassExtensionMethodsExceptions.Exceptions;
    using _08_StatiClassExtensionMethodsExceptions.Models;
    using System;

    class Program
    {
        static void Main()
        {
            LoginSystem sys = new LoginSystem();

            while (true)
            {
                try
                {
                    Console.Write("username: ");
                    string u = Console.ReadLine();

                    Console.Write("password: ");
                    string p = Console.ReadLine();

                    bool result = sys.Login(u, p);

                    if (result)
                        break;
                }
                catch (InvalidUsernameException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                catch (InvalidPasswordException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                catch (UserNotFoundException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                    sys.ShowUsers();
                }
                catch (IncorrectPasswordException e)
                {
                    Console.WriteLine("WARNING: " + e.Message);
                }
                catch (AccountLockedException e)
                {
                    Console.WriteLine("CRITICAL: " + e.Message);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("UNKNOWN: " + e.Message);
                }
            }
        }
    }
}
