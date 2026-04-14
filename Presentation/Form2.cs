using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form2 : Form
    {
        private readonly CustomerService _customerService;
        public Form2(CustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            var customers = await _customerService.GetCustomers();
            if (customers != null && customers.Any())
            {
                dataGridView1.DataSource = customers;
            }
        }
    }
}
