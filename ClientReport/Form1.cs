﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "RoomPlanningDataSet.T_Benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.T_BenutzerTableAdapter.Fill(this.RoomPlanningDataSet.T_Benutzer);
            this.reportViewer1.RefreshReport();
        }
    }
}