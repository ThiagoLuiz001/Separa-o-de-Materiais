
using Separacao_de_Materiais.Entities;
using Separacao_de_Materiais.Entities.Enums;
using Separacao_de_Materiais.Models;
using System.Diagnostics.Eventing.Reader;
using System.Xml.XPath;
namespace Separacao_de_Materiais.Forms

{
    public partial class FrmErase : Form
    {

         private int Index;


        private void DeleteInformations()
        {
            try
            {
                if (gridErase.Rows.Count <= 1)
                {
                    MessageBox.Show($"OP: {Filter.datas[Index].OP} foi apagado por completo!");
                    Filter.datas.RemoveAt(Index);
                    base.Dispose();
                    return;
                }
                if (rbOP.Checked)
                {
                    MessageBox.Show($"OP: {Filter.datas[Index].OP} foi apagado por completo!");
                    Filter.datas.RemoveAt(Index);
                    base.Dispose();
                    return;
                }
                else if(rbGrupo.Checked)
                {
                    for(int x=0; x< gridErase.Rows.Count; x++)
                    {
                        if (Convert.ToBoolean(gridErase.Rows[x].Cells[0].Value) == true)
                        {
                            string comp = gridErase.Rows[x].Cells[1].Value.ToString();

                            Filter.datas[Index].ClearList(comp);
                        }
                    }
                }
                else if(rbItens.Checked)
                {
                    for (int x = 0; x < gridErase.Rows.Count; x++)
                    {
                        if (Convert.ToBoolean(gridErase.Rows[x].Cells[0].Value) == true)
                        {
                            string value = gridErase.Rows[x].Cells[2].Value.ToString();
                            Filter.datas[Index].DeleteItem(value);
                        }
                    }
                }

                CheckOP();
            }
            catch
            {
                MessageBox.Show("Não há mais valores para apagar");
            }
        }



        private void CheckOP()
        {
            gbOP.Text = $"O que deseja apagar da OP: {Filter.datas[Index].OP}";
            if (rbOP.Checked)
            {
                ConstructionGrid('G');
            }
            else if (rbGrupo.Checked)
            {
                ConstructionGrid('G');
            }
            else if (rbItens.Checked)
            {
                ConstructionGrid('I');
            }

        }

        private void ConstructionGrid(char c)
        {
            gridErase.Rows.Clear();
            if (c == 'G')
            {
                bool validation = false;
                if (rbOP.Checked)
                {
                    validation = true;
                }
                gridErase.Columns["c3"].Visible = false;
                gridErase.Columns["c2"].Width = 200;
                gridErase.Columns["c4"].Width = 200;

                if (Filter.datas[Index].Aviation.Count != 0)
                {
                    gridErase.Rows.Add(validation, Filter.datas[Index].Aviation[0].CreationTree(), "N/A", Filter.datas[Index].Aviation.Count);
                }
                if (Filter.datas[Index].Accessories.Count != 0)
                {
                    gridErase.Rows.Add(validation, Filter.datas[Index].Accessories[0].CreationTree(), "N/A", Filter.datas[Index].Accessories.Count);
                }
                if (Filter.datas[Index].Mirrors.Count != 0)
                {
                    gridErase.Rows.Add(validation, Filter.datas[Index].Mirrors[0].CreationTree(), "N/A", Filter.datas[Index].Mirrors.Count);
                }
                if (Filter.datas[Index].Ironmongery.Count != 0)
                {
                    gridErase.Rows.Add(validation, Filter.datas[Index].Ironmongery[0].CreationTree(), "N/A", Filter.datas[Index].Ironmongery.Count);
                }



            }
            else if (c == 'I')
            {
                gridErase.Columns["c3"].Visible = true;
                gridErase.Columns["c2"].Width = 150;
                gridErase.Columns["c3"].Width = 230;
                gridErase.Columns["c4"].Width = 60;

                if (Filter.datas[Index].Aviation.Count != 0)
                {
                    foreach (Aviation avi in Filter.datas[Index].Aviation)
                    {
                        gridErase.Rows.Add(false, avi.CreationTree(), avi.Description, $"{avi.Units}  {avi.Type}");
                    }
                }
                if (Filter.datas[Index].Accessories.Count != 0)
                {
                    foreach (Accessories acc in Filter.datas[Index].Accessories)
                    {
                        gridErase.Rows.Add(false, acc.CreationTree(), acc.Description, $"{acc.Units} {acc.Type}");
                    }
                }
                if (Filter.datas[Index].Mirrors.Count != 0)
                {
                    foreach (Mirrors mirr in Filter.datas[Index].Mirrors)
                    {
                        gridErase.Rows.Add(false, mirr.CreationTree(), mirr.Description, $"{mirr.Units} {mirr.Type}");
                    }
                }
                if (Filter.datas[Index].Ironmongery.Count != 0)
                {
                    foreach (Ironmongery iron in Filter.datas[Index].Ironmongery)
                    {
                        gridErase.Rows.Add(false, iron.CreationTree(), iron.Description, $"{iron.Units} {iron.Type}");
                    }
                }


            }
        }


        public FrmErase()
        {
            InitializeComponent();
        }
        public FrmErase(int index)
        {
            Index = index;
            InitializeComponent();
        }

        private void rbOP_CheckedChanged(object sender, EventArgs e)
        {
            CheckOP();
        }

        private void FrmErase_Load(object sender, EventArgs e)
        {
            rbOP.Checked = true;
        }

        private void rbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            CheckOP();
        }

        private void rbItens_CheckedChanged(object sender, EventArgs e)
        {
            CheckOP();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo deletar os itens Selecionados?", caption: "Deletar informaçoes:", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteInformations();
            }
            else
            {
                MessageBox.Show("Caraaiiii");
            }
        }
    }
}
