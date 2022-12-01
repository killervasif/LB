using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogBook.Models;

namespace LogBook.CustomControls;

public partial class UC_Student : UserControl
{
    public Func<byte, bool, bool> DiamondCountChange;

    public UC_Student(Student student, Func<byte, bool, bool> diamondCountChange)
    {
        InitializeComponent();
        DiamondCountChange = diamondCountChange;

        lblNumber.Text = student.Number.ToString();

        if (student.PictureUrl is not null)
            pBoxProfile.Image = Image.FromFile($"../../../Resources/{student.PictureUrl}");

        if (student.ClassWork is not null)
            cBoxClassWork.SelectedIndex = (int)student.ClassWork;

        if (student.LaboratoryWork is not null)
            cBoxLabWork.SelectedIndex = (int)student.LaboratoryWork;

        lblFullName.Text = student.FullName();
        lblLastEnterance.Text = student.LastIn!.Value.ToString("MM/dd/yy");

        switch (student.Status)
        {
            case ParticipationStatus.Present:
                rbPresent.Checked = true;
                break;
            case ParticipationStatus.Absent:
                rbAbsent.Checked = true;
                break;
            case ParticipationStatus.Late:
                rbLate.Checked = true;
                break;
        }
    }


    private void btnComment_Click(object sender, EventArgs e)
    {
        var btn = sender as TextEditButton;
        btn!.Checked = !btn.Checked;

        if (btn.Checked)
        {
            txtComment.BorderStyle = BorderStyle.FixedSingle;
            txtComment.ReadOnly = false;
            txtComment.Visible = true;
            return;
        }

        txtComment.BorderStyle = BorderStyle.None;
        txtComment.ReadOnly = true;
        if (string.IsNullOrWhiteSpace(txtComment.Text))
            txtComment.Visible = false;
    }

    private void radioPresentOrLateButton_CheckedChanged(object sender, EventArgs e)
    {
        panel4.Enabled = true;
        panel5.Enabled = true;
        panel6.Enabled = true;
        panel7.Enabled = true;
    }

    private void rbAbsent_CheckedChanged(object sender, EventArgs e)
    {
        panel4.Enabled = false;
        panel5.Enabled = false;
        panel6.Enabled = false;
        panel7.Enabled = false;

        cBoxClassWork.SelectedIndex = 0;
        cBoxLabWork.SelectedIndex = 0;
    }

    private void diamondBtn_Click(object sender, EventArgs e)
    {
        var btn = sender as DiamondButton;

        if (btn!.Checked)
            return;

        byte score = 0;

        foreach (var button in btn!.Parent.Controls.OfType<DiamondButton>())
        {
            if (button.Position <= btn.Position && !button.Checked)
                score++;
        }

        if (DiamondCountChange(score, false))
            foreach (var button in btn!.Parent.Controls.OfType<DiamondButton>())
                if (button.Position <= btn.Position)
                    button.Checked = true;
    }

    private void btnClearDiamonds_Click(object sender, EventArgs e)
    {
        var btn = sender as Guna.UI2.WinForms.Guna2Button;

        byte score = 0;

        foreach (var button in btn!.Parent.Controls.OfType<DiamondButton>())
        {
            if (button.Checked)
            {
                button.Checked = false;
                score++;
            }
        }

        DiamondCountChange(score, true);

    }
}
