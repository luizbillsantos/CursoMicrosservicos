using RestauranteService.Dtos;

namespace RestauranteService.Utils
{
    public interface IItemServiceHttpClient
    {
        Task EnviaRestauranteParaItemService(RestauranteReadDto restauranteDto);
    }
}
