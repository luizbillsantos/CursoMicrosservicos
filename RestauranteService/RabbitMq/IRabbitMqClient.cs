using RestauranteService.Dtos;

namespace RestauranteService.RabbitMq
{
    public interface IRabbitMqClient
    {
        void PublicarRestaurante(RestauranteReadDto restauranteReadDto); 
    }
}
