using System;


namespace ClassLibrary
{
    public class HumanBody
    {
        public void Body(int i)
        {
            switch (i)
            {
                case 1:
                    Console.SetCursorPosition(12, 3);
                    Console.Write("O");
                    Console.SetCursorPosition(0, 12);
                    break;
                case 2:
                    Console.SetCursorPosition(12, 4);
                    Console.Write("|");
                    Console.SetCursorPosition(0, 14);
                    break;
                case 3:
                    Console.SetCursorPosition(11, 4);
                    Console.Write("/");
                    Console.SetCursorPosition(0, 16);
                    break;
                case 4:
                    Console.SetCursorPosition(13, 4);
                    Console.Write("\\");
                    Console.SetCursorPosition(0, 18);
                    break;
                case 5:
                    Console.SetCursorPosition(11, 5);
                    Console.Write("/");
                    Console.SetCursorPosition(0, 20);
                    break;
                case 6:
                    Console.SetCursorPosition(13, 5);
                    Console.Write("\\");
                    Console.SetCursorPosition(0, 22);
                    break;
                default:
                    break;
            }
        }
        public void DeadBody()
        {
            Console.SetCursorPosition(12, 3);
            Console.Write("O");
            Console.SetCursorPosition(11, 4);
            Console.Write("/|\\");
            Console.SetCursorPosition(11, 5);
            Console.Write("/ \\");
            Console.SetCursorPosition(0, 26);
        }
    }
}
