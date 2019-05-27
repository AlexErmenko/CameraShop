using System.ComponentModel;
using System.Windows.Forms;

using MaterialSkin.Controls;

namespace CameraShop
{
	partial class User
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
			if (disposing && (components != null)) components.Dispose();
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
			this.listBox1 = new System.Windows.Forms.ListBox();

			this.deviceBindingSource =
					new System.Windows.Forms.BindingSource(this.components);

			this.cameraMarketDataSet = new CameraShop.CameraMarketDataSet();

			this.MenuSorting =
					new MaterialSkin.Controls.MaterialContextMenuStrip();

			this.materialToolStripMenuItem1 =
					new MaterialSkin.Controls.MaterialToolStripMenuItem();

			this.materialToolStripMenuItem2 =
					new MaterialSkin.Controls.MaterialToolStripMenuItem();

			this.materialToolStripMenuItem3 =
					new MaterialSkin.Controls.MaterialToolStripMenuItem();

			this.materialToolStripMenuItem4 =
					new MaterialSkin.Controls.MaterialToolStripMenuItem();

			this.Menu                              = new System.Windows.Forms.MenuStrip();
			this.вікноАвторизаціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.допомогаToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
			this.пошукToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.вихідToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.label1                            = new System.Windows.Forms.Label();
			this.deviceTableAdapter                = new CameraShop.DeviceTableAdapter();
			this.tableAdapterManager               = new CameraShop.TableAdapterManager();
			this.nameLabel2                        = new System.Windows.Forms.Label();
			this.categoryLabel1                    = new System.Windows.Forms.Label();
			this.sensorSizeLabel2                  = new System.Windows.Forms.Label();
			this.systemLabel2                      = new System.Windows.Forms.Label();
			this.videoRecordCheckBox               = new System.Windows.Forms.CheckBox();
			this.monitorMountLabel2                = new System.Windows.Forms.Label();
			this.priceLabel2                       = new System.Windows.Forms.Label();
			this.megapixelLabel2                   = new System.Windows.Forms.Label();
			this.pictureBox1                       = new System.Windows.Forms.PictureBox();
			this.pictureBox2                       = new System.Windows.Forms.PictureBox();

			this.MenuFilter =
					new MaterialSkin.Controls.MaterialContextMenuStrip();

			this.materialToolStripMenuItem5 =
					new MaterialSkin.Controls.MaterialToolStripMenuItem();

			this.materialToolStripMenuItem6 =
					new MaterialSkin.Controls.MaterialToolStripMenuItem();

			this.materialToolStripMenuItem7 =
					new MaterialSkin.Controls.MaterialToolStripMenuItem();

			this.materialToolStripMenuItem8 =
					new MaterialSkin.Controls.MaterialToolStripMenuItem();

			this.пошукЗаНазвоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.пошукЗаToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
			nameLabel                           = new System.Windows.Forms.Label();
			sensorSizeLabel                     = new System.Windows.Forms.Label();
			systemLabel                         = new System.Windows.Forms.Label();
			videoRecordLabel                    = new System.Windows.Forms.Label();
			monitorMountLabel                   = new System.Windows.Forms.Label();
			megapixelLabel                      = new System.Windows.Forms.Label();
			priceLabel                          = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) (this.deviceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.cameraMarketDataSet)).BeginInit();
			this.MenuSorting.SuspendLayout();
			this.Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
			this.MenuFilter.SuspendLayout();
			this.SuspendLayout();

			//
			// nameLabel
			//
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(323, 154);
			nameLabel.Name     = "nameLabel";
			nameLabel.Size     = new System.Drawing.Size(50, 16);
			nameLabel.TabIndex = 2;
			nameLabel.Text     = "Назва";

			//
			// sensorSizeLabel
			//
			sensorSizeLabel.AutoSize = true;
			sensorSizeLabel.Location = new System.Drawing.Point(323, 218);
			sensorSizeLabel.Name     = "sensorSizeLabel";
			sensorSizeLabel.Size     = new System.Drawing.Size(110, 16);
			sensorSizeLabel.TabIndex = 6;
			sensorSizeLabel.Text     = "Розмір сенсору";

			//
			// systemLabel
			//
			systemLabel.AutoSize = true;
			systemLabel.Location = new System.Drawing.Point(323, 282);
			systemLabel.Name     = "systemLabel";
			systemLabel.Size     = new System.Drawing.Size(64, 16);
			systemLabel.TabIndex = 8;
			systemLabel.Text     = "Система";

			//
			// videoRecordLabel
			//
			videoRecordLabel.AutoSize = true;
			videoRecordLabel.Location = new System.Drawing.Point(323, 346);
			videoRecordLabel.Name     = "videoRecordLabel";
			videoRecordLabel.Size     = new System.Drawing.Size(119, 16);
			videoRecordLabel.TabIndex = 10;
			videoRecordLabel.Text     = "Відеоможливості";

			//
			// monitorMountLabel
			//
			monitorMountLabel.AutoSize = true;
			monitorMountLabel.Location = new System.Drawing.Point(323, 410);
			monitorMountLabel.Name     = "monitorMountLabel";
			monitorMountLabel.Size     = new System.Drawing.Size(95, 16);
			monitorMountLabel.TabIndex = 12;
			monitorMountLabel.Text     = "Тип монітору";

			//
			// megapixelLabel
			//
			megapixelLabel.AutoSize = true;
			megapixelLabel.Location = new System.Drawing.Point(323, 474);
			megapixelLabel.Name     = "megapixelLabel";
			megapixelLabel.Size     = new System.Drawing.Size(151, 16);
			megapixelLabel.TabIndex = 14;
			megapixelLabel.Text     = "Кількість мегапікселів";

			//
			// priceLabel
			//
			priceLabel.AutoSize = true;
			priceLabel.Location = new System.Drawing.Point(323, 538);
			priceLabel.Name     = "priceLabel";
			priceLabel.Size     = new System.Drawing.Size(36, 16);
			priceLabel.TabIndex = 16;
			priceLabel.Text     = "Ціна";

			//
			// listBox1
			//
			this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue",
																			this
																				.deviceBindingSource,
																			"Name", true));

			this.listBox1.DataSource        = this.deviceBindingSource;
			this.listBox1.DisplayMember     = "Name";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight        = 16;
			this.listBox1.Location          = new System.Drawing.Point(0, 64);
			this.listBox1.Name              = "listBox1";
			this.listBox1.Size              = new System.Drawing.Size(317, 612);
			this.listBox1.TabIndex          = 0;

			//
			// deviceBindingSource
			//
			this.deviceBindingSource.DataMember = "Device";
			this.deviceBindingSource.DataSource = this.cameraMarketDataSet;

			//
			// cameraMarketDataSet
			//
			this.cameraMarketDataSet.DataSetName = "CameraMarketDataSet";

			this.cameraMarketDataSet.SchemaSerializationMode =
					System.Data.SchemaSerializationMode.IncludeSchema;

			//
			// MenuSorting
			//
			this.MenuSorting.BackColor =
					System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
												((int) (((byte) (255)))), ((int) (((byte) (255)))));

			this.MenuSorting.Depth = 0;

			this.MenuSorting.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
											{
													this
														.materialToolStripMenuItem1,
													this
														.materialToolStripMenuItem2,
													this
														.materialToolStripMenuItem3,
													this
														.materialToolStripMenuItem4
											});

			this.MenuSorting.MouseState      = MaterialSkin.MouseState.HOVER;
			this.MenuSorting.Name            = "materialContextMenuStrip1";
			this.MenuSorting.ShowImageMargin = false;
			this.MenuSorting.Size            = new System.Drawing.Size(234, 100);

			//
			// materialToolStripMenuItem1
			//
			this.materialToolStripMenuItem1.DisplayStyle =
					System.Windows.Forms.ToolStripItemDisplayStyle.Text;

			this.materialToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.materialToolStripMenuItem1.Name = "materialToolStripMenuItem1";
			this.materialToolStripMenuItem1.Size = new System.Drawing.Size(233, 24);
			this.materialToolStripMenuItem1.Text = "Сортувати за ціною";

			this.materialToolStripMenuItem1.Click +=
					new System.EventHandler(this.MaterialToolStripMenuItem1_Click);

			//
			// materialToolStripMenuItem2
			//
			this.materialToolStripMenuItem2.Name = "materialToolStripMenuItem2";
			this.materialToolStripMenuItem2.Size = new System.Drawing.Size(233, 24);
			this.materialToolStripMenuItem2.Text = "Сортувати за назвою";

			this.materialToolStripMenuItem2.Click +=
					new System.EventHandler(this.MaterialToolStripMenuItem2_Click);

			//
			// materialToolStripMenuItem3
			//
			this.materialToolStripMenuItem3.Name = "materialToolStripMenuItem3";
			this.materialToolStripMenuItem3.Size = new System.Drawing.Size(233, 24);
			this.materialToolStripMenuItem3.Text = "Сортувати за розміром об\'єктива";

			this.materialToolStripMenuItem3.Click +=
					new System.EventHandler(this.MaterialToolStripMenuItem3_Click);

			//
			// materialToolStripMenuItem4
			//
			this.materialToolStripMenuItem4.Name = "materialToolStripMenuItem4";
			this.materialToolStripMenuItem4.Size = new System.Drawing.Size(233, 24);
			this.materialToolStripMenuItem4.Text = "Сортувати розміром екрану";

			this.materialToolStripMenuItem4.Click +=
					new System.EventHandler(this.MaterialToolStripMenuItem4_Click);

			//
			// Menu
			//
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
									{
											this
												.вікноАвторизаціїToolStripMenuItem,
											this
												.допомогаToolStripMenuItem,
											this
												.пошукToolStripMenuItem,
											this
												.вихідToolStripMenuItem
									});

			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name     = "Menu";
			this.Menu.Size     = new System.Drawing.Size(758, 24);
			this.Menu.TabIndex = 18;
			this.Menu.Text     = "menuStrip1";

			//
			// вікноАвторизаціїToolStripMenuItem
			//
			this.вікноАвторизаціїToolStripMenuItem.Name = "вікноАвторизаціїToolStripMenuItem";
			this.вікноАвторизаціїToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
			this.вікноАвторизаціїToolStripMenuItem.Text = "Вікно авторизації";

			this.вікноАвторизаціїToolStripMenuItem.Click +=
					new System.EventHandler(this.BackToLoginClick);

			//
			// допомогаToolStripMenuItem
			//
			this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
			this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.допомогаToolStripMenuItem.Text = "Допомога";

			this.допомогаToolStripMenuItem.Click +=
					new System.EventHandler(this.ДопомогаToolStripMenuItem_Click);

			//
			// пошукToolStripMenuItem
			//
			this.пошукToolStripMenuItem.DropDownItems
			.AddRange(new System.Windows.Forms.ToolStripItem[]
					{
							this
								.пошукЗаНазвоюToolStripMenuItem,
							this
								.пошукЗаToolStripMenuItem
					});

			this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
			this.пошукToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.пошукToolStripMenuItem.Text = "Пошук";

			//
			// вихідToolStripMenuItem
			//
			this.вихідToolStripMenuItem.Name  =  "вихідToolStripMenuItem";
			this.вихідToolStripMenuItem.Size  =  new System.Drawing.Size(47, 20);
			this.вихідToolStripMenuItem.Text  =  "Вихід";
			this.вихідToolStripMenuItem.Click += new System.EventHandler(this.ExitClick);

			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(323, 90);
			this.label1.Name     = "label1";
			this.label1.Size     = new System.Drawing.Size(33, 16);
			this.label1.TabIndex = 20;
			this.label1.Text     = "Тип";

			//
			// deviceTableAdapter
			//
			this.deviceTableAdapter.ClearBeforeFill = true;

			//
			// tableAdapterManager
			//
			this.tableAdapterManager.BackupDataSetBeforeUpdate      = false;
			this.tableAdapterManager.DeviceColorProfileTableAdapter = null;
			this.tableAdapterManager.DeviceShellTableAdapter        = null;
			this.tableAdapterManager.DeviceSystemTableAdapter       = null;
			this.tableAdapterManager.DeviceTableAdapter             = this.deviceTableAdapter;
			this.tableAdapterManager.DeviceTypesTableAdapter        = null;
			this.tableAdapterManager.DiveceViewFinderTableAdapter   = null;

			this.tableAdapterManager.UpdateOrder =
					CameraShop.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;

			//
			// nameLabel2
			//
			this.nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text",
																			this
																				.deviceBindingSource,
																			"Name", true));

			this.nameLabel2.Location = new System.Drawing.Point(520, 147);
			this.nameLabel2.Name     = "nameLabel2";
			this.nameLabel2.Size     = new System.Drawing.Size(181, 23);
			this.nameLabel2.TabIndex = 21;

			//
			// categoryLabel1
			//
			this.categoryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text",
																				this
																					.deviceBindingSource,
																				"Category", true));

			this.categoryLabel1.Location = new System.Drawing.Point(520, 90);
			this.categoryLabel1.Name     = "categoryLabel1";
			this.categoryLabel1.Size     = new System.Drawing.Size(181, 23);
			this.categoryLabel1.TabIndex = 22;

			//
			// sensorSizeLabel2
			//
			this.sensorSizeLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text",
																					this
																						.deviceBindingSource,
																					"SensorSize",
																					true));

			this.sensorSizeLabel2.Location = new System.Drawing.Point(520, 211);
			this.sensorSizeLabel2.Name     = "sensorSizeLabel2";
			this.sensorSizeLabel2.Size     = new System.Drawing.Size(181, 23);
			this.sensorSizeLabel2.TabIndex = 23;

			//
			// systemLabel2
			//
			this.systemLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text",
																				this
																					.deviceBindingSource,
																				"System", true));

			this.systemLabel2.Location = new System.Drawing.Point(520, 275);
			this.systemLabel2.Name     = "systemLabel2";
			this.systemLabel2.Size     = new System.Drawing.Size(181, 23);
			this.systemLabel2.TabIndex = 24;

			//
			// videoRecordCheckBox
			//
			this.videoRecordCheckBox.AutoCheck = false;

			this.videoRecordCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState",
																						this
																							.deviceBindingSource,
																						"VideoRecord",
																						true));

			this.videoRecordCheckBox.Location                = new System.Drawing.Point(523, 338);
			this.videoRecordCheckBox.Name                    = "videoRecordCheckBox";
			this.videoRecordCheckBox.Size                    = new System.Drawing.Size(185, 24);
			this.videoRecordCheckBox.TabIndex                = 25;
			this.videoRecordCheckBox.UseVisualStyleBackColor = true;

			//
			// monitorMountLabel2
			//
			this.monitorMountLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text",
																					this
																						.deviceBindingSource,
																					"MonitorMount",
																					true));

			this.monitorMountLabel2.Location = new System.Drawing.Point(520, 403);
			this.monitorMountLabel2.Name     = "monitorMountLabel2";
			this.monitorMountLabel2.Size     = new System.Drawing.Size(181, 23);
			this.monitorMountLabel2.TabIndex = 26;

			//
			// priceLabel2
			//
			this.priceLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text",
																				this
																					.deviceBindingSource,
																				"Price", true));

			this.priceLabel2.Location = new System.Drawing.Point(520, 531);
			this.priceLabel2.Name     = "priceLabel2";
			this.priceLabel2.Size     = new System.Drawing.Size(181, 23);
			this.priceLabel2.TabIndex = 27;

			//
			// megapixelLabel2
			//
			this.megapixelLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text",
																					this
																						.deviceBindingSource,
																					"Megapixel",
																					true));

			this.megapixelLabel2.Location = new System.Drawing.Point(520, 467);
			this.megapixelLabel2.Name     = "megapixelLabel2";
			this.megapixelLabel2.Size     = new System.Drawing.Size(181, 23);
			this.megapixelLabel2.TabIndex = 28;

			//
			// pictureBox1
			//
			this.pictureBox1.Image    =  global::CameraShop.Properties.Resources.AppendToBasket;
			this.pictureBox1.Location =  new System.Drawing.Point(326, 592);
			this.pictureBox1.Name     =  "pictureBox1";
			this.pictureBox1.Size     =  new System.Drawing.Size(164, 74);
			this.pictureBox1.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex =  30;
			this.pictureBox1.TabStop  =  false;
			this.pictureBox1.Click    += new System.EventHandler(this.PictureBox1_Click);

			//
			// pictureBox2
			//
			this.pictureBox2.Image    =  global::CameraShop.Properties.Resources.BasketFull;
			this.pictureBox2.Location =  new System.Drawing.Point(523, 592);
			this.pictureBox2.Name     =  "pictureBox2";
			this.pictureBox2.Size     =  new System.Drawing.Size(154, 74);
			this.pictureBox2.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex =  31;
			this.pictureBox2.TabStop  =  false;
			this.pictureBox2.Click    += new System.EventHandler(this.PictureBox2_Click);

			//
			// MenuFilter
			//
			this.MenuFilter.BackColor =
					System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
												((int) (((byte) (255)))), ((int) (((byte) (255)))));

			this.MenuFilter.Depth = 0;

			this.MenuFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
											{
													this
														.materialToolStripMenuItem5,
													this
														.materialToolStripMenuItem6,
													this
														.materialToolStripMenuItem7,
													this
														.materialToolStripMenuItem8
											});

			this.MenuFilter.MouseState      = MaterialSkin.MouseState.HOVER;
			this.MenuFilter.Name            = "materialContextMenuStrip1";
			this.MenuFilter.ShowImageMargin = false;
			this.MenuFilter.Size            = new System.Drawing.Size(234, 100);

			//
			// materialToolStripMenuItem5
			//
			this.materialToolStripMenuItem5.AutoSize = false;

			this.materialToolStripMenuItem5.DisplayStyle =
					System.Windows.Forms.ToolStripItemDisplayStyle.Text;

			this.materialToolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.materialToolStripMenuItem5.Name = "materialToolStripMenuItem5";
			this.materialToolStripMenuItem5.Size = new System.Drawing.Size(233, 24);
			this.materialToolStripMenuItem5.Text = "Сортувати за ціною";

			//
			// materialToolStripMenuItem6
			//
			this.materialToolStripMenuItem6.AutoSize = false;
			this.materialToolStripMenuItem6.Name     = "materialToolStripMenuItem6";
			this.materialToolStripMenuItem6.Size     = new System.Drawing.Size(233, 24);
			this.materialToolStripMenuItem6.Text     = "Сортувати за назвою";

			//
			// materialToolStripMenuItem7
			//
			this.materialToolStripMenuItem7.AutoSize = false;
			this.materialToolStripMenuItem7.Name     = "materialToolStripMenuItem7";
			this.materialToolStripMenuItem7.Size     = new System.Drawing.Size(233, 24);
			this.materialToolStripMenuItem7.Text     = "Сортувати за розміром об\'єктива";

			//
			// materialToolStripMenuItem8
			//
			this.materialToolStripMenuItem8.AutoSize = false;
			this.materialToolStripMenuItem8.Name     = "materialToolStripMenuItem8";
			this.materialToolStripMenuItem8.Size     = new System.Drawing.Size(233, 24);
			this.materialToolStripMenuItem8.Text     = "Сортувати розміром екрану";

			//
			// пошукЗаНазвоюToolStripMenuItem
			//
			this.пошукЗаНазвоюToolStripMenuItem.Name = "пошукЗаНазвоюToolStripMenuItem";
			this.пошукЗаНазвоюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.пошукЗаНазвоюToolStripMenuItem.Text = "Пошук за назвою";

			//
			// пошукЗаToolStripMenuItem
			//
			this.пошукЗаToolStripMenuItem.Name = "пошукЗаToolStripMenuItem";
			this.пошукЗаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.пошукЗаToolStripMenuItem.Text = "Пошук за ";

			//
			// User
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize          = new System.Drawing.Size(758, 678);
			this.ContextMenuStrip    = this.MenuSorting;
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.megapixelLabel2);
			this.Controls.Add(this.priceLabel2);
			this.Controls.Add(this.monitorMountLabel2);
			this.Controls.Add(this.videoRecordCheckBox);
			this.Controls.Add(this.systemLabel2);
			this.Controls.Add(this.sensorSizeLabel2);
			this.Controls.Add(this.categoryLabel1);
			this.Controls.Add(this.nameLabel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Menu);
			this.Controls.Add(priceLabel);
			this.Controls.Add(megapixelLabel);
			this.Controls.Add(monitorMountLabel);
			this.Controls.Add(videoRecordLabel);
			this.Controls.Add(systemLabel);
			this.Controls.Add(sensorSizeLabel);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.listBox1);

			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
												System.Drawing.FontStyle.Regular,
												System.Drawing.GraphicsUnit.Point, ((byte) (204)));

			this.HelpButton    = true;
			this.MainMenuStrip = this.Menu;
			this.Margin        = new System.Windows.Forms.Padding(4);
			this.Name          = "User";
			this.Text          = "Користувач";

			this.FormClosing +=
					new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);

			this.Load += new System.EventHandler(this.User_Load);
			((System.ComponentModel.ISupportInitialize) (this.deviceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.cameraMarketDataSet)).EndInit();
			this.MenuSorting.ResumeLayout(false);
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
			this.MenuFilter.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private ListBox                   listBox1;
		private MaterialContextMenuStrip  MenuSorting;
		private MaterialToolStripMenuItem materialToolStripMenuItem1;
		private MaterialToolStripMenuItem materialToolStripMenuItem2;
		private MaterialToolStripMenuItem materialToolStripMenuItem3;
		private MaterialToolStripMenuItem materialToolStripMenuItem4;
		private MenuStrip                 Menu;
		private ToolStripMenuItem         вікноАвторизаціїToolStripMenuItem;
		private ToolStripMenuItem         допомогаToolStripMenuItem;
		private ToolStripMenuItem         вихідToolStripMenuItem;
		private Label                     label1;
		private CameraMarketDataSet       cameraMarketDataSet;
		private BindingSource             deviceBindingSource;
		private DeviceTableAdapter        deviceTableAdapter;
		private TableAdapterManager       tableAdapterManager;
		private Label                     nameLabel2;
		private Label                     categoryLabel1;
		private Label                     sensorSizeLabel2;
		private Label                     systemLabel2;
		private CheckBox                  videoRecordCheckBox;
		private Label                     monitorMountLabel2;
		private Label                     priceLabel2;
		private Label                     megapixelLabel2;
		private PictureBox                pictureBox1;
		private PictureBox                pictureBox2;
		private MaterialContextMenuStrip  MenuFilter;
		private MaterialToolStripMenuItem materialToolStripMenuItem5;
		private MaterialToolStripMenuItem materialToolStripMenuItem6;
		private MaterialToolStripMenuItem materialToolStripMenuItem7;
		private MaterialToolStripMenuItem materialToolStripMenuItem8;
		private ToolStripMenuItem         пошукToolStripMenuItem;
		private ToolStripMenuItem         пошукЗаНазвоюToolStripMenuItem;
		private ToolStripMenuItem         пошукЗаToolStripMenuItem;
	}
}
