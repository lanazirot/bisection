namespace Bisection {
    partial class PrincipalForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.btnConfirmeFunction = new System.Windows.Forms.Button();
            this.grbFunctionValues = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxIter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtES = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXL = new System.Windows.Forms.TextBox();
            this.dtgValues = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtXRRespuesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clmnIteraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnXl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnXr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFunctionValues.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValues)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "f(x)";
            // 
            // txtFunction
            // 
            this.txtFunction.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunction.Location = new System.Drawing.Point(76, 28);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(285, 32);
            this.txtFunction.TabIndex = 1;
            // 
            // btnConfirmeFunction
            // 
            this.btnConfirmeFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmeFunction.Location = new System.Drawing.Point(32, 23);
            this.btnConfirmeFunction.Name = "btnConfirmeFunction";
            this.btnConfirmeFunction.Size = new System.Drawing.Size(143, 44);
            this.btnConfirmeFunction.TabIndex = 2;
            this.btnConfirmeFunction.Text = "Empezar";
            this.btnConfirmeFunction.UseVisualStyleBackColor = true;
            this.btnConfirmeFunction.Click += new System.EventHandler(this.btnConfirmeFunction_Click);
            // 
            // grbFunctionValues
            // 
            this.grbFunctionValues.Controls.Add(this.txtFunction);
            this.grbFunctionValues.Controls.Add(this.label1);
            this.grbFunctionValues.Location = new System.Drawing.Point(12, 12);
            this.grbFunctionValues.Name = "grbFunctionValues";
            this.grbFunctionValues.Size = new System.Drawing.Size(406, 86);
            this.grbFunctionValues.TabIndex = 3;
            this.grbFunctionValues.TabStop = false;
            this.grbFunctionValues.Text = "Función";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaxIter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtES);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtXU);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtXL);
            this.groupBox2.Location = new System.Drawing.Point(424, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 185);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores para bisección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max. iteraciones";
            // 
            // txtMaxIter
            // 
            this.txtMaxIter.Location = new System.Drawing.Point(114, 122);
            this.txtMaxIter.Name = "txtMaxIter";
            this.txtMaxIter.Size = new System.Drawing.Size(92, 20);
            this.txtMaxIter.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Es";
            // 
            // txtES
            // 
            this.txtES.Location = new System.Drawing.Point(114, 96);
            this.txtES.Name = "txtES";
            this.txtES.Size = new System.Drawing.Size(92, 20);
            this.txtES.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Xu (Upper)";
            // 
            // txtXU
            // 
            this.txtXU.Location = new System.Drawing.Point(114, 70);
            this.txtXU.Name = "txtXU";
            this.txtXU.Size = new System.Drawing.Size(92, 20);
            this.txtXU.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xl (Lower)";
            // 
            // txtXL
            // 
            this.txtXL.Location = new System.Drawing.Point(114, 44);
            this.txtXL.Name = "txtXL";
            this.txtXL.Size = new System.Drawing.Size(92, 20);
            this.txtXL.TabIndex = 6;
            // 
            // dtgValues
            // 
            this.dtgValues.AllowUserToAddRows = false;
            this.dtgValues.AllowUserToDeleteRows = false;
            this.dtgValues.AllowUserToResizeColumns = false;
            this.dtgValues.AllowUserToResizeRows = false;
            this.dtgValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnIteraciones,
            this.clmnXl,
            this.clmnXu,
            this.clmnXr,
            this.clmnEa});
            this.dtgValues.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgValues.Location = new System.Drawing.Point(12, 214);
            this.dtgValues.MultiSelect = false;
            this.dtgValues.Name = "dtgValues";
            this.dtgValues.ReadOnly = true;
            this.dtgValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgValues.Size = new System.Drawing.Size(655, 185);
            this.dtgValues.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmeFunction);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtXRRespuesta);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(226, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 86);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // txtXRRespuesta
            // 
            this.txtXRRespuesta.Enabled = false;
            this.txtXRRespuesta.Location = new System.Drawing.Point(73, 36);
            this.txtXRRespuesta.Name = "txtXRRespuesta";
            this.txtXRRespuesta.Size = new System.Drawing.Size(113, 20);
            this.txtXRRespuesta.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Xu = Xr";
            // 
            // clmnIteraciones
            // 
            this.clmnIteraciones.HeaderText = "No. de iteracion";
            this.clmnIteraciones.Name = "clmnIteraciones";
            this.clmnIteraciones.ReadOnly = true;
            this.clmnIteraciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnXl
            // 
            this.clmnXl.HeaderText = "Xl";
            this.clmnXl.Name = "clmnXl";
            this.clmnXl.ReadOnly = true;
            this.clmnXl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnXu
            // 
            this.clmnXu.HeaderText = "Xu";
            this.clmnXu.Name = "clmnXu";
            this.clmnXu.ReadOnly = true;
            this.clmnXu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnXr
            // 
            this.clmnXr.HeaderText = "Xr";
            this.clmnXr.Name = "clmnXr";
            this.clmnXr.ReadOnly = true;
            this.clmnXr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnEa
            // 
            this.clmnEa.HeaderText = "Ea";
            this.clmnEa.Name = "clmnEa";
            this.clmnEa.ReadOnly = true;
            this.clmnEa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgValues);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbFunctionValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bisection X 19100234";
            this.grbFunctionValues.ResumeLayout(false);
            this.grbFunctionValues.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValues)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Button btnConfirmeFunction;
        private System.Windows.Forms.GroupBox grbFunctionValues;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxIter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXL;
        private System.Windows.Forms.DataGridView dtgValues;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtXRRespuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIteraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnXl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnXr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEa;
    }
}

