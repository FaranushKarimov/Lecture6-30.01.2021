using System; 

namespace _6thLesson
{
    public class DocumentWorker
    {
        public virtual void OpenDocument(){
            System.Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument(){
            System.Console.WriteLine("Редактирование документа достуно в версии Про");
        }
        public virtual void SaveDocument(){
            System.Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument(){
            System.Console.WriteLine("Документ отредактирован.");
        }

        public override void SaveDocument(){
            System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт.");    
        }

    }
    class ExpertDocumentWorker: ProDocumentWorker
    {
       
        public override void SaveDocument(){
            System.Console.WriteLine("Документ сохранен в новом формате.");
        }
    }

}