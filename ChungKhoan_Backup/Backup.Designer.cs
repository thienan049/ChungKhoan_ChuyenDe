
namespace ChungKhoan_Backup
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.txtbDeviceName = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCreateDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackupDB = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestoreDB = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ChungKhoanDS = new ChungKhoan_Backup.CHUNGKHOANDataSet();
            this.sP_BACKUP_POSITIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_BACKUP_POSITIONSTableAdapter = new ChungKhoan_Backup.CHUNGKHOANDataSetTableAdapters.SP_BACKUP_POSITIONSTableAdapter();
            this.tableAdapterManager = new ChungKhoan_Backup.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.sP_BACKUP_POSITIONSGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_DANHSACH_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANHSACH_DBTableAdapter = new ChungKhoan_Backup.CHUNGKHOANDataSetTableAdapters.SP_DANHSACH_DBTableAdapter();
            this.sP_DANHSACH_DBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listDB = new System.Windows.Forms.ListBox();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.grCtrlBackupList = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chbxOverwrite = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbxTimeSpecified = new System.Windows.Forms.CheckBox();
            this.panelSetTime = new DevExpress.XtraEditors.PanelControl();
            this.timeRestore = new DevExpress.XtraEditors.TimeEdit();
            this.dateRestore = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtbDeviceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChungKhoanDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BACKUP_POSITIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BACKUP_POSITIONSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_DBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlBackupList)).BeginInit();
            this.grCtrlBackupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSetTime)).BeginInit();
            this.panelSetTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbDeviceName
            // 
            this.txtbDeviceName.Location = new System.Drawing.Point(719, 422);
            this.txtbDeviceName.Name = "txtbDeviceName";
            this.txtbDeviceName.Size = new System.Drawing.Size(131, 20);
            this.txtbDeviceName.TabIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCreateDevice,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnBackupDB,
            this.btnRestoreDB});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCreateDevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBackupDB, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRestoreDB, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnCreateDevice
            // 
            this.btnCreateDevice.Caption = "Device";
            this.btnCreateDevice.Id = 0;
            this.btnCreateDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDevice.ImageOptions.Image")));
            this.btnCreateDevice.Name = "btnCreateDevice";
            this.btnCreateDevice.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCreateDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateDevice_ItemClick);
            // 
            // btnBackupDB
            // 
            this.btnBackupDB.Caption = "Backup";
            this.btnBackupDB.Id = 3;
            this.btnBackupDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackupDB.ImageOptions.Image")));
            this.btnBackupDB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackupDB.ImageOptions.LargeImage")));
            this.btnBackupDB.Name = "btnBackupDB";
            this.btnBackupDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackupDB_ItemClick);
            // 
            // btnRestoreDB
            // 
            this.btnRestoreDB.Caption = "Restore";
            this.btnRestoreDB.Id = 4;
            this.btnRestoreDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreDB.ImageOptions.Image")));
            this.btnRestoreDB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestoreDB.ImageOptions.LargeImage")));
            this.btnRestoreDB.Name = "btnRestoreDB";
            this.btnRestoreDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestoreDB_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(862, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(862, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 414);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(862, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 414);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ChungKhoanDS
            // 
            this.ChungKhoanDS.DataSetName = "CHUNGKHOANDataSet";
            this.ChungKhoanDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_BACKUP_POSITIONSBindingSource
            // 
            this.sP_BACKUP_POSITIONSBindingSource.DataMember = "SP_BACKUP_POSITIONS";
            this.sP_BACKUP_POSITIONSBindingSource.DataSource = this.ChungKhoanDS;
            // 
            // sP_BACKUP_POSITIONSTableAdapter
            // 
            this.sP_BACKUP_POSITIONSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ChungKhoan_Backup.CHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_BACKUP_POSITIONSGridControl
            // 
            this.sP_BACKUP_POSITIONSGridControl.DataSource = this.sP_BACKUP_POSITIONSBindingSource;
            this.sP_BACKUP_POSITIONSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_BACKUP_POSITIONSGridControl.Location = new System.Drawing.Point(2, 23);
            this.sP_BACKUP_POSITIONSGridControl.MainView = this.gridView1;
            this.sP_BACKUP_POSITIONSGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.sP_BACKUP_POSITIONSGridControl.MenuManager = this.barManager1;
            this.sP_BACKUP_POSITIONSGridControl.Name = "sP_BACKUP_POSITIONSGridControl";
            this.sP_BACKUP_POSITIONSGridControl.Size = new System.Drawing.Size(761, 225);
            this.sP_BACKUP_POSITIONSGridControl.TabIndex = 19;
            this.sP_BACKUP_POSITIONSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView1.GridControl = this.sP_BACKUP_POSITIONSGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colposition
            // 
            this.colposition.AppearanceCell.Options.UseTextOptions = true;
            this.colposition.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.AppearanceHeader.Options.UseTextOptions = true;
            this.colposition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.Caption = "Position";
            this.colposition.FieldName = "position";
            this.colposition.Name = "colposition";
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 69;
            // 
            // colname
            // 
            this.colname.Caption = "Name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 237;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Date";
            this.colbackup_start_date.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 247;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "User name";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 116;
            // 
            // sP_DANHSACH_DBBindingSource
            // 
            this.sP_DANHSACH_DBBindingSource.DataMember = "SP_DANHSACH_DB";
            this.sP_DANHSACH_DBBindingSource.DataSource = this.ChungKhoanDS;
            // 
            // sP_DANHSACH_DBTableAdapter
            // 
            this.sP_DANHSACH_DBTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DANHSACH_DBBindingSource1
            // 
            this.sP_DANHSACH_DBBindingSource1.DataMember = "SP_DANHSACH_DB";
            this.sP_DANHSACH_DBBindingSource1.DataSource = this.ChungKhoanDS;
            // 
            // listDB
            // 
            this.listDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDB.DataSource = this.sP_DANHSACH_DBBindingSource1;
            this.listDB.DisplayMember = "name";
            this.listDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDB.FormattingEnabled = true;
            this.listDB.Location = new System.Drawing.Point(2, 23);
            this.listDB.Margin = new System.Windows.Forms.Padding(0);
            this.listDB.Name = "listDB";
            this.listDB.Size = new System.Drawing.Size(89, 225);
            this.listDB.TabIndex = 23;
            this.listDB.ValueMember = "name";
            this.listDB.SelectedIndexChanged += new System.EventHandler(this.listDB_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.grCtrlBackupList);
            this.mainPanel.Controls.Add(this.groupControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(862, 254);
            this.mainPanel.TabIndex = 24;
            // 
            // grCtrlBackupList
            // 
            this.grCtrlBackupList.Controls.Add(this.sP_BACKUP_POSITIONSGridControl);
            this.grCtrlBackupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrlBackupList.Location = new System.Drawing.Point(95, 2);
            this.grCtrlBackupList.Name = "grCtrlBackupList";
            this.grCtrlBackupList.Size = new System.Drawing.Size(765, 250);
            this.grCtrlBackupList.TabIndex = 25;
            this.grCtrlBackupList.Text = "groupControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listDB);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(93, 250);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Databases";
            // 
            // chbxOverwrite
            // 
            this.chbxOverwrite.AutoSize = true;
            this.chbxOverwrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbxOverwrite.FlatAppearance.BorderSize = 0;
            this.chbxOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxOverwrite.Location = new System.Drawing.Point(3, 17);
            this.chbxOverwrite.Name = "chbxOverwrite";
            this.chbxOverwrite.Size = new System.Drawing.Size(856, 19);
            this.chbxOverwrite.TabIndex = 0;
            this.chbxOverwrite.Text = "Xóa các bản sao lưu cũ trước khi backup\r\n";
            this.chbxOverwrite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbxTimeSpecified);
            this.groupBox1.Controls.Add(this.chbxOverwrite);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 63);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chbxTimeSpecified
            // 
            this.chbxTimeSpecified.AutoSize = true;
            this.chbxTimeSpecified.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbxTimeSpecified.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxTimeSpecified.Location = new System.Drawing.Point(3, 36);
            this.chbxTimeSpecified.Name = "chbxTimeSpecified";
            this.chbxTimeSpecified.Size = new System.Drawing.Size(856, 19);
            this.chbxTimeSpecified.TabIndex = 1;
            this.chbxTimeSpecified.Text = "Restore với mốc thời gian";
            this.chbxTimeSpecified.UseVisualStyleBackColor = true;
            this.chbxTimeSpecified.CheckedChanged += new System.EventHandler(this.chbxTimeSpecified_CheckedChanged);
            // 
            // panelSetTime
            // 
            this.panelSetTime.Controls.Add(this.timeRestore);
            this.panelSetTime.Controls.Add(this.dateRestore);
            this.panelSetTime.Controls.Add(this.labelControl1);
            this.panelSetTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSetTime.Location = new System.Drawing.Point(0, 357);
            this.panelSetTime.Name = "panelSetTime";
            this.panelSetTime.Size = new System.Drawing.Size(862, 59);
            this.panelSetTime.TabIndex = 31;
            // 
            // timeRestore
            // 
            this.timeRestore.EditValue = new System.DateTime(2021, 5, 19, 0, 0, 0, 0);
            this.timeRestore.Location = new System.Drawing.Point(334, 19);
            this.timeRestore.MenuManager = this.barManager1;
            this.timeRestore.Name = "timeRestore";
            this.timeRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeRestore.Size = new System.Drawing.Size(100, 20);
            this.timeRestore.TabIndex = 2;
            // 
            // dateRestore
            // 
            this.dateRestore.EditValue = null;
            this.dateRestore.Location = new System.Drawing.Point(148, 19);
            this.dateRestore.MenuManager = this.barManager1;
            this.dateRestore.Name = "dateRestore";
            this.dateRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRestore.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRestore.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateRestore.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRestore.Properties.EditFormat.FormatString = "";
            this.dateRestore.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateRestore.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateRestore.Size = new System.Drawing.Size(180, 20);
            this.dateRestore.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập mốc thời gian: ";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 454);
            this.Controls.Add(this.panelSetTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.txtbDeviceName);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Backup";
            this.Text = "Backup & Restore";
            this.Load += new System.EventHandler(this.Backup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtbDeviceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChungKhoanDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BACKUP_POSITIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BACKUP_POSITIONSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_DBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlBackupList)).EndInit();
            this.grCtrlBackupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSetTime)).EndInit();
            this.panelSetTime.ResumeLayout(false);
            this.panelSetTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtbDeviceName;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCreateDevice;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnBackupDB;
        private System.Windows.Forms.BindingSource sP_BACKUP_POSITIONSBindingSource;
        private CHUNGKHOANDataSet ChungKhoanDS;
        private CHUNGKHOANDataSetTableAdapters.SP_BACKUP_POSITIONSTableAdapter sP_BACKUP_POSITIONSTableAdapter;
        private CHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_BACKUP_POSITIONSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraBars.BarButtonItem btnRestoreDB;
        private System.Windows.Forms.BindingSource sP_DANHSACH_DBBindingSource;
        private CHUNGKHOANDataSetTableAdapters.SP_DANHSACH_DBTableAdapter sP_DANHSACH_DBTableAdapter;
        private System.Windows.Forms.ListBox listDB;
        private System.Windows.Forms.BindingSource sP_DANHSACH_DBBindingSource1;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private System.Windows.Forms.CheckBox chbxOverwrite;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl grCtrlBackupList;
        private System.Windows.Forms.CheckBox chbxTimeSpecified;
        private DevExpress.XtraEditors.PanelControl panelSetTime;
        private DevExpress.XtraEditors.DateEdit dateRestore;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit timeRestore;
    }
}

