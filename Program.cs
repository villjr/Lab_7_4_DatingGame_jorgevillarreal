using System;

namespace _7_4DatingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile John = new DatingProfile("John", "Smith", 44, "Male");
            John.WriteBio("Video Game fanatic who still lives with mom and dad.");

            DatingProfile Jane = new DatingProfile("Jane", "Doe", 43, "Female");
            Jane.WriteBio("Enjoys making candles with my own earwax and has over 10,000 stuffed animals.");

            John.SendMessage("Hello Jane", "Want to go to the forest and make chalk outlines of our bodies?",Jane);
            Jane.ReadMessage();
        }
    }
}
