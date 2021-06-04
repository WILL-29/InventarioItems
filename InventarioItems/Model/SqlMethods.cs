using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioItems;

namespace InventarioItems.Model
{
    public class SqlMethods
    {
        //Validar existencia de cualquier item
        static public bool ValidExist(TBL_Computers pc)
        {
            InventarioEntities db = new InventarioEntities();
            var data = db.TBL_Computers;
            if (data.Any(w => w.SN == pc.SN || w.Machine_Name == pc.Machine_Name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool ValidExist(TBL_Monitors moni)
        {
            InventarioEntities db = new InventarioEntities();
            var data = db.TBL_Monitors.ToList();
            if (data.Any(w => w.SN.Contains(moni.SN)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool ValidExist(TBL_Telephones tel)
        {
            InventarioEntities db = new InventarioEntities();
            var data = db.TBL_Telephones.ToList();
            if (data.Any(w => w.SN == tel.SN))
            {
                return true;
            }
            else
            {
                return false;
            }
    
       }
        

    //Agregar una computadora
    static public void AgregarPc(TBL_Computers pc)
        {
            InventarioEntities Hola = new InventarioEntities();
            Hola.TBL_Computers.Add(pc);
            Hola.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Computadora registrada exitosamente", "Información");
        }

        //Agregar un monitor
    static public void AgregarMonitor(TBL_Monitors moni)
        {
            InventarioEntities db = new InventarioEntities();
            db.TBL_Monitors.Add(moni);
            db.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Monitor registrado exitosamente", "Información");
        }

        //Agregar Empleado
    static public void AddEmploee(TBL_Employees Emp)
        {
            InventarioEntities db = new InventarioEntities();
            db.TBL_Employees.Add(Emp);
            db.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Empleado Registrado exitosamente.", "Información");
        }
        //Agregar Cisco IP Telephone
    static public void  AddTelephone(TBL_Telephones tel)
        {
            InventarioEntities db = new InventarioEntities();
            db.TBL_Telephones.Add(tel);
            db.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Teléfono Registrado existosamente.", "Información");

        }

    }                                    

}

