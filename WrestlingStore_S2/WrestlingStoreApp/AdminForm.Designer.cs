namespace WrestlingStoreApp
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAdministrator = new System.Windows.Forms.TabControl();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.rbWrestlingAccessories = new System.Windows.Forms.RadioButton();
            this.rbWrestlingClothes = new System.Windows.Forms.RadioButton();
            this.rbWrestlingShoes = new System.Windows.Forms.RadioButton();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.tbAdditionalInfo = new System.Windows.Forms.TextBox();
            this.lblProdImg = new System.Windows.Forms.Label();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.lblProdCategory = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblProdId = new System.Windows.Forms.Label();
            this.tbProdID = new System.Windows.Forms.TextBox();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.tbProdPrice = new System.Windows.Forms.TextBox();
            this.tbProdCategory = new System.Windows.Forms.TextBox();
            this.tbProdImg = new System.Windows.Forms.TextBox();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnRemoveProd = new System.Windows.Forms.Button();
            this.btnShowProducts = new System.Windows.Forms.Button();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.btnRemoveAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.tcAdministrator.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdministrator
            // 
            this.tcAdministrator.Controls.Add(this.tpProducts);
            this.tcAdministrator.Controls.Add(this.tpUsers);
            this.tcAdministrator.Controls.Add(this.tpOrders);
            this.tcAdministrator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAdministrator.Location = new System.Drawing.Point(0, 0);
            this.tcAdministrator.Name = "tcAdministrator";
            this.tcAdministrator.SelectedIndex = 0;
            this.tcAdministrator.Size = new System.Drawing.Size(800, 450);
            this.tcAdministrator.TabIndex = 0;
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.rbWrestlingAccessories);
            this.tpProducts.Controls.Add(this.rbWrestlingClothes);
            this.tpProducts.Controls.Add(this.rbWrestlingShoes);
            this.tpProducts.Controls.Add(this.lblAdditionalInfo);
            this.tpProducts.Controls.Add(this.tbAdditionalInfo);
            this.tpProducts.Controls.Add(this.lblProdImg);
            this.tpProducts.Controls.Add(this.lblProdPrice);
            this.tpProducts.Controls.Add(this.lblProdCategory);
            this.tpProducts.Controls.Add(this.lblProdName);
            this.tpProducts.Controls.Add(this.lblProdId);
            this.tpProducts.Controls.Add(this.tbProdID);
            this.tpProducts.Controls.Add(this.tbProdName);
            this.tpProducts.Controls.Add(this.tbProdPrice);
            this.tpProducts.Controls.Add(this.tbProdCategory);
            this.tpProducts.Controls.Add(this.tbProdImg);
            this.tpProducts.Controls.Add(this.lbProducts);
            this.tpProducts.Controls.Add(this.btnAddProd);
            this.tpProducts.Controls.Add(this.btnRemoveProd);
            this.tpProducts.Controls.Add(this.btnShowProducts);
            this.tpProducts.Location = new System.Drawing.Point(4, 24);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducts.Size = new System.Drawing.Size(792, 422);
            this.tpProducts.TabIndex = 0;
            this.tpProducts.Text = "Products";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // rbWrestlingAccessories
            // 
            this.rbWrestlingAccessories.AutoSize = true;
            this.rbWrestlingAccessories.Location = new System.Drawing.Point(244, 365);
            this.rbWrestlingAccessories.Name = "rbWrestlingAccessories";
            this.rbWrestlingAccessories.Size = new System.Drawing.Size(139, 19);
            this.rbWrestlingAccessories.TabIndex = 7;
            this.rbWrestlingAccessories.TabStop = true;
            this.rbWrestlingAccessories.Text = "Wrestling Accessories";
            this.rbWrestlingAccessories.UseVisualStyleBackColor = true;
            this.rbWrestlingAccessories.CheckedChanged += new System.EventHandler(this.rbWrestlingAccessories_CheckedChanged);
            // 
            // rbWrestlingClothes
            // 
            this.rbWrestlingClothes.AutoSize = true;
            this.rbWrestlingClothes.Location = new System.Drawing.Point(120, 365);
            this.rbWrestlingClothes.Name = "rbWrestlingClothes";
            this.rbWrestlingClothes.Size = new System.Drawing.Size(118, 19);
            this.rbWrestlingClothes.TabIndex = 6;
            this.rbWrestlingClothes.TabStop = true;
            this.rbWrestlingClothes.Text = "Wrestling Clothes";
            this.rbWrestlingClothes.UseVisualStyleBackColor = true;
            this.rbWrestlingClothes.CheckedChanged += new System.EventHandler(this.rbWrestlingClothes_CheckedChanged);
            // 
            // rbWrestlingShoes
            // 
            this.rbWrestlingShoes.AutoSize = true;
            this.rbWrestlingShoes.Location = new System.Drawing.Point(11, 366);
            this.rbWrestlingShoes.Name = "rbWrestlingShoes";
            this.rbWrestlingShoes.Size = new System.Drawing.Size(109, 19);
            this.rbWrestlingShoes.TabIndex = 5;
            this.rbWrestlingShoes.TabStop = true;
            this.rbWrestlingShoes.Text = "Wrestling Shoes";
            this.rbWrestlingShoes.UseVisualStyleBackColor = true;
            this.rbWrestlingShoes.CheckedChanged += new System.EventHandler(this.rbWrestlingShoes_CheckedChanged);
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.AutoSize = true;
            this.lblAdditionalInfo.Location = new System.Drawing.Point(14, 319);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(10, 15);
            this.lblAdditionalInfo.TabIndex = 4;
            this.lblAdditionalInfo.Text = ":";
            // 
            // tbAdditionalInfo
            // 
            this.tbAdditionalInfo.Location = new System.Drawing.Point(95, 309);
            this.tbAdditionalInfo.Name = "tbAdditionalInfo";
            this.tbAdditionalInfo.Size = new System.Drawing.Size(167, 23);
            this.tbAdditionalInfo.TabIndex = 1;
            // 
            // lblProdImg
            // 
            this.lblProdImg.AutoSize = true;
            this.lblProdImg.Location = new System.Drawing.Point(14, 260);
            this.lblProdImg.Name = "lblProdImg";
            this.lblProdImg.Size = new System.Drawing.Size(65, 15);
            this.lblProdImg.TabIndex = 4;
            this.lblProdImg.Text = "Image link:";
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Location = new System.Drawing.Point(14, 213);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(36, 15);
            this.lblProdPrice.TabIndex = 4;
            this.lblProdPrice.Text = "Price:";
            // 
            // lblProdCategory
            // 
            this.lblProdCategory.AutoSize = true;
            this.lblProdCategory.Location = new System.Drawing.Point(14, 160);
            this.lblProdCategory.Name = "lblProdCategory";
            this.lblProdCategory.Size = new System.Drawing.Size(58, 15);
            this.lblProdCategory.TabIndex = 4;
            this.lblProdCategory.Text = "Category:";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(14, 109);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(42, 15);
            this.lblProdName.TabIndex = 4;
            this.lblProdName.Text = "Name:";
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Location = new System.Drawing.Point(14, 52);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(21, 15);
            this.lblProdId.TabIndex = 4;
            this.lblProdId.Text = "ID:";
            // 
            // tbProdID
            // 
            this.tbProdID.Location = new System.Drawing.Point(95, 54);
            this.tbProdID.Name = "tbProdID";
            this.tbProdID.Size = new System.Drawing.Size(167, 23);
            this.tbProdID.TabIndex = 0;
            // 
            // tbProdName
            // 
            this.tbProdName.Location = new System.Drawing.Point(95, 101);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(167, 23);
            this.tbProdName.TabIndex = 1;
            // 
            // tbProdPrice
            // 
            this.tbProdPrice.Location = new System.Drawing.Point(95, 205);
            this.tbProdPrice.Name = "tbProdPrice";
            this.tbProdPrice.Size = new System.Drawing.Size(167, 23);
            this.tbProdPrice.TabIndex = 1;
            // 
            // tbProdCategory
            // 
            this.tbProdCategory.Location = new System.Drawing.Point(95, 152);
            this.tbProdCategory.Name = "tbProdCategory";
            this.tbProdCategory.Size = new System.Drawing.Size(167, 23);
            this.tbProdCategory.TabIndex = 1;
            // 
            // tbProdImg
            // 
            this.tbProdImg.Location = new System.Drawing.Point(95, 257);
            this.tbProdImg.Name = "tbProdImg";
            this.tbProdImg.Size = new System.Drawing.Size(167, 23);
            this.tbProdImg.TabIndex = 1;
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 15;
            this.lbProducts.Location = new System.Drawing.Point(362, 53);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(351, 229);
            this.lbProducts.TabIndex = 2;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(331, 309);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(85, 39);
            this.btnAddProd.TabIndex = 3;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnRemoveProd
            // 
            this.btnRemoveProd.Location = new System.Drawing.Point(495, 309);
            this.btnRemoveProd.Name = "btnRemoveProd";
            this.btnRemoveProd.Size = new System.Drawing.Size(85, 39);
            this.btnRemoveProd.TabIndex = 3;
            this.btnRemoveProd.Text = "Remove";
            this.btnRemoveProd.UseVisualStyleBackColor = true;
            this.btnRemoveProd.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnShowProducts
            // 
            this.btnShowProducts.Location = new System.Drawing.Point(641, 309);
            this.btnShowProducts.Name = "btnShowProducts";
            this.btnShowProducts.Size = new System.Drawing.Size(85, 39);
            this.btnShowProducts.TabIndex = 3;
            this.btnShowProducts.Text = "Show";
            this.btnShowProducts.UseVisualStyleBackColor = true;
            this.btnShowProducts.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.btnShowAllUsers);
            this.tpUsers.Controls.Add(this.btnRemoveAdmin);
            this.tpUsers.Controls.Add(this.btnAddAdmin);
            this.tpUsers.Controls.Add(this.lblPass);
            this.tpUsers.Controls.Add(this.lblAdress);
            this.tpUsers.Controls.Add(this.lblEmail);
            this.tpUsers.Controls.Add(this.lblLName);
            this.tpUsers.Controls.Add(this.lblFName);
            this.tpUsers.Controls.Add(this.lblId);
            this.tpUsers.Controls.Add(this.tbPassword);
            this.tpUsers.Controls.Add(this.tbAddress);
            this.tpUsers.Controls.Add(this.tbEmail);
            this.tpUsers.Controls.Add(this.tbLName);
            this.tpUsers.Controls.Add(this.tbFName);
            this.tpUsers.Controls.Add(this.tbID);
            this.tpUsers.Controls.Add(this.lbUsers);
            this.tpUsers.Location = new System.Drawing.Point(4, 24);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(792, 422);
            this.tpUsers.TabIndex = 1;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.Location = new System.Drawing.Point(617, 309);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(88, 48);
            this.btnShowAllUsers.TabIndex = 3;
            this.btnShowAllUsers.Text = "Show All Users";
            this.btnShowAllUsers.UseVisualStyleBackColor = true;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // btnRemoveAdmin
            // 
            this.btnRemoveAdmin.Location = new System.Drawing.Point(480, 309);
            this.btnRemoveAdmin.Name = "btnRemoveAdmin";
            this.btnRemoveAdmin.Size = new System.Drawing.Size(87, 48);
            this.btnRemoveAdmin.TabIndex = 3;
            this.btnRemoveAdmin.Text = "Remove Admin";
            this.btnRemoveAdmin.UseVisualStyleBackColor = true;
            this.btnRemoveAdmin.Click += new System.EventHandler(this.btnRemoveAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(336, 309);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(83, 48);
            this.btnAddAdmin.TabIndex = 3;
            this.btnAddAdmin.Text = "Create Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(14, 296);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(60, 15);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(14, 247);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(45, 15);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "Adress:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(14, 144);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(66, 15);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(14, 87);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(92, 288);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(143, 23);
            this.tbPassword.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(92, 239);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(143, 23);
            this.tbAddress.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(92, 188);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(143, 23);
            this.tbEmail.TabIndex = 1;
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(92, 136);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(143, 23);
            this.tbLName.TabIndex = 1;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(92, 84);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(143, 23);
            this.tbFName.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(92, 42);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(143, 23);
            this.tbID.TabIndex = 1;
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 15;
            this.lbUsers.Location = new System.Drawing.Point(328, 46);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(400, 199);
            this.lbUsers.TabIndex = 0;
            // 
            // tpOrders
            // 
            this.tpOrders.Location = new System.Drawing.Point(4, 24);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Size = new System.Drawing.Size(792, 422);
            this.tpOrders.TabIndex = 2;
            this.tpOrders.Text = "Orders";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAdministrator);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.tcAdministrator.ResumeLayout(false);
            this.tpProducts.ResumeLayout(false);
            this.tpProducts.PerformLayout();
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdministrator;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.TextBox tbProdID;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.TextBox tbProdPrice;
        private System.Windows.Forms.TextBox tbProdCategory;
        private System.Windows.Forms.TextBox tbProdImg;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnRemoveProd;
        private System.Windows.Forms.Button btnShowProducts;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.Label lblProdImg;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label lblProdCategory;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.TextBox tbAdditionalInfo;
        private System.Windows.Forms.RadioButton rbWrestlingAccessories;
        private System.Windows.Forms.RadioButton rbWrestlingClothes;
        private System.Windows.Forms.RadioButton rbWrestlingShoes;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnShowAllUsers;
        private System.Windows.Forms.Button btnRemoveAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TabPage tpOrders;
    }
}

