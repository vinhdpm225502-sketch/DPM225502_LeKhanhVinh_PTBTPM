﻿namespace DPM225502_LeKhanhVinh_MyWorld01_Flyweight {
    public class Program
    {
        public static void Main()
        {
            // Build document with text
            var document = "AAZZBBZB";

            var factory = new CharacterFactory();
            // extrinsic state
            int pointSize = 10;
            // For each character use a flyweight object
            foreach (char c in document)
            {
                var character = factory.GetCharacter(c);
                character.Display(++pointSize);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}