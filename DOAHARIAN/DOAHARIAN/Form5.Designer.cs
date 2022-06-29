
namespace DOAHARIAN
{
    partial class Form5
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
            this.dOA_DOA_HARIANNDataSet = new DOAHARIAN.DOA_DOA_HARIANNDataSet();
            this.doaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doaTableAdapter = new DOAHARIAN.DOA_DOA_HARIANNDataSetTableAdapters.DoaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dOA_DOA_HARIANNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dOA_DOA_HARIANNDataSet
            // 
            this.dOA_DOA_HARIANNDataSet.DataSetName = "DOA_DOA_HARIANNDataSet";
            this.dOA_DOA_HARIANNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doaBindingSource
            // 
            this.doaBindingSource.DataMember = "Doa";
            this.doaBindingSource.DataSource = this.dOA_DOA_HARIANNDataSet;
            // 
            // doaTableAdapter
            // 
            this.doaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "NamaDoa", true));
            this.label1.Location = new System.Drawing.Point(89, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "IdDoa", true));
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "Latin", true));
            this.label3.Location = new System.Drawing.Point(89, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "Arab", true));
            this.label4.Location = new System.Drawing.Point(89, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "Terjemahan", true));
            this.label5.Location = new System.Drawing.Point(89, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 624);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOA_DOA_HARIANNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DOA_DOA_HARIANNDataSet dOA_DOA_HARIANNDataSet;
        private System.Windows.Forms.BindingSource doaBindingSource;
        private DOA_DOA_HARIANNDataSetTableAdapters.DoaTableAdapter doaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}