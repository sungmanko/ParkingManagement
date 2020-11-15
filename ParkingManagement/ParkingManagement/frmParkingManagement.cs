using System;
using System.Windows.Forms;

namespace ParkingManagement
{
    public partial class frmParkingManagement : Form
    {
        /// <summary>
        /// 주차장1의 인/아웃 시간관리
        /// </summary>
        private DateTime parking1_In;
        private DateTime parking1_Out;

        /// <summary>
        /// 컨스트럭터
        /// </summary>
        public frmParkingManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 입고이벤트_1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIn1_Click(object sender, EventArgs e)
        {
            parking1_In = DateTime.Now;
            lblIn1.Text = parking1_In.ToString("HH:mm");
        }

        /// <summary>
        /// 출고이벤트_1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOut1_Click(object sender, EventArgs e)
        {
            parking1_Out = DateTime.Now.AddMinutes(41);
            lblOut1.Text = parking1_Out.ToString("HH:mm");

            // 주차시간계산
            lblSum1.Text = CalcSum(parking1_Out - parking1_In);
        }

        /// <summary>
        /// 주차요금계산
        /// </summary>
        /// <param name="ts">시간차</param>
        /// <returns>요금계산결과</returns>
        private string CalcSum(TimeSpan ts)
        {
            return (Math.Ceiling(Convert.ToDecimal(ts.Minutes / Convert.ToDecimal(txtBaseTime.Text)))
                * Convert.ToInt32(txtBaseMoney.Text)).ToString();
        }

        /// <summary>
        /// 화면로드이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmParkingManagement_Load(object sender, EventArgs e)
        {
            timerMain.Start();
        }

        /// <summary>
        /// Timer Tick 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            lblNowTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
