using System;
using System.Collections.Generic;
using System.IO;
using EjercicioIntegrador.Entidades;

namespace EjercicioIntegrador.Datos
{
    public class ManejadorDeArchivo
    {
        private readonly string _archivo = Environment.CurrentDirectory + @"\Biblioteca.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\Biblioteca.bak";

        public ManejadorDeArchivo()
        {
            
        }

        public List<Libro> LeerDatosDelArchivo()
        {
            List<Libro> lista = new List<Libro>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    var libroCompleto = ConstruirLibro(linea);
                    lista.Add(libroCompleto);
                }
                lector.Close();

            }
            return lista;
        }

        private Libro ConstruirLibro(string linea)
        {
            var campos = linea.Split('|');
            return new Libro()
            {
                ISBN = campos[0],
                Titulo = campos[1],
                Autor= campos[2],
                Editorial = (Editorial) int.Parse(campos[3]),
                Tema = (Tema) int.Parse(campos[4]),
                CantidadHojas = int.Parse(campos[5])
            };
        }

        public void Agregar(Libro objetoLibro)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            var linea = ConstruirLinea(objetoLibro);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Libro objetoLibro)
        {
            return $"{objetoLibro.ISBN}|{objetoLibro.Titulo}|{objetoLibro.Autor}|{objetoLibro.Editorial.GetHashCode()}|{objetoLibro.Tema.GetHashCode()}|{objetoLibro.CantidadHojas}";
        }

        public void BorrarDelArchivo(Libro libroABorrar)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var circEnArchivo = ConstruirLibro(linea);
                if (!circEnArchivo.Equals(libroABorrar))
                {
                    escritor.WriteLine(linea);
                }
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak,_archivo);
        }

        public void Editar(Libro libroOriginal, Libro libroModificado)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Libro circEnArchivo = ConstruirLibro(linea);
                if (circEnArchivo.Equals(libroOriginal))
                {
                    linea = ConstruirLinea(libroModificado);
                }
                escritor.WriteLine(linea);
            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak,_archivo);
        }
    }
}
