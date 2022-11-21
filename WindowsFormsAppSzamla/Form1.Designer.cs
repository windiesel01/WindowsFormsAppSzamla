namespace WindowsFormsAppSzamla
{
    partial class Form_Szamlak
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Szamlak));
            this.listBox_Szamlak = new System.Windows.Forms.ListBox();
            this.groupBox_szamla_adatok = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label_id = new System.Windows.Forms.Label();
            this.label_nev = new System.Windows.Forms.Label();
            this.label_egyenleg = new System.Windows.Forms.Label();
            this.label_datum = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_egyenleg = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dateTimePicker_datum = new System.Windows.Forms.DateTimePicker();
            this.groupBox_szamla_adatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Szamlak
            // 
            this.listBox_Szamlak.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Szamlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_Szamlak.FormattingEnabled = true;
            this.listBox_Szamlak.ItemHeight = 16;
            this.listBox_Szamlak.Location = new System.Drawing.Point(0, 0);
            this.listBox_Szamlak.Name = "listBox_Szamlak";
            this.listBox_Szamlak.Size = new System.Drawing.Size(233, 450);
            this.listBox_Szamlak.TabIndex = 0;
            this.listBox_Szamlak.SelectedIndexChanged += new System.EventHandler(this.listBox_Szamlak_SelectedIndexChanged);
            // 
            // groupBox_szamla_adatok
            // 
            this.groupBox_szamla_adatok.Controls.Add(this.dateTimePicker_datum);
            this.groupBox_szamla_adatok.Controls.Add(this.button_delete);
            this.groupBox_szamla_adatok.Controls.Add(this.button_update);
            this.groupBox_szamla_adatok.Controls.Add(this.button_insert);
            this.groupBox_szamla_adatok.Controls.Add(this.textBox_egyenleg);
            this.groupBox_szamla_adatok.Controls.Add(this.textBox_nev);
            this.groupBox_szamla_adatok.Controls.Add(this.textBox_id);
            this.groupBox_szamla_adatok.Controls.Add(this.label_datum);
            this.groupBox_szamla_adatok.Controls.Add(this.label_egyenleg);
            this.groupBox_szamla_adatok.Controls.Add(this.label_nev);
            this.groupBox_szamla_adatok.Controls.Add(this.label_id);
            this.groupBox_szamla_adatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_szamla_adatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_szamla_adatok.Location = new System.Drawing.Point(233, 0);
            this.groupBox_szamla_adatok.Name = "groupBox_szamla_adatok";
            this.groupBox_szamla_adatok.Size = new System.Drawing.Size(321, 450);
            this.groupBox_szamla_adatok.TabIndex = 1;
            this.groupBox_szamla_adatok.TabStop = false;
            this.groupBox_szamla_adatok.Text = "Számla adatok:";
            this.groupBox_szamla_adatok.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(98, 51);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(32, 24);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID:";
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(81, 86);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(49, 24);
            this.label_nev.TabIndex = 1;
            this.label_nev.Text = "Név:";
            // 
            // label_egyenleg
            // 
            this.label_egyenleg.AutoSize = true;
            this.label_egyenleg.Location = new System.Drawing.Point(34, 119);
            this.label_egyenleg.Name = "label_egyenleg";
            this.label_egyenleg.Size = new System.Drawing.Size(96, 24);
            this.label_egyenleg.TabIndex = 2;
            this.label_egyenleg.Text = "Egyenleg:";
            // 
            // label_datum
            // 
            this.label_datum.AutoSize = true;
            this.label_datum.Location = new System.Drawing.Point(8, 154);
            this.label_datum.Name = "label_datum";
            this.label_datum.Size = new System.Drawing.Size(122, 24);
            this.label_datum.TabIndex = 3;
            this.label_datum.Text = "Nyitás dátum:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(136, 46);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(54, 29);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(136, 81);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(154, 29);
            this.textBox_nev.TabIndex = 5;
            // 
            // textBox_egyenleg
            // 
            this.textBox_egyenleg.Location = new System.Drawing.Point(136, 116);
            this.textBox_egyenleg.Name = "textBox_egyenleg";
            this.textBox_egyenleg.Size = new System.Drawing.Size(154, 29);
            this.textBox_egyenleg.TabIndex = 6;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(38, 219);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(252, 54);
            this.button_insert.TabIndex = 8;
            this.button_insert.Text = "Hozzáadás";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(38, 279);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(252, 54);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Módositás";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(38, 339);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(252, 54);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dateTimePicker_datum
            // 
            this.dateTimePicker_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_datum.Location = new System.Drawing.Point(136, 151);
            this.dateTimePicker_datum.Name = "dateTimePicker_datum";
            this.dateTimePicker_datum.Size = new System.Drawing.Size(154, 29);
            this.dateTimePicker_datum.TabIndex = 11;
            // 
            // Form_Szamlak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.groupBox_szamla_adatok);
            this.Controls.Add(this.listBox_Szamlak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Szamlak";
            this.Text = "Számlák";
            this.groupBox_szamla_adatok.ResumeLayout(false);
            this.groupBox_szamla_adatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Szamlak;
        private System.Windows.Forms.GroupBox groupBox_szamla_adatok;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.TextBox textBox_egyenleg;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.Label label_egyenleg;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datum;
    }
}

