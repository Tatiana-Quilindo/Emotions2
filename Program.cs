using Borrador3Proyecto.Data.Repositories;
using Borrador3Proyecto.Data;
using Borrador3Proyecto.Utils;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using static Google.Rpc.Context.AttributeContext.Types;

namespace Borrador3Proyecto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------Create");
            Console.Write("Ingrese el nombre del Autor: ");
            string autor = Console.ReadLine();

            Connection dbConn = new Connection(autor);
            dbConn.InsertEmotionAndAuthor();
            EmotionRepository EmotionRepo = new EmotionRepository(dbConn);
  

            Emotion newEmotion = new Emotion(string.Empty, "Alegria", autor);
            EmotionRepo.Insert(newEmotion);


            Console.WriteLine("------finAll");

            var all = EmotionRepo.FindAll();

            foreach (var item in all) 
            { 
            
                Console.WriteLine($"{item.Id}) {item.Emocion} {item.MusicList}");
            }

            Console.WriteLine("------Find by id");

            var oneEntity = EmotionRepo.FindById(all.First().Id);
            Console.WriteLine($"{oneEntity.Id}{oneEntity.Emocion}{oneEntity.MusicList}");

            /*Console.WriteLine("------Delete");

            EmotionRepo.Delete(all.First().Id);

            Console.WriteLine("------Update");*/

            Emotion updateEmotion =all.Last();
            updateEmotion.Emocion = "Nostalgia";

            EmotionRepo.Update(updateEmotion);

            EmotionApp.Run();
        }
    }
}
