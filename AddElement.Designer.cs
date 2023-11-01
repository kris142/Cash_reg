namespace Сash_register
{
    partial class AddElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddElement));
            this.ItemsList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.des = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_remove = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ItemsList
            // 
            this.ItemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.des,
            this.weightf,
            this.pr});
            this.ItemsList.HideSelection = false;
            this.ItemsList.Location = new System.Drawing.Point(21, 12);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(402, 428);
            this.ItemsList.TabIndex = 22;
            this.ItemsList.UseCompatibleStateImageBehavior = false;
            this.ItemsList.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Название";
            this.name.Width = 83;
            // 
            // des
            // 
            this.des.Text = "Описание";
            this.des.Width = 156;
            // 
            // weightf
            // 
            this.weightf.Text = "Вес";
            // 
            // pr
            // 
            this.pr.Text = "Цена";
            // 
            // button_remove
            // 
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_remove.Location = new System.Drawing.Point(560, 333);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(100, 40);
            this.button_remove.TabIndex = 20;
            this.button_remove.Text = "Удалить";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // nametextbox
            // 
            this.namebox.Location = new System.Drawing.Point(557, 48);
            this.namebox.Name = "nametextbox";
            this.namebox.Size = new System.Drawing.Size(100, 20);
            this.namebox.TabIndex = 13;
            this.namebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametextbox_KeyPress);
            // 
            // button_add
            // 
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_add.Location = new System.Drawing.Point(515, 265);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(206, 40);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // pricebox
            // 
            this.price.Location = new System.Drawing.Point(560, 138);
            this.price.MaxLength = 10;
            this.price.Name = "pricebox";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 15;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(558, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(554, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(554, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Описание";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(574, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightbox
            // 
            this.weight.Location = new System.Drawing.Point(560, 186);
            this.weight.MaxLength = 10;
            this.weight.Name = "weightbox";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 24;
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(557, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Вес";
            // 
            // descriptextbox
            // 
            this.descriptext.Location = new System.Drawing.Point(558, 91);
            this.descriptext.Multiline = true;
            this.descriptext.Name = "descriptextbox";
            this.descriptext.Size = new System.Drawing.Size(100, 20);
            this.descriptext.TabIndex = 14;
            this.descriptext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametextbox_KeyPress);
            // 
            // AddElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Сash_register.Properties.Resources.rm222batch5_mind_12;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.ControlBox = false;
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptext);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ItemsList);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 505);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 505);
            this.Name = "AddElement";
            this.Text = "Добавить Блюдо";
            this.Load += new System.EventHandler(this.AddElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ItemsList;
        public System.Windows.Forms.ColumnHeader name;
        public System.Windows.Forms.ColumnHeader des;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader weightf;
        private System.Windows.Forms.ColumnHeader pr;
        private System.Windows.Forms.TextBox descriptext;
    }
}