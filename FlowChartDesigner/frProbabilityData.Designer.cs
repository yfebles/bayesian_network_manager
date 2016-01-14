namespace FlowChartDesigner
{
    partial class FrProbabilityData
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bayesianNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bayesianNodeChartElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bayesianNodeChartElementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datagridProbabilities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayesianNodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bayesianNodeChartElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayesianNodeChartElementBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProbabilities)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(159, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(41, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inserte las probabilidades condicionales \r\nde este nodo dado una configuración \r\n" +
                "de los padres.\r\n";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.bayesianNodeChartElementBindingSource;
            // 
            // parentMessagesBindingSource
            // 
            this.parentMessagesBindingSource.DataMember = "ParentMessages";
            this.parentMessagesBindingSource.DataSource = this.bayesianNodeBindingSource;
            // 
            // bayesianNodeBindingSource
            // 
            this.bayesianNodeBindingSource.DataSource = typeof(RB_Message_Transfer.BayesianNode);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SyncRoot";
            this.dataGridViewTextBoxColumn1.HeaderText = "SyncRoot";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // probabilityBindingSource
            // 
            this.probabilityBindingSource.DataSource = typeof(RB_Message_Transfer.Probability);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.datagridProbabilities);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(763, 438);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 7;
            // 
            // bayesianNodeChartElementBindingSource
            // 
            this.bayesianNodeChartElementBindingSource.DataSource = typeof(FlowChartDesigner.BayesianNodeChartElement);
            // 
            // bayesianNodeChartElementBindingSource1
            // 
            this.bayesianNodeChartElementBindingSource1.DataSource = typeof(FlowChartDesigner.BayesianNodeChartElement);
            // 
            // datagridProbabilities
            // 
            this.datagridProbabilities.AllowUserToAddRows = false;
            this.datagridProbabilities.AllowUserToDeleteRows = false;
            this.datagridProbabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProbabilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridProbabilities.Location = new System.Drawing.Point(0, 0);
            this.datagridProbabilities.Name = "datagridProbabilities";
            this.datagridProbabilities.Size = new System.Drawing.Size(493, 438);
            this.datagridProbabilities.TabIndex = 1;
            // 
            // FrProbabilityData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(763, 438);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrProbabilityData";
            this.RightToLeftLayout = true;
            this.Text = "Probabilidades condicionales del Nodo dado los padres";
            this.Load += new System.EventHandler(this.frProbabilityData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayesianNodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bayesianNodeChartElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayesianNodeChartElementBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProbabilities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource probabilityBindingSource;
        private System.Windows.Forms.BindingSource bayesianNodeBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private System.Windows.Forms.BindingSource bayesianNodeChartElementBindingSource;
        private System.Windows.Forms.BindingSource bayesianNodeChartElementBindingSource1;
        private System.Windows.Forms.BindingSource parentMessagesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView datagridProbabilities;
    }
}