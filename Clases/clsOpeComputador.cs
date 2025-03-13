using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Parcial1.Models;

namespace Parcial1.Clases
{
    public class clsOpeComputador
    {
        private ITMEntities db = new ITMEntities();
        public Computador computador { get; set; }

        public string Insertar()
        {
            try
            {
                db.Computadors.Add(computador);
                db.SaveChanges();

                return $"✅ Computador insertado correctamente. ID: {computador.ComputadorID}";
            }
            catch (Exception ex)
            {
                return $"❌ Error al insertar el computador: {ex.Message}";
            }
        }

        public Computador Consultar(int id)
        {
            return db.Computadors.FirstOrDefault(c => c.ComputadorID == id);
        }

        public string Actualizar()
        {
            try
            {
                Computador compu = Consultar(computador.ComputadorID);
                if (compu == null)
                {
                    return "⚠️ No se encontró el computador con ese ID";
                }

                db.Computadors.AddOrUpdate(computador);
                db.SaveChanges();

                return $"✅ Computador actualizado correctamente. ID: {computador.ComputadorID}";
            }
            catch (Exception ex)
            {
                return $"❌ No se pudo actualizar el computador: {ex.Message}";
            }
        }

        public List<Computador> ConsultarTodos()
        {
            return db.Computadors.OrderBy(c => c.MarcaProcesador).ToList();
        }

        public string Eliminar(int id)
        {
            try
            {
                Computador compu = Consultar(id);
                if (compu == null)
                {
                    return "⚠️ No se encontró el computador con ese ID";
                }

                db.Computadors.Remove(compu);
                db.SaveChanges();

                return $"✅ Computador eliminado correctamente. ID: {id}";
            }
            catch (Exception ex)
            {
                return $"❌ No se pudo eliminar el computador: {ex.Message}";
            }
        }
    }
}
