using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CameraShop
{
	partial class Admin
	{
		/// <summary>
		///   Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		///   Clean up any resources being used.
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
		///   Required method for Designer support - do not modify
		///   the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label sensorSizeLabel;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label systemLabel;
			System.Windows.Forms.Label videoRecordLabel;
			System.Windows.Forms.Label monitorMountLabel;
			System.Windows.Forms.Label megapixelLabel;
			System.Windows.Forms.Label priceLabel;
			System.Windows.Forms.Label CameraLbl;
			System.Windows.Forms.Label optionalStabilLabel;
			System.Windows.Forms.Label rawPhotoLabel;
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.Login = new System.Windows.Forms.ToolStripMenuItem();
			this.Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.Help = new System.Windows.Forms.ToolStripMenuItem();
			this.Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.cameraLightCheckBox = new System.Windows.Forms.CheckBox();
			this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cameraMarketDataSet = new CameraShop.CameraMarketDataSet();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.deviceColorProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.diveceViewFinderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.deviceShellBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.deviceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.deviceTypesTableAdapter = new DeviceTypesTableAdapter();
			this.deviceTableAdapter = new DeviceTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.deviceSystemTableAdapter = new DeviceSystemTableAdapter();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.sensorSizeTextBox = new System.Windows.Forms.TextBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.deviceSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.videoRecordCheckBox = new System.Windows.Forms.CheckBox();
			this.monitorMountTextBox = new System.Windows.Forms.TextBox();
			this.megapixelMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.priceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.deviceColorProfileTableAdapter = new DeviceColorProfileTableAdapter();
			this.optionalStabilCheckBox1 = new System.Windows.Forms.CheckBox();
			this.diveceViewFinderTableAdapter = new DiveceViewFinderTableAdapter();
			this.deviceShellTableAdapter = new DeviceShellTableAdapter();
			this.rawPhotoCheckBox = new System.Windows.Forms.CheckBox();
			this.Append = new MaterialSkin.Controls.MaterialFlatButton();
			sensorSizeLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			systemLabel = new System.Windows.Forms.Label();
			videoRecordLabel = new System.Windows.Forms.Label();
			monitorMountLabel = new System.Windows.Forms.Label();
			megapixelLabel = new System.Windows.Forms.Label();
			priceLabel = new System.Windows.Forms.Label();
			CameraLbl = new System.Windows.Forms.Label();
			optionalStabilLabel = new System.Windows.Forms.Label();
			rawPhotoLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cameraMarketDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceColorProfileBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diveceViewFinderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceShellBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceSystemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// sensorSizeLabel
			// 
			sensorSizeLabel.AutoSize = true;
			sensorSizeLabel.Location = new System.Drawing.Point(12, 182);
			sensorSizeLabel.Name = "sensorSizeLabel";
			sensorSizeLabel.Size = new System.Drawing.Size(115, 17);
			sensorSizeLabel.TabIndex = 8;
			sensorSizeLabel.Text = "Размер сенсора";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(12, 134);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(72, 17);
			nameLabel.TabIndex = 10;
			nameLabel.Text = "Название";
			// 
			// systemLabel
			// 
			systemLabel.AutoSize = true;
			systemLabel.Location = new System.Drawing.Point(12, 230);
			systemLabel.Name = "systemLabel";
			systemLabel.Size = new System.Drawing.Size(64, 17);
			systemLabel.TabIndex = 12;
			systemLabel.Text = "Система";
			// 
			// videoRecordLabel
			// 
			videoRecordLabel.AutoSize = true;
			videoRecordLabel.Location = new System.Drawing.Point(12, 279);
			videoRecordLabel.Name = "videoRecordLabel";
			videoRecordLabel.Size = new System.Drawing.Size(94, 17);
			videoRecordLabel.TabIndex = 14;
			videoRecordLabel.Text = "Видеозапись";
			// 
			// monitorMountLabel
			// 
			monitorMountLabel.AutoSize = true;
			monitorMountLabel.Location = new System.Drawing.Point(12, 327);
			monitorMountLabel.Name = "monitorMountLabel";
			monitorMountLabel.Size = new System.Drawing.Size(125, 17);
			monitorMountLabel.TabIndex = 16;
			monitorMountLabel.Text = "Размер монитора";
			// 
			// megapixelLabel
			// 
			megapixelLabel.AutoSize = true;
			megapixelLabel.Location = new System.Drawing.Point(12, 375);
			megapixelLabel.Name = "megapixelLabel";
			megapixelLabel.Size = new System.Drawing.Size(182, 17);
			megapixelLabel.TabIndex = 18;
			megapixelLabel.Text = "Количество мегапикселей";
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Location = new System.Drawing.Point(12, 429);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new System.Drawing.Size(43, 17);
			priceLabel.TabIndex = 20;
			priceLabel.Text = "Цена";
			// 
			// CameraLbl
			// 
			CameraLbl.AutoSize = true;
			CameraLbl.Location = new System.Drawing.Point(428, 405);
			CameraLbl.Name = "CameraLbl";
			CameraLbl.Size = new System.Drawing.Size(68, 17);
			CameraLbl.TabIndex = 27;
			CameraLbl.Text = "Вспышка";
			// 
			// optionalStabilLabel
			// 
			optionalStabilLabel.AutoSize = true;
			optionalStabilLabel.Location = new System.Drawing.Point(428, 280);
			optionalStabilLabel.Name = "optionalStabilLabel";
			optionalStabilLabel.Size = new System.Drawing.Size(102, 17);
			optionalStabilLabel.TabIndex = 44;
			optionalStabilLabel.Text = "Стабилизатор";
			// 
			// rawPhotoLabel
			// 
			rawPhotoLabel.AutoSize = true;
			rawPhotoLabel.Location = new System.Drawing.Point(428, 342);
			rawPhotoLabel.Name = "rawPhotoLabel";
			rawPhotoLabel.Size = new System.Drawing.Size(73, 17);
			rawPhotoLabel.TabIndex = 45;
			rawPhotoLabel.Text = "Raw фото";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.Edit,
            this.Help,
            this.Exit});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(808, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Login
			// 
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(114, 20);
			this.Login.Text = "Вікно авторизації";
			this.Login.Click += new System.EventHandler(this.LoginClick);
			// 
			// Edit
			// 
			this.Edit.Name = "Edit";
			this.Edit.Size = new System.Drawing.Size(104, 20);
			this.Edit.Text = "Редагувати дані";
			this.Edit.Click += new System.EventHandler(this.EditClick);
			// 
			// Help
			// 
			this.Help.Name = "Help";
			this.Help.Size = new System.Drawing.Size(75, 20);
			this.Help.Text = "Допомога";
			this.Help.Click += new System.EventHandler(this.HelpClick);
			// 
			// Exit
			// 
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(47, 20);
			this.Exit.Text = "Вихід";
			this.Exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Тип";
			// 
			// cameraLightCheckBox
			// 
			this.cameraLightCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deviceBindingSource, "CameraLight", true));
			this.cameraLightCheckBox.Location = new System.Drawing.Point(600, 398);
			this.cameraLightCheckBox.Name = "cameraLightCheckBox";
			this.cameraLightCheckBox.Size = new System.Drawing.Size(177, 24);
			this.cameraLightCheckBox.TabIndex = 45;
			this.cameraLightCheckBox.UseVisualStyleBackColor = true;
			// 
			// deviceBindingSource
			// 
			this.deviceBindingSource.DataMember = "Device";
			this.deviceBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// cameraMarketDataSet
			// 
			this.cameraMarketDataSet.DataSetName = "CameraMarketDataSet";
			this.cameraMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "ColorProfile", true));
			this.comboBox1.DataSource = this.deviceColorProfileBindingSource;
			this.comboBox1.DisplayMember = "ColorProfileName";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(600, 209);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(177, 24);
			this.comboBox1.TabIndex = 29;
			this.comboBox1.ValueMember = "ColorProfileName";
			// 
			// deviceColorProfileBindingSource
			// 
			this.deviceColorProfileBindingSource.DataMember = "DeviceColorProfile";
			this.deviceColorProfileBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(428, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 17);
			this.label3.TabIndex = 30;
			this.label3.Text = "Цветовой профиль";
			// 
			// comboBox2
			// 
			this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "ViewFinder", true));
			this.comboBox2.DataSource = this.diveceViewFinderBindingSource;
			this.comboBox2.DisplayMember = "ViewFinderName";
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(600, 146);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(177, 24);
			this.comboBox2.TabIndex = 31;
			this.comboBox2.ValueMember = "ViewFinderName";
			// 
			// diveceViewFinderBindingSource
			// 
			this.diveceViewFinderBindingSource.DataMember = "DiveceViewFinder";
			this.diveceViewFinderBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(428, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 17);
			this.label4.TabIndex = 32;
			this.label4.Text = "Тип видоискателя";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(428, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 17);
			this.label5.TabIndex = 34;
			this.label5.Text = "Тип корпуса";
			// 
			// comboBox3
			// 
			this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "Shell", true));
			this.comboBox3.DataSource = this.deviceShellBindingSource;
			this.comboBox3.DisplayMember = "ShellTypeName";
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(600, 83);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(177, 24);
			this.comboBox3.TabIndex = 33;
			this.comboBox3.ValueMember = "ShellTypeName";
			// 
			// deviceShellBindingSource
			// 
			this.deviceShellBindingSource.DataMember = "DeviceShell";
			this.deviceShellBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// comboBox4
			// 
			this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "Category", true));
			this.comboBox4.DataSource = this.deviceTypesBindingSource;
			this.comboBox4.DisplayMember = "TypeName";
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(202, 79);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(174, 24);
			this.comboBox4.TabIndex = 37;
			this.comboBox4.ValueMember = "TypeName";
			// 
			// deviceTypesBindingSource
			// 
			this.deviceTypesBindingSource.DataMember = "DeviceTypes";
			this.deviceTypesBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// deviceTypesTableAdapter
			// 
			this.deviceTypesTableAdapter.ClearBeforeFill = true;
			// 
			// deviceTableAdapter
			// 
			this.deviceTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DeviceColorProfileTableAdapter = null;
			this.tableAdapterManager.DeviceShellTableAdapter = null;
			this.tableAdapterManager.DeviceSystemTableAdapter = this.deviceSystemTableAdapter;
			this.tableAdapterManager.DeviceTableAdapter = this.deviceTableAdapter;
			this.tableAdapterManager.DeviceTypesTableAdapter = this.deviceTypesTableAdapter;
			this.tableAdapterManager.DiveceViewFinderTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// deviceSystemTableAdapter
			// 
			this.deviceSystemTableAdapter.ClearBeforeFill = true;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(202, 128);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(174, 23);
			this.nameTextBox.TabIndex = 38;
			// 
			// sensorSizeTextBox
			// 
			this.sensorSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "SensorSize", true));
			this.sensorSizeTextBox.Location = new System.Drawing.Point(202, 176);
			this.sensorSizeTextBox.Name = "sensorSizeTextBox";
			this.sensorSizeTextBox.Size = new System.Drawing.Size(174, 23);
			this.sensorSizeTextBox.TabIndex = 39;
			// 
			// comboBox5
			// 
			this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "System", true));
			this.comboBox5.DataSource = this.deviceSystemBindingSource;
			this.comboBox5.DisplayMember = "SystemName";
			this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(202, 224);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(174, 24);
			this.comboBox5.TabIndex = 40;
			this.comboBox5.ValueMember = "SystemName";
			// 
			// deviceSystemBindingSource
			// 
			this.deviceSystemBindingSource.DataMember = "DeviceSystem";
			this.deviceSystemBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// videoRecordCheckBox
			// 
			this.videoRecordCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deviceBindingSource, "VideoRecord", true));
			this.videoRecordCheckBox.Location = new System.Drawing.Point(202, 273);
			this.videoRecordCheckBox.Name = "videoRecordCheckBox";
			this.videoRecordCheckBox.Size = new System.Drawing.Size(174, 24);
			this.videoRecordCheckBox.TabIndex = 41;
			this.videoRecordCheckBox.UseVisualStyleBackColor = true;
			// 
			// monitorMountTextBox
			// 
			this.monitorMountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "MonitorMount", true));
			this.monitorMountTextBox.Location = new System.Drawing.Point(202, 322);
			this.monitorMountTextBox.Name = "monitorMountTextBox";
			this.monitorMountTextBox.Size = new System.Drawing.Size(174, 23);
			this.monitorMountTextBox.TabIndex = 42;
			// 
			// megapixelMaskedTextBox
			// 
			this.megapixelMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Megapixel", true));
			this.megapixelMaskedTextBox.Location = new System.Drawing.Point(202, 370);
			this.megapixelMaskedTextBox.Name = "megapixelMaskedTextBox";
			this.megapixelMaskedTextBox.Size = new System.Drawing.Size(174, 23);
			this.megapixelMaskedTextBox.TabIndex = 43;
			// 
			// priceMaskedTextBox
			// 
			this.priceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Price", true));
			this.priceMaskedTextBox.Location = new System.Drawing.Point(202, 418);
			this.priceMaskedTextBox.Name = "priceMaskedTextBox";
			this.priceMaskedTextBox.Size = new System.Drawing.Size(174, 23);
			this.priceMaskedTextBox.TabIndex = 44;
			// 
			// deviceColorProfileTableAdapter
			// 
			this.deviceColorProfileTableAdapter.ClearBeforeFill = true;
			// 
			// optionalStabilCheckBox1
			// 
			this.optionalStabilCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deviceBindingSource, "OptionalStabil", true));
			this.optionalStabilCheckBox1.Location = new System.Drawing.Point(600, 272);
			this.optionalStabilCheckBox1.Name = "optionalStabilCheckBox1";
			this.optionalStabilCheckBox1.Size = new System.Drawing.Size(177, 24);
			this.optionalStabilCheckBox1.TabIndex = 45;
			this.optionalStabilCheckBox1.UseVisualStyleBackColor = true;
			// 
			// diveceViewFinderTableAdapter
			// 
			this.diveceViewFinderTableAdapter.ClearBeforeFill = true;
			// 
			// deviceShellTableAdapter
			// 
			this.deviceShellTableAdapter.ClearBeforeFill = true;
			// 
			// rawPhotoCheckBox
			// 
			this.rawPhotoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deviceBindingSource, "RawPhoto", true));
			this.rawPhotoCheckBox.Location = new System.Drawing.Point(600, 335);
			this.rawPhotoCheckBox.Name = "rawPhotoCheckBox";
			this.rawPhotoCheckBox.Size = new System.Drawing.Size(177, 24);
			this.rawPhotoCheckBox.TabIndex = 46;
			this.rawPhotoCheckBox.UseVisualStyleBackColor = true;
			// 
			// Append
			// 
			this.Append.AutoSize = true;
			this.Append.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Append.Depth = 0;
			this.Append.Location = new System.Drawing.Point(364, 476);
			this.Append.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Append.MouseState = MaterialSkin.MouseState.HOVER;
			this.Append.Name = "Append";
			this.Append.Primary = false;
			this.Append.Size = new System.Drawing.Size(69, 36);
			this.Append.TabIndex = 47;
			this.Append.Text = "Додати";
			this.Append.UseVisualStyleBackColor = true;
			this.Append.Click += new System.EventHandler(this.Append_Click);
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(808, 527);
			this.Controls.Add(this.Append);
			this.Controls.Add(rawPhotoLabel);
			this.Controls.Add(this.rawPhotoCheckBox);
			this.Controls.Add(this.cameraLightCheckBox);
			this.Controls.Add(CameraLbl);
			this.Controls.Add(optionalStabilLabel);
			this.Controls.Add(this.optionalStabilCheckBox1);
			this.Controls.Add(this.priceMaskedTextBox);
			this.Controls.Add(this.megapixelMaskedTextBox);
			this.Controls.Add(this.monitorMountTextBox);
			this.Controls.Add(this.videoRecordCheckBox);
			this.Controls.Add(this.comboBox5);
			this.Controls.Add(this.sensorSizeTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(priceLabel);
			this.Controls.Add(megapixelLabel);
			this.Controls.Add(monitorMountLabel);
			this.Controls.Add(videoRecordLabel);
			this.Controls.Add(systemLabel);
			this.Controls.Add(nameLabel);
			this.Controls.Add(sensorSizeLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Admin";
			this.Text = "Администратор";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminFormClosing);
			this.Load += new System.EventHandler(this.Admin_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cameraMarketDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceColorProfileBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diveceViewFinderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceShellBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceSystemBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem Login;
		private ToolStripMenuItem Edit;
		private ToolStripMenuItem Help;
		private ToolStripMenuItem Exit;
		private Label label2;
		private ComboBox comboBox1;
		private Label label3;
		private ComboBox comboBox2;
		private Label label4;
		private Label label5;
		private ComboBox comboBox3;
		private ComboBox comboBox4;
		private CameraMarketDataSet cameraMarketDataSet;
		private BindingSource deviceTypesBindingSource;
		private DeviceTypesTableAdapter deviceTypesTableAdapter;
		private BindingSource deviceBindingSource;
		private DeviceTableAdapter deviceTableAdapter;
		private TableAdapterManager tableAdapterManager;
		private TextBox nameTextBox;
		private TextBox sensorSizeTextBox;
		private DeviceSystemTableAdapter deviceSystemTableAdapter;
		private ComboBox comboBox5;
		private BindingSource deviceSystemBindingSource;
		private CheckBox videoRecordCheckBox;
		private TextBox monitorMountTextBox;
		private MaskedTextBox megapixelMaskedTextBox;
		private MaskedTextBox priceMaskedTextBox;
		private CheckBox cameraLightCheckBox;
		private BindingSource deviceColorProfileBindingSource;
		private DeviceColorProfileTableAdapter deviceColorProfileTableAdapter;
		private CheckBox optionalStabilCheckBox1;
		private BindingSource diveceViewFinderBindingSource;
		private DiveceViewFinderTableAdapter diveceViewFinderTableAdapter;
		private BindingSource deviceShellBindingSource;
		private DeviceShellTableAdapter deviceShellTableAdapter;
		private CheckBox rawPhotoCheckBox;
		private MaterialSkin.Controls.MaterialFlatButton Append;
	}
}
