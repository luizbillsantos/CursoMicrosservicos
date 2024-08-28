using RestauranteService.Dtos;
using System.Text;
using System.Text.Json;

namespace RestauranteService.Utils
{
    public class ItemServiceHttpClient : IItemServiceHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ItemServiceHttpClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task EnviaRestauranteParaItemService(RestauranteReadDto restauranteDto)
        {
            var conteudo = new StringContent
                (
                    JsonSerializer.Serialize(restauranteDto)
                    , Encoding.UTF8,
                    "application/json"
                );
            await _httpClient.PostAsync(_configuration["ItemService"], conteudo);
        }
    }
}
