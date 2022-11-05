using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaLibrosContext())
            {
                var autor = db.Autor.Single(x => x.AutorId == 6);
                if (autor != null)
                {
                    db.Remove(autor);
                    var estadoTransaccion = db.SaveChanges();
                    System.Console.WriteLine("Estado de transaccion ==> " + estadoTransaccion);
                }
            }
        }
    }
}