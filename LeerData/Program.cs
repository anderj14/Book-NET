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
                var libros = db.Libro.Include(x => x.AutorLink).ThenInclude(xi => xi.Autor);

                foreach (var libro in libros)
                {
                    System.Console.WriteLine(libro.Titulo);
                    foreach (var autLink in libro.AutorLink)
                    {
                        System.Console.WriteLine("---- " + autLink.Autor.Nombre);
                    }
                }
            }
        }
    }
}