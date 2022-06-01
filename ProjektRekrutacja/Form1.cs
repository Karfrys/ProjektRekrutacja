using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektRekrutacja
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
      

        public Form1()
        {
            InitializeComponent();
            this.Text = "Raport";
            this.ShowIcon = false;
            mainDataGridControl.DataSource = db.Raports;
            
            ApperanceChanges();
            populateComboBox();
        }

        private void populateComboBox()
        {
            List<string> selected_user = ((from rap in db.Raports
                                          select rap.Lokal.ToString()).Distinct()).ToList();
            comboBoxUsers.Properties.Items.AddRange(selected_user);
        }

   
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime def;

            if(comboBoxUsers.SelectedItem != null)
            {
              if(dateFromEdit.EditValue != null)
                {
                    if(dateToEdit.EditValue == null)
                    {
                        def = DateTime.Now;
                    }    
                    else
                    {
                        def = dateToEdit.DateTime;
                    }
                
                    var UserQuerry = from rap in db.Raports
                                     where rap.Data >= dateFromEdit.DateTime
                                     && rap.Data <= def
                                     && rap.Lokal == comboBoxUsers.SelectedItem.ToString()
                                     select rap;

                    mainDataGridControl.DataSource = UserQuerry;
                }
                else
                {
                    MessageBox.Show("Wybierz datę początkową!");
                }

            }
            else
            {
                MessageBox.Show("Wybierz Lokal!");  
            }
            
        }


        //GridControl & gridview & dataedits apperance
        private void ApperanceChanges()
        {
            mainDataGridControl.Select();
            
            gridView1.CalcRowHeight += (sender, e) => {  
                {
                    e.RowHeight = 30;
                }
            };

            gridView1.OptionsView.ShowIndicator = false;
            mainDataGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            mainDataGridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;

            

            CalendarApperance(dateFromEdit);
            CalendarApperance(dateToEdit);

        }

        void CalendarApperance(DevExpress.XtraEditors.DateEdit de)
        {
            de.Properties.ShowToday = false;
            de.Properties.FirstDayOfWeek = DayOfWeek.Sunday;
            de.Properties.WeekDayAbbreviationLength = 1;
            de.Properties.ShowClear = false;
        }

    }
}
