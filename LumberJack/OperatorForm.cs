﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumberJack
{
    public partial class OperatorForm : Form
    {
        SqlConnection myCon;
        public OperatorForm(SqlConnection myCon)
        {
            InitializeComponent();
            this.myCon = myCon;
        }
    }
}
