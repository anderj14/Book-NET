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
                var libros = db.Libro.Include(x => x.ComentarioLista).AsNoTracking();

                foreach (var libro in libros)
                {
                    System.Console.WriteLine(libro.Titulo);
                    foreach(var comentario in libro.ComentarioLista){
                        System.Console.WriteLine("---- " + comentario.ComentarioTexto);
                    }
                }
            }
        }
    }
}