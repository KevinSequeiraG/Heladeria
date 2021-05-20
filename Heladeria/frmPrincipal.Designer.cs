
namespace Heladeria
{
    partial class frmPrincipal
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
            this.grbHelado = new System.Windows.Forms.GroupBox();
            this.rdbFresa = new System.Windows.Forms.RadioButton();
            this.rdbChocolate = new System.Windows.Forms.RadioButton();
            this.rdbCrema = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkOreo = new System.Windows.Forms.CheckBox();
            this.chkMani = new System.Windows.Forms.CheckBox();
            this.chkCaramelo = new System.Windows.Forms.CheckBox();
            this.btnCrearOrden = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grbHelado.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHelado
            // 
            this.grbHelado.Controls.Add(this.rdbFresa);
            this.grbHelado.Controls.Add(this.rdbChocolate);
            this.grbHelado.Controls.Add(this.rdbCrema);
            this.grbHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHelado.Location = new System.Drawing.Point(26, 24);
            this.grbHelado.Name = "grbHelado";
            this.grbHelado.Size = new System.Drawing.Size(151, 165);
            this.grbHelado.TabIndex = 0;
            this.grbHelado.TabStop = false;
            this.grbHelado.Text = "Helado";
            // 
            // rdbFresa
            // 
            this.rdbFresa.AutoSize = true;
            this.rdbFresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFresa.Image = global::Heladeria.Properties.Resources.heladoFresa__2_;
            this.rdbFresa.Location = new System.Drawing.Point(18, 117);
            this.rdbFresa.Name = "rdbFresa";
            this.rdbFresa.Size = new System.Drawing.Size(93, 32);
            this.rdbFresa.TabIndex = 5;
            this.rdbFresa.TabStop = true;
            this.rdbFresa.Text = "Fresa";
            this.rdbFresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbFresa.UseVisualStyleBackColor = true;
            // 
            // rdbChocolate
            // 
            this.rdbChocolate.AutoSize = true;
            this.rdbChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChocolate.Image = global::Heladeria.Properties.Resources.heladochocolate;
            this.rdbChocolate.Location = new System.Drawing.Point(18, 79);
            this.rdbChocolate.Name = "rdbChocolate";
            this.rdbChocolate.Size = new System.Drawing.Size(119, 32);
            this.rdbChocolate.TabIndex = 1;
            this.rdbChocolate.TabStop = true;
            this.rdbChocolate.Text = "Chocolate";
            this.rdbChocolate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbChocolate.UseVisualStyleBackColor = true;
            // 
            // rdbCrema
            // 
            this.rdbCrema.AutoSize = true;
            this.rdbCrema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCrema.Image = global::Heladeria.Properties.Resources.heladocrema;
            this.rdbCrema.Location = new System.Drawing.Point(18, 40);
            this.rdbCrema.Name = "rdbCrema";
            this.rdbCrema.Size = new System.Drawing.Size(98, 32);
            this.rdbCrema.TabIndex = 0;
            this.rdbCrema.TabStop = true;
            this.rdbCrema.Text = "Crema";
            this.rdbCrema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbCrema.UseVisualStyleBackColor = true;
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.chkOreo);
            this.grbToppings.Controls.Add(this.chkMani);
            this.grbToppings.Controls.Add(this.chkCaramelo);
            this.grbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToppings.Location = new System.Drawing.Point(235, 24);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(151, 165);
            this.grbToppings.TabIndex = 1;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chkOreo
            // 
            this.chkOreo.AutoSize = true;
            this.chkOreo.Image = global::Heladeria.Properties.Resources.oreo;
            this.chkOreo.Location = new System.Drawing.Point(16, 115);
            this.chkOreo.Name = "chkOreo";
            this.chkOreo.Size = new System.Drawing.Size(93, 32);
            this.chkOreo.TabIndex = 2;
            this.chkOreo.Text = "Oreo";
            this.chkOreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkOreo.UseVisualStyleBackColor = true;
            // 
            // chkMani
            // 
            this.chkMani.AutoSize = true;
            this.chkMani.Image = global::Heladeria.Properties.Resources.mani;
            this.chkMani.Location = new System.Drawing.Point(16, 77);
            this.chkMani.Name = "chkMani";
            this.chkMani.Size = new System.Drawing.Size(91, 32);
            this.chkMani.TabIndex = 1;
            this.chkMani.Text = "Maní";
            this.chkMani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkMani.UseVisualStyleBackColor = true;
            // 
            // chkCaramelo
            // 
            this.chkCaramelo.AutoSize = true;
            this.chkCaramelo.Image = global::Heladeria.Properties.Resources.caramelo;
            this.chkCaramelo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCaramelo.Location = new System.Drawing.Point(16, 38);
            this.chkCaramelo.Name = "chkCaramelo";
            this.chkCaramelo.Size = new System.Drawing.Size(124, 32);
            this.chkCaramelo.TabIndex = 0;
            this.chkCaramelo.Text = "Caramelo";
            this.chkCaramelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkCaramelo.UseVisualStyleBackColor = true;
            // 
            // btnCrearOrden
            // 
            this.btnCrearOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearOrden.Location = new System.Drawing.Point(136, 206);
            this.btnCrearOrden.Name = "btnCrearOrden";
            this.btnCrearOrden.Size = new System.Drawing.Size(121, 31);
            this.btnCrearOrden.TabIndex = 2;
            this.btnCrearOrden.Text = "Crear orden";
            this.btnCrearOrden.UseVisualStyleBackColor = true;
            this.btnCrearOrden.Click += new System.EventHandler(this.btnCrearOrden_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(125, 273);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 16);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(183, 270);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(74, 22);
            this.txtTotal.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 324);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCrearOrden);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbHelado);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grbHelado.ResumeLayout(false);
            this.grbHelado.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHelado;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.Button btnCrearOrden;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton rdbFresa;
        private System.Windows.Forms.RadioButton rdbChocolate;
        private System.Windows.Forms.RadioButton rdbCrema;
        private System.Windows.Forms.CheckBox chkOreo;
        private System.Windows.Forms.CheckBox chkMani;
        private System.Windows.Forms.CheckBox chkCaramelo;
    }
}

