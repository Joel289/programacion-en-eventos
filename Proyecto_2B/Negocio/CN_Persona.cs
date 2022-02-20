using Base_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CN_Persona
    {
        public persona obtenerpersona(usuario usr)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            var persona = from a in db.usuario
                          join b in db.persona on a.usuario_persona_id equals b.id_persona
                          where a.id_usuario == usr.id_usuario
                          select b;
            persona per = new persona();
            per = (persona)persona.First();
            return per;
        }

        public persona CrearPersona(string nombre, string apellido, int edad, string celular)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            persona p = new persona();
            p.nombre = nombre;
            p.apellido = apellido;
            p.edad = edad;
            p.celular = celular;
            db.persona.InsertOnSubmit(p);
            db.SubmitChanges();
            return p;
        }

        public persona BuscarPersona(string nombre)
        {
            Base_AzureDataContext db = new Base_AzureDataContext();
            persona p = null;



            var perso = from a in db.persona
                        where a.nombre == nombre
                        select a;
            foreach (persona a in perso)
            {
                return a;
            }
            return p;



        }
    }
}
