using System;
using System.ComponentModel;
using System.Windows.Forms;

using MaterialSkin.Controls;

namespace CameraShop
{
	partial class AdminEdit
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
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label sensorSizeLabel;
			System.Windows.Forms.Label systemLabel;
			System.Windows.Forms.Label videoRecordLabel;
			System.Windows.Forms.Label monitorMountLabel;
			System.Windows.Forms.Label megapixelLabel;
			System.Windows.Forms.Label priceLabel;
			System.Windows.Forms.Label CategoryLbl;
			System.Windows.Forms.Label rawPhotoLabel;
			System.Windows.Forms.Label cameraLightLabel;
			System.Windows.Forms.Label colorProfileLabel;
			System.Windows.Forms.Label optionalStabilLabel;
			System.Windows.Forms.Label viewFinderLabel;
			System.Windows.Forms.Label shellLabel;
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cameraMarketDataSet = new CameraShop.CameraMarketDataSet();
			this.Save = new MaterialSkin.Controls.MaterialFlatButton();
			this.deviceTableAdapter = new DeviceTableAdapter();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.LoginForm = new System.Windows.Forms.ToolStripMenuItem();
			this.AdminForm = new System.Windows.Forms.ToolStripMenuItem();
			this.видалитиТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Help = new System.Windows.Forms.ToolStripMenuItem();
			this.Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.tableAdapterManager = new TableAdapterManager();
			this.deviceColorProfileTableAdapter = new DeviceColorProfileTableAdapter();
			this.deviceShellTableAdapter = new DeviceShellTableAdapter();
			this.deviceSystemTableAdapter = new DeviceSystemTableAdapter();
			this.deviceTypesTableAdapter = new DeviceTypesTableAdapter();
			this.diveceViewFinderTableAdapter = new DiveceViewFinderTableAdapter();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.sensorSizeTextBox = new System.Windows.Forms.TextBox();
			this.videoRecordCheckBox = new System.Windows.Forms.CheckBox();
			this.monitorMountTextBox = new System.Windows.Forms.TextBox();
			this.megapixelMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.priceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.rawPhotoCheckBox = new System.Windows.Forms.CheckBox();
			this.cameraLightCheckBox = new System.Windows.Forms.CheckBox();
			this.optionalStabilCheckBox = new System.Windows.Forms.CheckBox();
			this.SystemSelect = new System.Windows.Forms.ComboBox();
			this.deviceSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ColorProfileSelect = new System.Windows.Forms.ComboBox();
			this.deviceColorProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ShellSelect = new System.Windows.Forms.ComboBox();
			this.deviceShellBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ViewFinderSelect = new System.Windows.Forms.ComboBox();
			this.diveceViewFinderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.CategorySelect = new System.Windows.Forms.ComboBox();
			this.deviceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			nameLabel = new System.Windows.Forms.Label();
			sensorSizeLabel = new System.Windows.Forms.Label();
			systemLabel = new System.Windows.Forms.Label();
			videoRecordLabel = new System.Windows.Forms.Label();
			monitorMountLabel = new System.Windows.Forms.Label();
			megapixelLabel = new System.Windows.Forms.Label();
			priceLabel = new System.Windows.Forms.Label();
			CategoryLbl = new System.Windows.Forms.Label();
			rawPhotoLabel = new System.Windows.Forms.Label();
			cameraLightLabel = new System.Windows.Forms.Label();
			colorProfileLabel = new System.Windows.Forms.Label();
			optionalStabilLabel = new System.Windows.Forms.Label();
			viewFinderLabel = new System.Windows.Forms.Label();
			shellLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cameraMarketDataSet)).BeginInit();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.deviceSystemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceColorProfileBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceShellBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diveceViewFinderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(387, 94);
			nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(48, 17);
			nameLabel.TabIndex = 1;
			nameLabel.Text = "Назва";
			// 
			// sensorSizeLabel
			// 
			sensorSizeLabel.AutoSize = true;
			sensorSizeLabel.Location = new System.Drawing.Point(387, 143);
			sensorSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			sensorSizeLabel.Name = "sensorSizeLabel";
			sensorSizeLabel.Size = new System.Drawing.Size(110, 17);
			sensorSizeLabel.TabIndex = 3;
			sensorSizeLabel.Text = "Розмір сенсора";
			// 
			// systemLabel
			// 
			systemLabel.AutoSize = true;
			systemLabel.Location = new System.Drawing.Point(387, 211);
			systemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			systemLabel.Name = "systemLabel";
			systemLabel.Size = new System.Drawing.Size(64, 17);
			systemLabel.TabIndex = 5;
			systemLabel.Text = "Система";
			// 
			// videoRecordLabel
			// 
			videoRecordLabel.AutoSize = true;
			videoRecordLabel.Location = new System.Drawing.Point(387, 275);
			videoRecordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			videoRecordLabel.Name = "videoRecordLabel";
			videoRecordLabel.Size = new System.Drawing.Size(82, 17);
			videoRecordLabel.TabIndex = 7;
			videoRecordLabel.Text = "Відеозапис";
			// 
			// monitorMountLabel
			// 
			monitorMountLabel.AutoSize = true;
			monitorMountLabel.Location = new System.Drawing.Point(387, 326);
			monitorMountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			monitorMountLabel.Name = "monitorMountLabel";
			monitorMountLabel.Size = new System.Drawing.Size(111, 17);
			monitorMountLabel.TabIndex = 9;
			monitorMountLabel.Text = "Розмір дисплея";
			// 
			// megapixelLabel
			// 
			megapixelLabel.AutoSize = true;
			megapixelLabel.Location = new System.Drawing.Point(387, 390);
			megapixelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			megapixelLabel.Name = "megapixelLabel";
			megapixelLabel.Size = new System.Drawing.Size(151, 17);
			megapixelLabel.TabIndex = 11;
			megapixelLabel.Text = "Кількість мегапікселів";
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Location = new System.Drawing.Point(387, 448);
			priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new System.Drawing.Size(38, 17);
			priceLabel.TabIndex = 13;
			priceLabel.Text = "Ціна";
			// 
			// CategoryLbl
			// 
			CategoryLbl.AutoSize = true;
			CategoryLbl.Location = new System.Drawing.Point(741, 445);
			CategoryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			CategoryLbl.Name = "CategoryLbl";
			CategoryLbl.Size = new System.Drawing.Size(33, 17);
			CategoryLbl.TabIndex = 20;
			CategoryLbl.Text = "Тип";
			// 
			// rawPhotoLabel
			// 
			rawPhotoLabel.AutoSize = true;
			rawPhotoLabel.Location = new System.Drawing.Point(741, 95);
			rawPhotoLabel.Name = "rawPhotoLabel";
			rawPhotoLabel.Size = new System.Drawing.Size(73, 17);
			rawPhotoLabel.TabIndex = 40;
			rawPhotoLabel.Text = "Raw фото";
			// 
			// cameraLightLabel
			// 
			cameraLightLabel.AutoSize = true;
			cameraLightLabel.Location = new System.Drawing.Point(741, 154);
			cameraLightLabel.Name = "cameraLightLabel";
			cameraLightLabel.Size = new System.Drawing.Size(66, 17);
			cameraLightLabel.TabIndex = 42;
			cameraLightLabel.Text = "Вспишка";
			// 
			// colorProfileLabel
			// 
			colorProfileLabel.AutoSize = true;
			colorProfileLabel.Location = new System.Drawing.Point(741, 213);
			colorProfileLabel.Name = "colorProfileLabel";
			colorProfileLabel.Size = new System.Drawing.Size(134, 17);
			colorProfileLabel.TabIndex = 44;
			colorProfileLabel.Text = "Цветовой профиль";
			// 
			// optionalStabilLabel
			// 
			optionalStabilLabel.AutoSize = true;
			optionalStabilLabel.Location = new System.Drawing.Point(741, 272);
			optionalStabilLabel.Name = "optionalStabilLabel";
			optionalStabilLabel.Size = new System.Drawing.Size(185, 17);
			optionalStabilLabel.TabIndex = 46;
			optionalStabilLabel.Text = "Оптическая стабилизация";
			// 
			// viewFinderLabel
			// 
			viewFinderLabel.AutoSize = true;
			viewFinderLabel.Location = new System.Drawing.Point(741, 331);
			viewFinderLabel.Name = "viewFinderLabel";
			viewFinderLabel.Size = new System.Drawing.Size(129, 17);
			viewFinderLabel.TabIndex = 48;
			viewFinderLabel.Text = "Тип видоискателя";
			// 
			// shellLabel
			// 
			shellLabel.AutoSize = true;
			shellLabel.Location = new System.Drawing.Point(741, 390);
			shellLabel.Name = "shellLabel";
			shellLabel.Size = new System.Drawing.Size(90, 17);
			shellLabel.TabIndex = 50;
			shellLabel.Text = "Тип корпуса";
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.DataSource = this.deviceBindingSource;
			this.listBox1.DisplayMember = "Name";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(-3, 62);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(369, 530);
			this.listBox1.TabIndex = 0;
			this.listBox1.ValueMember = "Name";
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
			// Save
			// 
			this.Save.AutoSize = true;
			this.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Save.Depth = 0;
			this.Save.Location = new System.Drawing.Point(613, 514);
			this.Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Save.MouseState = MaterialSkin.MouseState.HOVER;
			this.Save.Name = "Save";
			this.Save.Primary = false;
			this.Save.Size = new System.Drawing.Size(79, 36);
			this.Save.TabIndex = 17;
			this.Save.Text = "Зберегти";
			this.Save.UseVisualStyleBackColor = false;
			this.Save.Click += new System.EventHandler(this.SaveChanges);
			// 
			// deviceTableAdapter
			// 
			this.deviceTableAdapter.ClearBeforeFill = true;
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginForm,
            this.AdminForm,
            this.видалитиТоварToolStripMenuItem,
            this.Help,
            this.Exit});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(1087, 24);
			this.MainMenu.TabIndex = 22;
			this.MainMenu.Text = "menuStrip1";
			// 
			// LoginForm
			// 
			this.LoginForm.Name = "LoginForm";
			this.LoginForm.Size = new System.Drawing.Size(114, 20);
			this.LoginForm.Text = "Вікно авторизації";
			this.LoginForm.Click += new System.EventHandler(this.LoginFormClick);
			// 
			// AdminForm
			// 
			this.AdminForm.Name = "AdminForm";
			this.AdminForm.Size = new System.Drawing.Size(129, 20);
			this.AdminForm.Text = "Додати новий товар";
			this.AdminForm.Click += new System.EventHandler(this.AdminForm_Click);
			// 
			// видалитиТоварToolStripMenuItem
			// 
			this.видалитиТоварToolStripMenuItem.Name = "видалитиТоварToolStripMenuItem";
			this.видалитиТоварToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.видалитиТоварToolStripMenuItem.Text = "Видалити товар";
			this.видалитиТоварToolStripMenuItem.Click += new System.EventHandler(this.RemoveCurrentDevice);
			// 
			// Help
			// 
			this.Help.Name = "Help";
			this.Help.Size = new System.Drawing.Size(75, 20);
			this.Help.Text = "Допомога";
			this.Help.Click += new System.EventHandler(this.Help_Click);
			// 
			// Exit
			// 
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(47, 20);
			this.Exit.Text = "Вихід";
			this.Exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DeviceColorProfileTableAdapter = this.deviceColorProfileTableAdapter;
			this.tableAdapterManager.DeviceShellTableAdapter = this.deviceShellTableAdapter;
			this.tableAdapterManager.DeviceSystemTableAdapter = this.deviceSystemTableAdapter;
			this.tableAdapterManager.DeviceTableAdapter = this.deviceTableAdapter;
			this.tableAdapterManager.DeviceTypesTableAdapter = this.deviceTypesTableAdapter;
			this.tableAdapterManager.DiveceViewFinderTableAdapter = this.diveceViewFinderTableAdapter;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// deviceColorProfileTableAdapter
			// 
			this.deviceColorProfileTableAdapter.ClearBeforeFill = true;
			// 
			// deviceShellTableAdapter
			// 
			this.deviceShellTableAdapter.ClearBeforeFill = true;
			// 
			// deviceSystemTableAdapter
			// 
			this.deviceSystemTableAdapter.ClearBeforeFill = true;
			// 
			// deviceTypesTableAdapter
			// 
			this.deviceTypesTableAdapter.ClearBeforeFill = true;
			// 
			// diveceViewFinderTableAdapter
			// 
			this.diveceViewFinderTableAdapter.ClearBeforeFill = true;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(592, 88);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(121, 23);
			this.nameTextBox.TabIndex = 25;
			// 
			// sensorSizeTextBox
			// 
			this.sensorSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "SensorSize", true));
			this.sensorSizeTextBox.Location = new System.Drawing.Point(592, 137);
			this.sensorSizeTextBox.Name = "sensorSizeTextBox";
			this.sensorSizeTextBox.Size = new System.Drawing.Size(121, 23);
			this.sensorSizeTextBox.TabIndex = 29;
			// 
			// videoRecordCheckBox
			// 
			this.videoRecordCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deviceBindingSource, "VideoRecord", true));
			this.videoRecordCheckBox.Location = new System.Drawing.Point(592, 268);
			this.videoRecordCheckBox.Name = "videoRecordCheckBox";
			this.videoRecordCheckBox.Size = new System.Drawing.Size(121, 24);
			this.videoRecordCheckBox.TabIndex = 33;
			this.videoRecordCheckBox.UseVisualStyleBackColor = true;
			// 
			// monitorMountTextBox
			// 
			this.monitorMountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "MonitorMount", true));
			this.monitorMountTextBox.Location = new System.Drawing.Point(592, 320);
			this.monitorMountTextBox.Name = "monitorMountTextBox";
			this.monitorMountTextBox.Size = new System.Drawing.Size(121, 23);
			this.monitorMountTextBox.TabIndex = 35;
			// 
			// megapixelMaskedTextBox
			// 
			this.megapixelMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Megapixel", true));
			this.megapixelMaskedTextBox.Location = new System.Drawing.Point(592, 384);
			this.megapixelMaskedTextBox.Name = "megapixelMaskedTextBox";
			this.megapixelMaskedTextBox.Size = new System.Drawing.Size(121, 23);
			this.megapixelMaskedTextBox.TabIndex = 37;
			// 
			// priceMaskedTextBox
			// 
			this.priceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Price", true));
			this.priceMaskedTextBox.Location = new System.Drawing.Point(592, 442);
			this.priceMaskedTextBox.Name = "priceMaskedTextBox";
			this.priceMaskedTextBox.Size = new System.Drawing.Size(121, 23);
			this.priceMaskedTextBox.TabIndex = 39;
			// 
			// rawPhotoCheckBox
			// 
			this.rawPhotoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deviceBindingSource, "RawPhoto", true));
			this.rawPhotoCheckBox.Location = new System.Drawing.Point(932, 88);
			this.rawPhotoCheckBox.Name = "rawPhotoCheckBox";
			this.rawPhotoCheckBox.Size = new System.Drawing.Size(121, 24);
			this.rawPhotoCheckBox.TabIndex = 41;
			this.rawPhotoCheckBox.UseVisualStyleBackColor = true;
			// 
			// cameraLightCheckBox
			// 
			this.cameraLightCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deviceBindingSource, "CameraLight", true));
			this.cameraLightCheckBox.Location = new System.Drawing.Point(932, 137);
			this.cameraLightCheckBox.Name = "cameraLightCheckBox";
			this.cameraLightCheckBox.Size = new System.Drawing.Size(121, 24);
			this.cameraLightCheckBox.TabIndex = 43;
			this.cameraLightCheckBox.UseVisualStyleBackColor = true;
			// 
			// optionalStabilCheckBox
			// 
			this.optionalStabilCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deviceBindingSource, "OptionalStabil", true));
			this.optionalStabilCheckBox.Location = new System.Drawing.Point(932, 272);
			this.optionalStabilCheckBox.Name = "optionalStabilCheckBox";
			this.optionalStabilCheckBox.Size = new System.Drawing.Size(121, 24);
			this.optionalStabilCheckBox.TabIndex = 47;
			this.optionalStabilCheckBox.UseVisualStyleBackColor = true;
			// 
			// SystemSelect
			// 
			this.SystemSelect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "System", true));
			this.SystemSelect.DataSource = this.deviceSystemBindingSource;
			this.SystemSelect.DisplayMember = "SystemName";
			this.SystemSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SystemSelect.FormattingEnabled = true;
			this.SystemSelect.Location = new System.Drawing.Point(592, 211);
			this.SystemSelect.Name = "SystemSelect";
			this.SystemSelect.Size = new System.Drawing.Size(121, 24);
			this.SystemSelect.TabIndex = 51;
			this.SystemSelect.ValueMember = "SystemName";
			// 
			// deviceSystemBindingSource
			// 
			this.deviceSystemBindingSource.DataMember = "DeviceSystem";
			this.deviceSystemBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// ColorProfileSelect
			// 
			this.ColorProfileSelect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "ColorProfile", true));
			this.ColorProfileSelect.DataSource = this.deviceColorProfileBindingSource;
			this.ColorProfileSelect.DisplayMember = "ColorProfileName";
			this.ColorProfileSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ColorProfileSelect.FormattingEnabled = true;
			this.ColorProfileSelect.Location = new System.Drawing.Point(932, 218);
			this.ColorProfileSelect.Name = "ColorProfileSelect";
			this.ColorProfileSelect.Size = new System.Drawing.Size(121, 24);
			this.ColorProfileSelect.TabIndex = 52;
			this.ColorProfileSelect.ValueMember = "ColorProfileName";
			// 
			// deviceColorProfileBindingSource
			// 
			this.deviceColorProfileBindingSource.DataMember = "DeviceColorProfile";
			this.deviceColorProfileBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// ShellSelect
			// 
			this.ShellSelect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "Shell", true));
			this.ShellSelect.DataSource = this.deviceShellBindingSource;
			this.ShellSelect.DisplayMember = "ShellTypeName";
			this.ShellSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ShellSelect.FormattingEnabled = true;
			this.ShellSelect.Location = new System.Drawing.Point(932, 383);
			this.ShellSelect.Name = "ShellSelect";
			this.ShellSelect.Size = new System.Drawing.Size(121, 24);
			this.ShellSelect.TabIndex = 53;
			this.ShellSelect.ValueMember = "ShellTypeName";
			// 
			// deviceShellBindingSource
			// 
			this.deviceShellBindingSource.DataMember = "DeviceShell";
			this.deviceShellBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// ViewFinderSelect
			// 
			this.ViewFinderSelect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "ViewFinder", true));
			this.ViewFinderSelect.DataSource = this.diveceViewFinderBindingSource;
			this.ViewFinderSelect.DisplayMember = "ViewFinderName";
			this.ViewFinderSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ViewFinderSelect.FormattingEnabled = true;
			this.ViewFinderSelect.Location = new System.Drawing.Point(932, 319);
			this.ViewFinderSelect.Name = "ViewFinderSelect";
			this.ViewFinderSelect.Size = new System.Drawing.Size(121, 24);
			this.ViewFinderSelect.TabIndex = 54;
			this.ViewFinderSelect.ValueMember = "ViewFinderName";
			// 
			// diveceViewFinderBindingSource
			// 
			this.diveceViewFinderBindingSource.DataMember = "DiveceViewFinder";
			this.diveceViewFinderBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// CategorySelect
			// 
			this.CategorySelect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceBindingSource, "Category", true));
			this.CategorySelect.DataSource = this.deviceTypesBindingSource;
			this.CategorySelect.DisplayMember = "TypeName";
			this.CategorySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CategorySelect.FormattingEnabled = true;
			this.CategorySelect.Location = new System.Drawing.Point(932, 438);
			this.CategorySelect.Name = "CategorySelect";
			this.CategorySelect.Size = new System.Drawing.Size(121, 24);
			this.CategorySelect.TabIndex = 55;
			this.CategorySelect.ValueMember = "TypeName";
			// 
			// deviceTypesBindingSource
			// 
			this.deviceTypesBindingSource.DataMember = "DeviceTypes";
			this.deviceTypesBindingSource.DataSource = this.cameraMarketDataSet;
			// 
			// AdminEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 594);
			this.Controls.Add(this.CategorySelect);
			this.Controls.Add(this.ViewFinderSelect);
			this.Controls.Add(this.ShellSelect);
			this.Controls.Add(this.ColorProfileSelect);
			this.Controls.Add(this.SystemSelect);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.sensorSizeTextBox);
			this.Controls.Add(this.videoRecordCheckBox);
			this.Controls.Add(this.monitorMountTextBox);
			this.Controls.Add(this.megapixelMaskedTextBox);
			this.Controls.Add(this.priceMaskedTextBox);
			this.Controls.Add(rawPhotoLabel);
			this.Controls.Add(this.rawPhotoCheckBox);
			this.Controls.Add(cameraLightLabel);
			this.Controls.Add(this.cameraLightCheckBox);
			this.Controls.Add(colorProfileLabel);
			this.Controls.Add(optionalStabilLabel);
			this.Controls.Add(this.optionalStabilCheckBox);
			this.Controls.Add(viewFinderLabel);
			this.Controls.Add(shellLabel);
			this.Controls.Add(this.MainMenu);
			this.Controls.Add(CategoryLbl);
			this.Controls.Add(this.Save);
			this.Controls.Add(priceLabel);
			this.Controls.Add(megapixelLabel);
			this.Controls.Add(monitorMountLabel);
			this.Controls.Add(videoRecordLabel);
			this.Controls.Add(systemLabel);
			this.Controls.Add(sensorSizeLabel);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.listBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.MainMenuStrip = this.MainMenu;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AdminEdit";
			this.Text = "Адміністратор";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminEditFormClosing);
			this.Load += new System.EventHandler(this.AdminEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cameraMarketDataSet)).EndInit();
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.deviceSystemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceColorProfileBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceShellBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diveceViewFinderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListBox                 listBox1;
		private MaterialFlatButton      Save;
		private CameraMarketDataSet cameraMarketDataSet;
		private BindingSource deviceBindingSource;
		private DeviceTableAdapter deviceTableAdapter;
		private MenuStrip MainMenu;
		private ToolStripMenuItem LoginForm;
		private ToolStripMenuItem AdminForm;
		private ToolStripMenuItem Help;
		private ToolStripMenuItem Exit;
		private TableAdapterManager tableAdapterManager;
		private TextBox nameTextBox;
		private TextBox sensorSizeTextBox;
		private CheckBox videoRecordCheckBox;
		private TextBox monitorMountTextBox;
		private MaskedTextBox megapixelMaskedTextBox;
		private MaskedTextBox priceMaskedTextBox;
		private CheckBox rawPhotoCheckBox;
		private CheckBox cameraLightCheckBox;
		private CheckBox optionalStabilCheckBox;
		private ComboBox SystemSelect;
		private ComboBox ColorProfileSelect;
		private ComboBox ShellSelect;
		private ComboBox ViewFinderSelect;
		private ComboBox CategorySelect;
		private DeviceSystemTableAdapter deviceSystemTableAdapter;
		private BindingSource deviceSystemBindingSource;
		private DeviceColorProfileTableAdapter deviceColorProfileTableAdapter;
		private BindingSource deviceColorProfileBindingSource;
		private DiveceViewFinderTableAdapter diveceViewFinderTableAdapter;
		private BindingSource diveceViewFinderBindingSource;
		private DeviceShellTableAdapter deviceShellTableAdapter;
		private BindingSource deviceShellBindingSource;
		private DeviceTypesTableAdapter deviceTypesTableAdapter;
		private BindingSource deviceTypesBindingSource;
		private ToolStripMenuItem видалитиТоварToolStripMenuItem;
	}
}
