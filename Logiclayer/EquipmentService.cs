using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class EquipmentService
    {
        public List<Equipment> GetAllEquipment()
        {
            using var context = new DataAccessLayer.Datalayer();
            List<Equipment> allEquipment = context.Equipment.ToList();

            return allEquipment;
        }

        public Equipment CreateEquipment(Equipment equipment)
        {
            using var db = new Datalayer();
            db.Equipment.Add(equipment);
            db.SaveChanges();
            return equipment;
        }

        public void UpdateEquipment(Equipment updated)
        {
            using var db = new Datalayer();
            var existing = db.Equipment.FirstOrDefault(e => e.equipment_ID == updated.equipment_ID);
            if (existing != null)
            {
                existing.equipment_name = updated.equipment_name;
                existing.category = updated.category;
                existing.condition = updated.condition;
                existing.available_count = updated.available_count;
                db.SaveChanges();
            }
        }

        public void DeleteEquipment(int equipmentId)
        {
            using var db = new Datalayer();
            var equipment = db.Equipment.FirstOrDefault(e => e.equipment_ID == equipmentId);
            if (equipment != null)
            {
                db.Equipment.Remove(equipment);
                db.SaveChanges();
            }
        }
    }
}
