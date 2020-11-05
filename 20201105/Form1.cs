using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 生命週期
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        #region 事件觸發
        /// <summary>
        /// 查詢按鈕被按下處理方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            //檢查輸入情況
            
            if(string.IsNullOrEmpty(tbPlate.Text))
            {
                MessageBox.Show("請先輸入車牌", "錯誤");
            }

            //模擬送車牌訊號

            //根據得到的結果顯示資料
        }
        #endregion

        #region 邏輯判斷
        #endregion

    }
}
