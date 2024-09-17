using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bro_Hot_Food_And_Beverage
{
    public partial class MainMenu : Form
    {
        private int quantity = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            add_new_meal add_New_Meal = new add_new_meal();
            add_New_Meal.ShowDialog();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("sajuuu");
            }
        }

        private void guna2Button51_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button52_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button53_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button54_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button55_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button56_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button57_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button58_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button59_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button60_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button61_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button62_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button63_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button64_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button65_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button66_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button67_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button68_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button69_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button70_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button71_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button72_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button73_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button74_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            String kottuF = btn_CkottuF.Text;
            kottuF = "Chiken Kottu Full";
            
            txt_meal_name.Text = kottuF;
            txt_meal_price.Text = "800";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btn_qty_plus_Click(object sender, EventArgs e)
        { 
                quantity++;
                txt_qty.Text = quantity.ToString();
        }

        private void btn_qty_minus_Click(object sender, EventArgs e)
        {
                quantity--;
                txt_qty.Text = quantity.ToString(); 
        }
    }
}
