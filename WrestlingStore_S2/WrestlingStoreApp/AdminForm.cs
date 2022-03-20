using LogicLayer;
using Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrestlingStoreApp
{
    public partial class AdminForm : Form
    {
        private ProductManager pm;
        private UserManager um;
        public AdminForm()
        {
            InitializeComponent();
            pm = new ProductManager();
            um = new UserManager();
            tbAdditionalInfo.Visible = false;
            lblAdditionalInfo.Visible = false;
            lblAdditionalInfo.Text = "";
            LoadProducts();
            LoadUsers();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbWrestlingAccessories.Checked)
                {
                    pm.AddAccessories( tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text);
                    LoadProducts();
                }
                else if (rbWrestlingClothes.Checked)
                {
                    pm.AddClothes( tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text, tbAdditionalInfo.Text);
                    LoadProducts();
                }
                else if (rbWrestlingShoes.Checked)
                {
                    pm.AddShoes( tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text, tbAdditionalInfo.Text);
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Please select the type of Product!");
                }
            }
            catch (System.FormatException)
            {

                MessageBox.Show("The information provided is incorrect!");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            lbProducts.Items.Clear();
            foreach (Product p in pm.GetProducts())
            {
                lbProducts.Items.Add(p);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pm.RemoveProduct((Product)lbProducts.SelectedItem);
            LoadProducts();
        }

        private void rbWrestlingShoes_CheckedChanged(object sender, EventArgs e)
        {
            tbAdditionalInfo.Visible = true;
            lblAdditionalInfo.Visible = true;
            lblAdditionalInfo.Text = "Kind";
        }

        private void rbWrestlingClothes_CheckedChanged(object sender, EventArgs e)
        {
            tbAdditionalInfo.Visible = true;
            lblAdditionalInfo.Visible = true;
            lblAdditionalInfo.Text = "Material";
        }

        private void rbWrestlingAccessories_CheckedChanged(object sender, EventArgs e)
        {
            tbAdditionalInfo.Visible = false;
            lblAdditionalInfo.Visible = false;
            lblAdditionalInfo.Text = "";
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                um.AddAdmin( tbFName.Text, tbLName.Text, tbEmail.Text, tbAddress.Text, tbPassword.Text);
                LoadUsers();
            }
            catch (System.FormatException)
            {

                MessageBox.Show("The information provided is incorrect!");
                return;
            }
        }

        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)lbUsers.SelectedItem;
            try
            {
                if (selectedUser.role == "Administrator")
                {
                    um.RemoveUser(selectedUser);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("You are allowed to only create other administrators!");
                    return;
                }
            }
            catch (System.NullReferenceException)
            {

                MessageBox.Show("Please, select a User!");
            }
            
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            lbUsers.Items.Clear();
            foreach (User user in um.GetAllUsers())
            {
                lbUsers.Items.Add(user);
            }
        }
    }
}
