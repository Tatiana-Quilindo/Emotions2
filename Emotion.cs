using Google.Cloud.Firestore;
using System.Security.Cryptography;
using static Google.Rpc.Context.AttributeContext.Types;

namespace Borrador3Proyecto
{
   
    public class Emotion
    {
        private string _id { get; set; }
        private string _Emocion { get; set; }

        public List<MusicInfo> MusicList { get; set; }
        public string Id { get { return _id; } set { _id = value; } }
        public string Emocion { get { return _Emocion; } set { _Emocion = value; } }
        public string Autor { get; set; }


        /*public Emotion(string id, string Emocion, int v, string autor)
        {
            _Emocion = Emocion;
            _id = id;
            Autor = autor;
        }*/

        public Emotion(string id, string emocion, string autor)
        {
            Id = id;
            Emocion = emocion;
            Autor = autor;
        }
    }
}
