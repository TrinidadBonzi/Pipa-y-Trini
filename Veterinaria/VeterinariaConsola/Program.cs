using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:5083"); // o el puerto que use tu API

        var persona = new
        {
            Nombre = "Carlos",
            Apellido = "Pérez",
            Dni = "12345678"
        };

        HttpResponseMessage response = await client.PostAsJsonAsync("/api/duenio", persona);
        Console.WriteLine(await response.Content.ReadAsStringAsync());

        // Obtener todos los animales
        var animales = await client.GetFromJsonAsync<List<Animal>>("https://localhost:5083/api/animales");

        // Crear nuevo animal
        var nuevoAnimal = new { Nombre = "Firulais", Tipo = "Perro", Edad = 3 };
        await client.PostAsJsonAsync("https://localhost:/api/animales", nuevoAnimal);

        // Modificar animal (PUT)
        var animalModificado = new { Id = 1, Nombre = "Firulais", Tipo = "Perro", Edad = 4 };
        await client.PutAsJsonAsync("https://localhost:5083/api/animales/1", animalModificado);

        // Eliminar animal
        await client.DeleteAsync("https://localhost:5083/api/animales/1");


        var atencion = new
        {
            AnimalId = 1,
            Fecha = DateTime.Now,
            Descripcion = "Vacunación anual"
        };
        await client.PostAsJsonAsync("https://localhost:5083/api/atenciones", atencion);

        var medicamentos = await client.GetFromJsonAsync<List<Medicamento>>("https://localhost:5083/api/medicamentos");
        foreach (var m in medicamentos)
        {
            Console.WriteLine($"{m.Nombre} - {m.Dosis}");
        }

    }
}

