using LogBook.CustomControls;
using LogBook.Models;
using LogBook.Repository;

namespace LogBook;
using static FakeRepository;

public partial class Form1 : Form
{
    public Func<byte, bool, bool> DiamondCountChange { get; set; }

    public Form1()
    {
        InitializeComponent();
        DiamondCountChange += (score, isAdd) =>
        {
            byte diamondCount = byte.Parse(lblDiamondCount.Text);

            if (isAdd)
            {
                diamondCount += score;
                lblDiamondCount.Text = diamondCount.ToString();
                return true;
            }

            if (diamondCount - score < 0)
                return false;

            diamondCount -= score;
            lblDiamondCount.Text = diamondCount.ToString();
            return true;
        };
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        for (int i =students.Count-1; i >= 0; i--)
        {
            UC_Student uC_Student = new(students[i], DiamondCountChange)
            {
                Dock = DockStyle.Top
            };

            panelStudents.Controls.Add(uC_Student);

        }
    }

    private void btnTopicChange_Click(object sender, EventArgs e)
    {
        var btn = sender as TextEditButton;
        btn!.Checked = !btn.Checked;

        if (btn.Checked)
        {
            txtLessonTopic.BorderStyle = BorderStyle.FixedSingle;
            txtLessonTopic.ReadOnly = false;
            txtLessonTopic.Visible = true;
            return;
        }

        txtLessonTopic.BorderStyle = BorderStyle.None;
        txtLessonTopic.ReadOnly = true;

        if (string.IsNullOrWhiteSpace(txtLessonTopic.Text))
        {
            txtLessonTopic.Visible = false;
            return;
        }

        panelStudents.Enabled = true;
        rbMarAllPresent.Enabled = true;
    }


    private void rbTeacher_CheckedChanged(object sender, EventArgs e) => btnTopicChange.Enabled = true;

  

    private void rbMarAllPresent_CheckedChanged(object sender, EventArgs e)
    {
        foreach (var uc_student in panelStudents.Controls.OfType<UC_Student>())
            uc_student.rbPresent.Checked = true;
    }
}