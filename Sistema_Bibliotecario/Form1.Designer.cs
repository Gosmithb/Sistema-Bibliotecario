
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
            this.conectar_Btn = new System.Windows.Forms.Button();
            this.nombre_Tbx = new System.Windows.Forms.TextBox();
            this.apellidoPaterno_Tbx = new System.Windows.Forms.TextBox();
            this.apellidoMaterno_Tbx = new System.Windows.Forms.TextBox();
            this.nombre_Lbl = new System.Windows.Forms.Label();
            this.apellidoPaterno_Lbl = new System.Windows.Forms.Label();
            this.apellidoMaterno_Lbl = new System.Windows.Forms.Label();
            this.usersList_Lv = new System.Windows.Forms.ListView();
            this.SaveUser_Btn = new System.Windows.Forms.Button();
            this.listUsers_Btn = new System.Windows.Forms.Button();
            this.deleteUser_Btn = new System.Windows.Forms.Button();
            this.updateUser_Btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conectar_Btn
            // 
            this.conectar_Btn.Location = new System.Drawing.Point(12, 415);
            this.conectar_Btn.Name = "conectar_Btn";
            this.conectar_Btn.Size = new System.Drawing.Size(75, 23);
            this.conectar_Btn.TabIndex = 0;
            this.conectar_Btn.Text = "Conectar";
            this.conectar_Btn.UseVisualStyleBackColor = true;
            this.conectar_Btn.Click += new System.EventHandler(this.conectar_Btn_Click);
            // 
            // nombre_Tbx
            // 
            this.nombre_Tbx.Location = new System.Drawing.Point(12, 77);
            this.nombre_Tbx.Name = "nombre_Tbx";
            this.nombre_Tbx.Size = new System.Drawing.Size(100, 20);
            this.nombre_Tbx.TabIndex = 1;
            // 
            // apellidoPaterno_Tbx
            // 
            this.apellidoPaterno_Tbx.Location = new System.Drawing.Point(12, 133);
            this.apellidoPaterno_Tbx.Name = "apellidoPaterno_Tbx";
            this.apellidoPaterno_Tbx.Size = new System.Drawing.Size(100, 20);
            this.apellidoPaterno_Tbx.TabIndex = 2;
            // 
            // apellidoMaterno_Tbx
            // 
            this.apellidoMaterno_Tbx.Location = new System.Drawing.Point(12, 205);
            this.apellidoMaterno_Tbx.Name = "apellidoMaterno_Tbx";
            this.apellidoMaterno_Tbx.Size = new System.Drawing.Size(100, 20);
            this.apellidoMaterno_Tbx.TabIndex = 3;
            // 
            // nombre_Lbl
            // 
            this.nombre_Lbl.AutoSize = true;
            this.nombre_Lbl.Location = new System.Drawing.Point(12, 46);
            this.nombre_Lbl.Name = "nombre_Lbl";
            this.nombre_Lbl.Size = new System.Drawing.Size(44, 13);
            this.nombre_Lbl.TabIndex = 4;
            this.nombre_Lbl.Text = "Nombre";
            // 
            // apellidoPaterno_Lbl
            // 
            this.apellidoPaterno_Lbl.AutoSize = true;
            this.apellidoPaterno_Lbl.Location = new System.Drawing.Point(12, 117);
            this.apellidoPaterno_Lbl.Name = "apellidoPaterno_Lbl";
            this.apellidoPaterno_Lbl.Size = new System.Drawing.Size(84, 13);
            this.apellidoPaterno_Lbl.TabIndex = 5;
            this.apellidoPaterno_Lbl.Text = "Apellido Paterno";
            // 
            // apellidoMaterno_Lbl
            // 
            this.apellidoMaterno_Lbl.AutoSize = true;
            this.apellidoMaterno_Lbl.Location = new System.Drawing.Point(12, 189);
            this.apellidoMaterno_Lbl.Name = "apellidoMaterno_Lbl";
            this.apellidoMaterno_Lbl.Size = new System.Drawing.Size(86, 13);
            this.apellidoMaterno_Lbl.TabIndex = 6;
            this.apellidoMaterno_Lbl.Text = "Apellido Materno";
            // 
            // usersList_Lv
            // 
            this.usersList_Lv.HideSelection = false;
            this.usersList_Lv.Location = new System.Drawing.Point(329, 46);
            this.usersList_Lv.Name = "usersList_Lv";
            this.usersList_Lv.Size = new System.Drawing.Size(271, 213);
            this.usersList_Lv.TabIndex = 7;
            this.usersList_Lv.UseCompatibleStateImageBehavior = false;
            // 
            // SaveUser_Btn
            // 
            this.SaveUser_Btn.Location = new System.Drawing.Point(110, 415);
            this.SaveUser_Btn.Name = "SaveUser_Btn";
            this.SaveUser_Btn.Size = new System.Drawing.Size(75, 23);
            this.SaveUser_Btn.TabIndex = 8;
            this.SaveUser_Btn.Text = "Registrar usuario";
            this.SaveUser_Btn.UseVisualStyleBackColor = true;
            this.SaveUser_Btn.Click += new System.EventHandler(this.SaveUser_Btn_Click);
            // 
            // listUsers_Btn
            // 
            this.listUsers_Btn.Location = new System.Drawing.Point(206, 415);
            this.listUsers_Btn.Name = "listUsers_Btn";
            this.listUsers_Btn.Size = new System.Drawing.Size(98, 23);
            this.listUsers_Btn.TabIndex = 9;
            this.listUsers_Btn.Text = "Mostrar Usuarios";
            this.listUsers_Btn.UseVisualStyleBackColor = true;
            this.listUsers_Btn.Click += new System.EventHandler(this.listUsers_Btn_Click);
            // 
            // deleteUser_Btn
            // 
            this.deleteUser_Btn.Location = new System.Drawing.Point(329, 415);
            this.deleteUser_Btn.Name = "deleteUser_Btn";
            this.deleteUser_Btn.Size = new System.Drawing.Size(75, 23);
            this.deleteUser_Btn.TabIndex = 10;
            this.deleteUser_Btn.Text = "Eliminar Usuario";
            this.deleteUser_Btn.UseVisualStyleBackColor = true;
            this.deleteUser_Btn.Click += new System.EventHandler(this.deleteUser_Btn_Click);
            // 
            // updateUser_Btn
            // 
            this.updateUser_Btn.Location = new System.Drawing.Point(429, 415);
            this.updateUser_Btn.Name = "updateUser_Btn";
            this.updateUser_Btn.Size = new System.Drawing.Size(75, 23);
            this.updateUser_Btn.TabIndex = 11;
            this.updateUser_Btn.Text = "Actualizar Usuario";
            this.updateUser_Btn.UseVisualStyleBackColor = true;
            this.updateUser_Btn.Click += new System.EventHandler(this.updateUser_Btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(535, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.updateUser_Btn);
            this.Controls.Add(this.deleteUser_Btn);
            this.Controls.Add(this.listUsers_Btn);
            this.Controls.Add(this.SaveUser_Btn);
            this.Controls.Add(this.usersList_Lv);
            this.Controls.Add(this.apellidoMaterno_Lbl);
            this.Controls.Add(this.apellidoPaterno_Lbl);
            this.Controls.Add(this.nombre_Lbl);
            this.Controls.Add(this.apellidoMaterno_Tbx);
            this.Controls.Add(this.apellidoPaterno_Tbx);
            this.Controls.Add(this.nombre_Tbx);
            this.Controls.Add(this.conectar_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conectar_Btn;
        private System.Windows.Forms.TextBox nombre_Tbx;
        private System.Windows.Forms.TextBox apellidoPaterno_Tbx;
        private System.Windows.Forms.TextBox apellidoMaterno_Tbx;
        private System.Windows.Forms.Label nombre_Lbl;
        private System.Windows.Forms.Label apellidoPaterno_Lbl;
        private System.Windows.Forms.Label apellidoMaterno_Lbl;
        private System.Windows.Forms.ListView usersList_Lv;
        private System.Windows.Forms.Button SaveUser_Btn;
        private System.Windows.Forms.Button listUsers_Btn;
        private System.Windows.Forms.Button deleteUser_Btn;
        private System.Windows.Forms.Button updateUser_Btn;
        private System.Windows.Forms.Button button4;
    }
}

