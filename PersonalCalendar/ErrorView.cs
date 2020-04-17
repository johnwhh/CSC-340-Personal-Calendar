using System;
using System.Windows.Forms;

namespace PersonalCalendar
{
    public partial class ErrorView : UserControl
    {
        private MainForm parentForm;
        public ErrorView(MainForm parent)
        {
            parentForm = parent;
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            parentForm.ToggleButtons(true);
            parentForm.Controls.Remove(this);
        }
    }
}
