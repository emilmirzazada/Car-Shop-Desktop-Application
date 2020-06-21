namespace Turbo
{
    partial class FrmCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalog));
            this.Control_Cars = new DevExpress.XtraGrid.GridControl();
            this.cardView_Cars = new DevExpress.XtraGrid.Views.Card.CardView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Photo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Brand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_addAd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lkpEdtCitiesFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpEdtCurrencyFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpEdtModelsFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpEdtBrandsFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.chkBarter = new DevExpress.XtraEditors.CheckEdit();
            this.chkCredit = new DevExpress.XtraEditors.CheckEdit();
            this.txtMaxPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtMinPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtMaxGrad = new DevExpress.XtraEditors.TextEdit();
            this.txtMinGrad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView_Cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEdtCitiesFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEdtCurrencyFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEdtModelsFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEdtBrandsFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBarter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxGrad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinGrad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control_Cars
            // 
            this.Control_Cars.Location = new System.Drawing.Point(0, 184);
            this.Control_Cars.MainView = this.cardView_Cars;
            this.Control_Cars.Name = "Control_Cars";
            this.Control_Cars.Size = new System.Drawing.Size(831, 455);
            this.Control_Cars.TabIndex = 0;
            this.Control_Cars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView_Cars});
            this.Control_Cars.Click += new System.EventHandler(this.Control_Cars_Click);
            // 
            // cardView_Cars
            // 
            this.cardView_Cars.Appearance.Card.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardView_Cars.Appearance.Card.Options.UseFont = true;
            this.cardView_Cars.Appearance.FieldValue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cardView_Cars.AppearancePrint.Card.Options.UseTextOptions = true;
            this.cardView_Cars.AppearancePrint.Card.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cardView_Cars.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.gridColumn7,
            this.gridColumn6,
            this.Photo1,
            this.Brand,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.cardView_Cars.GridControl = this.Control_Cars;
            this.cardView_Cars.Name = "cardView_Cars";
            this.cardView_Cars.OptionsBehavior.Editable = false;
            this.cardView_Cars.OptionsBehavior.FieldAutoHeight = true;
            this.cardView_Cars.OptionsBehavior.ReadOnly = true;
            this.cardView_Cars.OptionsView.ShowCardCaption = false;
            this.cardView_Cars.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView_Cars.Click += new System.EventHandler(this.cardView_Cars_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Qiymət";
            this.gridColumn7.FieldName = "Price";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Valyuta";
            this.gridColumn6.FieldName = "Currency";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // Photo1
            // 
            this.Photo1.Caption = "Şəkil";
            this.Photo1.FieldName = "Photo1";
            this.Photo1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Photo1.ImageOptions.SvgImageSize = new System.Drawing.Size(200, 200);
            this.Photo1.MinWidth = 150;
            this.Photo1.Name = "Photo1";
            this.Photo1.Visible = true;
            this.Photo1.VisibleIndex = 0;
            this.Photo1.Width = 150;
            // 
            // Brand
            // 
            this.Brand.Caption = "Marka";
            this.Brand.FieldName = "Brand_Name";
            this.Brand.Name = "Brand";
            this.Brand.Visible = true;
            this.Brand.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Model";
            this.gridColumn2.FieldName = "Model_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Buraxılış ili";
            this.gridColumn3.FieldName = "Graduation_Year";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mühərrikin həcmi";
            this.gridColumn4.FieldName = "Engine_Capacity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Yürüş";
            this.gridColumn5.FieldName = "Walk";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            // 
            // btn_addAd
            // 
            this.btn_addAd.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btn_addAd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAd.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_addAd.Appearance.Options.UseBackColor = true;
            this.btn_addAd.Appearance.Options.UseFont = true;
            this.btn_addAd.Appearance.Options.UseForeColor = true;
            this.btn_addAd.Location = new System.Drawing.Point(678, 49);
            this.btn_addAd.Name = "btn_addAd";
            this.btn_addAd.Size = new System.Drawing.Size(136, 33);
            this.btn_addAd.TabIndex = 1;
            this.btn_addAd.Text = "Elan yerləşdir";
            this.btn_addAd.Click += new System.EventHandler(this.btn_addAd_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lkpEdtCitiesFilter);
            this.panelControl1.Controls.Add(this.lkpEdtCurrencyFilter);
            this.panelControl1.Controls.Add(this.lkpEdtModelsFilter);
            this.panelControl1.Controls.Add(this.lkpEdtBrandsFilter);
            this.panelControl1.Controls.Add(this.btnFilter);
            this.panelControl1.Controls.Add(this.chkBarter);
            this.panelControl1.Controls.Add(this.chkCredit);
            this.panelControl1.Controls.Add(this.txtMaxPrice);
            this.panelControl1.Controls.Add(this.txtMinPrice);
            this.panelControl1.Controls.Add(this.txtMaxGrad);
            this.panelControl1.Controls.Add(this.txtMinGrad);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_addAd);
            this.panelControl1.Location = new System.Drawing.Point(0, 96);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(836, 91);
            this.panelControl1.TabIndex = 3;
            // 
            // lkpEdtCitiesFilter
            // 
            this.lkpEdtCitiesFilter.Location = new System.Drawing.Point(541, 14);
            this.lkpEdtCitiesFilter.Name = "lkpEdtCitiesFilter";
            this.lkpEdtCitiesFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkpEdtCitiesFilter.Properties.Appearance.Options.UseFont = true;
            this.lkpEdtCitiesFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEdtCitiesFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Şəhər", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.False)});
            this.lkpEdtCitiesFilter.Properties.NullText = "Bütün şəhərlər";
            this.lkpEdtCitiesFilter.Size = new System.Drawing.Size(121, 22);
            this.lkpEdtCitiesFilter.TabIndex = 22;
            // 
            // lkpEdtCurrencyFilter
            // 
            this.lkpEdtCurrencyFilter.Location = new System.Drawing.Point(242, 14);
            this.lkpEdtCurrencyFilter.Name = "lkpEdtCurrencyFilter";
            this.lkpEdtCurrencyFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkpEdtCurrencyFilter.Properties.Appearance.Options.UseFont = true;
            this.lkpEdtCurrencyFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEdtCurrencyFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Valyuta")});
            this.lkpEdtCurrencyFilter.Properties.NullText = "AZN";
            this.lkpEdtCurrencyFilter.Size = new System.Drawing.Size(51, 22);
            this.lkpEdtCurrencyFilter.TabIndex = 21;
            // 
            // lkpEdtModelsFilter
            // 
            this.lkpEdtModelsFilter.Location = new System.Drawing.Point(29, 53);
            this.lkpEdtModelsFilter.Name = "lkpEdtModelsFilter";
            this.lkpEdtModelsFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkpEdtModelsFilter.Properties.Appearance.Options.UseFont = true;
            this.lkpEdtModelsFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEdtModelsFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model_Name", "Model_Name")});
            this.lkpEdtModelsFilter.Properties.NullText = "Bütün modellər";
            this.lkpEdtModelsFilter.Size = new System.Drawing.Size(121, 22);
            this.lkpEdtModelsFilter.TabIndex = 20;
            // 
            // lkpEdtBrandsFilter
            // 
            this.lkpEdtBrandsFilter.Location = new System.Drawing.Point(29, 14);
            this.lkpEdtBrandsFilter.Name = "lkpEdtBrandsFilter";
            this.lkpEdtBrandsFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkpEdtBrandsFilter.Properties.Appearance.Options.UseFont = true;
            this.lkpEdtBrandsFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEdtBrandsFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand_Name", "Marka")});
            this.lkpEdtBrandsFilter.Properties.NullText = "Bütün markalar";
            this.lkpEdtBrandsFilter.Size = new System.Drawing.Size(121, 22);
            this.lkpEdtBrandsFilter.TabIndex = 19;
            this.lkpEdtBrandsFilter.EditValueChanged += new System.EventHandler(this.lkpEdtBrandsFilter_EditValueChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnFilter.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFilter.Appearance.Options.UseBackColor = true;
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Appearance.Options.UseForeColor = true;
            this.btnFilter.Location = new System.Drawing.Point(678, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(136, 33);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Axtar";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // chkBarter
            // 
            this.chkBarter.EditValue = 0;
            this.chkBarter.Location = new System.Drawing.Point(460, 55);
            this.chkBarter.Name = "chkBarter";
            this.chkBarter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBarter.Properties.Appearance.Options.UseFont = true;
            this.chkBarter.Properties.Caption = "Barter";
            this.chkBarter.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkBarter.Properties.ValueChecked = 1;
            this.chkBarter.Properties.ValueUnchecked = 0;
            this.chkBarter.Size = new System.Drawing.Size(75, 20);
            this.chkBarter.TabIndex = 12;
            // 
            // chkCredit
            // 
            this.chkCredit.EditValue = 0;
            this.chkCredit.Location = new System.Drawing.Point(460, 12);
            this.chkCredit.Name = "chkCredit";
            this.chkCredit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCredit.Properties.Appearance.Options.UseFont = true;
            this.chkCredit.Properties.Caption = "Kredit";
            this.chkCredit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkCredit.Properties.ValueChecked = 1;
            this.chkCredit.Properties.ValueUnchecked = 0;
            this.chkCredit.Size = new System.Drawing.Size(75, 20);
            this.chkCredit.TabIndex = 11;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.EditValue = "";
            this.txtMaxPrice.Location = new System.Drawing.Point(372, 14);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPrice.Properties.Appearance.Options.UseFont = true;
            this.txtMaxPrice.Properties.NullValuePrompt = "max.";
            this.txtMaxPrice.Size = new System.Drawing.Size(66, 22);
            this.txtMaxPrice.TabIndex = 10;
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.EditValue = "";
            this.txtMinPrice.Location = new System.Drawing.Point(299, 14);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinPrice.Properties.Appearance.Options.UseFont = true;
            this.txtMinPrice.Properties.NullValuePrompt = "min.";
            this.txtMinPrice.Size = new System.Drawing.Size(67, 22);
            this.txtMinPrice.TabIndex = 9;
            // 
            // txtMaxGrad
            // 
            this.txtMaxGrad.EditValue = "";
            this.txtMaxGrad.Location = new System.Drawing.Point(360, 53);
            this.txtMaxGrad.Name = "txtMaxGrad";
            this.txtMaxGrad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxGrad.Properties.Appearance.Options.UseFont = true;
            this.txtMaxGrad.Properties.NullValuePrompt = "max.";
            this.txtMaxGrad.Size = new System.Drawing.Size(78, 22);
            this.txtMaxGrad.TabIndex = 8;
            // 
            // txtMinGrad
            // 
            this.txtMinGrad.EditValue = "";
            this.txtMinGrad.Location = new System.Drawing.Point(262, 53);
            this.txtMinGrad.Name = "txtMinGrad";
            this.txtMinGrad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinGrad.Properties.Appearance.Options.UseFont = true;
            this.txtMinGrad.Properties.NullValuePrompt = "min.";
            this.txtMinGrad.Size = new System.Drawing.Size(78, 22);
            this.txtMinGrad.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(196, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Buraxılış ili";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(196, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Qiymət";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.Control_Cars);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1019, 621);
            this.panelControl2.TabIndex = 4;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.pictureBox1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(833, 97);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(184, 522);
            this.panelControl4.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.btnAdmin);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1015, 95);
            this.panelControl3.TabIndex = 14;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnAdmin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdmin.Appearance.Options.UseBackColor = true;
            this.btnAdmin.Appearance.Options.UseFont = true;
            this.btnAdmin.Appearance.Options.UseForeColor = true;
            this.btnAdmin.Location = new System.Drawing.Point(845, 31);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(148, 33);
            this.btnAdmin.TabIndex = 22;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(330, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(324, 37);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "101 CAR SHOP";
            // 
            // FrmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 621);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCatalog_FormClosed);
            this.Load += new System.EventHandler(this.FrmCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Control_Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView_Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEdtCitiesFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEdtCurrencyFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEdtModelsFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEdtBrandsFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBarter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxGrad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinGrad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Control_Cars;
        private DevExpress.XtraGrid.Views.Card.CardView cardView_Cars;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn Photo1;
        private DevExpress.XtraGrid.Columns.GridColumn Brand;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btn_addAd;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.CheckEdit chkBarter;
        private DevExpress.XtraEditors.CheckEdit chkCredit;
        private DevExpress.XtraEditors.TextEdit txtMaxPrice;
        private DevExpress.XtraEditors.TextEdit txtMinPrice;
        private DevExpress.XtraEditors.TextEdit txtMaxGrad;
        private DevExpress.XtraEditors.TextEdit txtMinGrad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LookUpEdit lkpEdtBrandsFilter;
        private DevExpress.XtraEditors.LookUpEdit lkpEdtModelsFilter;
        private DevExpress.XtraEditors.LookUpEdit lkpEdtCurrencyFilter;
        private DevExpress.XtraEditors.SimpleButton btnAdmin;
        private DevExpress.XtraEditors.LookUpEdit lkpEdtCitiesFilter;
    }
}