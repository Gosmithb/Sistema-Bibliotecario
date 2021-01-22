
namespace Sistema_Bibliotecario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Search_User_Btn = new System.Windows.Forms.Button();
            this.first_name_Tbx = new System.Windows.Forms.TextBox();
            this.last_name_Tbx = new System.Windows.Forms.TextBox();
            this.address_Tbx = new System.Windows.Forms.TextBox();
            this.first_name__Lbl = new System.Windows.Forms.Label();
            this.last_name_Lbl = new System.Windows.Forms.Label();
            this.address_Lbl = new System.Windows.Forms.Label();
            this.usersList_Lv = new System.Windows.Forms.ListView();
            this.SaveUser_Btn = new System.Windows.Forms.Button();
            this.listUsers_Btn = new System.Windows.Forms.Button();
            this.deleteUser_Btn = new System.Windows.Forms.Button();
            this.updateUser_Btn = new System.Windows.Forms.Button();
            this.datos_Gbx = new System.Windows.Forms.GroupBox();
            this.curp_Tbx = new System.Windows.Forms.TextBox();
            this.age_Tbx = new System.Windows.Forms.TextBox();
            this.curp_Lbl = new System.Windows.Forms.Label();
            this.age_Lbl = new System.Windows.Forms.Label();
            this.datos_Gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_User_Btn
            // 
            this.Search_User_Btn.Location = new System.Drawing.Point(12, 321);
            this.Search_User_Btn.Name = "Search_User_Btn";
            this.Search_User_Btn.Size = new System.Drawing.Size(75, 23);
            this.Search_User_Btn.TabIndex = 0;
            this.Search_User_Btn.Text = "Buscar";
            this.Search_User_Btn.UseVisualStyleBackColor = true;
            this.Search_User_Btn.Click += new System.EventHandler(this.Search_User_Btn_Click);
            // 
            // first_name_Tbx
            // 
            this.first_name_Tbx.Location = new System.Drawing.Point(9, 32);
            this.first_name_Tbx.Name = "first_name_Tbx";
            this.first_name_Tbx.Size = new System.Drawing.Size(100, 20);
            this.first_name_Tbx.TabIndex = 1;
            // 
            // last_name_Tbx
            // 
            this.last_name_Tbx.Location = new System.Drawing.Point(6, 81);
            this.last_name_Tbx.Name = "last_name_Tbx";
            this.last_name_Tbx.Size = new System.Drawing.Size(100, 20);
            this.last_name_Tbx.TabIndex = 2;
            // 
            // address_Tbx
            // 
            this.address_Tbx.Location = new System.Drawing.Point(6, 133);
            this.address_Tbx.Name = "address_Tbx";
            this.address_Tbx.Size = new System.Drawing.Size(100, 20);
            this.address_Tbx.TabIndex = 3;
            // 
            // first_name__Lbl
            // 
            this.first_name__Lbl.AutoSize = true;
            this.first_name__Lbl.Location = new System.Drawing.Point(6, 16);
            this.first_name__Lbl.Name = "first_name__Lbl";
            this.first_name__Lbl.Size = new System.Drawing.Size(44, 13);
            this.first_name__Lbl.TabIndex = 4;
            this.first_name__Lbl.Text = "Nombre";
            // 
            // last_name_Lbl
            // 
            this.last_name_Lbl.AutoSize = true;
            this.last_name_Lbl.Location = new System.Drawing.Point(6, 65);
            this.last_name_Lbl.Name = "last_name_Lbl";
            this.last_name_Lbl.Size = new System.Drawing.Size(44, 13);
            this.last_name_Lbl.TabIndex = 5;
            this.last_name_Lbl.Text = "Apellido";
            // 
            // address_Lbl
            // 
            this.address_Lbl.AutoSize = true;
            this.address_Lbl.Location = new System.Drawing.Point(6, 117);
            this.address_Lbl.Name = "address_Lbl";
            this.address_Lbl.Size = new System.Drawing.Size(52, 13);
            this.address_Lbl.TabIndex = 6;
            this.address_Lbl.Text = "Dirección";
            // 
            // usersList_Lv
            // 
            this.usersList_Lv.HideSelection = false;
            this.usersList_Lv.Location = new System.Drawing.Point(278, 18);
            this.usersList_Lv.Name = "usersList_Lv";
            this.usersList_Lv.Size = new System.Drawing.Size(271, 213);
            this.usersList_Lv.TabIndex = 7;
            this.usersList_Lv.UseCompatibleStateImageBehavior = false;
            // 
            // SaveUser_Btn
            // 
            this.SaveUser_Btn.Location = new System.Drawing.Point(93, 321);
            this.SaveUser_Btn.Name = "SaveUser_Btn";
            this.SaveUser_Btn.Size = new System.Drawing.Size(75, 23);
            this.SaveUser_Btn.TabIndex = 8;
            this.SaveUser_Btn.Text = "Registrar usuario";
            this.SaveUser_Btn.UseVisualStyleBackColor = true;
            this.SaveUser_Btn.Click += new System.EventHandler(this.SaveUser_Btn_Click);
            // 
            // listUsers_Btn
            // 
            this.listUsers_Btn.Location = new System.Drawing.Point(174, 321);
            this.listUsers_Btn.Name = "listUsers_Btn";
            this.listUsers_Btn.Size = new System.Drawing.Size(98, 23);
            this.listUsers_Btn.TabIndex = 9;
            this.listUsers_Btn.Text = "Mostrar Usuarios";
            this.listUsers_Btn.UseVisualStyleBackColor = true;
            this.listUsers_Btn.Click += new System.EventHandler(this.listUsers_Btn_Click);
            // 
            // deleteUser_Btn
            // 
            this.deleteUser_Btn.Location = new System.Drawing.Point(278, 321);
            this.deleteUser_Btn.Name = "deleteUser_Btn";
            this.deleteUser_Btn.Size = new System.Drawing.Size(75, 23);
            this.deleteUser_Btn.TabIndex = 10;
            this.deleteUser_Btn.Text = "Eliminar Usuario";
            this.deleteUser_Btn.UseVisualStyleBackColor = true;
            this.deleteUser_Btn.Click += new System.EventHandler(this.deleteUser_Btn_Click);
            // 
            // updateUser_Btn
            // 
            this.updateUser_Btn.Location = new System.Drawing.Point(359, 321);
            this.updateUser_Btn.Name = "updateUser_Btn";
            this.updateUser_Btn.Size = new System.Drawing.Size(75, 23);
            this.updateUser_Btn.TabIndex = 11;
            this.updateUser_Btn.Text = "Actualizar Usuario";
            this.updateUser_Btn.UseVisualStyleBackColor = true;
            this.updateUser_Btn.Click += new System.EventHandler(this.updateUser_Btn_Click);
            // 
            // datos_Gbx
            // 
            this.datos_Gbx.Controls.Add(this.curp_Tbx);
            this.datos_Gbx.Controls.Add(this.age_Tbx);
            this.datos_Gbx.Controls.Add(this.curp_Lbl);
            this.datos_Gbx.Controls.Add(this.age_Lbl);
            this.datos_Gbx.Controls.Add(this.first_name__Lbl);
            this.datos_Gbx.Controls.Add(this.first_name_Tbx);
            this.datos_Gbx.Controls.Add(this.last_name_Lbl);
            this.datos_Gbx.Controls.Add(this.last_name_Tbx);
            this.datos_Gbx.Controls.Add(this.address_Lbl);
            this.datos_Gbx.Controls.Add(this.address_Tbx);
            this.datos_Gbx.Location = new System.Drawing.Point(12, 3);
            this.datos_Gbx.Name = "datos_Gbx";
            this.datos_Gbx.Size = new System.Drawing.Size(260, 293);
            this.datos_Gbx.TabIndex = 12;
            this.datos_Gbx.TabStop = false;
            this.datos_Gbx.Text = "Datos Personales";
            // 
            // curp_Tbx
            // 
            this.curp_Tbx.Location = new System.Drawing.Point(6, 241);
            this.curp_Tbx.Name = "curp_Tbx";
            this.curp_Tbx.Size = new System.Drawing.Size(100, 20);
            this.curp_Tbx.TabIndex = 10;
            // 
            // age_Tbx
            // 
            this.age_Tbx.Location = new System.Drawing.Point(6, 184);
            this.age_Tbx.Name = "age_Tbx";
            this.age_Tbx.Size = new System.Drawing.Size(100, 20);
            this.age_Tbx.TabIndex = 9;
            // 
            // curp_Lbl
            // 
            this.curp_Lbl.AutoSize = true;
            this.curp_Lbl.Location = new System.Drawing.Point(6, 225);
            this.curp_Lbl.Name = "curp_Lbl";
            this.curp_Lbl.Size = new System.Drawing.Size(37, 13);
            this.curp_Lbl.TabIndex = 8;
            this.curp_Lbl.Text = "CURP";
            // 
            // age_Lbl
            // 
            this.age_Lbl.AutoSize = true;
            this.age_Lbl.Location = new System.Drawing.Point(6, 168);
            this.age_Lbl.Name = "age_Lbl";
            this.age_Lbl.Size = new System.Drawing.Size(32, 13);
            this.age_Lbl.TabIndex = 7;
            this.age_Lbl.Text = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 366);
            this.Controls.Add(this.datos_Gbx);
            this.Controls.Add(this.updateUser_Btn);
            this.Controls.Add(this.deleteUser_Btn);
            this.Controls.Add(this.listUsers_Btn);
            this.Controls.Add(this.SaveUser_Btn);
            this.Controls.Add(this.usersList_Lv);
            this.Controls.Add(this.Search_User_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.datos_Gbx.ResumeLayout(false);
            this.datos_Gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search_User_Btn;
        private System.Windows.Forms.TextBox first_name_Tbx;
        private System.Windows.Forms.TextBox last_name_Tbx;
        private System.Windows.Forms.TextBox address_Tbx;
        private System.Windows.Forms.Label first_name__Lbl;
        private System.Windows.Forms.Label last_name_Lbl;
        private System.Windows.Forms.Label address_Lbl;
        private System.Windows.Forms.ListView usersList_Lv;
        private System.Windows.Forms.Button SaveUser_Btn;
        private System.Windows.Forms.Button listUsers_Btn;
        private System.Windows.Forms.Button deleteUser_Btn;
        private System.Windows.Forms.Button updateUser_Btn;
        private System.Windows.Forms.GroupBox datos_Gbx;
        private System.Windows.Forms.Label curp_Lbl;
        private System.Windows.Forms.Label age_Lbl;
        private System.Windows.Forms.TextBox curp_Tbx;
        private System.Windows.Forms.TextBox age_Tbx;
    }
}

