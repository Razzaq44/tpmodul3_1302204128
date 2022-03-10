using System;

public class DoorMachine
{
    enum State { Terkunci, Terbuka };
    public static void doorMachine()
    {
        State state = State.Terkunci;
        string[] screenName = { "Terkunci", "Terbuka" };
        Console.WriteLine("Pintu " + screenName[(int)state]);
        while (state != State.Terbuka)
        {            
            Console.Write("Enter Command : ");
            string command = Console.ReadLine();
            switch (state)
            {
                case State.Terkunci:
                    if (command == "Kunci Pintu")
                    {
                        state = State.Terkunci;
                        Console.WriteLine("Pintu Terkunci");
                    }
                    else if (command == "Buka Pintu")
                    {
                        state = State.Terbuka;
                        Console.WriteLine("Pintu Tidak Terkunci");
                    }
                    else
                    {
                        state = State.Terkunci;
                        Console.WriteLine("Pintu Terkunci");
                    }
                    break;
                case State.Terbuka:
                    if (command == "Buka Pintu")
                    {
                        state = State.Terbuka;
                        Console.WriteLine("Pintu Tidak Terkunci");
                    }
                    else if (command == "Kunci Pintu")
                    {
                        state = State.Terkunci;
                        Console.WriteLine("Pintu Terkunci");
                    }
                    else
                    {
                        state = State.Terbuka;
                        Console.WriteLine("Pintu Tidak Terkunci");
                    }
                    break;
            }
        }
        Console.WriteLine("Exit");
    }
}
