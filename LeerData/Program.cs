using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaLibrosContext())
            {
                var nuevoAutor1 = new Autor{
                    Nombre = "Pedro",
                    Apellidos = "Paredes",
                    Grado = "Master"
                };

                db.Add(nuevoAutor1);

                var nuevoAutor2 = new Autor{
                    Nombre = "Paola",
                    Apellidos = "Martinez",
                    Grado = "Master"
                };

                db.Add(nuevoAutor2);

                var estadoTransaccion = db.SaveChanges();
                System.Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);
            }
        }
    }
}