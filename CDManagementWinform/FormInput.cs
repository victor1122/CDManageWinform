using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDManagementWinform
{
    public partial class FormInput : Form
    {
        bool isAdd;

        #region StartUpCode
        public bool IsAdd
        {
            get
            {
                return isAdd;
            }

            set
            {
                isAdd = value;
            }
        }

        public FormInput()
        {
            InitializeComponent();
            this.cbxGenre.SelectedIndex = 0;
            IsAdd = true;
            txtID.Enabled = true;

        }
        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtAlbum.Clear();
            this.txtDuration.Clear();
            this.txtID.Clear();
            this.txtSinger.Clear();
            this.txtSong.Clear();
            this.cbxGenre.SelectedIndex = 0;
            this.listSongs.Items.Clear();
        }

        #region validateInput
        public bool valid()
        {
            bool isError = false;
            if (txtID.Text.Equals(""))
            {
                ErrorID.SetError(txtID, "ID must not be empty!");
                isError = true;
            }

            if (txtAlbum.Text.Equals(""))
            {
                ErrorAlbum.SetError(txtAlbum, "Album must not be empty!");
                isError = true;
            }
            if (txtSinger.Text.Equals(""))
            {
                ErrorSinger.SetError(txtSinger, "Singer must not be empty!");
                isError = true;
            }
            if (listSongs.Items.Count == 0)
            {
                ErrorSong.SetError(listSongs, "You must add at least one song");
                isError = true;
            }


            if (isError)
            {
                return false;
            }
            else
            {
                ErrorID.Clear(); ErrorAlbum.Clear(); ErrorDuration.Clear();
                ErrorSinger.Clear(); ErrorSong.Clear();
                return true;
            }
        }//end of valid()

        private void txtDuration_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && e.KeyCode != Keys.Back)
            {
                ErrorDuration.SetError(txtDuration, "Duration must be positive integer!");
                e.SuppressKeyPress = true;
            }
            else
            {
                ErrorDuration.Clear();
            }
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!valid())
            {
                return;
            }
            if (IsAdd)
            {
                addNew();
            }
            else
            {
                update();
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (txtSong.Text == null || txtSong.Text.Equals(""))
            {
                ErrorSong.SetError(txtSong, "Song's name must not be empty!");
                return;
            }
            else
            {
                ErrorSong.Clear();
                listSongs.Items.Add("- " + txtSong.Text);
                txtSong.Clear();
                txtSong.Focus();
            }
        }

        public void setInfo(CDInformation cd)
        {
            txtID.Text = cd.ID1;
            txtID.Enabled = false;
            txtAlbum.Text = cd.Album1;
            txtSinger.Text = cd.Singer1;
            cbxGenre.SelectedIndex = cbxGenre.FindStringExact(cd.Genre1);
            txtDuration.Text = cd.Duration.ToString();
            listSongs.Items.Clear();
            listSongs.Items.AddRange(cd.Song.ToArray());
        }

        public void addNew()
        {
            CDInformation cd = new CDInformation(
                txtID.Text,
                txtAlbum.Text,
                txtSinger.Text,
                cbxGenre.Text,
                int.Parse(txtDuration.Text)
                );
            for (int i = 0; i < listSongs.Items.Count; i++)
            {
                cd.Song.Add(listSongs.Items[i].ToString());
            }
            FormManage owner = (FormManage)this.Owner;
            foreach (CDInformation CD in owner.ListCD)
            {
                if (owner.ListCD.Count == 0) break;
                if (CD.ID1.Equals(txtID.Text))
                {
                    ErrorID.SetError(txtID, "This ID is already existed!!");
                    return;
                }
            }
            ErrorID.Clear();
            owner.ListCD.Add(cd);
            owner.loadListData();
            btnReset_Click(this, null);
        }

        public void update()
        {
            FormManage ownder = (FormManage)this.Owner;
            DataGridViewRow row = new DataGridViewRow();
            CDInformation cd = new CDInformation(
                txtID.Text,
                txtAlbum.Text,
                txtSinger.Text,
                cbxGenre.Text,
                int.Parse(txtDuration.Text)
                );
            for (int i = 0; i < listSongs.Items.Count; i++)
            {
                cd.Song.Add(listSongs.Items[i].ToString());
            }
            FormManage owner = (FormManage)this.Owner;
            foreach (CDInformation CD in owner.ListCD)
            {
                if (owner.ListCD.Count == 0) break;
                if (CD.ID1.Equals(txtID.Text))
                {
                    CD.Album1 = cd.Album1;
                    CD.Singer1 = cd.Singer1;
                    CD.Genre1 = cd.Genre1;
                    CD.Duration = cd.Duration;
                    CD.Song = cd.Song;
                    break;
                }
            }
            owner.loadListData();
            this.Close();
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (listSongs.Items.Count == 0) return;
            if (listSongs.SelectedItem == null)
            {
                listSongs.Items.RemoveAt(listSongs.Items.Count - 1);
                return;
            }
            else
            {
                int pos = listSongs.SelectedIndex;
                listSongs.Items.RemoveAt(pos);
                return;
            }
        }
    }
}
