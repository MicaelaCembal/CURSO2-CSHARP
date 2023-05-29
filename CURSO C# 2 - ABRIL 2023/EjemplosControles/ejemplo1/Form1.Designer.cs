
namespace ejemplo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.elementos = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.Label();
            this.FechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkBoxPrincesas = new System.Windows.Forms.CheckBox();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.rbtCenicienta = new System.Windows.Forms.RadioButton();
            this.rbtAriel = new System.Windows.Forms.RadioButton();
            this.rbtRapunzel = new System.Windows.Forms.RadioButton();
            this.TipoRadioButton = new System.Windows.Forms.GroupBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.TipoRadioButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // btnAgregar
            // 
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // elementos
            // 
            resources.ApplyResources(this.elementos, "elementos");
            this.elementos.HideSelection = false;
            this.elementos.Name = "elementos";
            this.elementos.UseCompatibleStateImageBehavior = false;
            this.elementos.View = System.Windows.Forms.View.List;
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            this.Nombre.Name = "Nombre";
            // 
            // FechaNacimiento
            // 
            resources.ApplyResources(this.FechaNacimiento, "FechaNacimiento");
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // dateTimePickerFechaNacimiento
            // 
            resources.ApplyResources(this.dateTimePickerFechaNacimiento, "dateTimePickerFechaNacimiento");
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            // 
            // checkBoxPrincesas
            // 
            resources.ApplyResources(this.checkBoxPrincesas, "checkBoxPrincesas");
            this.checkBoxPrincesas.Name = "checkBoxPrincesas";
            this.checkBoxPrincesas.UseVisualStyleBackColor = true;
            // 
            // labelPerfil
            // 
            resources.ApplyResources(this.labelPerfil, "labelPerfil");
            this.labelPerfil.Name = "labelPerfil";
            // 
            // rbtCenicienta
            // 
            resources.ApplyResources(this.rbtCenicienta, "rbtCenicienta");
            this.rbtCenicienta.Name = "rbtCenicienta";
            this.rbtCenicienta.TabStop = true;
            this.rbtCenicienta.UseVisualStyleBackColor = true;
            // 
            // rbtAriel
            // 
            resources.ApplyResources(this.rbtAriel, "rbtAriel");
            this.rbtAriel.Name = "rbtAriel";
            this.rbtAriel.TabStop = true;
            this.rbtAriel.UseVisualStyleBackColor = true;
            // 
            // rbtRapunzel
            // 
            resources.ApplyResources(this.rbtRapunzel, "rbtRapunzel");
            this.rbtRapunzel.Name = "rbtRapunzel";
            this.rbtRapunzel.TabStop = true;
            this.rbtRapunzel.UseVisualStyleBackColor = true;
            // 
            // TipoRadioButton
            // 
            resources.ApplyResources(this.TipoRadioButton, "TipoRadioButton");
            this.TipoRadioButton.Controls.Add(this.rbtRapunzel);
            this.TipoRadioButton.Controls.Add(this.rbtAriel);
            this.TipoRadioButton.Controls.Add(this.rbtCenicienta);
            this.TipoRadioButton.Name = "TipoRadioButton";
            this.TipoRadioButton.TabStop = false;
            // 
            // labelColor
            // 
            resources.ApplyResources(this.labelColor, "labelColor");
            this.labelColor.Name = "labelColor";
            // 
            // comboBoxColor
            // 
            resources.ApplyResources(this.comboBoxColor, "comboBoxColor");
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            resources.GetString("comboBoxColor.Items"),
            resources.GetString("comboBoxColor.Items1"),
            resources.GetString("comboBoxColor.Items2"),
            resources.GetString("comboBoxColor.Items3"),
            resources.GetString("comboBoxColor.Items4")});
            this.comboBoxColor.Name = "comboBoxColor";
            // 
            // labelNumero
            // 
            resources.ApplyResources(this.labelNumero, "labelNumero");
            this.labelNumero.Name = "labelNumero";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // btnVerPerfil
            // 
            resources.ApplyResources(this.btnVerPerfil, "btnVerPerfil");
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.TipoRadioButton);
            this.Controls.Add(this.labelPerfil);
            this.Controls.Add(this.checkBoxPrincesas);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.FechaNacimiento);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.elementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TipoRadioButton.ResumeLayout(false);
            this.TipoRadioButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView elementos;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label FechaNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.CheckBox checkBoxPrincesas;
        private System.Windows.Forms.Label labelPerfil;
        private System.Windows.Forms.RadioButton rbtCenicienta;
        private System.Windows.Forms.RadioButton rbtAriel;
        private System.Windows.Forms.RadioButton rbtRapunzel;
        private System.Windows.Forms.GroupBox TipoRadioButton;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

