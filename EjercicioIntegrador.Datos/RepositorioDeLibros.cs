using System;
using System.Collections.Generic;
using System.Linq;
using EjercicioIntegrador.Entidades;


namespace EjercicioIntegrador.Datos
{
    public class RepositorioDeLibros
    {
        private List<Libro> listaLibros;
        private ManejadorDeArchivo manejador;
        public static RepositorioDeLibros _instancia = null;
        
        public static RepositorioDeLibros GetInstancia()
        {
            if (_instancia==null)
            {
                _instancia = new RepositorioDeLibros();
            }

            return _instancia;
        }
        private RepositorioDeLibros()
        {
            listaLibros = new List<Libro>();
            manejador = new ManejadorDeArchivo();
            listaLibros = manejador.LeerDatosDelArchivo();
        }

        public List<Libro> GetLista()
        {
            return listaLibros;
        }

        public void Agregar(Libro itemLibro)
        {
            manejador.Agregar(itemLibro);
            listaLibros.Add(itemLibro);
        }

        public void Editar(Libro libroOriginal, Libro libroModificado)
        {
            manejador.Editar(libroOriginal, libroModificado);
            int index = listaLibros.IndexOf(libroOriginal);//obtengo el nro. de elemento del libro que se va a editar
            listaLibros.RemoveAt(index);//borro el elemento con el index obtenido
            listaLibros.Insert(index,libroModificado);//pongo el libro modificado en el lugar que estaba antes el libro original
        }

        public void Borrar(Libro libroaBorrar)
        {
            manejador.BorrarDelArchivo(libroaBorrar);
            listaLibros.Remove(libroaBorrar);
        }

        public bool Existe(Libro libroIngresado)
        {
            return listaLibros.Contains(libroIngresado);
        }
        
        public int GetCantidad()
        {
            return listaLibros.Count;
        }

        public List<Libro> FiltrarPorEditorial(Editorial editorial)
        {
            return listaLibros.Where(c => c.Editorial == editorial).ToList();
            
        }

        public List<Libro> FiltrarPorTema(Tema tema)
        {
            return listaLibros.Where(c => c.Tema == tema).ToList();
        }

        
        public List<Libro> OrdenarAscPorCantidadHojas()
        {
            return listaLibros.OrderBy(c => c.CantidadHojas).ToList();
        }

        public List<Libro> OrdenarDescPorCantidadHojas()
        {
            return listaLibros.OrderByDescending(c => c.CantidadHojas).ToList();
        }

        public object ExisteISBN()
        {
            return true;
        }
    }

    
}
