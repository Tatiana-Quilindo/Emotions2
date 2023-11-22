using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using static Google.Rpc.Context.AttributeContext.Types;

namespace Borrador3Proyecto.Data
{

    public class Connection
    {
        public FirestoreDb FirestoreDb { get; set; }
        public string Autor { get; set; }

        public Connection(string autor)
        {
            Autor = autor;
            var filePath = @"Data\musicemotions-cf347-firebase-adminsdk-ld0qe-2a4f43257e.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            FirestoreDb = FirestoreDb.Create("musicemotions-cf347");
        }

        public void InsertEmotionAndAuthor()
        {
            // Crear una nueva emoción con "Alegria" y el nombre del autor
            Emotion emotion = new Emotion(string.Empty, "Alegria", Autor);

            // Insertar la emoción en Firestore
            var fbModel = MapEntityToFirestoreModel(emotion);
            var colRef = FirestoreDb.Collection("Emotion");
            var doc = colRef.AddAsync(fbModel).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private FirestoreModels.EmotionFirestoreModel MapEntityToFirestoreModel(Emotion emotion)
        {
            return new FirestoreModels.EmotionFirestoreModel
            {
                Id = emotion.Id,
                Emocion = emotion.Emocion,
                Autor = emotion.Autor
            };
        }
    }


    /*public class Connection
    {
        public FirestoreDb FirestoreDb { get; set; }
        public string Autor { get; set; }  // Agregar propiedad para almacenar el Autor

        public Connection(string? autor)
        {
            Autor = autor;  // Establecer el valor del Autor desde el constructor

            var filePath = @"Data\musicemotions-cf347-firebase-adminsdk-ld0qe-2a4f43257e.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            FirestoreDb = FirestoreDb.Create("musicemotions-cf347"); 
        }

                public void InsertEmotion(Emotion emotion)
        {
            var fbModel = MapEntityToFirestoreModel(emotion);
            var colRef = FirestoreDb.Collection("Emotion");
            var doc = colRef.AddAsync(fbModel).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private FirestoreModels.EmotionFirestoreModel MapEntityToFirestoreModel(Emotion emotion)
        {
            return new FirestoreModels.EmotionFirestoreModel
            {
                Id = emotion.Id,
                Emocion = emotion.Emocion,
                Autor = emotion.Autor
            };
        }
    }*/
}
