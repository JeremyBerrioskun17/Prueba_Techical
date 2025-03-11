namespace PruebaTech.View
{
    partial class Form_Actualizar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bttn_Guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_IDProducto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_IDProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Bttn_Guardar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_Cantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Precio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Descripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Nombre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(613, 260);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Bttn_Guardar
            // 
            this.Bttn_Guardar.Location = new System.Drawing.Point(502, 211);
            this.Bttn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bttn_Guardar.Name = "Bttn_Guardar";
            this.Bttn_Guardar.Size = new System.Drawing.Size(98, 36);
            this.Bttn_Guardar.TabIndex = 8;
            this.Bttn_Guardar.Text = "Editar";
            this.Bttn_Guardar.UseVisualStyleBackColor = true;
            this.Bttn_Guardar.Click += new System.EventHandler(this.Bttn_Guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(277, 153);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(220, 26);
            this.Txt_Cantidad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(277, 74);
            this.Txt_Precio.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(220, 26);
            this.Txt_Precio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(12, 153);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(220, 26);
            this.Txt_Descripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(12, 74);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(220, 26);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Editar Producto";
            // 
            // LB_IDProducto
            // 
            this.LB_IDProducto.AutoSize = true;
            this.LB_IDProducto.Location = new System.Drawing.Point(538, 27);
            this.LB_IDProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_IDProducto.Name = "LB_IDProducto";
            this.LB_IDProducto.Size = new System.Drawing.Size(26, 20);
            this.LB_IDProducto.TabIndex = 10;
            this.LB_IDProducto.Text = "ID";
            this.LB_IDProducto.Visible = false;
            // 
            // Form_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 260);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Actualizar";
            this.Text = "Form_Actualizar";
            this.Load += new System.EventHandler(this.Form_Actualizar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bttn_Guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label LB_IDProducto;
        private System.Windows.Forms.Label label5;
    }
}