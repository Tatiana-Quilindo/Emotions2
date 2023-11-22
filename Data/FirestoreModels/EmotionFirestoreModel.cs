using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;


namespace Borrador3Proyecto.Data.FirestoreModels
{
    [FirestoreData]
    public class EmotionFirestoreModel
    {
        [FirestoreDocumentId]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Emocion { get; set; }

        [FirestoreProperty]
        public string Autor { get; set; }
    }
}
