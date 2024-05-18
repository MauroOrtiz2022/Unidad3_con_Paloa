using MongoDB.Bson;
using MongoDB.Driver;

namespace Unidad3
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Reemplaza con tu cadena de conexi�n si es diferente
            string connectionString = "mongodb://localhost:27017";

            // Crea un cliente MongoDB
            var client = new MongoClient(connectionString);

            // Obt�n la base de datos
            var database = client.GetDatabase("DB_TELTEC");

            // Obt�n la colecci�n
            var collection = database.GetCollection<BsonDocument>("llamadas");

            //// Crear un nuevo documento BSON
            //var document = new BsonDocument
            //{
            //    { "nombre", "Juan" },
            //    { "edad", 30 },
            //    { "profesion", "Desarrollador" }
            //};

            //// Inserta el documento en la colecci�n
            //collection.InsertOne(document);

            //Console.WriteLine("Documento insertado exitosamente.");
        }

    }
}