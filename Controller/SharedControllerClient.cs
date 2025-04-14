using ADUSClient.Localidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Controller
{
    public class SharedControllerClient
    {
        private readonly HttpClient _httpClient;

        public SharedControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UFViewModel>> ListaUF(string? filtro)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/localidade/ufs?filtro=" + filtro;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<UFViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<UFViewModel> ListaUFIBGE(string ibge)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/localidade/ufs/" + ibge.ToString();
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<UFViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<MunicipioViewModel>> ListaCidade(int iduf, string? filtro)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/localidade/cidades/" + iduf.ToString() + "?filtro=" + filtro;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<MunicipioViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<MunicipioViewModel> ListaCidadeIBGE(string ibge)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/localidade/cidadesibge/" + ibge.ToString();
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<MunicipioViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }
    }
}