using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice5App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<Customer> customers = new Queue<Customer>();
        private int i = 1;
        //Customer aCustomer = new Customer();
        //ListViewItem aListViewItem = new ListViewItem();
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            //ListViewItem aListViewItem = new ListViewItem();
            Customer aCustomer = new Customer();
            aCustomer.serialNo = i++;
            aCustomer.name = nameEnqueueTextBox.Text;
            aCustomer.complain = complainEnqueueTextBox.Text;

            customers.Enqueue(aCustomer);
           
            //aListViewItem.SubItems.Add(aCustomer.name);
            //aListViewItem.SubItems.Add(aCustomer.complain);

            string[] row = { aCustomer.serialNo.ToString(), aCustomer.name, aCustomer.complain };
            var listViewItem = new ListViewItem(row);
            waitingQueueListView.Items.Add(listViewItem);
            MessageBox.Show(aCustomer.name + " Serial Number is : "+aCustomer.serialNo);

        }

        private int c = 0;
        private void dequeueButton_Click(object sender, EventArgs e)
        {
            
            Customer aCustomer = new Customer();
            if (waitingQueueListView.Items.Count == 0)
            {
                MessageBox.Show("There is no item for Dequeue");
            }
            else
            {
                aCustomer = customers.Dequeue();

                serialNoTextBox.Text = aCustomer.serialNo.ToString();
                nameDequeueTextBox.Text = aCustomer.name;
                complainDequeueTextBox.Text = aCustomer.complain;

                waitingQueueListView.Items.RemoveAt(0);
            }

        }
    }
}
