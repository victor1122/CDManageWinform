using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDManagementWinform
{
    public partial class FormManage : Form
    {
        private List<CDInformation> listCD = new List<CDInformation>();
        public FormManage()
        {
            InitializeComponent();
            
            this.cbxSearch.SelectedIndex = 0;
            this.cbxSort.SelectedIndex = 0;
            this.gvCD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        #region GetSet
        public DataGridView CDview
        {
            get { return gvCD; }
        }

        public List<CDInformation> ListCD
        {
            get
            {
                return listCD;
            }

            set
            {
                listCD = value;
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormInput input = new FormInput();
            input.Owner = this;
            input.IsAdd = true;
            input.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listCD.Count == 0)
            {
                MessageBox.Show("You don't have any item to update", "Update Error", MessageBoxButtons.OK);
                return;
            }
            if (gvCD.SelectedRows.Count == 0)
            {
                ErrorClick.SetError(btnSave, "Please select row!!!");
                return;
            }
            ErrorClick.Clear();
            DataGridViewRow row = gvCD.SelectedRows[0];
            FormInput update = new FormInput();
            CDInformation cd = new CDInformation(
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                int.Parse(row.Cells[4].Value.ToString()));
            for (int i = 0; i < lSong.Items.Count; i++)
            {
                cd.Song.Add((string)lSong.Items[i]);
            }
            update.setInfo(cd);
            lSong.Items.Clear();
            update.Owner = this;
            update.IsAdd = false;
            update.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listCD.Count == 0)
            {
                MessageBox.Show("You don't have any item to delete", "Delete Error", MessageBoxButtons.OK);
                return;
            }
            if (gvCD.SelectedRows.Count == 0)
            {
                ErrorClick.SetError(btnSave, "Please select row!!!");
                return;
            }
            ErrorClick.Clear();
            DataGridViewRow row = gvCD.SelectedRows[0];
            foreach (CDInformation cd in listCD)
            {
                if (row.Cells[0].Value.ToString().Equals(cd.ID1))
                {
                    listCD.Remove(cd);
                    break;
                }
            }
            loadListData();
            lSong.Items.Clear();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (gvCD.Rows.Count == 0) return;
            string sortby = cbxSort.Text;
            if (sortby.Equals("Album"))
            {
                listCD.Sort((cd1, cd2) => cd1.Album1.CompareTo(cd2.Album1));
                loadListData();
                return;
            }
            if (sortby.Equals("Singer"))
            {
                listCD.Sort((cd1, cd2) => cd1.Singer1.CompareTo(cd2.Singer1));
                loadListData();
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (gvCD.Rows.Count == 0) return;
            string searchby = cbxSearch.Text;
            if (searchby == "")
            {
                ErrorClick.SetError(btnClearSearch, "Search Value must not be empty!!!");
                return;
            }
            if (searchby.Equals("Album"))
            {
                ErrorClick.Clear();
                string searchValue = txtSearch.Text;
                foreach (DataGridViewRow row in gvCD.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                txtSearch.Clear();
                return;
            }
            if (searchby.Equals("Singer"))
            {
                string searchValue = txtSearch.Text;
                foreach (DataGridViewRow row in gvCD.Rows)
                {
                    if (row.Cells[2].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                txtSearch.Clear();
                return;
            }
            if (searchby.Equals("Song"))
            {
                string searchValue = txtSearch.Text;
                List<string> result = new List<string>();
                foreach (CDInformation cd in listCD)
                {
                    foreach (string song in cd.Song)
                    {
                        if (song.Contains(searchValue))
                        {
                            result.Add(cd.ID1);
                        }
                    }
                }//end of find song
                foreach (DataGridViewRow row in gvCD.Rows)
                {
                    foreach (string song in result)
                    {
                        if (row.Cells[0].Value.ToString().Contains(song))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
                txtSearch.Clear();
                return;

            }
        }

        public void loadListData()
        {
            gvCD.Rows.Clear();
            foreach (CDInformation cd in ListCD)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(CDview);
                row.SetValues(
                    cd.ID1,
                    cd.Album1,
                    cd.Singer1,
                    cd.Genre1,
                    cd.Duration);
                CDview.Rows.Add(row);
            }
        }

        

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            if (gvCD.Rows.Count == 0) return;
            foreach (DataGridViewRow row in gvCD.Rows)
            {
                row.Visible = true;
            }
        }

        #region LoadSaveFile
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listCD.Count == 0)
            {
                MessageBox.Show("You don't have any item to be saved", "Saving Error", MessageBoxButtons.OK);
                return;
            }
            DialogResult save = FileSaveDialog.ShowDialog();
            if (save == DialogResult.OK)
            {
                string filename = FileSaveDialog.FileName;
                //tạo file hoặc nếu file tồn tại thì ghi đè lên tất cả nội dung cũ
                File.WriteAllText(filename, "");
                int count = 0;
                foreach (CDInformation cd in listCD)
                {
                    string songs = "";
                    //get songs
                    for (int i = 0; i < cd.Song.Count; i++)
                    {
                        songs += cd.Song[i];
                        if (i < cd.Song.Count - 1) songs += "#";
                    }
                    //create string write to file
                    string CDInfo = string.Format("{0}~{1}~{2}~{3}~{4}~{5}",
                        cd.ID1,
                        cd.Album1,
                        cd.Singer1,
                        cd.Genre1,
                        cd.Duration,
                        songs);
                    if (count > 0) File.AppendAllText(filename, Environment.NewLine);
                    File.AppendAllText(filename, CDInfo);
                    count++;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = FileOpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = FileOpenDialog.FileName;
                string[] CDs = File.ReadAllLines(file);
                listCD = new List<CDInformation>();
                if (CDs == null || CDs.Count() == 0)
                {
                    MessageBox.Show("File is empty!!!", "Empty File", MessageBoxButtons.OK);
                    return;
                }
                foreach (string CD in CDs)
                {
                    string[] CDInfo = CD.Split('~');
                    CDInformation info = new CDInformation(
                        CDInfo[0],
                        CDInfo[1],
                        CDInfo[2],
                        CDInfo[3],
                        int.Parse(CDInfo[4]));
                    string[] songs = CDInfo[5].Split('#');
                    foreach (string song in songs)
                    {
                        info.Song.Add(song);
                    }
                    listCD.Add(info);
                }
                loadListData();
            }
        } 
        #endregion

        #region RowClick
        private void gvCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gvCD.CurrentRow;
            if (row == null) return;
            string id = row.Cells[0].Value.ToString();
            foreach (CDInformation CD in ListCD)
            {
                if (CD.ID1.Equals(id))
                {
                    lSong.Items.Clear();
                    foreach (string song in CD.Song)
                    {
                        lSong.Items.Add(song);
                    }
                    break;
                }
            }
        }
        private void gvCD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = gvCD.CurrentRow;
            string id = row.Cells[0].Value.ToString();
            foreach (CDInformation CD in ListCD)
            {
                if (CD.ID1.Equals(id))
                {
                    lSong.Items.Clear();
                    foreach (string song in CD.Song)
                    {
                        lSong.Items.Add(song);
                    }
                    break;
                }
            }
        }
        #endregion
        
    }
}
