using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AlumnoCRUD.FE.Models;

namespace AlumnoCRUD.FE.Services
{
    public class AlumnoService
    {
        private readonly HttpClient _httpClient;
        public AlumnoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        //GET para obtener listado alumnos
        public async Task<List<Models.Alumno>> ObtenerAlumnosAsync()
        {
            var response = await _httpClient.GetAsync("api/Alumnos");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Models.Alumno>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
        }

        //POST para agregar alumnos
        public async Task<bool> AgregarAlumnoAsync(Models.Alumno alumno)
        {
            var json = JsonSerializer.Serialize(alumno);
            var contec = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Alumnos", contec);
            return response.IsSuccessStatusCode;
        }

        // Actualizar alumno (PUT)
        public async Task<bool> ActualizarAlumnoAsync(Models.Alumno alumno)
        {
            var json = JsonSerializer.Serialize(alumno);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/Alumnos/{alumno.Id}", content);
            return response.IsSuccessStatusCode;
        }

        // Eliminar alumno (DELETE)
        public async Task<bool> EliminarAlumnoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Alumnos/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
