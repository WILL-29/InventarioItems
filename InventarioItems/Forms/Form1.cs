using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioItems.Model;
using InventarioItems.Forms;

namespace InventarioItems.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Botón registrar nueva computadora

            TBL_Computers ComputadoraREgMod = new TBL_Computers();
            ComputadoraREgMod.Asset_ID = Asset_Text.Text;
            ComputadoraREgMod.Model = ModeloMarca_Text.Text;
            ComputadoraREgMod.Company = Convert.ToInt32(Company_ComboBox.SelectedValue);
            ComputadoraREgMod.Computer_Type = Convert.ToInt32(PCType_ComboBox.SelectedValue);
            ComputadoraREgMod.Machine_Name = MachineName_Text.Text;
            ComputadoraREgMod.SN = SN_Text.Text;
            ComputadoraREgMod.User_assign_ID = Convert.ToInt32(UserAssigned_CB.SelectedValue);
            ComputadoraREgMod.Brand = Convert.ToInt32(Brand_PC_CB.SelectedValue);
            ComputadoraREgMod.Return_Date = Return_PC_Date.Value;
            ComputadoraREgMod.Temporary = Temp_PC_Chk.Checked;
            ComputadoraREgMod.Status = Convert.ToInt32(Status_PC_CB.SelectedValue);

            if (SqlMethods.ValidExist(ComputadoraREgMod) == true)
            {
                MessageBox.Show("Ya existen computadoras reigstradaos con los valores digitados, favor revisar serial y Machine Name");
            }
            else
            {
                SqlMethods.AgregarPc(ComputadoraREgMod);
            }
            //Companies, Computer_TYPES, User-assigned 

            //var valorcompanie = Company_ComboBox.SelectedItem;  //Me da lo quhe esté seleccionado, en este caso me da el registor completo
            //var sseleccionado = Company_ComboBox.SelectedValue; //Selected value me da lo que yo especifiquemás arriba en VALUEMEMBER
            //var valorcompanie = (TBL_Companies)Company_ComboBox.SelectedItem;
            //object oper = 123;
            //var jupiter = (int)oper;         
            //así se hace un cast, convirtiendo valores
            //metodo includes para hacer join
        }
        private void Company_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Item_Consu_CB.Text = "1 - Computadoras";

            //dbcontext = se refiere  al nombre que tiene el nombre que tiene la base de datos
            //Estos son los ComboBOxes de la pestaña Computadoras
            InventarioEntities dbCBs = new InventarioEntities();
            //List<TBL_Employees> ListaEmpleCB;
            //ListaEmpleCB = 
            //ListaEmpleCB = TBL_Employees.

            Company_ComboBox.DataSource = dbCBs.TBL_Companies.ToList();
            Company_ComboBox.DisplayMember = "Company_Name";
            Company_ComboBox.ValueMember = "ID_Company";
            //Company_ComboBox.SelectedValue = "";

            PCType_ComboBox.DataSource = dbCBs.TBL_Computer_Types.ToList();
            PCType_ComboBox.DisplayMember = "Type";
            PCType_ComboBox.ValueMember = "ID_Type";

            //UserAssigned_CB.DataSource =  
            UserAssigned_CB.DataSource = dbCBs.TBL_Employees.ToList();
            UserAssigned_CB.DisplayMember = "Name";
            UserAssigned_CB.ValueMember = "ID";

            Brand_PC_CB.DataSource = dbCBs.TBL_Brands.ToList();
            Brand_PC_CB.DisplayMember = "Brand";
            Brand_PC_CB.ValueMember = "ID_Brand";

            Status_PC_CB.DataSource = dbCBs.TBL_Status.ToList();
            Status_PC_CB.DisplayMember = "Status";
            Status_PC_CB.ValueMember = "ID_Status";

            //Estos son los comboboxes de la pestaña de Monitores
            Company_Moni_CB.DataSource = dbCBs.TBL_Companies.ToList();
            Company_Moni_CB.DisplayMember = "Company_Name";
            Company_Moni_CB.ValueMember = "ID_Company";

            User_Monit_CB.DataSource = dbCBs.TBL_Employees.ToList();
            User_Monit_CB.DisplayMember = "Name";
            User_Monit_CB.ValueMember = "ID";

            Brand_Moni_CB.DataSource = dbCBs.TBL_Brands.ToList();
            Brand_Moni_CB.DisplayMember = "Brand";
            Brand_Moni_CB.ValueMember = "ID_Brand";

            Status_Moni_CB.DataSource = dbCBs.TBL_Status.ToList();
            Status_Moni_CB.DisplayMember = "Status";
            Status_Moni_CB.ValueMember = "ID_Status";

            //Estos son los comboboxes de los teléfonos

            Company_Tel_CB.DataSource = dbCBs.TBL_Companies.ToList();
            Company_Tel_CB.DisplayMember = "Company_Name";
            Company_Tel_CB.ValueMember = "ID_Company";

            User_Tel_CB.DataSource = dbCBs.TBL_Employees.ToList();
            User_Tel_CB.DisplayMember = "Name";
            User_Tel_CB.ValueMember = "ID";

            Brand_Tel_CB.DataSource = dbCBs.TBL_Brands.ToList();
            Brand_Tel_CB.DisplayMember = "Brand";
            Brand_Tel_CB.ValueMember = "ID_Brand";

            Status_Tel_CB.DataSource = dbCBs.TBL_Status.ToList();
            Status_Tel_CB.DisplayMember = "Status";
            Status_Tel_CB.ValueMember = "ID_Status";

            //Combobox de registrar empleados

            Company_Employee_CB.DataSource = dbCBs.TBL_Companies.ToList();
            Company_Employee_CB.DisplayMember = "Company_Name";
            Company_Employee_CB.ValueMember = "ID_Company";


            //ELIMINAR VALOR POR DEFECTO A LOS DATE
            Return_PC_Date.Text = "";
        }
        private void UserAssigned_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UserAssigned_CB.DataSource = 
            //UserAssigned_CB.DisplayMember
            //UserAssigned_CB.ValueMember

        }

        private void MachineName_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Temp_Moni_Chk_CheckedChanged(object sender, EventArgs e)
        {
            Return_Moni_Date.Enabled = Temp_Moni_Chk.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBL_Monitors MoniRegModi = new TBL_Monitors();
            MoniRegModi.Brand = Convert.ToInt16(Brand_Moni_CB.SelectedValue);
            MoniRegModi.Model = Model_Moni_TB.Text;
            MoniRegModi.SN = SN_Monit_TB.Text;
            MoniRegModi.Company = Convert.ToInt16(Company_Moni_CB.SelectedValue);
            MoniRegModi.Asset_ID = Asset_Moni_TB.Text;
            MoniRegModi.Status = Convert.ToInt16(Status_Moni_CB.SelectedValue);
            if (Size_Moni_TB.Text == "")
            {
                Size_Moni_TB.Text = "0";
            }
            MoniRegModi.Size = Convert.ToInt32(Size_Moni_TB.Text);
            MoniRegModi.User_Assigned = Convert.ToInt16(User_Monit_CB.SelectedValue);
            MoniRegModi.Temporary = Temp_Moni_Chk.Checked;
            MoniRegModi.Return_Date = Return_Moni_Date.Value;

            if (SqlMethods.ValidExist(MoniRegModi) == true)
            {
                MessageBox.Show("Ya existe un monitor con este serial", "Información");
            }
            else
            {
                SqlMethods.AgregarMonitor(MoniRegModi);
            }
        }

        private void Temp_PC_Chk_CheckedChanged(object sender, EventArgs e)
        {
            Return_PC_Date.Enabled = Temp_PC_Chk.Checked;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Temp_Tel_Chk_CheckedChanged(object sender, EventArgs e)
        {
            Return_Tel_Date.Enabled = Temp_Tel_Chk.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TBL_Telephones telregedit = new TBL_Telephones();
            telregedit.Asset_ID = Asset_Tel_TB.Text;
            telregedit.Brand = Convert.ToInt32(Brand_Tel_CB.SelectedValue);
            telregedit.Company = Convert.ToInt32(Company_Tel_CB.SelectedValue);
            telregedit.Model = Model_Tel_TB.Text;
            telregedit.Return_Date = Return_Tel_Date.Value;
            telregedit.SN = SN_Tel_TB.Text;
            telregedit.Status_Tel = Convert.ToInt32(Status_Tel_CB.SelectedValue);
            telregedit.Temporary = Temp_Tel_Chk.Checked;
            telregedit.User_Assigned = Convert.ToInt32(User_Tel_CB.SelectedValue);

            InventarioEntities Hola = new InventarioEntities();
            Hola.TBL_Telephones.Add(telregedit);
            Hola.SaveChanges();

            

        }

        private void Return_Tel_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Consultar_Click(object sender, EventArgs e)

            
        {
            InventarioEntities db = new InventarioEntities();
            if (Item_Consu_CB.Text == "1 - Computadoras")
            {
                //dataGridView1.Height = tabPage1.Height - 100;
                // aquí se alimenta el DataGridView de la pestaña consulta


                //var datadata = from row in dataviewinfo.TBL_Computers.AsQueryable()
                //where row.Machine_Name.Contains(Consulta_TB.Text) //== Consulta_TB.Text
                //select row;

                //var datadata = dataviewinfo.TBL_Computers.AsQueryable().Where(w => w.Machine_Name.Equals(Consulta_TB.Text, StringComparison.OrdinalIgnoreCase));

                //var datadata = db.TBL_Computers.AsQueryable().OrderBy(w => w.Machine_Name).Where(w => w.Machine_Name.Contains(Consulta_TB.Text));

                //var datadata = from w in db.TBL_Computers.AsQueryable()
                //               where w.Machine_Name.Contains(Consulta_TB.Text) || w.SN.Contains(Consulta_TB.Text) select new
                //               { w.Machine_Name, w.User_assign_ID, w.Computer_Type, w.Model,w.SN , w.Status};

                //var datadata = db.TBL_Computers.AsQueryable().OrderBy(w => w.Machine_Name)
                //   .Where(w => w.Machine_Name.Contains(Consulta_TB.Text) || w.SN.Contains(Consulta_TB.Text) || w.Return_Date.ToString().Contains(Consulta_TB.Text))
                //    .Select(w => new { w.Machine_Name, w.User_assign_ID, w.Computer_Type,w.Brand, w.Model, w.SN, w.Status,w.Temporary, w.Return_Date});

                //ESTE ES EL QUE FUNCIONA HASTA EL 20 - 12 - 2020
                var datadata = from comp in db.TBL_Computers
                               join co in db.TBL_Companies on comp.Company equals co.ID_Company
                               join us in db.TBL_Employees on comp.User_assign_ID equals us.ID
                               join ct in db.TBL_Computer_Types on comp.Computer_Type equals ct.ID_Type
                               join br in db.TBL_Brands on comp.Brand equals br.ID_Brand
                               join st in db.TBL_Status on comp.Status equals st.ID_Status
                               orderby comp.Machine_Name
                               where comp.Machine_Name.Contains(Consulta_TB.Text) || us.Name.Contains(Consulta_TB.Text) || comp.SN.Contains(Consulta_TB.Text)
                               || comp.Model.Contains(Consulta_TB.Text) || co.Company_Name.Contains(Consulta_TB.Text)
                               select new { comp.Machine_Name, us.Name, br.Brand, comp.Model, comp.SN, ct.Type, co.Company_Name, comp.Temporary, comp.Return_Date, st.Status };
              
                // aquí agregamos la data al DataGridView
                dataGridView1.DataSource = datadata.ToList();

                //Aquí modificamos los nombres de las columnas, por ahora solo me interesa modificar este

                dataGridView1.Columns[0].HeaderText = "Nombre de equipo";
            }
            else if (Item_Consu_CB.Text == "2 - Monitores")
            {
                var datadata = from mon in db.TBL_Monitors
                               join us in db.TBL_Employees on mon.User_Assigned equals us.ID
                               join br in db.TBL_Brands on mon.Brand equals br.ID_Brand
                               join st in db.TBL_Status on mon.Status equals st.ID_Status
                               join co in db.TBL_Companies on mon.Company equals co.ID_Company
                               orderby us.Name
                               where mon.SN.Contains(Consulta_TB.Text) || mon.Model.Contains(Consulta_TB.Text) || us.Name.Contains(Consulta_TB.Text)
                               select new { br.Brand, mon.Model, mon.SN, co.Company_Name, us.Name, st.Status,mon.Temporary, mon.Return_Date };

                dataGridView1.DataSource = datadata.ToList();

            }
            else if (Item_Consu_CB.Text == "3 - Teléfonos")
            {
                var datadata = from tel in db.TBL_Telephones
                               join us in db.TBL_Employees on tel.User_Assigned equals us.ID
                               join st in db.TBL_Status on tel.Status_Tel equals st.ID_Status
                               join co in db.TBL_Companies on tel.Company equals co.ID_Company
                               join br in db.TBL_Brands on tel.Brand equals br.ID_Brand
                               orderby us.Name
                               where tel.SN.Contains(Consulta_TB.Text) || us.Name.Contains(Consulta_TB.Text)
                               select new { br.Brand, tel.Model, tel.SN, us.Name, tel.Asset_ID,co.Company_Name, st.Status,tel.Temporary, tel.Return_Date };

                dataGridView1.DataSource = datadata.ToList();
            }


        }

        private void Consulta_TB_TextChanged(object sender, EventArgs e)
        {
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {   
        }
        private void Item_Consu_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            FormReport frm = new FormReport();

            List<Pc_String> hola = new List<Pc_String>();
            for (int i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                Pc_String pc = new Pc_String();
                pc.MName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                pc.owner = dataGridView1.Rows[i].Cells[1].Value.ToString();
                pc.Brand = dataGridView1.Rows[i].Cells[2].Value.ToString();
                pc.Model = dataGridView1.Rows[i].Cells[3].Value.ToString();
                pc.SN = dataGridView1.Rows[i].Cells[4].Value.ToString();
                pc.CompType = dataGridView1.Rows[i].Cells[5].Value.ToString();
                pc.Company = dataGridView1.Rows[i].Cells[6].Value.ToString();
                pc.Temp = dataGridView1.Rows[i].Cells[7].Value.ToString();
                pc.ReturnDate = dataGridView1.Rows[i].Cells[8].Value.ToString();
                pc.Status = dataGridView1.Rows[i].Cells[9].Value.ToString();
                hola.Add(pc);
            }
            frm.DataPcR = hola;
            frm.ShowDialog();
        }
    }
}
