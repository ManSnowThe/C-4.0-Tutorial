// Пример обработки событий, связанных с нажатием клавиш на клавиатуре.using System;

namespace ca2
{
    // Создать класс, производный от класса EventArgs и
    // хранящий символ нажатой клавиши.
    class KeyEventArgs : EventArgs
    {
        public char ch;
    }

    // Объявить класс события, связанного с нажатием клавиш на клавиатуре.
    class KeyEvent
    {
        public event EventHandler<KeyEventArgs> KeyPress;

        // Этот метод вызывается при нажатии клавиши.        public void OnKeyPress(char key)
        {
            KeyEventArgs k = new KeyEventArgs();

            if (KeyPress != null)
            {
                k.ch = key;
                KeyPress(this, k);
            }
        }
    }
    // Продемонстрировать обработку события типа KeyEvent.
    class KeyEventDemo
    {
        static void Main()
        {
            KeyEvent kevt = new KeyEvent();
            ConsoleKeyInfo key;
            int count = 0;

            // Использовать лямбда-выражение для отображения факта нажатия клавиши.
            kevt.KeyPress += (sender, e) =>
                Console.WriteLine("Получено сообщение о нажатии клавиши: " + e.ch);

            // Использовать лямбда-выражение для подсчета нажатых клавиш
            kevt.KeyPress += (sender, e) =>
                count++; // count - внешняя переменная

            Console.WriteLine("Введите несколько символов. По завершении введите точку.");
                do
                {
                    key = Console.ReadKey();
                    kevt.OnKeyPress(key.KeyChar);
                } while (key.KeyChar != '.');
            Console.WriteLine("Было нажато " + count + " клавиш.");
            }
        }
    }
