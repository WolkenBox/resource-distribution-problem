using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ResDist
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		/// <summary>Сколько оружия может вместить корабль</summary>
		int NumWeapons;

		/// <summary>Сколько типов оружия доступно на складе</summary>
		int NumWeaponTypes;

		int InputWeaponPrice = -1, InputWeaponEffect = -1;

		//------------------------------------------------------------------------

		#region Controls
		private System.Windows.Forms.TextBox txtNumWeapons;
		private System.Windows.Forms.Label lblNumWeapons;
		private System.Windows.Forms.Label lblNumWeaponTypes;
		private System.Windows.Forms.TextBox txtNumWeaponTypes;
		private System.Windows.Forms.Label lblWeapons;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.TextBox txtWeaponName;
		private System.Windows.Forms.TextBox txtWeaponPrice;
		private System.Windows.Forms.TextBox txtEffect;
		private Wildgrape.Aqua.Controls.Button btnAddWeaponType;
		private Wildgrape.Aqua.Controls.Button btnSolveTask;
		private PJControls.FadingListView lstWeapons;
		private System.Windows.Forms.GroupBox grpInputData;
		private System.Windows.Forms.Label lblNeedMoney;
		private System.Windows.Forms.TextBox txtNeedMoney;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.GroupBox groupBox1;
		private PJControls.FadingListView lstPlan;
		private System.Windows.Forms.Label lblPlan;
		private System.Windows.Forms.Label lblTbl;
		private PJControls.FadingListView lstTbl;
		private Crownwood.Magic.Controls.TabControl tabControl1;
		private Crownwood.Magic.Controls.TabPage tabPage1;
		private Wildgrape.Aqua.Controls.Button btnExit;
		private Crownwood.Magic.Controls.TabPage tabPage2;
		private DataPlotter.Plotter plotter;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblInfo;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#endregion

		//------------------------------------------------------------------------

		public frmMain(){
			InitializeComponent();
		}

		//------------------------------------------------------------------------

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		//------------------------------------------------------------------------

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNumWeapons = new System.Windows.Forms.TextBox();
			this.lblNumWeapons = new System.Windows.Forms.Label();
			this.lblNumWeaponTypes = new System.Windows.Forms.Label();
			this.txtNumWeaponTypes = new System.Windows.Forms.TextBox();
			this.lblWeapons = new System.Windows.Forms.Label();
			this.lstWeapons = new PJControls.FadingListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.errorProvider = new System.Windows.Forms.ErrorProvider();
			this.txtWeaponName = new System.Windows.Forms.TextBox();
			this.txtWeaponPrice = new System.Windows.Forms.TextBox();
			this.txtEffect = new System.Windows.Forms.TextBox();
			this.btnAddWeaponType = new Wildgrape.Aqua.Controls.Button();
			this.btnSolveTask = new Wildgrape.Aqua.Controls.Button();
			this.grpInputData = new System.Windows.Forms.GroupBox();
			this.lblNeedMoney = new System.Windows.Forms.Label();
			this.txtNeedMoney = new System.Windows.Forms.TextBox();
			this.lstPlan = new PJControls.FadingListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lstTbl = new PJControls.FadingListView();
			this.lblTbl = new System.Windows.Forms.Label();
			this.lblPlan = new System.Windows.Forms.Label();
			this.tabControl1 = new Crownwood.Magic.Controls.TabControl();
			this.tabPage1 = new Crownwood.Magic.Controls.TabPage();
			this.btnExit = new Wildgrape.Aqua.Controls.Button();
			this.tabPage2 = new Crownwood.Magic.Controls.TabPage();
			this.lblInfo = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnCalc = new System.Windows.Forms.Button();
			this.plotter = new DataPlotter.Plotter();
			this.grpInputData.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNumWeapons
			// 
			this.txtNumWeapons.Location = new System.Drawing.Point(32, 56);
			this.txtNumWeapons.Name = "txtNumWeapons";
			this.txtNumWeapons.TabIndex = 0;
			this.txtNumWeapons.Text = "";
			this.txtNumWeapons.Validated += new System.EventHandler(this.txtNumWeapons_Validated);
			// 
			// lblNumWeapons
			// 
			this.lblNumWeapons.Location = new System.Drawing.Point(24, 32);
			this.lblNumWeapons.Name = "lblNumWeapons";
			this.lblNumWeapons.Size = new System.Drawing.Size(240, 23);
			this.lblNumWeapons.TabIndex = 1;
			this.lblNumWeapons.Text = "Максимальное количество единиц оружия:";
			// 
			// lblNumWeaponTypes
			// 
			this.lblNumWeaponTypes.Location = new System.Drawing.Point(24, 88);
			this.lblNumWeaponTypes.Name = "lblNumWeaponTypes";
			this.lblNumWeaponTypes.Size = new System.Drawing.Size(224, 23);
			this.lblNumWeaponTypes.TabIndex = 2;
			this.lblNumWeaponTypes.Text = "Количество типов оружия:";
			// 
			// txtNumWeaponTypes
			// 
			this.txtNumWeaponTypes.Location = new System.Drawing.Point(32, 112);
			this.txtNumWeaponTypes.Name = "txtNumWeaponTypes";
			this.txtNumWeaponTypes.ReadOnly = true;
			this.txtNumWeaponTypes.TabIndex = 3;
			this.txtNumWeaponTypes.Text = "";
			// 
			// lblWeapons
			// 
			this.lblWeapons.Location = new System.Drawing.Point(272, 32);
			this.lblWeapons.Name = "lblWeapons";
			this.lblWeapons.Size = new System.Drawing.Size(136, 23);
			this.lblWeapons.TabIndex = 5;
			this.lblWeapons.Text = "Доступное оружие:";
			// 
			// lstWeapons
			// 
			this.lstWeapons.AddColor = System.Drawing.Color.Red;
			this.lstWeapons.ChangeColor = System.Drawing.Color.Green;
			this.lstWeapons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.columnHeader1,
																						 this.columnHeader2,
																						 this.columnHeader3});
			this.lstWeapons.DeleteColor = System.Drawing.Color.Blue;
			this.lstWeapons.FadingTime = 10;
			this.lstWeapons.Location = new System.Drawing.Point(280, 96);
			this.lstWeapons.MultiSelect = false;
			this.lstWeapons.Name = "lstWeapons";
			this.lstWeapons.Size = new System.Drawing.Size(296, 112);
			this.lstWeapons.TabIndex = 7;
			this.lstWeapons.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Название";
			this.columnHeader1.Width = 129;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Стоимость";
			this.columnHeader2.Width = 69;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Эффективность";
			this.columnHeader3.Width = 94;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// txtWeaponName
			// 
			this.errorProvider.SetIconAlignment(this.txtWeaponName, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
			this.txtWeaponName.Location = new System.Drawing.Point(280, 64);
			this.txtWeaponName.Name = "txtWeaponName";
			this.txtWeaponName.Size = new System.Drawing.Size(128, 21);
			this.txtWeaponName.TabIndex = 9;
			this.txtWeaponName.Text = "Оружие1";
			// 
			// txtWeaponPrice
			// 
			this.errorProvider.SetIconAlignment(this.txtWeaponPrice, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
			this.txtWeaponPrice.Location = new System.Drawing.Point(408, 64);
			this.txtWeaponPrice.Name = "txtWeaponPrice";
			this.txtWeaponPrice.Size = new System.Drawing.Size(72, 21);
			this.txtWeaponPrice.TabIndex = 10;
			this.txtWeaponPrice.Text = "";
			this.txtWeaponPrice.Validated += new System.EventHandler(this.txtWeaponPrice_Validated);
			// 
			// txtEffect
			// 
			this.txtEffect.Location = new System.Drawing.Point(480, 64);
			this.txtEffect.Name = "txtEffect";
			this.txtEffect.Size = new System.Drawing.Size(96, 21);
			this.txtEffect.TabIndex = 11;
			this.txtEffect.Text = "";
			this.txtEffect.TextChanged += new System.EventHandler(this.txtEffect_TextChanged);
			// 
			// btnAddWeaponType
			// 
			this.btnAddWeaponType.Location = new System.Drawing.Point(416, 24);
			this.btnAddWeaponType.Name = "btnAddWeaponType";
			this.btnAddWeaponType.TabIndex = 13;
			this.btnAddWeaponType.Text = "Добавить тип оружия";
			this.btnAddWeaponType.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAddWeaponType_MouseUp);
			this.btnAddWeaponType.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
			// 
			// btnSolveTask
			// 
			this.btnSolveTask.Location = new System.Drawing.Point(384, 240);
			this.btnSolveTask.Name = "btnSolveTask";
			this.btnSolveTask.Pulse = true;
			this.btnSolveTask.TabIndex = 14;
			this.btnSolveTask.Text = "Решить задачу";
			this.btnSolveTask.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
			this.btnSolveTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSolveTask_MouseDown);
			// 
			// grpInputData
			// 
			this.grpInputData.Controls.Add(this.txtNumWeapons);
			this.grpInputData.Controls.Add(this.txtNumWeaponTypes);
			this.grpInputData.Controls.Add(this.txtEffect);
			this.grpInputData.Controls.Add(this.txtWeaponPrice);
			this.grpInputData.Controls.Add(this.btnAddWeaponType);
			this.grpInputData.Controls.Add(this.lblNumWeaponTypes);
			this.grpInputData.Controls.Add(this.lblNumWeapons);
			this.grpInputData.Controls.Add(this.txtWeaponName);
			this.grpInputData.Controls.Add(this.lblWeapons);
			this.grpInputData.Controls.Add(this.lstWeapons);
			this.grpInputData.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpInputData.Location = new System.Drawing.Point(8, 8);
			this.grpInputData.Name = "grpInputData";
			this.grpInputData.Size = new System.Drawing.Size(584, 224);
			this.grpInputData.TabIndex = 15;
			this.grpInputData.TabStop = false;
			this.grpInputData.Text = "Входные данные";
			// 
			// lblNeedMoney
			// 
			this.lblNeedMoney.Location = new System.Drawing.Point(16, 24);
			this.lblNeedMoney.Name = "lblNeedMoney";
			this.lblNeedMoney.Size = new System.Drawing.Size(176, 32);
			this.lblNeedMoney.TabIndex = 16;
			this.lblNeedMoney.Text = "Необходимое количество денег для оптимальной загрузки:";
			// 
			// txtNeedMoney
			// 
			this.txtNeedMoney.Location = new System.Drawing.Point(208, 32);
			this.txtNeedMoney.Name = "txtNeedMoney";
			this.txtNeedMoney.ReadOnly = true;
			this.txtNeedMoney.Size = new System.Drawing.Size(64, 21);
			this.txtNeedMoney.TabIndex = 17;
			this.txtNeedMoney.Text = "";
			// 
			// lstPlan
			// 
			this.lstPlan.AddColor = System.Drawing.Color.Red;
			this.lstPlan.ChangeColor = System.Drawing.Color.Green;
			this.lstPlan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.columnHeader4,
																					  this.columnHeader5});
			this.lstPlan.DeleteColor = System.Drawing.Color.Blue;
			this.lstPlan.FadingTime = 10;
			this.lstPlan.Location = new System.Drawing.Point(376, 40);
			this.lstPlan.MultiSelect = false;
			this.lstPlan.Name = "lstPlan";
			this.lstPlan.Size = new System.Drawing.Size(200, 176);
			this.lstPlan.TabIndex = 18;
			this.lstPlan.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Оружие";
			this.columnHeader4.Width = 123;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Количество";
			this.columnHeader5.Width = 73;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lstTbl);
			this.groupBox1.Controls.Add(this.lblTbl);
			this.groupBox1.Controls.Add(this.lblPlan);
			this.groupBox1.Controls.Add(this.lblNeedMoney);
			this.groupBox1.Controls.Add(this.txtNeedMoney);
			this.groupBox1.Controls.Add(this.lstPlan);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(8, 264);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(584, 224);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Результаты";
			// 
			// lstTbl
			// 
			this.lstTbl.AddColor = System.Drawing.Color.Red;
			this.lstTbl.ChangeColor = System.Drawing.Color.Green;
			this.lstTbl.DeleteColor = System.Drawing.Color.Blue;
			this.lstTbl.FadingTime = 10;
			this.lstTbl.GridLines = true;
			this.lstTbl.Location = new System.Drawing.Point(16, 80);
			this.lstTbl.MultiSelect = false;
			this.lstTbl.Name = "lstTbl";
			this.lstTbl.Size = new System.Drawing.Size(344, 136);
			this.lstTbl.TabIndex = 22;
			this.lstTbl.View = System.Windows.Forms.View.Details;
			// 
			// lblTbl
			// 
			this.lblTbl.Location = new System.Drawing.Point(16, 64);
			this.lblTbl.Name = "lblTbl";
			this.lblTbl.Size = new System.Drawing.Size(336, 16);
			this.lblTbl.TabIndex = 21;
			this.lblTbl.Text = "Значения вычислений по шагам рекуррентного выражения";
			// 
			// lblPlan
			// 
			this.lblPlan.Location = new System.Drawing.Point(376, 16);
			this.lblPlan.Name = "lblPlan";
			this.lblPlan.Size = new System.Drawing.Size(200, 23);
			this.lblPlan.TabIndex = 20;
			this.lblPlan.Text = "План оптимальной загрузки корабля";
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument;
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.HideTabsMode = Crownwood.Magic.Controls.TabControl.HideTabsModes.ShowAlways;
			this.tabControl1.IDEPixelBorder = false;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 1;
			this.tabControl1.SelectedTab = this.tabPage2;
			this.tabControl1.Size = new System.Drawing.Size(602, 520);
			this.tabControl1.TabIndex = 21;
			this.tabControl1.TabPages.AddRange(new Crownwood.Magic.Controls.TabPage[] {
																						  this.tabPage1,
																						  this.tabPage2});
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnExit);
			this.tabPage1.Controls.Add(this.grpInputData);
			this.tabPage1.Controls.Add(this.btnSolveTask);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(0, 0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Selected = false;
			this.tabPage1.Size = new System.Drawing.Size(602, 495);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Title = "Задача";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(512, 240);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 20;
			this.btnExit.Text = "Выход";
			this.btnExit.MouseEnter += new System.EventHandler(this.btns_MouseEnter);
			this.btnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseDown);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lblInfo);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.btnCalc);
			this.tabPage2.Controls.Add(this.plotter);
			this.tabPage2.Location = new System.Drawing.Point(0, 0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(602, 495);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Title = "График";
			// 
			// lblInfo
			// 
			this.lblInfo.BackColor = System.Drawing.Color.Transparent;
			this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblInfo.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblInfo.Location = new System.Drawing.Point(56, 32);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(288, 56);
			this.lblInfo.TabIndex = 3;
			this.lblInfo.Text = "xxxxxxxxxxx";
			this.lblInfo.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(504, 456);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Выход";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(368, 456);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(120, 24);
			this.btnCalc.TabIndex = 1;
			this.btnCalc.Text = "Расчитать график";
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// plotter
			// 
			this.plotter.BorderBottom = 50;
			this.plotter.BorderLeft = 50;
			this.plotter.BorderRight = 30;
			this.plotter.BorderTop = 30;
			this.plotter.ColorAxis = System.Drawing.Color.Black;
			this.plotter.ColorBg = System.Drawing.Color.White;
			this.plotter.ColorDraw = System.Drawing.Color.DarkBlue;
			this.plotter.ColorGrid = System.Drawing.Color.LightGray;
			this.plotter.Dock = System.Windows.Forms.DockStyle.Top;
			this.plotter.DrawMode = DataPlotter.Plotter.DrawModeType.Bar;
			this.plotter.FontAxis = new System.Drawing.Font("Arial", 8F);
			this.plotter.Location = new System.Drawing.Point(0, 0);
			this.plotter.Name = "plotter";
			this.plotter.PenWidth = 2;
			this.plotter.Size = new System.Drawing.Size(602, 440);
			this.plotter.TabIndex = 0;
			this.plotter.XData = null;
			this.plotter.XGrid = 50;
			this.plotter.XLogBase = 0;
			this.plotter.XRangeEnd = 100;
			this.plotter.XRangeStart = 0;
			this.plotter.YData = null;
			this.plotter.YGrid = 10;
			this.plotter.YLogBase = 0;
			this.plotter.YRangeEnd = 100;
			this.plotter.YRangeStart = 0;
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(602, 520);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "Задача целочисленного программирования";
			this.grpInputData.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//------------------------------------------------------------------------

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		//------------------------------------------------------------------------

		private void txtNumWeapons_Validated(object sender, System.EventArgs e) {
			if(txtNumWeapons.Text == "") return;
			try {
				NumWeapons = Convert.ToInt32(txtNumWeapons.Text);
			}
			catch(Exception ex) {
				errorProvider.SetError(txtNumWeapons, ex.Message);
				return;
			}
			errorProvider.SetError(txtNumWeapons, "");
		}

		//------------------------------------------------------------------------

		private void txtNumWeaponTypes_Validated(object sender, System.EventArgs e) {
			if(txtNumWeaponTypes.Text == "") return;
			try {
				NumWeaponTypes = Convert.ToInt32(txtNumWeaponTypes.Text);
			}
			catch(Exception ex) {
				errorProvider.SetError(txtNumWeaponTypes, ex.Message);
				return;
			}


			errorProvider.SetError(txtNumWeaponTypes, "");
		}
		//------------------------------------------------------------------------


		private void txtWeaponPrice_Validated(object sender, System.EventArgs e) {
			if(txtWeaponPrice.Text == "") return;
			try {
				InputWeaponPrice = Convert.ToInt32(txtWeaponPrice.Text);
			}
			catch(Exception ex) {
				errorProvider.SetError(txtWeaponPrice, ex.Message);
				return;
			}

			if(InputWeaponPrice <= 0) {
				errorProvider.SetError(txtWeaponPrice, "Цена должна быть положительным числом");
				InputWeaponPrice = -1;
			}
			else
				errorProvider.SetError(txtWeaponPrice, "");

		}

		//------------------------------------------------------------------------

		private void txtEffect_TextChanged(object sender, System.EventArgs e) {
			if(txtEffect.Text == "") return;
			try {
				InputWeaponEffect = Convert.ToInt32(txtEffect.Text);
			}
			catch(Exception ex) {
				errorProvider.SetError(txtEffect, ex.Message);
				return;
			}

			if(InputWeaponEffect <= 0) {
				errorProvider.SetError(txtEffect, "Эффективность должна быть положительным числом");
				InputWeaponEffect = -1;
			}
			else
				errorProvider.SetError(txtEffect, "");
		}

		//------------------------------------------------------------------------

		private void btns_MouseEnter(object sender, System.EventArgs e) {
			((Control) sender).Focus();
		}

		//------------------------------------------------------------------------

		private void btnExit_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			Application.Exit();
		}

		//------------------------------------------------------------------------
		
		private void btnExit2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			Application.Exit();
		}

		//------------------------------------------------------------------------

		private void btnAddWeaponType_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
			if(txtWeaponName.Text == "" ||
				InputWeaponPrice < 0 ||
				InputWeaponEffect < 0) {
				MessageBox.Show("Введенные данные не корректны!", "Ошибка ввода", 
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			ListViewItem WeapItem = new ListViewItem();

			WeapItem.Text = txtWeaponName.Text;
			WeapItem.SubItems.Add(InputWeaponPrice.ToString());
			WeapItem.SubItems.Add(InputWeaponEffect.ToString());
			lstWeapons.AddItem(WeapItem);
			txtWeaponName.Text = string.Format("Оружие{0}", lstWeapons.Items.Count + 1);
			txtNumWeaponTypes.Text = lstWeapons.Items.Count.ToString();
		}

		//------------------------------------------------------------------------

		private void btnSolveTask_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			if(txtNumWeapons.Text == "") {
				MessageBox.Show("Не введено максимальное количество единиц оружия", 
					"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if(lstWeapons.Items.Count < 1) {
				MessageBox.Show("Не введены типы оружия", "Ошибка ввода", 
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int W0 = Convert.ToInt32(txtNumWeapons.Text);
			WeaponType[] WeapTypes = new WeaponType[lstWeapons.Items.Count];
			int i, i2;
			ListViewItem lvi;
			int ColWidth;

			for(i = 0; i < lstWeapons.Items.Count; i++) {
				WeapTypes[i].Price = Convert.ToInt32(lstWeapons.Items[i].SubItems[1].Text);
				WeapTypes[i].Effect = Convert.ToInt32(lstWeapons.Items[i].SubItems[2].Text);
			}

			Task.Solve(W0, WeapTypes);
			txtNeedMoney.Text = Task.NeedPrice.ToString();

			for(i = 0; i < lstWeapons.Items.Count; i++) {
				lvi = new ListViewItem();
				lvi.Text = lstWeapons.Items[i].Text;
				lvi.SubItems.Add(Task.Plan[i].ToString());
				lstPlan.AddItem(lvi);
			}

			btnSolveTask.Pulse = false;
			
			// выводим результаты промежуточных вычислений в таблицу

			ColWidth = lstTbl.Width / (1 + 2 * Task.Plan.Length);
			lstTbl.Columns.Add("W", ColWidth, HorizontalAlignment.Left);
			for(i = 0; i < Task.Plan.Length; i++) {
				lstTbl.Columns.Add(string.Format("F{0}(W)", i+1), ColWidth, HorizontalAlignment.Left);
				lstTbl.Columns.Add(string.Format("X{0}", i+1), ColWidth, HorizontalAlignment.Left);
			}

			for(i = 0; i <= W0; i++) {
				lvi = new ListViewItem();
				lvi.Text = i.ToString();
				for(i2 = 0; i2 < Task.Plan.Length; i2++) {
					lvi.SubItems.Add(Task.F[i, i2].ToString());
					lvi.SubItems.Add(Task.X[i, i2].ToString());
				}
				lstTbl.AddItem(lvi);
			}
		}

		private void btnCalc_Click(object sender, System.EventArgs e) {
			DateTime t1, t2;
			TimeSpan ts;
			WeaponType[] wt;
			Random rnd = new Random(DateTime.Now.Second);
			double[] x, y;
			const int N = 600;

			Cursor.Current = Cursors.WaitCursor;
			plotter.XRangeEnd = N;
			x = new double[N];
			y = new double[N];
			for(int i = 1; i < N; i++) {
				x[i] = i;
				t1 = DateTime.Now;
				wt = new WeaponType[i];
				for(int j = 0; j < i; j++) {
					wt[j].Price = rnd.Next(1, int.MaxValue);
					wt[j].Effect = rnd.Next(1, int.MaxValue);
				}
				Task.Solve(i+1000, wt);
				t2 = DateTime.Now;
				ts = t2 - t1;
				y[i] = Convert.ToDouble(ts.TotalMilliseconds);
				plotter.XData = x;
				plotter.YData = y;
			}
			Cursor.Current = Cursors.Default;
			lblInfo.Text = string.Format(" Количество решенных задач: {0}\n" +
				" Максимальное кол-во единиц оружия: [1;{1}]\n" +
				" Размерность задачи: [1;{2}]",
				N.ToString(), N+1000, N);
			lblInfo.Visible = true;
			Refresh();
			}

		private void button1_Click(object sender, System.EventArgs e) {
			Application.Exit();
		}
	}
}