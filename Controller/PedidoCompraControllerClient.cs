using FarmPlannerClient.PedidoCompra;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Controller
{
    public class PedidoCompraControllerClient
    {
        private readonly HttpClient _httpClient;

        public PedidoCompraControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PedidoCompraViewModel>> Lista(int idorganizacao, int idano, int idfazenda, int idsafra, string idconta, int idproduto, int idmoeda, int idfornec, DateTime ini, DateTime fim, string? filtro)
        {
            //{ idorganizacao}/{ idano}/{ idfazenda}/{ idsafra}/{ idmoeda}/{ idproduto}/{ idconta}/{idfornec}/{ ini}/{ fim}
            PedidoCompraViewModel reg = new PedidoCompraViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/PedidoCompra/listar/" + idorganizacao.ToString() + "/" + idano.ToString() + "/" + idfazenda.ToString() + "/" + idsafra.ToString() + "/" + idmoeda.ToString() + "/" + idproduto.ToString() + "/" + idconta + "/" + idfornec.ToString() + "/" + ini.ToString("yyyy-MM-dd") + "/" + fim.ToString("yyyy-MM-dd") +
                "?filtro=" + filtro;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<PedidoCompraViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<PedidoCompraViewModel> ListaById(int id, string idconta)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/PedidoCompra/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<PedidoCompraViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Salvar(int id, string idconta, PedidoCompraViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/PedidoCompra/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> Excluir(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/PedidoCompra/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(PedidoCompraViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/PedidoCompra", content);
            return response;
        }

        public async Task<HttpResponseMessage> AdicionarEntrega(EntregaCompraViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/ProdutoCompra/Entrega", content);
            return response;
        }

        public async Task<List<ItemEntregaViewModel>> ListaProdutoByPedido(int idpedido, int idproduto, string idconta)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/ProdutoCompra/listar/" + idpedido.ToString() + "/" + idproduto.ToString() + "/" + idconta;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ItemEntregaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<ProdutoCompraViewModel> ListaProdutoById(int id, string idconta)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/ProdutoCompra/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<ProdutoCompraViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> SalvarProduto(int id, string idconta, ProdutoCompraViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/ProdutoCompra/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> ExcluirProduto(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/ProdutoCompra/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<HttpResponseMessage> AdicionarProduto(ProdutoCompraViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/ProdutoCompra", content);
            return response;
        }

        public async Task<List<ItemEntregaViewModel>> ListaItensEntrega(int idpedido, string idconta)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/ProdutoCompra/ItensEntrega/" + idpedido.ToString() + "/" + idconta + "/0");
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ItemEntregaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<EntregaCompraViewModel>> ListaEntregaByProduto(int id, string idconta)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/ProdutoCompra/EntregaByItem/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<EntregaCompraViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> ExcluirEntregaById(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/produtocompra/Entrega/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }
    }
}