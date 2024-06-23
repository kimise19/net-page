using BlazorCrud.Client.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorCrud.Client.Services
{
	public class AuthorService
	{
		private readonly HttpClient httpClient;

		public AuthorService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async Task<List<Author>> GetAuthorsAsync()
		{
			return await httpClient.GetFromJsonAsync<List<Author>>("http://localhost:61473/api/Autor/ObtenerTodosLosAutores");
		}

		public async Task<Author> GetAuthorByIdAsync(int id)
		{
			return await httpClient.GetFromJsonAsync<Author>($"http://localhost:61473/api/Autor/ObtenerAutorPorId?id={id}");
		}

		public async Task CreateAuthorAsync(Author author)
		{
			await httpClient.PostAsJsonAsync("http://localhost:61473/api/Autor/CrearAutor", author);
		}

		public async Task DeleteAuthorAsync(int id)
		{
			await httpClient.DeleteAsync($"http://localhost:61473/api/Autor/EliminarAutor?id={id}");
		}
	}
}
