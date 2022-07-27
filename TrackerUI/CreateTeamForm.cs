using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerLibrary;
using ManagerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPersonAll();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            RefreshLists();
        }

        //Test method.
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Jim", LastName = "Cortny" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Ivan", LastName = "Ivanov" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Jones" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Storm" });
        }

        private void RefreshLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                PersonModel person = new PersonModel();
                person.FirstName = firstNameValue.Text;
                person.LastName = lastNameValue.Text;
                person.EmailAddress = emailValue.Text;
                person.PhoneNumber = phoneNumberValue.Text;

                person = GlobalConfig.Connection.CreatePerson(person);

                selectedTeamMembers.Add(person);

                RefreshLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                phoneNumberValue.Text = "";
            }
        }

        private bool IsValidForm()
        {
            if (firstNameValue.Text.Length == 0) return false;
            if (lastNameValue.Text.Length == 0) return false;
            if (emailValue.Text.Length == 0) return false;
            if (phoneNumberValue.Text.Length == 0) return false;

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                RefreshLists();
            }

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                RefreshLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            //TODO: Если мы не закрываем форму после создания команды, нужно reset'нуть форму.
        }
    }
}
