using Separacao_de_Materiais.Models;
using Separacao_de_Materiais.Entities.Enums;
using Separacao_de_Materiais.Entities.Exceptions;
using Separacao_de_Materiais.Models.Validations;
using Separacao_de_Materiais.Entities;
using System.Globalization;
using Separacao_de_Materiais.Entities.Commons;
using Separacao_de_Materiais.Forms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Separacao_de_Materiais.Properties;
using System.Runtime.Intrinsics.X86;

namespace Separacao_de_Materiais
{



    public partial class FrmPrincipal : Form
    {
        private int countInfo = 0;
        private int Index = 0;
        private float y = 30;
        private List<PrinterItens> printers = new List<PrinterItens>();

        //______________________________________Ajustar Imagem________________________________________
        /// <summary>
        /// Ajusta o tamanho da imagem para comportar no cabeçalho
        /// </summary>
        /// <param name="image"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }

            return resizedBitmap;
        }











        //______________________________________MÉTODOS__________________________________________

        private List<PrinterItens> ConferPrintItens()
        {
            int index;
            bool cp = false;
            List<PrinterItens> itens = new List<PrinterItens>();
            foreach (Data D in Filter.datas)
            {
                if (D.Aviation.Count != 0)
                {
                    cp = true;
                    foreach (Aviation avi in D.Aviation)
                    {
                        if (cp == true)
                        {
                            itens.Add(new PrinterItens(D.Order, D.OP, D.Client, (Itens)avi));
                            cp = false;
                        }
                        else
                        {
                            itens[itens.Count - 1].AddList((Itens)avi);
                        }
                    }
                }
                if (D.Accessories.Count != 0)
                {
                    cp = true;
                    foreach (Accessories ace in D.Accessories)
                    {
                        if (cp == true)
                        {
                            itens.Add(new PrinterItens(D.Order, D.OP, D.Client, (Itens)ace));
                            cp = false;
                        }
                        else
                        {
                            itens[itens.Count - 1].AddList((Itens)ace);
                        }
                    }
                }
                if (D.Mirrors.Count != 0)
                {
                    cp = true;
                    foreach (Mirrors mir in D.Mirrors)
                    {
                        if (cp == true)
                        {
                            itens.Add(new PrinterItens(D.Order, D.OP, D.Client, (Itens)mir));
                            cp = false;
                        }
                        else
                        {
                            itens[itens.Count - 1].AddList((Itens)mir);
                        }
                    }
                }
                if (D.Ironmongery.Count != 0)
                {
                    cp = true;
                    foreach (Ironmongery iron in D.Ironmongery)
                    {
                        if (cp == true)
                        {
                            itens.Add(new PrinterItens(D.Order, D.OP, D.Client, (Itens)iron));
                            cp = false;
                        }
                        else
                        {
                            itens[itens.Count - 1].AddList((Itens)iron);
                        }
                    }
                }
            }




            return itens;
        }



        /// <summary>
        /// Adiciona o pedido ao TRee
        /// </summary>
        /// <param name="iten"></param>
        private void TreeAdd(Itens iten)
        {
            bool n1 = TreeExist(treePedido.Nodes, iten.CreationTree());
            if (!n1)
            {
                treePedido.Nodes.Add("cl" + iten.CreationTree(), iten.CreationTree());
            }
            bool n2 = TreeExist(treePedido.Nodes["cl" + iten.CreationTree()].Nodes, iten.ToString());
            if (!n2)
            {
                treePedido.Nodes["cl" + iten.CreationTree()].Nodes.Add(iten.ToString());
            }
        }

        /// <summary>
        /// Confere se já existe os nó no Tree e cria se não houver
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        private bool TreeExist(TreeNodeCollection nodes, string nodeName)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == nodeName)
                {
                    return true;  // O nó foi encontrado
                }

                // Verifica os nós filhos recursivamente
                if (TreeExist(node.Nodes, nodeName))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Passa os dados para o Tree para o usuário visualizar
        /// </summary>
        /// <param name="index"></param>
        private void TreeVisualization(int index)
        {
            treePedido.Nodes.Clear();
            foreach (Data d in Filter.datas)
            {
                if (index == d.OP)
                {
                    lblOP.Text = "OP: " + d.OP.ToString();
                    lblPed.Text = "Pedido: " + d.Order.ToString();
                    lblCli.Text = "Cliente: " + d.Client;
                    if (d.Aviation.Count != 0)
                    {
                        foreach (Aviation avi in d.Aviation)
                        {
                            TreeAdd(avi);
                        }
                    }
                    if (d.Accessories.Count != 0)
                    {
                        foreach (Accessories acce in d.Accessories)
                        {
                            TreeAdd(acce);
                        }
                    }
                    if (d.Mirrors.Count != 0)
                    {
                        foreach (Mirrors mirr in d.Mirrors)
                        {
                            TreeAdd(mirr);
                        }
                    }
                    if (d.Ironmongery.Count != 0)
                    {
                        foreach (Ironmongery iron in d.Ironmongery)
                        {
                            TreeAdd(iron);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Adiciona os pedidos no DataGrid
        /// </summary>
        private void GridAdd()
        {
            gridMateriais.Rows.Clear();
            foreach (Data i in Filter.datas)
            {

                bool b = false;
                for (int j = 0; j < gridMateriais.Rows.Count; j++)
                {
                    if (Convert.ToInt32(gridMateriais.Rows[j].Cells[2].Value) != i.OP)
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    if (gridMateriais.Rows.Count == 0)
                    {
                        gridMateriais.Rows.Add("1º", i.Order, i.OP, i.Client, $"Visu {i.OP}", $"Apag {i.OP}");
                    }
                    else
                    {
                        gridMateriais.Rows.Add($"{gridMateriais.Rows.Count}º", i.Order, i.OP, i.Client, $"Visu {i.OP}", $"Apag {i.OP}");
                    }
                }
                else
                {

                }


            }
        }

        //_________________________________________CONSTRUTOR______________________________________
        public FrmPrincipal()
        {
            InitializeComponent();
            gridMateriais.Rows.Clear();
            GridAdd();
            printMaterial.PrintPage += new PrintPageEventHandler(printMaterial_PrintPage);
        }

        //__________________________________________EVENTOS_________________________________________
        private void txtPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    RequestValidation rv = new RequestValidation();
                    int value = rv.InformationIntegrity(txtPedido.Text);
                    Filter.AddList(value);
                    GridAdd();

                }
                catch (ExceptionsInformation ex)
                {
                    MessageBox.Show(ex.ToString(), caption: "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridMateriais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (gridMateriais.Columns[e.ColumnIndex].Name == "clVisualizar")
                {
                    TreeVisualization(Convert.ToInt32(gridMateriais.Rows[e.RowIndex].Cells[2].Value));
                }
                else if (gridMateriais.Columns[e.ColumnIndex].Name == "clApagar")
                {
                    foreach (Data D in Filter.datas)
                    {
                        if (D.OP == Convert.ToInt32(gridMateriais.Rows[e.RowIndex].Cells[2].Value))
                        {
                            MessageBox.Show($"Aviamento: {D.Aviation.Count}\n" +
                                $"Acessorios: {D.Accessories.Count}\n" +
                                $"Espelhos: {D.Mirrors.Count}\n" +
                                $"Ferragens: {D.Ironmongery.Count}");
                        }
                    }


                    FrmErase erase = new FrmErase((int)e.RowIndex);
                    erase.Show();
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printMaterial;
            printPreviewDialog1.ShowDialog();
        }

        private void printMaterial_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (Index == 0)
            {
                printers = ConferPrintItens();
            }

            
            Pen pen = new Pen(Color.Black, 1);
            Font fontCab = new Font("Tahoma", 10, FontStyle.Bold);
            Font fontCont = new Font("Tahoma", 8, FontStyle.Regular);
            Image image = Resources.logo;
            float iniInfoPos = 30, InfoTam = 100, InfoWidth = 250, descWidth = 420, descHeight = 40, cellDesc = 150, x = 60, y = 30;
            int pages = 0;
            float pageHeight = e.MarginBounds.Height;
            float totalHeight = InfoTam + (descHeight / 2) * 4 + iniInfoPos;

            Image logo = ResizeImage(image, (int)InfoTam - 5, (int)InfoTam - 10);

            for (int i = Index; i < printers.Count; i++)
            {

                if (y + totalHeight > pageHeight || y >= pageHeight)
                {
                    Index = i + 1;
                    e.HasMorePages = true;
                    return;
                }


                int numerador = 4;
                string information = "";
                foreach (Itens itens in printers[i]._Itens)
                {
                    if (countInfo == 0)
                    {
                        printers[i].AddDescription(itens.CreationTree());
                    }
                    information += $"\n{itens.ToString()}";
                    countInfo++;
                }

                if (countInfo > 3)
                {
                    numerador += countInfo - 3;
                }
                MessageBox.Show($"Pedido: {printers[i].Order}" +
                    $"\nOP: {printers[i].OP}" +
                    $"\nCliente: {printers[i].Client}" +
                    $"\nGrupo: {printers[i].GroupDescription()}" +
                    $"\nDescrição {information}");
                // _________________________ Cabeçalho ___________________________
                // Desenha o logo
                e.Graphics.DrawRectangle(pen, iniInfoPos, y, InfoTam, InfoTam);
                e.Graphics.DrawImage(logo, iniInfoPos + 3, y + 5);

                // Registro de Qualidade
                e.Graphics.DrawRectangle(pen, iniInfoPos + InfoTam, y, InfoWidth, (InfoTam / 2));
                e.Graphics.DrawString("Registro de Qualidade", fontCab, Brushes.Black, iniInfoPos + InfoTam + 5, y + InfoTam / 4);

                // GRD
                e.Graphics.DrawRectangle(pen, iniInfoPos + InfoTam + InfoWidth, y, InfoWidth, InfoTam / 2);
                e.Graphics.DrawString("GRD_ALM-023 - Ed. 02", fontCab, Brushes.Black, iniInfoPos + InfoTam + InfoWidth + 5, y + InfoTam / 4);

                y += InfoTam / 2;

                // Separação de materiais
                e.Graphics.DrawRectangle(pen, iniInfoPos + InfoTam, y, InfoWidth, InfoTam / 2);
                e.Graphics.DrawString("Separação de Materiais\npara Especiais", fontCab, Brushes.Black, iniInfoPos + InfoTam + 5, y + 5);

                // Data de Criação do Documento
                e.Graphics.DrawRectangle(pen, iniInfoPos + InfoTam + InfoWidth, y, InfoWidth, InfoTam / 2);
                e.Graphics.DrawString("Data: 07/10/2024", fontCab, Brushes.Black, iniInfoPos + InfoTam + InfoWidth + 5, y + InfoTam / 4);

                y += InfoTam / 2;

                // _________________________ Informações _________________________

                // Coluna do Grupo
                e.Graphics.DrawRectangle(pen, iniInfoPos, y, iniInfoPos, (descHeight * 3) + (((descHeight / 2) * numerador)));
                e.Graphics.DrawString(printers[i].GroupDescription(), fontCab, Brushes.Black, iniInfoPos + 5, y + 5);

                // Linha do Pedido
                e.Graphics.DrawRectangle(pen, iniInfoPos * 2, y, cellDesc, descHeight);
                e.Graphics.DrawString("PEDIDO:", fontCab, Brushes.Black, iniInfoPos * 2 + 5, y + descHeight / 2);
                e.Graphics.DrawRectangle(pen, iniInfoPos * 2 + cellDesc, y, descWidth, descHeight);
                e.Graphics.DrawString(printers[i].Order.ToString(), fontCont, Brushes.Black, iniInfoPos * 2 + cellDesc + 5, y + descHeight / 2);

                y += descHeight;

                // Linha OP
                e.Graphics.DrawRectangle(pen, iniInfoPos * 2, y, cellDesc, descHeight);
                e.Graphics.DrawString("OP:", fontCab, Brushes.Black, iniInfoPos * 2 + 5, y + descHeight / 2);
                e.Graphics.DrawRectangle(pen, iniInfoPos * 2 + cellDesc, y, descWidth, descHeight);
                e.Graphics.DrawString(printers[i].OP.ToString(), fontCont, Brushes.Black, iniInfoPos * 2 + cellDesc + 5, y + descHeight / 2);

                y += descHeight;

                // Linha Cliente
                e.Graphics.DrawRectangle(pen, iniInfoPos * 2, y, cellDesc, descHeight);
                e.Graphics.DrawString("CLIENTE:", fontCab, Brushes.Black, iniInfoPos * 2 + 5, y + descHeight / 2);
                e.Graphics.DrawRectangle(pen, iniInfoPos * 2 + cellDesc, y, descWidth, descHeight);
                e.Graphics.DrawString(printers[i].Client, fontCont, Brushes.Black, iniInfoPos * 2 + cellDesc + 5, y + descHeight / 2);

                y += descHeight;

                // Linha Descrição
                e.Graphics.DrawRectangle(pen, iniInfoPos * 2, y, cellDesc, (descHeight / 2) * numerador);
                e.Graphics.DrawString("DESCRIÇÃO\nDO ITEM", fontCab, Brushes.Black, iniInfoPos * 2 + 5, y + descHeight / 2);
                e.Graphics.DrawRectangle(pen, iniInfoPos * 2 + cellDesc, y, descWidth, (descHeight / 2) * numerador);
                e.Graphics.DrawString(information, fontCont, Brushes.Black, iniInfoPos * 2 + cellDesc + 5, y + 2);

                y += (descHeight / 2) * numerador + iniInfoPos;

                // _________________________ Fim da impressão da página _________________________
                countInfo = 0;
                pages++;
                e.HasMorePages = false;
            }




           
            Index = 0;

        }


    }
}
