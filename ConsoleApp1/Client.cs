using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Factories;

namespace DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory
{
    
    internal class Client
    {
        private ButtonWidget _button;
        private TextFieldWidget _textField;
        
        public Client(ThemeFactory factory)
        {
            _button = factory.createButton();
            _textField = factory.CreateTextField();
        }
        public void Run()
        {
            _textField.statusChange(_button);
        }
    }
}
