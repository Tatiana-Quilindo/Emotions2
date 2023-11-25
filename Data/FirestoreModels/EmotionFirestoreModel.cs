using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace Borrador3Proyecto.Data.FirestoreModels
{
    [FirestoreData]
    public class EmotionFirestoreModel
    {
        [FirestoreDocumentId]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Emocion { get; set; }
        /*
        [FirestoreProperty]
        public string Autor { get; set; }*/

        [FirestoreProperty]
        public string Autor { get; set; }
        [FirestoreProperty]

        public string Género { get; set; }
        [FirestoreProperty]
        public string Álbum { get; set; }

        [FirestoreProperty]
        [JsonProperty("URL de la Imagen del Álbum")]

        public string URL_de_la_Imagen_del_Álbum { get; set; }
        [FirestoreProperty]
        [JsonProperty("URL de la Imagen del Artista")]

        public string URL_de_la_Imagen_del_Artista { get; set; }
        [FirestoreProperty]
        [JsonProperty("URL del Video")]
        public string URL_del_Video { get; set; }
        //[FirestoreProperty]
    
    }
}
