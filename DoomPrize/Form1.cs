using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace DoomPrize
{
    public partial class FormSorteador : Form
    {
        public FormSorteador()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            var diretorio = Directory.GetCurrentDirectory() + @"\Fonts\";
            //Pegar todas as fontes de um diretório
            foreach (string item in Directory.GetFiles(diretorio, "*.ttf"))
            //foreach (string item in Directory.GetFiles(@"C:\Users\Marques\Desktop\Projetos\DoomPrize\DoomPrize\Fonts\", "*.ttf"))
                pfc.AddFontFile(item);


            Titulo.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            NomeItem.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            label1.Font = new Font(pfc.Families[0], 16);
            NomeItem.AutoSize = true;
            Titulo.Location = new Point(272, 175);
            Titulo.AutoSize = true;
            pictureBox1.AutoSize = false;
            pictureBox2.Size = new Size(243, 271);
            pictureBox2.Location = new Point(335, 300);
            pictureBox1.Image = Properties.Resources.iconeDOOM;
            pictureBox2.InitialImage = Properties.Resources.RareBox;
            pictureBox2.Image = Properties.Resources.RareBox;
            pictureBox2.Visible = true;
            radioButton1.Checked = true;
            pictureBox4.Visible = false;
            pictureBox4.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.RareBox;
            }
            else if (radioButton2.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.EpicBox;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.LEGENDARYBOX;
            }
        }
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.RareBox;
            }
            else if (radioButton2.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.EpicBox;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.LEGENDARYBOX;
            }
        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.RareBox;
            }
            else if (radioButton2.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.EpicBox;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.LEGENDARYBOX;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var tipoLoot = 0;
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
            button1.Enabled = false;
            NomeItem.Visible = false;
            label1.Visible = false;
            pictureBox3.Visible = false;
            Task_Void_Async();
            await Task.Delay(1300);
            label1.Visible = false;
            label1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(78)))));
            Random random = new Random(Guid.NewGuid().GetHashCode());
            var premio = new Premios();
            var c = new Sorteador();
            var sorteado = 0;
            pictureBox3.Visible = true;
            NomeItem.Visible = true;
            if (radioButton1.Checked == true)
            {
                tipoLoot = 1;
                sorteado = c.Sorteio(tipoLoot, random);
            }
            else if (radioButton2.Checked == true)
            {
                tipoLoot = 2;
                sorteado = c.Sorteio(tipoLoot, random);
            }
            else
            {
                tipoLoot = 3;
                sorteado = c.Sorteio(tipoLoot, random);
            }
            if (sorteado == 9) // VipBox Ant
            {
                premio.Nome = "Vipbox Ant";
                premio.Imagem = Properties.Resources.VipboxAnt;
            }
            else if (sorteado == 10) // VipBox Cockroach
            {
                premio.Nome = "Vipbox Cockroach";
                premio.Imagem = Properties.Resources.VipboxCock;
            }
            else if (sorteado == 11) // VipBox Dragonfly
            {
                premio.Nome = "Vipbox Dragonfly";
                premio.Imagem = Properties.Resources.VipboxDragon;
            }
            else if (sorteado == 12) // VipBox Doom
            {
                premio.Nome = "Vipbox Doom";
                premio.Imagem = Properties.Resources.VipboxDoomBlack;
                label1.ForeColor = Color.Black;
                premio.Lvl = "Black";
                //premio = c.SorteioSetDoom(random);
                //switch (premio.Lvl)
                //{
                //    case "1":
                //        premio.Lvl = "Red";
                //        break;
                //    case "2":
                //        label1.ForeColor = Color.Gold;
                //        premio.Lvl = "Gold";
                //        break;
                //    case "3":
                //        label1.ForeColor = Color.Black;
                //        premio.Lvl = "Black";
                //        break;
                //    case "4":
                //        label1.ForeColor = Color.White;
                //        premio.Lvl = "White";
                //        break;
                //}
            }

            else if (sorteado == 8) // Código 8 para mochilas
            {
                premio = c.SorteioMochila(random);
                if (premio.Nome == "Mochila DOOM")
                {
                    premio.Nome = "Mochila Doom";
                    label1.ForeColor = Color.Black;
                    premio.Lvl = "Black";
                    premio.Imagem = Properties.Resources.MochilaDoomBlack;
                    //premio = c.SorteioMochilaDoom(random);
                    //switch (premio.Lvl)
                    //{
                    //    case "1":
                    //        premio.Lvl = "Red";
                    //        break;
                    //    case "2":
                    //        label1.ForeColor = Color.Gold;
                    //        premio.Lvl = "Gold";
                    //        break;
                    //    case "3":
                    //        label1.ForeColor = Color.Black;
                    //        premio.Lvl = "Black";
                    //        break;
                    //    case "4":
                    //        label1.ForeColor = Color.White;
                    //        premio.Lvl = "White";
                    //        break;
                    //}
                }

            }
            else if (sorteado == 2 || sorteado == 3 || sorteado == 4 || // Códigos para armas melee
                sorteado == 5 || sorteado == 6 || sorteado == 7)
            {
                premio = c.SorteioArmaMelee(tipoLoot, sorteado, random);
            }
            else if (sorteado == 1) // Código 1 para armas de fogo
            {
                premio = c.SorteioArmaFogo(random);
            }

            if (!string.IsNullOrEmpty(premio.Nome))
            {
                if (!string.IsNullOrEmpty(premio.Lvl))
                {
                    label1.Visible = true;
                    if (premio.Lvl.Length > 1 && premio.Lvl != "LENDARIO") // Para não exibir o texto "Level" quando mostrar o tipo de set doom
                    {
                        label1.Text = premio.Lvl;
                    }
                    else
                    {
                        label1.Text = "Level " + premio.Lvl;
                    }
                }
                pictureBox3.Image = premio.Imagem;
                NomeItem.Text = premio.Nome;

                //EXTRAROLL
                if (premio.Lvl == "1" || premio.Lvl == "2" || sorteado == 1 ||
                    premio.Nome == "Faca de caca" || premio.Nome == "Pe de Cabra")
                {
                    if (tipoLoot == 1)
                    {
                        var numero = random.Next(1, 6);
                        if (numero == 3)
                        {
                            DialogResult resultado;
                            MessageBoxButtons extraRoll = MessageBoxButtons.YesNo;
                            if (sorteado == 1)
                            {
                                resultado = MessageBox.Show(string.Format("Você ganhou uma {0}! Mas também tirou um Extra Roll para tentar algo diferente! Deseja sortear novamente?", premio.Nome), "ExtraRoll", extraRoll);
                            }
                            else
                            {
                                resultado = MessageBox.Show(string.Format("Você ganhou o item {0} de Level {1}! Mas também tirou um Extra Roll para tentar algo diferente! Deseja sortear novamente?", premio.Nome.Replace("Pe de", "Pé de").Replace("caca", "caça"), premio.Lvl), "ExtraRoll", extraRoll);
                            }
                            if (resultado == DialogResult.Yes)
                            {
                                button1_Click(null, null);
                            }
                        }
                    }
                    if (tipoLoot == 2)
                    {
                        var numero = random.Next(1, 8);
                        if (numero == 3)
                        {
                            DialogResult resultado;
                            MessageBoxButtons extraRoll = MessageBoxButtons.YesNo;
                            if (sorteado == 1)
                            {
                                resultado = MessageBox.Show(string.Format("Você ganhou uma {0}! Mas também tirou um Extra Roll para tentar algo diferente! Deseja sortear novamente?", premio.Nome), "ExtraRoll", extraRoll);
                            }
                            else
                            {
                                resultado = MessageBox.Show(string.Format("Você ganhou o item {0} de Level {1}! Mas também tirou um Extra Roll para tentar algo diferente! Deseja sortear novamente?", premio.Nome.Replace("Pe de", "Pé de").Replace("caca", "caça"), premio.Lvl), "ExtraRoll", extraRoll);
                            }
                            if (resultado == DialogResult.Yes)
                            {
                                button1_Click(null, null);
                            }
                        }
                    }
                    else
                    {
                        var numero = random.Next(1, 11);
                        if (numero == 3)
                        {
                            DialogResult resultado;
                            MessageBoxButtons extraRoll = MessageBoxButtons.YesNo;
                            if (sorteado == 1)
                            {
                                resultado = MessageBox.Show(string.Format("Você ganhou uma {0}! Mas também tirou um Extra Roll para tentar algo diferente! Deseja sortear novamente?", premio.Nome), "ExtraRoll", extraRoll);
                            }
                            else
                            {
                                resultado = MessageBox.Show(string.Format("Você ganhou o item {0} de Level {1}! Mas também tirou um Extra Roll para tentar algo diferente! Deseja sortear novamente?", premio.Nome.Replace("Pe de", "Pé de").Replace("caca", "caça"), premio.Lvl), "ExtraRoll", extraRoll);
                            }
                            if (resultado == DialogResult.Yes)
                            {
                                button1_Click(null, null);
                            }
                        }
                    }
                                    
                }
            }

            button1.Enabled = true;
        }

        async Task Task_Void_Async()
        {
            pictureBox4.Visible = true;
            pictureBox4.Enabled = true;
            await Task.Delay(1300);
            pictureBox4.Visible = false;
            pictureBox4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSorteador NewForm = new FormSorteador();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
