using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> characters = [];
        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character;
            if (characters.TryGetValue(key, out Character? value))
            {
                character = value;
            }
            else
            {
                character = key switch
                {
                    'A' => new CharacterA(),
                    'B' => new CharacterB(),
                    // ...
                    'Z' => new CharacterZ(),
                    _ => null!
                };
                characters.Add(key, character);
            }
            return character;
        }
    }
}
