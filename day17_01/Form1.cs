using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day17_01
{
    public partial class kang01 : Form
    {
        public kang01()
        {
            InitializeComponent();
        }

        //keydown event는 키눌림을 위한 이벤트로 keys열거형으로 키 구분
        // 문자키는 모두 대문자로 입력된다. 즉, 대소문자 구분을 못한다.
        private void kang01_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.A && e.Shift && e.Control)
            //{
            //    MessageBox.Show("A + ctrl + shift");
            //}

            /*
            switch (e.KeyCode)
            {
                case Keys.A: MessageBox.Show("A checked"); break;
                case Keys.B: MessageBox.Show("B checked"); break;
                case Keys.C: MessageBox.Show("C checked"); break;
            }
            */

            if(e.Modifiers == (Keys.Alt | Keys.Shift))
            {
                MessageBox.Show("alt + shift");
            }



            //밑의 두방식은 결과가 같다.

            /*  Keycode를 이용한 방식
            if(e.KeyCode == Keys.A && e.Modifiers == (Keys.Control | Keys.Shift))
            {
                MessageBox.Show("A + shift + ctrl");
            }
            */

            //KeyData를 이용한 방식
            if(e.KeyData == (Keys.A | Keys.Control | Keys.Shift))
            {
                MessageBox.Show("A + shift + ctrl");
            }
        }

        
        private void kang01_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("keyPress");
        }
    }
}
