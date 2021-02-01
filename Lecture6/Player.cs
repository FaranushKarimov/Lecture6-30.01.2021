namespace _6thLesson
{
    public class Player: IPlayable, IRecordable
    {
        public void Play(){
            System.Console.WriteLine("Playing...");   
        }
        public void Pause(){
            System.Console.WriteLine("Paused...");
        }
        public void Stop(){
            System.Console.WriteLine("Stopped...");
        } 
        public void Record(){
            System.Console.WriteLine("Recording...");
         }
    }
    interface IPlayable{
        void Play();
        void Pause();
        void Stop();
 
    }
    interface IRecordable{
        void Record();
        void Pause();
        void Stop(); 
    }
}