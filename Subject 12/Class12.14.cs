// Сымитировать управление лентой конвейера.
using System;

namespace ca2
{
    class ConveyorControl
    {
        // Перечислить команды конвейера.        public enum Action { Start, Stop, Forward, Reverse};

        public void Conveyor(Action com)
        {
            switch (com)
            {
                case Action.Start:
                    Console.WriteLine("Запустить конвейер.");
                    break;
                case Action.Stop:
                    Console.WriteLine("Остановить конвейер.");
                    break;
                case Action.Forward:
                    Console.WriteLine("Переместить конвейер вперед.");
                    break;
                case Action.Reverse:
                    Console.WriteLine("Переместить конвейер назад.");
                    break;
            }
        }
    }
    class ConveyorDemo
    {
        static void Main()
        {
            ConveyorControl c = new ConveyorControl();

            c.Conveyor(ConveyorControl.Action.Start);
            c.Conveyor(ConveyorControl.Action.Forward);
            c.Conveyor(ConveyorControl.Action.Reverse);
            c.Conveyor(ConveyorControl.Action.Stop);
        }
    }
}
