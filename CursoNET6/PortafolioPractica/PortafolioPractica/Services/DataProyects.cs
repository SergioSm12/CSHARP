using PortafolioPractica.Models;

namespace PortafolioPractica.Services
{
    public class DataProyects : IDataProyects
    {
        public List<Proyecto> ObtenerProyecto()
        {
            return new List<Proyecto>()
            {

                new Proyecto
            {
                Titulo = "Amazon",
                Description = "E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/img/amazon.png"

            },
            new Proyecto
            {
                Titulo="New York Times",
                Description= "Pagina de noticias en React",
                Link= "https://nytimes.com",
                ImagenURL="/img/nyt.png"
            },
            new Proyecto
            {
                Titulo="Reddit",
                Description= "Red social para compartir en comunidades",
                Link= "https://reddit.com",
                ImagenURL="/img/reddit.png"
            },
            new Proyecto
            {
                Titulo="Steam",
                Description= "Tienda en linea para comprar videojuegos ",
                Link= "https://store.steampowered.com",
                ImagenURL="/img/steam.png"
            }
            };

        }
    }
}
