using System.Windows.Forms;

namespace UsrControl
{
    class UsrControl
    {
        /// <summary>
        /// winform textbox 16进制输入处理
        /// </summary>
        /// <param name="isChecked"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TxtHexCtrl(bool isChecked,object sender, KeyPressEventArgs e)
        {
            TextBox txt1 = (TextBox)sender;
            if (isChecked)
            {
                if (isChecked)
                {
                    txt1.CharacterCasing = CharacterCasing.Upper;
                    if ((e.KeyChar >= 'a' && e.KeyChar <= 'f')
                        || (e.KeyChar >= 'A' && e.KeyChar <= 'F')
                        || char.IsDigit(e.KeyChar)
                        || (char.IsControl(e.KeyChar) && e.KeyChar != (char)13)
                        || e.KeyChar == ' '
                        )
                    {
                        int length = txt1.TextLength;
                        switch (length % 3)
                        {
                            case 0:
                            case 1:
                                if (e.KeyChar == ' ') e.Handled = true;
                                break;
                            case 2:
                                if (e.KeyChar != ' ')
                                {
                                    e.KeyChar = ' ';
                                    e.Handled = true;
                                    //MessageBox.Show("请输入空格");
                                    
                                }
                                break;
                            default:
                                break;
                        }
                        e.Handled = false;

                    }
                    else
                    {
                        MessageBox.Show("输入错误!!!");
                        e.Handled = true;
                    }
                }
                else
                {
                    txt1.CharacterCasing = CharacterCasing.Normal;
                }
            }
            //else
            //{
            //    txtSend.CharacterCasing = CharacterCasing.Normal;
            //}
        }
    }
}
