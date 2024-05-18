using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Unidad3
{
    internal class conexion
    {
        //static void Main(string[] args)
        //{
        //    // Reemplaza con tu cadena de conexión si es diferente
        //    string connectionString = "mongodb://localhost:27017";

        //    // Crea un cliente MongoDB
        //    var client = new MongoClient(connectionString);

        //    // Obtén la base de datos
        //    var database = client.GetDatabase("DB_TELTEC");

        //    // Obtén la colección
        //    var collection = database.GetCollection<BsonDocument>("llamadas");

        //    // Crear un nuevo documento BSON
        //    var document = new BsonDocument
        //    {
        //        { "nombre", "Juan" },
        //        { "edad", 30 },
        //        { "profesion", "Desarrollador" }
        //    };

        //    // Inserta el documento en la colección
        //    collection.InsertOne(document);

        //    Console.WriteLine("Documento insertado exitosamente.");
        //}
    }
}
