using ustatickets.Data.Enum;
using ustatickets.Models;

namespace ustatickets.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Cinema 
                if (!context.Cinema.Any())
                {
                    context.Cinema.AddRange(new List<Cinema>()
                    {  //1
                        new Cinema()
                        {
                            Name= "Paramount Pictures",
                            Logo= "http://localhost/img/cinema/paramount.png",
                            Description= "Paramount Pictures Corporation is an American film and television production and distribution company and the main namesake division of Paramount Global (formerly ViacomCBS)."
                        },
                        //2
                        new Cinema()
                        {
                            Name= "Marvel Studios",
                            Logo= "http://localhost/img/cinema/Marvel_Studios.png",
                            Description= "Marvel Studios, LLC​ es un estudio cinematográfico estadounidense que tiene su sede en los Walt Disney Studios de Burbank, el estudio es una filial de The Walt Disney Company. Marvel Studios es conocido por producir el Universo cinematográfico de Marvel, basado en los personajes de Marvel Comics.​"
                        },
                        //3
                        new Cinema()
                        {
                            Name= "Mandalay Pictures",
                            Logo= "http://localhost/img/cinema/Mandalay_Pictures_logo.svg.png",
                            Description= "Mandalay Pictures es un estudio cinematográfico estadounidense y una subsidiaria de Mandalay Entertainment, fundada el 27 de mayo de 1995 por Peter Guber, quien anteriormente dirigió Sony Pictures Entertainment y The Guber-Peters Company.​"
                        },
                        //4
                        new Cinema()
                        {
                            Name= "Warner Bros Pictures",
                            Logo= "http://localhost/img/cinema/1200px-Warner_Bros._Pictures_logo.svg.png",
                            Description= "Warner Bros. Entertainment Inc., anteriormente conocida como Warner Bros. Pictures, Inc., es una compañía estadounidense filial de Warner Bros. Discovery y con sede en Burbank, California.​"
                        },
                        //5
                        new Cinema()
                        {
                            Name= "Universal Pictures",
                            Logo= "http://localhost/img/cinema/Universal-Pictures-Logo.svg",
                            Description= "Universal Pictures, a efectos legales Universal City Studios LLC​, es un estudio cinematográfico estadounidense, propiedad de Comcast Corporation a través de su propia dependencia NBCUniversal, ​ también es uno de los \"Grandes 5\" de Hollywood, y el primer gran estudio de Hollywood de la historia.​"
                        },

                    });
                    context.SaveChanges();

                }
                if (!context.Director.Any())
                {
                    context.Director.AddRange(new List<Director>()
                    {   //1
                        new Director()
                        {
                           ProfilePictureURL="http://localhost/img/directors/jhosep%20kosinski.webp",
                           FullName="Joseph Kosinski",
                           Bio="Joseph Kosinski es un actor y director de anuncios comerciales de televisión estadounidense, y director de cine principalmente conocido por su trabajo con imágenes generadas por computador."
                        },
                        //2
                        new Director()
                        {
                           ProfilePictureURL="http://localhost/img/directors/Anthony%20Russo.jpg",
                           FullName="Anthony Russo",
                           Bio="Russo nació el 3 de febrero de 1970 en Cleveland, Ohio, EE. UU. Creció junto a sus padres y su hermano Joe. Estudiaron juntos en la Universidad Case de Western Reserve, donde comenzaron a escribir, producir y dirigir su primer largometraje, Pieces."
                        },
                        //3
                        new Director()
                        {
                           ProfilePictureURL="http://localhost/img/directors/Jeff%20Wadlow.jpg",
                           FullName="Jeff Wadlow",
                           Bio="Jeff Wadlow es un director, productor, guionista y actor estadounidense.​ Hijo de la fallecida Emily Couric y sobrino de la presentadora de la CBS Katie Couric"
                        },
                        //4
                        new Director()
                        {
                           ProfilePictureURL="http://localhost/img/directors/Ryan_Cogler.jpg",
                           FullName="Ryan Cogler",
                           Bio="Ryan Kyle Coogler​ es un director y guionista estadounidense. Es conocido en la industria por su trabajo como director de las películas Creed y Black Panther"
                        },
                        //5
                        new Director()
                        {
                           ProfilePictureURL="http://localhost/img/directors/Client_Eastwood.jpg",
                           FullName="Client Eastwood",
                           Bio="Clinton «Clint» Eastwood Jr. es un actor, director, guionista y productor de cine estadounidense. Su primer papel relevante fue como secundario en el reparto de la serie de televisión Rawhide."
                        },
                        //6
                        new Director()
                        {
                           ProfilePictureURL="http://localhost/img/directors/Rob_Cohen.jpg",
                           FullName="Rob Cohen",
                           Bio="Robert \"Rob\" Cohen ​ es un director de cine y televisión, productor y guionista estadounidense. Ha dirigido películas como Dragonheart, Daylight, The Fast and the Furious, xXx, Stealth y La momia: la tumba del emperador Dragón."
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                    {   //1
                        new Movie()
                        {
                            Name="Top Gun: Maverick",
                            Description="Después de más de treinta años de servicio como uno de los mejores aviadores de la Armada, Pete Mitchell está donde pertenece, forzando los límites como valiente piloto de pruebas y esquivando el avance de rango que lo dejaría en tierra.",
                            Price= 0.0,
                            ImageUrl= "http://localhost/img/movies/top_gun_maverick.jpg",
                            StartTimme= DateTime.Now.AddDays(-10),
                            EndTime=DateTime.Now.AddDays(-2),
                            CinemaId=1,
                            DirectorId=1,
                            MovieCategory= MovieCategory.Action
                        },
                        //2
                        new Movie()
                        {
                            Name ="Vengadores: Endgame",
                            Description="Después de que Thanos haya aniquilado a la mitad del universo, los Vengadores supervivientes deben hacer todo lo posible por deshacer tal atrocidad.",
                            Price = 0.0,
                            ImageUrl="http://localhost/img/movies/Vengadores_Endgame-135478227-large.jpg",
                            StartTimme=DateTime.Now.AddDays(-4),
                            EndTime=DateTime.Now,
                            CinemaId=2,
                            DirectorId=2,
                            MovieCategory=MovieCategory.Action
                         },
                        //3
                        new Movie()
                        {
                            Name ="Never Back Down",
                            Description="Un adolescente frustrado y conflictivo llega a un nuevo instituto donde descubre la existencia de un club de lucha clandestino y conoce a un compañero que le obligará a pelear.",
                            Price = 0.0,
                            ImageUrl="http://localhost/img/movies/Never_Back_Down.jpg",
                            StartTimme=DateTime.Now.AddDays(-7),
                            EndTime=DateTime.Now,
                            CinemaId=3,
                            DirectorId=3,
                            MovieCategory=MovieCategory.Action
                         },
                        //4
                        new Movie()
                        {
                            Name ="Creed: La leyenda de Rocky",
                            Description="El excampeón mundial de los pesos pesados Rocky Balboa es entrenador y mentor de Adonis Johnson, el hijo de su difunto amigo y exrival Apollo Creed.",
                            Price = 0.0,
                            ImageUrl="http://localhost/img/movies/creed.jpg",
                            StartTimme=DateTime.Now.AddDays(-15),
                            EndTime=DateTime.Now.AddDays(5),
                            CinemaId=4,
                            DirectorId=4,
                            MovieCategory=MovieCategory.Drama
                         },
                        //5
                        new Movie()
                        {
                            Name ="Invictus",
                            Description="Nelson Mandela, en su primer mandato como presidente de Sudáfrica, inicia una aventura única para unir el país devastado por el Apartheid: alistar al equipo nacional de rugby en una misión para ganar la Copa del Mundo de Rugby de 1995.",
                            Price = 0.0,
                            ImageUrl="http://localhost/img/movies/invictus.jpg",
                            StartTimme=DateTime.Now.AddDays(-10),
                            EndTime=DateTime.Now.AddDays(3),
                            CinemaId=4,
                            DirectorId=5,
                            MovieCategory=MovieCategory.Drama
                         },
                        //6
                        new Movie()
                        {
                            Name ="The Fast and the Furious",
                            Description="El oficial de policía de Los Ángeles Brian O'Conner debe decidir dónde está realmente su lealtad cuando se enamora del mundo de las carreras callejeras que ha sido enviado a destruir.",
                            Price = 0.0,
                            ImageUrl="http://localhost/img/movies/fastandthefurius.jpg",
                            StartTimme=DateTime.Now.AddDays(-8),
                            EndTime=DateTime.Now.AddDays(8),
                            CinemaId=5,
                            DirectorId=6,
                            MovieCategory=MovieCategory.Action
                         },
                        

                    });
                    context.SaveChanges();
                }
                
                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                    {   //1
                        new Actor()
                        {
                           ProfilePictureURL="http://localhost/img/actors/Tom-Cruise.webp",
                           FullName="Tom Cruise",
                           Bio="Thomas Cruise Mapother IV, más conocido como Tom Cruise, es un actor y productor de cine estadounidense ganador de tres premios Globo de Oro, un Premio Saturn y una Palma de Oro honoraria."
                        },
                        //2
                        new Actor()
                        {
                           ProfilePictureURL="http://localhost/img/actors/Robert%20Downey.jpg",
                           FullName="Robert Downey",
                           Bio="Robert John Downey Jr. es un actor, actor de voz, productor y cantante estadounidense. Inició su carrera como actor a temprana edad apareciendo en varios filmes dirigidos por su padre, Robert Downey Sr., y en su infancia estudió actuación en varias academias de Nueva York."
                        },
                        //3
                        new Actor()
                        {
                           ProfilePictureURL="http://localhost/img/actors/Scarlett_Johansson.webp",
                           FullName="Scarlett Johansson",
                           Bio="Scarlett Ingrid Johansson es una actriz, cantante, directora, productora y empresaria estadounidense. Comenzó a mostrar intereses en la actuación desde temprana edad, y a lo largo de su infancia y adolescencia se formó en distintos institutos como actriz."
                        },
                        //4
                        new Actor()
                        {
                           ProfilePictureURL="http://localhost/img/actors/Sean_Faris.jpg",
                           FullName="Sean faris",
                           Bio="Sean Hardy Faris, es un actor y modelo estadounidense. Es conocido por sus papeles como Jake Tyler en Never Back Down y Kyo Kusanagi en The King of Fighters."
                        },
                        //5
                        new Actor()
                        {
                           ProfilePictureURL="http://localhost/img/actors/michael_b_jordan.jpg",
                           FullName="Michel B Jordan",
                           Bio="Michael Bakari Jordan, popularmente conocido como Michael B. Jordan, es un actor, director y productor estadounidense. Es conocido por interpretar al personaje de Erik Killmonger, el primo y enemigo de T'Challa, en Black Panther, y a Adonis Creed, hijo del boxeador ficticio Apollo Creed, en Creed."
                        },
                        //6
                        new Actor()
                        {
                           ProfilePictureURL="http://localhost/img/actors/Matt_damon.jpg",
                           FullName="Matt Damon",
                           Bio="Matthew Paige Damon, conocido simplemente como Matt Damon, es un actor, guionista y productor estadounidense. Desde temprana edad se destacó en sus estudios y comenzó a mostrar interés por la actuación durante la secundaria gracias a sus maestros"
                        },
                        //7
                        new Actor()
                        {
                           ProfilePictureURL="http://localhost/img/actors/morgan_freeman.webp",
                           FullName="Morgan Freeman",
                           Bio="Morgan Freeman​ es un actor y documentalista estadounidense, ganador del premio Óscar en 2005 por Million Dollar Baby. Además ha recibido otras nominaciones por sus actuaciones en El reportero de la calle 42, Paseando a Miss Daisy, Cadena perpetua e Invictus"
                        },
                        //8
                         new Actor()
                        {
                           ProfilePictureURL="http://localhost/img/actors/Paul-walker.webp",
                           FullName="Paul Waker",
                           Bio="Paul William Walker IV​ fue un actor, modelo, piloto de carreras y biólogo marino estadounidense, ​ conocido por su papel de Brian O'Conner en la película de acción The Fast and the Furious, Repitiéndolo en cinco ocasiones de las siguientes películas de la franquicia."
                        },
                        
                    });

                }
                if (!context.Actor_Movie.Any())
                {
                    context.Actor_Movie.AddRange(new List<Actor_Movie>() 
                    {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=1,
                        },
                        new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=2,
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=2,
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=3,
                        },
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=4,
                        },
                        new Actor_Movie()
                        {
                            ActorId=6,
                            MovieId=5,
                        },
                        new Actor_Movie()
                        {
                            ActorId=7,
                            MovieId=5,
                        },
                        new Actor_Movie()
                        {
                            ActorId=8,
                            MovieId=6,
                        },

                    
                    });
                    context.SaveChanges();
                }
                


            }
        }
    }
}
