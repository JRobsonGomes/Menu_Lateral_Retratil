using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteMenus.Properties;

namespace TesteMenus
{
    public partial class Form1 : Form
    {
        //private bool estaRecolhido;
        Button botao;
        Control painel;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (estaRecolhido)
            {
                botao.Image = Resources.Collapse_Arrow_20px;
                painel.Height += 10;
                if (painel.Size == painel.MaximumSize)
                {
                    timer1.Stop();
                    estaRecolhido = false;
                }
            }
            else
            {
                botao.Image = Resources.Expand_Arrow_20px;
                painel.Height -= 10;
                if (painel.Size == painel.MinimumSize)
                {
                    timer1.Stop();
                    estaRecolhido = true;
                }
            }*/
            botao.Image = Resources.Collapse_Arrow_20px;
            painel.Height += 10;
            painel.Size = painel.MaximumSize;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            botao = BuscaBotaoClick(sender, e);
            painel = botao.Parent;
            timer1.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            botao = BuscaBotaoClick(sender, e);
            painel = botao.Parent;
            timer1.Start();
        }

        private Button BuscaBotaoClick(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            return iButton;

            //MessageBox.Show(iButton.Name + " " + iButton.Parent.Name);
        }

        private void panelDropDown_Leave(object sender, EventArgs e)
        {
            button5.Image = Resources.Expand_Arrow_20px;
            panelDropDown.Size = panelDropDown.MinimumSize;
            panelDropDown.Height -= 10;
            timer1.Stop();
        }

        private void panelDropDown2_Leave(object sender, EventArgs e)
        {
            button14.Image = Resources.Expand_Arrow_20px;
            panelDropDown2.Size = panelDropDown2.MinimumSize;
            panelDropDown2.Height -= 10;
            timer1.Stop();
        }
    }
}
