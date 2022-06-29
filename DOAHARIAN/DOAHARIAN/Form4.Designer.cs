
namespace DOAHARIAN
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextId = new System.Windows.Forms.TextBox();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textLatin = new System.Windows.Forms.TextBox();
            this.textTerjemahan = new System.Windows.Forms.TextBox();
            this.dOA_DOA_HARIANNDataSet = new DOAHARIAN.DOA_DOA_HARIANNDataSet();
            this.dOADOAHARIANNDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doaTableAdapter = new DOAHARIAN.DOA_DOA_HARIANNDataSetTableAdapters.DoaTableAdapter();
            this.doaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terjemahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOA_DOA_HARIANNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOADOAHARIANNDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDoaDataGridViewTextBoxColumn,
            this.namaDoaDataGridViewTextBoxColumn,
            this.latinDataGridViewTextBoxColumn,
            this.terjemahanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(43, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(686, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(108, 563);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 608);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "IdDoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "NamaDoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Latin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Terjemahan";
            // 
            // TextId
            // 
            this.TextId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "IdDoa", true));
            this.TextId.Location = new System.Drawing.Point(402, 414);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(100, 26);
            this.TextId.TabIndex = 11;
            // 
            // textNama
            // 
            this.textNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "NamaDoa", true));
            this.textNama.Location = new System.Drawing.Point(402, 446);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(100, 26);
            this.textNama.TabIndex = 12;
            // 
            // textLatin
            // 
            this.textLatin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "Latin", true));
            this.textLatin.Location = new System.Drawing.Point(402, 480);
            this.textLatin.Name = "textLatin";
            this.textLatin.Size = new System.Drawing.Size(100, 26);
            this.textLatin.TabIndex = 14;
            // 
            // textTerjemahan
            // 
            this.textTerjemahan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doaBindingSource, "Terjemahan", true));
            this.textTerjemahan.Location = new System.Drawing.Point(402, 512);
            this.textTerjemahan.Name = "textTerjemahan";
            this.textTerjemahan.Size = new System.Drawing.Size(100, 26);
            this.textTerjemahan.TabIndex = 15;
            // 
            // dOA_DOA_HARIANNDataSet
            // 
            this.dOA_DOA_HARIANNDataSet.DataSetName = "DOA_DOA_HARIANNDataSet";
            this.dOA_DOA_HARIANNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOADOAHARIANNDataSetBindingSource
            // 
            this.dOADOAHARIANNDataSetBindingSource.DataSource = this.dOA_DOA_HARIANNDataSet;
            this.dOADOAHARIANNDataSetBindingSource.Position = 0;
            // 
            // doaBindingSource
            // 
            this.doaBindingSource.DataMember = "Doa";
            this.doaBindingSource.DataSource = this.dOADOAHARIANNDataSetBindingSource;
            // 
            // doaTableAdapter
            // 
            this.doaTableAdapter.ClearBeforeFill = true;
            // 
            // doaBindingSource1
            // 
            this.doaBindingSource1.DataMember = "Doa";
            this.doaBindingSource1.DataSource = this.dOA_DOA_HARIANNDataSet;
            // 
            // idDoaDataGridViewTextBoxColumn
            // 
            this.idDoaDataGridViewTextBoxColumn.DataPropertyName = "IdDoa";
            this.idDoaDataGridViewTextBoxColumn.HeaderText = "IdDoa";
            this.idDoaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDoaDataGridViewTextBoxColumn.Name = "idDoaDataGridViewTextBoxColumn";
            this.idDoaDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaDoaDataGridViewTextBoxColumn
            // 
            this.namaDoaDataGridViewTextBoxColumn.DataPropertyName = "NamaDoa";
            this.namaDoaDataGridViewTextBoxColumn.HeaderText = "NamaDoa";
            this.namaDoaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDoaDataGridViewTextBoxColumn.Name = "namaDoaDataGridViewTextBoxColumn";
            this.namaDoaDataGridViewTextBoxColumn.Width = 150;
            // 
            // latinDataGridViewTextBoxColumn
            // 
            this.latinDataGridViewTextBoxColumn.DataPropertyName = "Latin";
            this.latinDataGridViewTextBoxColumn.HeaderText = "Latin";
            this.latinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.latinDataGridViewTextBoxColumn.Name = "latinDataGridViewTextBoxColumn";
            this.latinDataGridViewTextBoxColumn.Width = 150;
            // 
            // terjemahanDataGridViewTextBoxColumn
            // 
            this.terjemahanDataGridViewTextBoxColumn.DataPropertyName = "Terjemahan";
            this.terjemahanDataGridViewTextBoxColumn.HeaderText = "Terjemahan";
            this.terjemahanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.terjemahanDataGridViewTextBoxColumn.Name = "terjemahanDataGridViewTextBoxColumn";
            this.terjemahanDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 780);
            this.Controls.Add(this.textTerjemahan);
            this.Controls.Add(this.textLatin);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOA_DOA_HARIANNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOADOAHARIANNDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextId;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textLatin;
        private System.Windows.Forms.TextBox textTerjemahan;
        private System.Windows.Forms.BindingSource dOADOAHARIANNDataSetBindingSource;
        private DOA_DOA_HARIANNDataSet dOA_DOA_HARIANNDataSet;
        private System.Windows.Forms.BindingSource doaBindingSource;
        private DOA_DOA_HARIANNDataSetTableAdapters.DoaTableAdapter doaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terjemahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doaBindingSource1;
    }
}