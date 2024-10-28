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
using Microsoft.VisualBasic;
using Separacao_de_Materiais.Styles;

namespace Separacao_de_Materiais
{



    public partial class FrmPrincipal : Form
    {
        private int countInfo = 0;
        private int Index = 0;
        private int cap = 0;
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
            List<PrinterItens> itens = new List<PrinterItens>();
            foreach (Data D in Filter.datas)
            {
                if (D.Aviation.Count != 0)
                {
                    itens.Add(new PrinterItens(D.Order, D.OP, D.Client, D.Aviation));
                }
                if (D.Accessories.Count != 0)
                {
                    itens.Add(new PrinterItens(D.Order, D.OP, D.Client, D.Accessories));
                }
                if (D.Mirrors.Count != 0)
                {
                    itens.Add(new PrinterItens(D.Order, D.OP, D.Client, D.Mirrors));
                }
                if (D.Ironmongery.Count != 0)
                {
                    itens.Add(new PrinterItens(D.Order, D.OP, D.Client, D.Ironmongery));
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
                        foreach (Itens avi in d.Aviation)
                        {
                            TreeAdd(avi);
                        }
                    }
                    if (d.Accessories.Count != 0)
                    {
                        foreach (Itens acce in d.Accessories)
                        {
                            TreeAdd(acce);
                        }
                    }
                    if (d.Mirrors.Count != 0)
                    {
                        foreach (Itens mirr in d.Mirrors)
                        {
                            TreeAdd(mirr);
                        }
                    }
                    if (d.Ironmongery.Count != 0)
                    {
                        foreach (Itens iron in d.Ironmongery)
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
            SgridPedido.Rows.Clear();
            foreach (Data i in Filter.datas)
            {

                bool b = false;
                for (int j = 0; j < SgridPedido.Rows.Count; j++)
                {
                    if (Convert.ToInt32(SgridPedido.Rows[j].Cells[2].Value) != i.OP)
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
                    if (SgridPedido.Rows.Count == 0)
                    {
                        SgridPedido.Rows.Add("1º", i.Order, i.OP, i.Client, $"Visu {i.OP}", $"Apag {i.OP}");
                    }
                    else
                    {
                        SgridPedido.Rows.Add($"{SgridPedido.Rows.Count}º", i.Order, i.OP, i.Client, $"Visu {i.OP}", $"Apag {i.OP}");
                    }
                }
                else
                {

                }


            }
        }

        private int CountItens()
        {
            int count = printers.Count % 3 == 0 ? printers.Count() / 3 : printers.Count() / 3 + 1;
            //MessageBox.Show($"Contagem de paginas: {count}");
            return count;
        }
        //_________________________________________CONSTRUTOR______________________________________
        public FrmPrincipal()
        {
            InitializeComponent();
            SgridPedido.Rows.Clear();
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
                    int value = rv.InformationIntegrity(StxtPedido.Text);
                    Filter.AddList(value);
                    GridAdd();

                }
                catch (ExceptionsInformation ex)
                {
                    MessageBox.Show(ex.ToString(), caption: "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SgridPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SgridPedido.Columns[e.ColumnIndex].Name == "clVisu")
                {
                    TreeVisualization(Convert.ToInt32(SgridPedido.Rows[e.RowIndex].Cells[2].Value));
                }
                else if (SgridPedido.Columns[e.ColumnIndex].Name == "clApag")
                {
                    foreach (Data D in Filter.datas)
                    {
                        if (D.OP == Convert.ToInt32(SgridPedido.Rows[e.RowIndex].Cells[2].Value))
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

        private void StxtPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    RequestValidation rv = new RequestValidation();
                    int value = rv.InformationIntegrity(StxtPedido.Text);
                    Filter.AddList(value);
                    GridAdd();

                }
                catch (ExceptionsInformation ex)
                {
                    MessageBox.Show(ex.ToString(), caption: "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                StxtPedido.Text = "";
            }

        }

        private void SbtnImprimir_Click(object sender, EventArgs e)
        {
            printers = ConferPrintItens();
            //teste();
            // for (int i = 0; i < CountItens(); i++)
            //{

            PrintDocument document = new PrintDocument();
            cap += 3;
            printPreviewDialog1.Document = printMaterial;
            printPreviewDialog1.ShowDialog();
            //}
            Index = 0;
        }


        private void teste()
        {
            int n = 1;

            foreach (PrinterItens p in printers)
            {

                MessageBox.Show($"Num: {n}º" +
                    $"\nPedido: {p.Order}" +
                    $"\nOP: {p.OP}" +
                    $"\nCliente: {p.Client}" +
                    $"Grupo: {p.Group}" +
                    $"\nDescrição: {p.Description}");
                n++;
            }

        }

        private void printMaterial_PrintPage(object sender, PrintPageEventArgs e)
        {
          //  if(Index > 0) 
           // {
                e.Graphics.Clear(Color.White); 
           //}


            var g = e.Graphics;        
            var pen = new Pen(Color.Black, 1);
            var fontCab = new Font("Tahoma", 10, FontStyle.Bold);
            var fontCont = new Font("Tahoma", 8, FontStyle.Regular);
            var image = Resources.logo;
            float iniInfoPos = 30, InfoTam = 100, InfoWidth = 250, descWidth = 420, descHeight = 40, cellDesc = 150, x = 60, y = 30;
            int pages = 0;
            float pageHeight = e.MarginBounds.Height;
            float totalHeight = InfoTam + (descHeight / 2) * 4 + iniInfoPos;
            var logo = ResizeImage(image, (int)InfoTam - 5, (int)InfoTam - 10);

            
            for (int i = Index; i < printers.Count(); i++)
            {
                if (y + totalHeight > pageHeight)
                {
                    y = 30;
                    e.HasMorePages = true;
                    Index = i;
                    break;
                }

                int numerador = 4;

                if (printers[i].Description.Split('\n').Length > 3)
                {
                    numerador += printers[i].Description.Split('\n').Length - 3;
                }
                // _________________________ Cabeçalho ___________________________
                // Desenha o logo
                g.DrawRectangle(pen, iniInfoPos, y, InfoTam, InfoTam);
                g.DrawImage(logo, iniInfoPos + 3, y + 5);

                // Registro de Qualidade
                g.DrawRectangle(pen, iniInfoPos + InfoTam, y, InfoWidth, (InfoTam / 2));
                g.DrawString("Registro de Qualidade", fontCab, Brushes.Black, iniInfoPos + InfoTam + 5, y + InfoTam / 4);

                // GRD
                g.DrawRectangle(pen, iniInfoPos + InfoTam + InfoWidth, y, InfoWidth, InfoTam / 2);
                g.DrawString("GRD_ALM-023 - Ed. 02", fontCab, Brushes.Black, iniInfoPos + InfoTam + InfoWidth + 5, y + InfoTam / 4);

                y += InfoTam / 2;

                // Separação de materiais
                g.DrawRectangle(pen, iniInfoPos + InfoTam, y, InfoWidth, InfoTam / 2);
                g.DrawString("Separação de Materiais\npara Especiais", fontCab, Brushes.Black, iniInfoPos + InfoTam + 5, y + 5);

                // Data de Criação do Documento
                g.DrawRectangle(pen, iniInfoPos + InfoTam + InfoWidth, y, InfoWidth, InfoTam / 2);
                g.DrawString("Data: 07/10/2024", fontCab, Brushes.Black, iniInfoPos + InfoTam + InfoWidth + 5, y + InfoTam / 4);

                y += InfoTam / 2;

                // _________________________ Informações _________________________

                // Coluna do Grupo
                g.DrawRectangle(pen, iniInfoPos, y, iniInfoPos, (descHeight * 3) + (((descHeight / 2) * numerador)));
                g.DrawString(printers[i].Group, fontCab, Brushes.Black, iniInfoPos + 5, y + 5);

                // Linha do Pedido
                g.DrawRectangle(pen, iniInfoPos * 2, y, cellDesc, descHeight);
                g.DrawString("PEDIDO:", fontCab, Brushes.Black, iniInfoPos * 2 + 5, y + descHeight / 2);
                g.DrawRectangle(pen, iniInfoPos * 2 + cellDesc, y, descWidth, descHeight);
                g.DrawString(printers[i].Order.ToString(), fontCont, Brushes.Black, iniInfoPos * 2 + cellDesc + 5, y + descHeight / 2);

                y += descHeight;

                // Linha OP
                g.DrawRectangle(pen, iniInfoPos * 2, y, cellDesc, descHeight);
                g.DrawString("OP:", fontCab, Brushes.Black, iniInfoPos * 2 + 5, y + descHeight / 2);
                g.DrawRectangle(pen, iniInfoPos * 2 + cellDesc, y, descWidth, descHeight);
                g.DrawString(printers[i].OP.ToString(), fontCont, Brushes.Black, iniInfoPos * 2 + cellDesc + 5, y + descHeight / 2);

                y += descHeight;

                // Linha Cliente
                g.DrawRectangle(pen, iniInfoPos * 2, y, cellDesc, descHeight);
                g.DrawString("CLIENTE:", fontCab, Brushes.Black, iniInfoPos * 2 + 5, y + descHeight / 2);
                g.DrawRectangle(pen, iniInfoPos * 2 + cellDesc, y, descWidth, descHeight);
                g.DrawString(printers[i].Client, fontCont, Brushes.Black, iniInfoPos * 2 + cellDesc + 5, y + descHeight / 2);

                y += descHeight;

                // Linha Descrição
                g.DrawRectangle(pen, iniInfoPos * 2, y, cellDesc, (descHeight / 2) * numerador);
                g.DrawString("DESCRIÇÃO\nDO ITEM", fontCab, Brushes.Black, iniInfoPos * 2 + 5, y + descHeight / 2);
                g.DrawRectangle(pen, iniInfoPos * 2 + cellDesc, y, descWidth, (descHeight / 2) * numerador);
                g.DrawString(printers[i].Description, fontCont, Brushes.Black, iniInfoPos * 2 + cellDesc + 5, y + 2);

                y += (descHeight / 2) * numerador + iniInfoPos;

                // _________________________ Fim da impressão da página _________________________
                pages++;



            }

            if (Index == printers.Count())
            {
                e.HasMorePages = false;
                Index = 0;
            }




        }

        private void printMaterial_BeginPrint(object sender, PrintEventArgs e)
        {

            PaperSize tamanhoA4 = new PaperSize("A4", 827, 1169);
            printMaterial.DefaultPageSettings.PaperSize = tamanhoA4;

        }

       
    }
}
