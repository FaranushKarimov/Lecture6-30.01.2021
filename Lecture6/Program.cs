using System;

namespace _6thLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// Key for Particular version
            /// </summary>
            string PRO_KEY = "root", EXP_KEY = "toor"; 
            
            /// <summary>
            /// Init of DocumentWorker class in Main
            /// </summary>
            DocumentWorker document = new DocumentWorker(); 
            
            startOfProgram:
                System.Console.Write(@"
                                        Сделайте выбор:
                                        1. Использовать демо версию
                                        2. Использовать код версии
                                        Выберите номер :  ");
                                        int choice = int.Parse(Console.ReadLine());
                string messageToUser = ""; 
                switch( choice ){
                    case 1: {
                        messageToUser = "Вы выбрали демо версию с ограниченным функционалом."; 
                        document = new DocumentWorker(); 
                    }break; 
                    case 2: {
                        messageToUser = "Вы ввели код для использования "; 
                        System.Console.Write(@"
                                        Введите код:");
                        string tempKey = Console.ReadLine(); 
                        if ( tempKey == EXP_KEY ){
                            document = new ExpertDocumentWorker(); 
                            messageToUser+= "Эксперт версии"; 
                        }
                        if ( tempKey == PRO_KEY ){
                            document = new ProDocumentWorker();
                            messageToUser+= "Про версии";  
                        }
                    }break; 
                    default:{
                        System.Console.WriteLine("Неправильно...");
                        goto startOfProgram; 
                    }
                }
            bool working = true; 
            System.Console.WriteLine(messageToUser);
            while ( working ){
                    
                System.Console.Write(@"
                                        Фунции данной программы:
                                        1. Открытие документа
                                        2. Изменение документа
                                        3. Сохранение документа
                                        4. Выход
                                        Выбор по номеру: ");
                                        choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        Console.ForegroundColor = ConsoleColor.Green; 
                        document.OpenDocument();
                        Console.ForegroundColor = ConsoleColor.White; 
                    }break;

                    case 2:{
                        Console.ForegroundColor = ConsoleColor.Green;
                        document.EditDocument();
                        Console.ForegroundColor = ConsoleColor.White; 
                    }break; 

                    case 3: {
                        Console.ForegroundColor = ConsoleColor.Green;
                        document.SaveDocument();
                        Console.ForegroundColor = ConsoleColor.White;  
                    }break; 
                    case 4:{
                        working = false; 
                    }break; 
                    default:{
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine(@"
                                        Неправильный выбор
                                        Повторите попытку");
                                        
                        Console.ForegroundColor = ConsoleColor.White;
                    }break;
                }
                

            }
        Player player = new Player();  
        working = true; 
        while ( working ){
            System.Console.Write(@"
                        1. Player
                        2. Recorder
                        3. Exit
                        Number of your choice:  ");
                        choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{ 
                    System.Console.Write(@"
                        1. Play
                        2. Pause
                        3. Stop");  
                    int choice1 = int.Parse(Console.ReadLine());
                    switch(choice1){
                        case 1:{
                            player.Play(); 
                        }
                        break; 
                        case 2:{
                            player.Pause(); 
                        }
                        break; 
                        case 3:{
                            player.Stop();
                        }
                        break; 
                        default:{
                            System.Console.WriteLine("Повторите попытку.....");
                        }break; 
                    }
                }break; 

                case 2:{ 
                    System.Console.Write(@"
                        1. Record
                        2. Pause
                        3. Stop");  
                    int choice1 = int.Parse(Console.ReadLine());
                    switch(choice1){
                        case 1:{
                            player.Record(); 
                        }
                        break; 
                        case 2:{
                            player.Pause(); 
                        }
                        break; 
                        case 3:{
                            player.Stop();
                        }
                        break; 
                        default:{
                            System.Console.WriteLine("Повторите попытку.....");
                        }break; 
                    }
                }break; 
                case 3:{
                    working = false; 
                }
                break; 

                default:{
                    System.Console.WriteLine("Повторите попытку.....");
                }break; 
            }
        }

        }
    }

}
