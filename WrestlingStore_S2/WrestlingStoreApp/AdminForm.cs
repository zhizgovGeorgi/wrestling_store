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
using DAL;

namespace WrestlingStoreApp
{
    public partial class AdminForm : Form
    {
        private ProductManager pm;
        private UserManager um;
        private OrderManager om;
        public AdminForm()
        {
            InitializeComponent();
            pm = new ProductManager(new ProductData());
            um = new UserManager(new UserData());
            om = new OrderManager(new OrderData());
            LoadProducts();
            LoadUsers();
            LoadOrders();
            tbAdditionalInfo.Visible = false;
            lblAdditionalInfo.Visible = false;
            lblAdditionalInfo.Text = "";
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbWrestlingAccessories.Checked)
                {
                    if (tbProdName.Text == "")
                    {
                        MessageBox.Show("Please enter name  of the product");
                        return;

                    }
                    if (tbProdCategory.Text == "")
                    {
                        MessageBox.Show("Please enter category  of the product");
                        return;

                    }
                    if (tbProdPrice.Text == "")
                    {
                        MessageBox.Show("Please enter price  of the product");
                        return;

                    }
                    if (tbProdImg.Text == "")
                    {
                        MessageBox.Show("Please enter image  of the product");
                        return;

                    }
                    Product product = new WrestlingAccessories(tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text);
                    pm.AddProduct(product);
                    LoadProducts();
                }

                else if (rbWrestlingClothes.Checked)
                {
                    if (tbProdName.Text == "")
                    {
                        MessageBox.Show("Please enter name  of the product");
                        return;

                    }
                    if (tbProdCategory.Text == "")
                    {
                        MessageBox.Show("Please enter category  of the product");
                        return;

                    }
                    if (tbProdPrice.Text == "")
                    {
                        MessageBox.Show("Please enter price  of the product");
                        return;

                    }
                    if (tbProdImg.Text == "")
                    {
                        MessageBox.Show("Please enter image  of the product");
                        return;

                    }
                    if (tbAdditionalInfo.Text == "")
                    {
                        MessageBox.Show("Please enter material  of the product");
                        return;

                    }
                    Product product = new WrestlingClothes(tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text, tbAdditionalInfo.Text);
                    pm.AddProduct(product);
                    LoadProducts();
                }
                else if (rbWrestlingShoes.Checked)
                {
                    if (tbProdName.Text == "")
                    {
                        MessageBox.Show("Please enter name  of the product");
                        return;

                    }
                    if (tbProdCategory.Text == "")
                    {
                        MessageBox.Show("Please enter category  of the product");
                        return;

                    }
                    if (tbProdPrice.Text == "")
                    {
                        MessageBox.Show("Please enter price  of the product");
                        return;

                    }
                    if (tbProdImg.Text == "")
                    {
                        MessageBox.Show("Please enter image  of the product");
                        return;

                    }
                    if (tbAdditionalInfo.Text == "")
                    {
                        MessageBox.Show("Please enter kind  of the product");
                        return;

                    }
                    Product product = new WrestlingShoes(tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text, tbAdditionalInfo.Text);
                    pm.AddProduct(product);
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
            User user = new User(tbFName.Text, tbLName.Text, tbEmail.Text, tbAddress.Text, tbPassword.Text, "Administrator");
            try
            {
                um.AddAdmin(user);
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
                if (selectedUser.Role == "Administrator")
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

        private void LoadOrders()
        {
            lbOrders.Items.Clear();
            foreach (Order order in om.GetCartItems())
            {
                if (order.Status == Status.Complete)
                {

                    lbOrders.Items.Add(order);
                }
            }
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            om.EditOrder((Order)lbOrders.SelectedItem, Status.Declined);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            om.EditOrder((Order)lbOrders.SelectedItem, Status.Confirmed);
        }
    }
}
