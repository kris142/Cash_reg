namespace Сash_register
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.home_page = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adddish = new System.Windows.Forms.ToolStripMenuItem();
            this.Account = new System.Windows.Forms.ToolStripMenuItem();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.Register = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьАвторизациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeselected = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.to_shopping_basket = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.hint5 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.cartsum = new System.Windows.Forms.Label();
            this.product_list = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Menu_bas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.quantity1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.shopping_basket = new System.Windows.Forms.ListView();
            this.Блюдо = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.Menu_bas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home_page,
            this.Account,
            this.выходToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(895, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            // 
            // home_page
            // 
            this.home_page.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.adddish});
            this.home_page.Name = "home_page";
            this.home_page.Size = new System.Drawing.Size(63, 20);
            this.home_page.Text = "Главная";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // adddish
            // 
            this.adddish.Name = "adddish";
            this.adddish.Size = new System.Drawing.Size(166, 22);
            this.adddish.Text = "Добавить блюдо";
            this.adddish.Click += new System.EventHandler(this.add_dish);
            // 
            // Account
            // 
            this.Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.Register,
            this.сброситьАвторизациюToolStripMenuItem});
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(63, 20);
            this.Account.Text = "Аккаунт";
            // 
            // Login
            // 
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(203, 22);
            this.Login.Text = "Войти";
            this.Login.Click += new System.EventHandler(this.ent_acc);
            // 
            // Register
            // 
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(203, 22);
            this.Register.Text = "Зарегистрировать";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // сброситьАвторизациюToolStripMenuItem
            // 
            this.сброситьАвторизациюToolStripMenuItem.Name = "сброситьАвторизациюToolStripMenuItem";
            this.сброситьАвторизациюToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.сброситьАвторизациюToolStripMenuItem.Text = "Сбросить авторизацию";
            this.сброситьАвторизациюToolStripMenuItem.Click += new System.EventHandler(this.сброситьАвторизациюToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exit);
            // 
            // removeselected
            // 
            this.removeselected.Enabled = false;
            this.removeselected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeselected.Location = new System.Drawing.Point(218, 535);
            this.removeselected.Name = "removeselected";
            this.removeselected.Size = new System.Drawing.Size(286, 58);
            this.removeselected.TabIndex = 42;
            this.removeselected.Text = "Удалить выбранное";
            this.removeselected.UseVisualStyleBackColor = true;
            this.removeselected.Click += new System.EventHandler(this.removeselected_Click);
            // 
            // export_button
            // 
            this.export_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.export_button.Location = new System.Drawing.Point(30, 535);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(182, 58);
            this.export_button.TabIndex = 40;
            this.export_button.Text = "Экспортировать итог в txt";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // to_shopping_basket
            // 
            this.to_shopping_basket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_shopping_basket.Location = new System.Drawing.Point(257, 519);
            this.to_shopping_basket.Name = "to_shopping_basket";
            this.to_shopping_basket.Size = new System.Drawing.Size(286, 67);
            this.to_shopping_basket.TabIndex = 31;
            this.to_shopping_basket.Text = "Добавить в корзину";
            this.to_shopping_basket.UseVisualStyleBackColor = true;
            this.to_shopping_basket.Click += new System.EventHandler(this.to_shopping_basket_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(413, 477);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 16);
            this.price.TabIndex = 27;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(413, 461);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 16);
            this.name.TabIndex = 26;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2.ForeColor = System.Drawing.Color.Black;
            this.l2.Location = new System.Drawing.Point(297, 493);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(88, 16);
            this.l2.TabIndex = 24;
            this.l2.Text = "Количество:";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable1.ForeColor = System.Drawing.Color.Black;
            this.lable1.Location = new System.Drawing.Point(297, 476);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(92, 16);
            this.lable1.TabIndex = 23;
            this.lable1.Text = "Цена одного:";
            // 
            // hint5
            // 
            this.hint5.AutoSize = true;
            this.hint5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hint5.ForeColor = System.Drawing.Color.Black;
            this.hint5.Location = new System.Drawing.Point(310, 460);
            this.hint5.Name = "hint5";
            this.hint5.Size = new System.Drawing.Size(76, 16);
            this.hint5.TabIndex = 22;
            this.hint5.Text = "Название:";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.BackColor = System.Drawing.Color.Transparent;
            this.sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(146, 480);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(20, 24);
            this.sum.TabIndex = 16;
            this.sum.Text = "0";
            // 
            // cartsum
            // 
            this.cartsum.AutoSize = true;
            this.cartsum.BackColor = System.Drawing.Color.Transparent;
            this.cartsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartsum.Location = new System.Drawing.Point(53, 480);
            this.cartsum.Name = "cartsum";
            this.cartsum.Size = new System.Drawing.Size(69, 24);
            this.cartsum.TabIndex = 15;
            this.cartsum.Text = "Итого:";
            // 
            // product_list
            // 
            this.product_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_list.FormattingEnabled = true;
            this.product_list.ItemHeight = 18;
            this.product_list.Location = new System.Drawing.Point(25, 43);
            this.product_list.Name = "product_list";
            this.product_list.Size = new System.Drawing.Size(756, 360);
            this.product_list.TabIndex = 43;
            this.product_list.SelectedIndexChanged += new System.EventHandler(this.product_list_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 745);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(16, 17);
            this.richTextBox1.TabIndex = 44;
            this.richTextBox1.Text = "";
            // 
            // Menu_bas
            // 
            this.Menu_bas.Controls.Add(this.tabPage1);
            this.Menu_bas.Controls.Add(this.tabPage2);
            this.Menu_bas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu_bas.Location = new System.Drawing.Point(32, 62);
            this.Menu_bas.Name = "Menu_bas";
            this.Menu_bas.SelectedIndex = 0;
            this.Menu_bas.Size = new System.Drawing.Size(832, 639);
            this.Menu_bas.TabIndex = 45;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.quantity1);
            this.tabPage1.Controls.Add(this.product_list);
            this.tabPage1.Controls.Add(this.to_shopping_basket);
            this.tabPage1.Controls.Add(this.hint5);
            this.tabPage1.Controls.Add(this.lable1);
            this.tabPage1.Controls.Add(this.l2);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Меню";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 25);
            this.button2.TabIndex = 47;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // quantity1
            // 
            this.quantity1.Location = new System.Drawing.Point(395, 493);
            this.quantity1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity1.Name = "quantity1";
            this.quantity1.Size = new System.Drawing.Size(38, 24);
            this.quantity1.TabIndex = 46;
            this.quantity1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.shopping_basket);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.removeselected);
            this.tabPage2.Controls.Add(this.sum);
            this.tabPage2.Controls.Add(this.export_button);
            this.tabPage2.Controls.Add(this.cartsum);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Корзина";
            // 
            // shopping_basket
            // 
            this.shopping_basket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Блюдо,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.shopping_basket.HideSelection = false;
            this.shopping_basket.Location = new System.Drawing.Point(175, 22);
            this.shopping_basket.Name = "shopping_basket";
            this.shopping_basket.Size = new System.Drawing.Size(474, 390);
            this.shopping_basket.TabIndex = 47;
            this.shopping_basket.UseCompatibleStateImageBehavior = false;
            this.shopping_basket.View = System.Windows.Forms.View.Details;
            this.shopping_basket.SelectedIndexChanged += new System.EventHandler(this.shopping_basket_SelectedIndexChanged);
            // 
            // Блюдо
            // 
            this.Блюдо.Text = "Блюдо";
            this.Блюдо.Width = 128;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Цена";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Колличество";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Стоимость";
            this.columnHeader3.Width = 112;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(510, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 58);
            this.button1.TabIndex = 43;
            this.button1.Text = "Удалить всё";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(203, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "руб.";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(375, 9);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(0, 13);
            this.user_name.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Гость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Здравствуйте,";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(895, 763);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.Menu_bas);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Касса столовой";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.Menu_bas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem home_page;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adddish;
        private System.Windows.Forms.ToolStripMenuItem Account;
        private System.Windows.Forms.ToolStripMenuItem Login;
        private System.Windows.Forms.ToolStripMenuItem Register;
        private System.Windows.Forms.ToolStripMenuItem сброситьАвторизациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button removeselected;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Button to_shopping_basket;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label hint5;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label cartsum;
        private System.Windows.Forms.ListBox product_list;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl Menu_bas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantity1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView shopping_basket;
        private System.Windows.Forms.ColumnHeader Блюдо;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button2;
    }
}