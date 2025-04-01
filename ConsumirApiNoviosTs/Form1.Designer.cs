namespace ConsumirApiNoviosTs
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            labelnombre = new Label();
            txtId = new TextBox();
            txtnombre = new TextBox();
            btnBuscar = new Button();
            label4 = new Label();
            txtcancion = new TextBox();
            label5 = new Label();
            txtprofesion = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            txtfoto = new TextBox();
            btnAgregar = new Button();
            btnUpdate = new Button();
            btnEliminar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(548, 351);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(412, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 1;
            label1.Text = "Novios de Taylor Swift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 41);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Novio ID:";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(25, 75);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(54, 15);
            labelnombre.TabIndex = 3;
            labelnombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new Point(98, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(112, 23);
            txtId.TabIndex = 4;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(98, 75);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(193, 23);
            txtnombre.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(216, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 46);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Cancion";
            // 
            // txtcancion
            // 
            txtcancion.Location = new Point(412, 43);
            txtcancion.Name = "txtcancion";
            txtcancion.Size = new Size(234, 23);
            txtcancion.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 83);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Profesion";
            // 
            // txtprofesion
            // 
            txtprofesion.Location = new Point(412, 80);
            txtprofesion.Name = "txtprofesion";
            txtprofesion.Size = new Size(148, 23);
            txtprofesion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(657, 49);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 11;
            label6.Text = "Foto:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(583, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 351);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtfoto
            // 
            txtfoto.Location = new Point(697, 43);
            txtfoto.Name = "txtfoto";
            txtfoto.Size = new Size(190, 23);
            txtfoto.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightGreen;
            btnAgregar.Location = new Point(583, 93);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Crear";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(697, 93);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(802, 93);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 494);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnUpdate);
            Controls.Add(btnAgregar);
            Controls.Add(txtfoto);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(txtprofesion);
            Controls.Add(label5);
            Controls.Add(txtcancion);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(txtnombre);
            Controls.Add(txtId);
            Controls.Add(labelnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label labelnombre;
        private TextBox txtId;
        private TextBox txtnombre;
        private Button btnBuscar;
        private Label label4;
        private TextBox txtcancion;
        private Label label5;
        private TextBox txtprofesion;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox txtfoto;
        private Button btnAgregar;
        private Button btnUpdate;
        private Button btnEliminar;
        private Button button1;
    }
}
