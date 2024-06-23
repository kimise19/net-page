using BlazorCrud.Client.model;
using BlazorCrud.Client.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorCrud.Client.Services
{
    public class BookService
    {
        private readonly HttpClient httpClient;

        public BookService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await httpClient.GetFromJsonAsync<List<Book>>("http://localhost:61473/api/Libro/ObtenerTodosLosLibros");
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await httpClient.GetFromJsonAsync<Book>($"http://localhost:61473/api/Libro/ObtenerLibroPorId?id={id}");
        }

        public async Task CreateBookAsync(Book book)
        {
            var response = await httpClient.PostAsJsonAsync("http://localhost:61473/api/Libro/CrearLibro", book);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteBookAsync(int id)
        {
            var response = await httpClient.DeleteAsync($"http://localhost:61473/api/Libro/EliminarLibro?id={id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
