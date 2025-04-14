using ADUSClient.Moeda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Controller
{
    public class MoedaControllerClient
    {
        private readonly HttpClient _httpClient;

        public MoedaControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<MoedaViewModel>> ListaMoeda(string? filtro)
        {
            MoedaViewModel reg = new MoedaViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/moeda/?filtro=" + filtro);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<MoedaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<MoedaViewModel> ListaMoedaById(int id)
        {
            MoedaViewModel reg = new MoedaViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/moeda/" + id.ToString());
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<MoedaViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Salvar(int id, MoedaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/moeda/" + id.ToString(), content);
            return response;
        }

        public async Task<HttpResponseMessage> Excluir(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/moeda/" + id.ToString());
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(MoedaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/moeda", content);
            return response;
        }

        public async Task<List<CotacaoMoedaViewModel>> ListaCotacaoByMoeda(int idMoeda, DateTime ini, DateTime fim)
        {
            CotacaoMoedaViewModel reg = new CotacaoMoedaViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/cotacaomoeda/Listar/" + idMoeda.ToString() + "?ini=" + ini.ToString("MM/dd/yyyy") + "&fim=" + fim.ToString("MM/dd/yyyy"));
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<CotacaoMoedaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<CotacaoMoedaViewModel> ListaCotacaoById(int id)
        {
            CotacaoMoedaViewModel reg = new CotacaoMoedaViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/cotacaomoeda/" + id.ToString());
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<CotacaoMoedaViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> SalvarCotacao(int id, CotacaoMoedaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/cotacaomoeda/" + id.ToString(), content);
            return response;
        }

        public async Task<HttpResponseMessage> ExcluirCotacao(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/cotacaomoeda/" + id.ToString());
            return response;
        }

        public async Task<HttpResponseMessage> AdicionarCotacao(CotacaoMoedaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/cotacaomoeda", content);
            return response;
        }
    }
}