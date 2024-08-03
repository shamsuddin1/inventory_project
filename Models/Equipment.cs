using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventory_project.Models
{
    public class Equipment:Member
    {
        public int EquipmentID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public DateTime EntryDate { get; set; }
        public Member Member { get; set; }
        public Equipment() {
            Member = new Member();
        }
        public static List<Equipment> LstEquipment()
        {
            List<Equipment> list = new List<Equipment>();

            for(int i=1; i<30; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Laptop"+i.ToString();
                equipment.Count = i*5;
                equipment.EntryDate = DateTime.Now;
                list.Add(equipment);
            }
            return list;

        }

        public static List<Equipment> LstAssignedEquipment()
        {
            List<Equipment> list = new List<Equipment>();

            for (int i = 1; i < 30; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Laptop" + i.ToString();
                equipment.Count = i * 5;
                equipment.EntryDate = DateTime.Now;

                equipment.Member.MemberName = "Member" + i.ToString();
                equipment.Member.MemberDesignation = "Officer";
                equipment.Member.MobileNumber = "0175000536";
                list.Add(equipment);
            }
            return list;

        }
    }
}