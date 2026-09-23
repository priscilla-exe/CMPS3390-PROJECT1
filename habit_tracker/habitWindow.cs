using System;
using System.Windows.Forms;

namespace habitTrack
{
    public class habitWindow : Form
    { 
        Label habitName;
        DataGridView habitsTable;
        Label habitLabel;
        TextBox habitTextBox;
        Button addButton;

        public habitWindow()
        {
            this.Text = "Habit Tracker";
            this.Width = 600;
            this.Height = 400;

            habitName = new Label();
            habitName.Text = "Habit Tracker";
            habitName.Location = new System.Drawing.Point(10, 10);
            habitName.AutoSize = true;
            
            this.Controls.Add(habitName);

            habitsTable = new DataGridView();

            habitsTable.Location = new System.Drawing.Point(10, 35);
            habitsTable.Width = 565;
            habitsTable.Height = 290;
            habitsTable.ColumnCount = 2;
            habitsTable.Columns[0].Name = "Habit";
            habitsTable.Columns[1].Name = "Date/Time";
            habitsTable.AllowUserToAddRows = false;
            habitsTable.RowHeadersVisible = false;
            habitsTable.AllowUserToResizeRows = false;
            habitsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            habitsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.Controls.Add(habitsTable);

            habitLabel = new Label();

            habitLabel.Text = "Enter habit:";
            habitLabel.Location = new System.Drawing.Point(10, 335);
            habitLabel.AutoSize = true;
            habitLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.Controls.Add(habitLabel);

            habitTextBox = new TextBox();

            habitTextBox.Location = new System.Drawing.Point(85, 335);
            habitTextBox.Width = 250;
            habitTextBox.KeyDown += habitEnter;
            habitTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.Controls.Add(habitTextBox);

            addButton = new Button();

            addButton.Text = "Add";
            addButton.Location = new System.Drawing.Point(335, 333);
            addButton.Click += clickAdd;
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            this.Controls.Add(addButton);
        }
        private void clickAdd(object sender, EventArgs e)
        {
            string habit = habitTextBox.Text;
            if (habit == "" | habit == " "){MessageBox.Show("error: must enter a habit");}
            string now = DateTime.Now.ToString();
            habitsTable.Rows.Add(habit, now);
            habitTextBox.Text = "";
        }
        private void habitEnter(object sender, KeyEventArgs e){if (e.KeyCode == Keys.Enter){clickAdd(sender, e);}}
    }
}