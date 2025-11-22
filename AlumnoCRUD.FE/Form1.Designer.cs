namespace AlumnoCRUD.FE
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();

            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();

            this.dgvAlumnos = new System.Windows.Forms.DataGridView();

            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();

            // 
            // Labels
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 20);
            this.lblNombre.Text = "Nombre";

            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 55);
            this.lblApellido.Text = "Apellido";

            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(30, 90);
            this.lblLegajo.Text = "Legajo";

            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 125);
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";

            // 
            // Textboxes
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 17);
            this.txtNombre.Size = new System.Drawing.Size(180, 22);

            this.txtApellido.Location = new System.Drawing.Point(180, 52);
            this.txtApellido.Size = new System.Drawing.Size(180, 22);

            this.txtLegajo.Location = new System.Drawing.Point(180, 87);
            this.txtLegajo.Size = new System.Drawing.Size(180, 22);

            // 
            // Fecha Nacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(180, 122);
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);

            // 
            // DataGridView
            // 
            this.dgvAlumnos.Location = new System.Drawing.Point(30, 200);
            this.dgvAlumnos.Size = new System.Drawing.Size(820, 200);
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);

            // 
            // Botones
            // 
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(420, 20);
            this.btnAgregar.Size = new System.Drawing.Size(120, 30);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Location = new System.Drawing.Point(420, 60);
            this.btnActualizar.Size = new System.Drawing.Size(120, 30);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(420, 100);
            this.btnEliminar.Size = new System.Drawing.Size(120, 30);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(900, 430);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblFechaNacimiento);

            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.dtpFechaNacimiento);

            this.Controls.Add(this.dgvAlumnos);

            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);

            this.Text = "Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblFechaNacimiento;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLegajo;

        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;

        private System.Windows.Forms.DataGridView dgvAlumnos;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
