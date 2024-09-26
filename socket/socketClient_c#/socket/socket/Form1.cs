using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socket
{
    public partial class Form1 : Form
    {
        private const int ActionCarIn = 2;
        private const int ActionCarOut = 8;

        public Form1()
        {
            InitializeComponent();
        }

        public delegate void TextBoxDelegate(string text);

        public void Msg(string strText)
        {
            if (TextBox1.InvokeRequired)
            {
                TextBox1.Invoke(new Action<string>(Msg), strText);
            }
            else
            {
                TextBox1.AppendText(Environment.NewLine + " >> " + strText);
                TextBox1.ScrollToCaret();
            }
        }


        /// <summary>
        /// 지정된 매개변수에 따라 관련 TextBox를 Clear 합니다
        /// </summary>
        /// <param name="check">true이면 들어오는 차의 필드를 지우고, false이면 나가는 차의 필드를 지웁니다.</param>
        private void ClearTextBox(int action)
        {
            if (action == ActionCarIn)
            {
                IN_Interface_id_Box.Text = string.Empty;
                IN_CarNumBox.Text = string.Empty;
                Total_Weight_Box.Text = string.Empty;
            }
            else 
            {
                OUT_Interface_id_Box.Text = string.Empty;
                OUT_CarNumBox.Text = string.Empty;
                Empty_Weight_Box.Text = string.Empty;
            }

        }
        /// <summary>
        /// TextBox 유효성 검사
        /// </summary>
        /// <param name="action"></param>
        /// <returns>성공 true, 실패 false</returns>
        private bool CheckTextBox(int action)
        {
            string[] carInBoxes = { IN_Interface_id_Box.Text, IN_CarNumBox.Text, Total_Weight_Box.Text };
            string[] carOutBoxes = { OUT_Interface_id_Box.Text, OUT_CarNumBox.Text, Empty_Weight_Box.Text };

            var boxesToCheck = action == ActionCarIn ? carInBoxes : carOutBoxes;

            return boxesToCheck.All(box => !string.IsNullOrEmpty(box));
        }


        /// <summary>
        /// Dto 생성
        /// </summary>
        /// <param name="action">ActionCarIn: 입차 정보 ActionCarOut : 출차 정보</param>
        /// <returns>dto 객체 반환</returns>
        private Dto createDto(int action)
        {

            if (action == ActionCarIn)
            {
                String id = IN_Interface_id_Box.Text;
                DateTime dateTime = DateTime.Now;
                String date = dateTime.ToString("yyyyMMdd");
                String time = dateTime.ToString("HHmmss");
                String carNum = IN_CarNumBox.Text;
                String total_weight = Total_Weight_Box.Text;

                return new Dto(id, date, time, carNum, total_weight);

            }else if(action == ActionCarOut)
            {
                String id = OUT_Interface_id_Box.Text;
                DateTime dateTime = DateTime.Now;
                String date = dateTime.ToString("yyyyMMdd");
                String empty_weight = Empty_Weight_Box.Text;

                return new Dto(empty_weight, date, id);

            }
            else
            {
                throw new ArgumentException("Invalid action code.");
            }



        }

        /// <summary>
        /// 입차, 출자에 따라 Data를 DB에 저장합니다
        /// </summary>
        /// <param name="action"> In일 경우</param>
        /// <returns></returns>
        private async Task Process_Car(int action)
        {
            ConDb db = new ConDb
            {
                strIP = DB_IP_Box.Text,
                strDB = DB_Name_Box.Text
            };

            if (!db.ValueCheck())
            {
                Msg("데이터베이스 정보가 누락되었습니다.");
                Btn_CarIn.Enabled = true;
                return;
            }

            try
            {
                Dto dto = createDto(action);

                if (action == ActionCarIn && CheckTextBox(action))
                {
                    //await db.InsertData(dto);

                    String s1 = Socket_IP_Box.Text;
                    String s2 = Socket_Port_Box.Text;
                    Remote remote = new Remote(s1,s2);

                    remote.Connect(dto);
                }
                else if(action == ActionCarOut && CheckTextBox(action))
                {   
                    await db.UpdateData(dto);
                }
                else
                {
                    TextBox1.Text = "빈칸을 입력해주세요";
                    return;
                }
                
                ClearTextBox(action);
                Msg(action == ActionCarIn ? "입차 데이터 저장을 완료했습니다." : "출차 데이터 저장을 완료했습니다.");
            }
            catch (ArgumentException ex)
            {
                Msg("DTO 생성 실패: " + ex.Message);
            }
            catch (Exception ex)
            {
                Msg(action == ActionCarIn ? "입차 데이터 저장에 실패하였습니다: " + ex.Message : "출차 데이터 저장에 실패하였습니다: " + ex.Message);
            }

        }

      

        private async void Btn_CarIn_Click(object sender, EventArgs e)
        {
            await Process_Car(ActionCarIn);

        }



        private async void Btn_CarOut_Click(object sender, EventArgs e)
        {
            await Process_Car(ActionCarOut);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
