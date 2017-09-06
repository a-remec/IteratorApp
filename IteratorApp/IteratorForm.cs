using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorApp
{
    public partial class IteratorForm : Form
    {

        ConcreteAggregate ag;

        public IteratorForm()
        {
            InitializeComponent();
            ConcreteAggregate ag = new ConcreteAggregate();
            Iterator iter = ag.CreateIterator(IteratorType.TotalIterator);
            PopulateListBox(iter, lbTotalIterator);
        }

        private void LoadAg(ConcreteAggregate ag)
        {
            ag.Add("Mark");
            ag.Add("Tim");
            ag.Add("Allison");
            ag.Add("David");
            ag.Add("Jessica");
            ag.Add("Christian");
            ag.Add("Austin");
            ag.Add("Jennifer");
            ag.Add("Joe");
            ag.Add("Drew");
            ag.Add("Eric");
            ag.Add("Maddie");
            ag.Add("Tyler");
            ag.Add("Jon");
            ag.Add("Derek");
        }

        public void PopulateListBox(Iterator iter, ListBox lb)
        {
            lb.Items.Clear();
            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                lb.Items.Add(iter.CurrentItem());
            }
        }

        private void btnLetterIterator_Click(object sender, EventArgs e)
        {
            Iterator iter = ag.CreateIterator(IteratorType.LetterIterator);
            PopulateListBox(iter, lbLetterIterator);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IteratorForm_Load(object sender, EventArgs e)
        {

        }

    }
}
