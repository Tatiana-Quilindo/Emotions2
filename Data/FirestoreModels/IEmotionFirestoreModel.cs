namespace Borrador3Proyecto.Data.FirestoreModels
{
    public interface IEmotionFirestoreModel
    {
        string Álbum { get; set; }
        string Autor { get; set; }
        string Emocion { get; set; }
        string Género { get; set; }
        string Id { get; set; }
        string URL_de_la_Imagen_del_Álbum { get; set; }
        string URL_de_la_Imagen_del_Artista { get; set; }
        string URL_del_Video { get; set; }
    }
}