using System;

namespace CameraShop
{
    partial class Basket
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
			this.GetReport = new MaterialSkin.Controls.MaterialFlatButton();
			this.cameraMarketDataSet = new CameraShop.CameraMarketDataSet();
			this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.basketDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.cameraMarketDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// GetReport
			// 
			this.GetReport.AutoSize = true;
			this.GetReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GetReport.Depth = 0;
			this.GetReport.Location = new System.Drawing.Point(288, 373);
			this.GetReport.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.GetReport.MouseState = MaterialSkin.MouseState.HOVER;
			this.GetReport.Name = "GetReport";
			this.GetReport.Primary = false;
			this.GetReport.Size = new System.Drawing.Size(117, 36);
			this.GetReport.TabIndex = 1;
			this.GetReport.Text = "Отримати чек";
			this.GetReport.UseVisualStyleBackColor = true;
			this.GetReport.Click += new System.EventHandler(this.GenerateReport);
			// 
			// cameraMarketDataSet
			// 
			this.cameraMarketDataSet.DataSetName = "CameraMarketDataSet";
			this.cameraMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// basketBindingSource
			// 
			this.basketBindingSource.DataMember = "Basket";
			this.basketBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// basketDataGridView
			// 
			this.basketDataGridView.AllowUserToAddRows = false;
			this.basketDataGridView.AutoGenerateColumns = false;
			this.basketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.basketDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.basketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.basketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.basketDataGridView.DataSource = this.basketBindingSource;
			this.basketDataGridView.Location = new System.Drawing.Point(21, 92);
			this.basketDataGridView.Name = "basketDataGridView";
			this.basketDataGridView.Size = new System.Drawing.Size(655, 220);
			this.basketDataGridView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn1.HeaderText = "Назва";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
			this.dataGridViewTextBoxColumn2.HeaderText = "Ціна";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn3.HeaderText = "Кількість";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// Basket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 443);
			this.Controls.Add(this.basketDataGridView);
			this.Controls.Add(this.GetReport);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Basket";
			this.Text = "Кошик";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Basket_FormClosing);
			this.Load += new System.EventHandler(this.Basket_Load);
			((System.ComponentModel.ISupportInitialize)(this.cameraMarketDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private MaterialSkin.Controls.MaterialFlatButton GetReport;
		private CameraMarketDataSet cameraMarketDataSet;
		private System.Windows.Forms.BindingSource basketBindingSource;
		private System.Windows.Forms.DataGridView basketDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}