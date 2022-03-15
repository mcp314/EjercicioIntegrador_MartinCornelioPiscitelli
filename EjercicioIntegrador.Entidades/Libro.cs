using EjercicioIntegrador.Entidades;
using System;
using System.Text;

namespace EjercicioIntegrador.Entidades
{
    public class Libro:ICloneable
    {
        public string ISBN { get; set; }
        public Editorial Editorial { get; set; }
        public Tema Tema { get; set; }

        public Libro()
        {
            
        }
        public string Titulo { get;set; }

        public string Autor { get; set; }

        public int CantidadHojas { get; set; }


        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Libro))
            {
                return false;
            }

            return this.ISBN == ((Libro) obj).ISBN &&
                   this.Titulo ==((Libro) obj).Titulo &&
                   this.Autor == ((Libro) obj).Autor &&
                   this.Editorial == ((Libro) obj).Editorial &&
                   this.Tema == ((Libro) obj).Tema &&
                   this.CantidadHojas == ((Libro) obj).CantidadHojas;
        }
        

        public object Clone()
        {
            return this.MemberwiseClone();
        }
       
    }
}
