namespace Portafolio.Servicios
{
    //servicio Unico AddSingleton
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            //un guid es un string aleatorio largo
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }

    }
    //Servicio de limitado 
    //AddScope
    public class ServicioDelimitado
    {
        public ServicioDelimitado()
        {
            //un guid es un string aleatorio largo
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }

    }
    //AddTransient
    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {
            //un guid es un string aleatorio largo
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }

    }
}
