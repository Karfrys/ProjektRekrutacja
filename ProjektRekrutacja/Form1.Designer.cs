namespace ProjektRekrutacja
{
    partial class Form1
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dateFromEdit = new DevExpress.XtraEditors.DateEdit();
            this.raportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateToEdit = new DevExpress.XtraEditors.DateEdit();
            this.commitButton = new DevExpress.XtraEditors.SimpleButton();
            this.colNazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainDataGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNazwa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodzina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUzytkownik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLokal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBoxUsers = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateToEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateToEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUsers.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFromEdit
            // 
            this.dateFromEdit.EditValue = null;
            this.dateFromEdit.Location = new System.Drawing.Point(12, 44);
            this.dateFromEdit.Name = "dateFromEdit";
            this.dateFromEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromEdit.Properties.Appearance.Options.UseFont = true;
            serializableAppearanceObject9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            serializableAppearanceObject9.Options.UseFont = true;
            this.dateFromEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.dateFromEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFromEdit.Properties.NullText = "Od:";
            this.dateFromEdit.Size = new System.Drawing.Size(100, 26);
            this.dateFromEdit.TabIndex = 0;
            // 
            // raportsBindingSource
            // 
            this.raportsBindingSource.DataSource = typeof(ProjektRekrutacja.Raport);
            // 
            // dateToEdit
            // 
            this.dateToEdit.EditValue = null;
            this.dateToEdit.Location = new System.Drawing.Point(12, 76);
            this.dateToEdit.Name = "dateToEdit";
            this.dateToEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToEdit.Properties.Appearance.Options.UseFont = true;
            this.dateToEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateToEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateToEdit.Properties.NullText = "Do:";
            this.dateToEdit.Size = new System.Drawing.Size(100, 26);
            this.dateToEdit.TabIndex = 3;
            // 
            // commitButton
            // 
            this.commitButton.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.commitButton.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.commitButton.Appearance.ForeColor = System.Drawing.Color.Black;
            this.commitButton.Appearance.Options.UseBackColor = true;
            this.commitButton.Appearance.Options.UseFont = true;
            this.commitButton.Appearance.Options.UseForeColor = true;
            this.commitButton.Location = new System.Drawing.Point(12, 264);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(106, 23);
            this.commitButton.TabIndex = 5;
            this.commitButton.Text = "Zatwierdź";
            this.commitButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // colNazwa
            // 
            this.colNazwa.FieldName = "Nazwa";
            this.colNazwa.Name = "colNazwa";
            this.colNazwa.Visible = true;
            this.colNazwa.VisibleIndex = 0;
            // 
            // mainDataGridControl
            // 
            this.mainDataGridControl.DataSource = typeof(ProjektRekrutacja.Raport);
            this.mainDataGridControl.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.mainDataGridControl.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.mainDataGridControl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainDataGridControl.Location = new System.Drawing.Point(157, -1);
            this.mainDataGridControl.MainView = this.gridView1;
            this.mainDataGridControl.Name = "mainDataGridControl";
            this.mainDataGridControl.Size = new System.Drawing.Size(557, 292);
            this.mainDataGridControl.TabIndex = 6;
            this.mainDataGridControl.UseDisabledStatePainter = false;
            this.mainDataGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNazwa1,
            this.colData,
            this.colGodzina,
            this.colUzytkownik,
            this.colLokal});
            this.gridView1.GridControl = this.mainDataGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNazwa1
            // 
            this.colNazwa1.FieldName = "Nazwa";
            this.colNazwa1.Name = "colNazwa1";
            this.colNazwa1.Visible = true;
            this.colNazwa1.VisibleIndex = 0;
            // 
            // colData
            // 
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 1;
            // 
            // colGodzina
            // 
            this.colGodzina.FieldName = "Godzina";
            this.colGodzina.Name = "colGodzina";
            this.colGodzina.Visible = true;
            this.colGodzina.VisibleIndex = 2;
            // 
            // colUzytkownik
            // 
            this.colUzytkownik.FieldName = "Uzytkownik";
            this.colUzytkownik.Name = "colUzytkownik";
            this.colUzytkownik.Visible = true;
            this.colUzytkownik.VisibleIndex = 3;
            // 
            // colLokal
            // 
            this.colLokal.FieldName = "Lokal";
            this.colLokal.Name = "colLokal";
            this.colLokal.Visible = true;
            this.colLokal.VisibleIndex = 4;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Location = new System.Drawing.Point(12, 12);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxUsers.Properties.Appearance.Options.UseFont = true;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Black;
            serializableAppearanceObject1.Options.UseBackColor = true;
            this.comboBoxUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.comboBoxUsers.Properties.NullText = "Lokal:";
            this.comboBoxUsers.Size = new System.Drawing.Size(100, 26);
            this.comboBoxUsers.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 292);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.mainDataGridControl);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.dateToEdit);
            this.Controls.Add(this.dateFromEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dateFromEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateToEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateToEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUsers.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateFromEdit;
        private System.Windows.Forms.BindingSource raportsBindingSource;
        private DevExpress.XtraEditors.DateEdit dateToEdit;
        private DevExpress.XtraEditors.SimpleButton commitButton;
        private DevExpress.XtraGrid.Columns.GridColumn colNazwa;
        private DevExpress.XtraGrid.GridControl mainDataGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNazwa1;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colGodzina;
        private DevExpress.XtraGrid.Columns.GridColumn colUzytkownik;
        private DevExpress.XtraGrid.Columns.GridColumn colLokal;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxUsers;
    }
}

