using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class DateTimePickerForm : Form
    {
        public DateTime NewDueTime { get; internal set; }

        // Event to notify the parent form about the updated due time
        public event Action<DateTime> DueTimeUpdated;
        public DateTimePickerForm(DateTime currentDueTime)
        {
            InitializeComponent();
            DueTimePicker.Value = currentDueTime;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            NewDueTime = DueTimePicker.Value;

            // Trigger the event to notify AssignmentRetrive
            DueTimeUpdated?.Invoke(NewDueTime);

            // Close the form after the update
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
